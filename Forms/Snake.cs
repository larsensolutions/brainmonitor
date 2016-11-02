using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using System.Drawing.Drawing2D;
using System.Media;

namespace BrainMonitor
{
    public partial class Snake : Form, MindsetObserver
    {
        private SnakeModel snakeModel;
        private bool running;
        private Thread th;
        private int conslevel, medlevel;
        System.Timers.Timer timer = new System.Timers.Timer();
        System.Timers.Timer timer2 = new System.Timers.Timer();
        int[,] apples;
        int x, y;
        private bool mindset = true;
        private bool updateEntireSnakeBody = true;
        private QuickSampleModel[] quickSampleCollection = null;
        private bool collectQuicksamples = false;
        private int counter = 0;
        private float cur, prev, bc, bp = 0;
        private int collectionSize = 10;
        private double resultThreshold = 0.5; // Needs to be between 0 and 1, because of the NeuralNet setup


        public Snake()
        {
            InitializeComponent();
            snakeModel = new SnakeModel(this);
            System.Drawing.Graphics graphicsObj;
            graphicsObj = gameView_panel.CreateGraphics();
            GUI.getInstance().addMindObserver(this);
            apples = new int[gameView_panel.Width, gameView_panel.Height];
            makeRandomApple();
            
        }
        private bool left = false;

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();
        }

        private void playAppleSound() 
        {
            String filename = "C:\\WINDOWS\\Media\\ding.wav";
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(new System.IO.FileInfo(filename).FullName);
            sp.Play();
        }


        public void makeRandomApple()
        {
            
            Random random = new Random();
            x = random.Next(0, gameView_panel.Width-3);
            y = random.Next(0, gameView_panel.Height-3);
            apples[x,y] = 1;
        }

        public void removeRandomApple()
        {
            apples[x,y] = 0;
        }

        public void mindLogic(object source, ElapsedEventArgs e)
        {
            updateGo(Color.Green);
            //left = GUI.getInstance().isitBlink();
        
        }

        public void mindLogic()
        {
            updateGo(Color.Green);
            counter = 0;
            quickSampleCollection = new QuickSampleModel[collectionSize];
            //collectQuicksamples = true;

            while (counter < collectionSize)
            {

            }

            collectQuicksamples = false;
            double[] samplePowers = new double[5]; // only using delta, theta, alpha, beta, gamma.
            
            foreach (QuickSampleModel qsm in quickSampleCollection)
            {
                double[] temp = qsm.getPowerBands;
                samplePowers[0] += temp[0];
                samplePowers[1] += temp[1];
                samplePowers[2] += temp[2];
                samplePowers[3] += temp[3];
                samplePowers[4] += temp[4];
                //samplePowers[5] += temp[5];
            }
            for (int i = 0; i < samplePowers.Length; i++)
            {
                samplePowers[i] /= collectionSize;
            }
            float testResults;
            GUI.getInstance().testSamplesForNN(out testResults, samplePowers);
            teller.Text = "Restults" + testResults.ToString();


            if (testResults < resultThreshold)
            {
                snakeModel.setAction(SnakeModel.Action.LEFT);
                snakeModel.moveBody();
                lb.Text = "FORWARD";
            }
            else
            {
                snakeModel.setAction(SnakeModel.Action.RIGHT);
                snakeModel.moveBody();
                lb.Text = "RIGHT";
            }
        }

        public void paintUpdate()
        {
            updateGo(Color.Red);
            playSimpleSound();
            Thread.Sleep(1000);
        }


        public void paintLogic(object source, ElapsedEventArgs e) 
        {
            updateGo(Color.Red);
            if (left)
            {
                snakeModel.setAction(SnakeModel.Action.LEFT);
                snakeModel.moveBody();
                lb.Text = "LEFT";
                left = false;
            }
            else
            {
                if (mindset)
                {
                    if (conslevel > 50) //&& conslevel > medlevel
                    {
                        snakeModel.setAction(SnakeModel.Action.FORWARD);
                        snakeModel.moveBody();
                        lb.Text = "FORWARD";
                    }
                    else
                    {
                        lb.Text = "Attention below 50";
                    }
                }
                else
                {
                   snakeModel.setAction(SnakeModel.Action.FORWARD);
                   snakeModel.moveBody();
                   lb.Text = "FORWARD";
                }
            }          

            if (snakeModel.hitApple(x, y, 10))
            {
                playAppleSound();
                removeRandomApple();
                snakeModel.growTheSnake();
                makeRandomApple();
                lb.Text = "HIT APPLE!!";
                //updateEntireSnakeBody = true;
            }

            if (snakeModel.gameOver())
            {
                lb.Text = "Game Over";
                running = false;
            }

            gameView_panel.Invalidate();
            gameView_panel.Update();
        }

        public void run(){
        
            /*
                long mindInterval = 3000; // 1000 = 1 second
                long paintInterval = 6000;
                if (mindset)
                {
                    timer.Interval = mindInterval;
                    timer.Elapsed += new ElapsedEventHandler(mindLogic);
                    timer.Start();
                }

                
                timer2.Interval = paintInterval;
                timer2.Elapsed+= new ElapsedEventHandler(paintLogic);
                timer2.Start();
                */
                
                while (running)
                {
                    if (mindset && collectQuicksamples)
                    {
                        playSimpleSound();
                        Thread.Sleep(1500);
                        
                        mindLogic();

                        paintUpdate();
                    }
                    else
                    {
                        snakeModel.setAction(SnakeModel.Action.FORWARD);
                        lb.Text = "FORWARD";
                        snakeModel.moveBody();
                        gameView_panel.Invalidate();
                    }

                    if (snakeModel.hitApple(x, y, 10))
                    {
                        removeRandomApple();
                        playAppleSound();
                        snakeModel.growTheSnake();
                        makeRandomApple();
                        lb.Text = "HIT APPLE!!";
                        updateEntireSnakeBody = true;
                    }

                    if (snakeModel.gameOver())
                    {
                        lb.Text = "Game Over";
                        running = false;
                    }

                    gameView_panel.Invalidate();
                    gameView_panel.Update();

                    Thread.Sleep(80); 
                } 

        }

        void Snake_KeyUp(object sender, KeyEventArgs e)
        {
            switch ((int)e.KeyValue)
            {
                case (int)Keys.Right:
                    snakeModel.setAction(SnakeModel.Action.RIGHT);
                    snakeModel.moveBody();
                    lb.Text = "RIGHT";
                    break;
                case (int)Keys.Left:
                    snakeModel.setAction(SnakeModel.Action.LEFT);
                    snakeModel.moveBody();
                    lb.Text = "LEFT";
                    break;
                case (int)Keys.Escape:
                    quit_button_Click();
                    break;
                default:
                    snakeModel.setAction(SnakeModel.Action.FORWARD);
                    snakeModel.moveBody();
                    lb.Text = "FORWARD";
                    break;
            };

            gameView_panel.Invalidate();
            gameView_panel.Update();
        }

        public void start()
        {
            this.KeyUp += new KeyEventHandler(Snake_KeyUp);
            this.Activate();
            this.Focus();
            lb.Text = "" + this.Focused;
            KeyPreview = true;

            running = true;
            th = new Thread(this.run);
            th.Start();
            
        }

        private void quit_button_Click()
        {
            running = false;
            this.Owner.Show();
            this.Hide();
            timer.Stop();
            timer2.Stop();
            GUI.getInstance().removeMindObserver(this);
            th.Abort();
        }

        private void gameView_panel_Paint(object sender, PaintEventArgs e)
        {
            
            if (snakeModel.getDrawableSnake() != null)
            {
                Graphics graphicsObj = e.Graphics;
                
                //graphicsObj.DrawLines(new Pen(Color.Red, 3), snakeModel.getDrawableSnake());
                
                //graphicsObj.DrawPolygon(new Pen(Color.Red, 3), snakeModel.getDrawableSnake());
                
                Point[] temp = snakeModel.getDrawableSnake();
                GraphicsPath graphPath = new GraphicsPath();
                ///*
                if (updateEntireSnakeBody)
                {
                    for (int i = 0; i < temp.Length; i++)
                    {
                        graphPath.AddEllipse(temp[i].X, temp[i].Y, 2, 2);
                        //graphicsObj.DrawEllipse(new Pen(Color.Red, 1), temp[i].X, temp[i].Y, 2, 2);
                        //graphicsObj.DrawLine(new Pen(Color.Red, 3), temp[i].X, temp[i].Y, temp[i+1].X, temp[i+1].Y);
                    }

                    graphicsObj.DrawPath(new Pen(Color.Red, 3), graphPath);
                    //*/
                    updateEntireSnakeBody = false;
                }
                else
                {
                    //graphicsObj.DrawEllipse(new Pen(Color.Red, 1), temp[0].X, temp[0].Y, 2, 2);
                    //graphicsObj.DrawEllipse(new Pen(Color.Red, 1), temp[temp.Length - 1].X, temp[temp.Length - 1].Y, 2, 2);
                    for (int i = 0; i < temp.Length; i+=4)
                    {
                        graphPath.AddEllipse(temp[i].X, temp[i].Y, 2, 2);
                        //graphicsObj.DrawEllipse(new Pen(Color.Red, 1), temp[i].X, temp[i].Y, 2, 2);
                        //graphicsObj.DrawLine(new Pen(Color.Red, 3), temp[i].X, temp[i].Y, temp[i+1].X, temp[i+1].Y);
                    }

                    graphicsObj.DrawPath(new Pen(Color.Red, 3), graphPath);
                }
                
                graphicsObj.DrawEllipse(new Pen(Color.Blue, 1), x, y, 4, 4);
                graphicsObj.Dispose(); 

            }
             
        }

        public int[] getBorders()
        {
            return new int[] { gameView_panel.Width, gameView_panel.Height };
        }

        public void thinkgearChanged(ThinkGearNET.ThinkGearChangedEventArgs e)
        {
            conslevel = (int)e.ThinkGearState.Attention;
            medlevel = (int)e.ThinkGearState.Meditation;
            bool blink = false;
            bp = bc;
            bc = e.ThinkGearState.BlinkStrength;
            if (bc != bp && bc > 48)
            {
                blink = true;
            }
            if (blink && !collectQuicksamples)
            {
                collectQuicksamples = true;
            }
            if (cur != prev)
            {
                if (collectQuicksamples && counter < collectionSize)
                {
                    quickSampleCollection[counter] = new QuickSampleModel(new double[] { e.ThinkGearState.Delta,
                    e.ThinkGearState.Theta, e.ThinkGearState.Alpha1 + e.ThinkGearState.Alpha2,
                    e.ThinkGearState.Beta1 + e.ThinkGearState.Beta2, e.ThinkGearState.Gamma1 + 
                    e.ThinkGearState.Gamma2}, (int)e.ThinkGearState.Attention, (int)e.ThinkGearState.Meditation);
                    counter++;
                }
            }
            prev = cur;
            cur = e.ThinkGearState.Delta;
        }

        private void updateGo(Color color)
        {
            go_panel.BackColor = color;
            go_panel.Invalidate();

        }
    }
}
//end of file