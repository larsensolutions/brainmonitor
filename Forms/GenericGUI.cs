using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;
using BrainMonitor;
using System.Windows.Forms;

namespace BrainMonitor
{
    public partial class MotionGUI : Form
    {
        static AutoResetEvent autoEvent = new AutoResetEvent(false);
        public Thread scenarioThread;
        private Form ag = null;
        private String saveSessionPath = null;


        public MotionGUI()
        {
            InitializeComponent();
            System.Drawing.Graphics graphicsObj;
            graphicsObj = scenario_Panel.CreateGraphics();
            samples1_tb.Text = "" + 10;
            samples2_tb.Text = "" + 10;
        }


        private void folder_select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            DialogResult res = fb.ShowDialog();
            if (res == DialogResult.OK)
            {
                saveSessionPath = fb.SelectedPath + @"\";
            }
        }

        private void view_att_Click(object sender, EventArgs e)
        {
            if (ag != null)
            {
                ag.Owner = this.Owner;
                this.Owner.Show();
                ag.Show();
                ((AttentionGraph)ag).CreateChart();
                ((AttentionGraph)ag).saveAttentionGraph(saveSessionPath);
                this.Hide();
            }
        }


        private void runScenario()
        {
            ag = new AttentionGraph(part1_tb.Text + "_ag", 1);
            GUI.getInstance().addMindObserver((MindsetObserver)ag);

            start_button.Enabled = false;
            GUI.getInstance().setSaveSettionPath(saveSessionPath);
            GUI.getInstance().savemode_cb.Checked = true;
            GUI.getInstance().sname_tb.Text = part1_tb.Text;
            GUI.getInstance().number_tb.Text = "" + 0;

            SampleTakeControl controller = new SampleTakeControl(this, SampleTakeControl.SampleOf.NoBlink);
            Thread th = new Thread(controller.run);
            pictureBox1.Image = Image.FromFile(@"C:\sonic.gif");
            th.Start();

            autoEvent.WaitOne();


            GUI.getInstance().sname_tb.Text = part2_tb.Text;
            GUI.getInstance().number_tb.Text = "" + 0;
            controller = new SampleTakeControl(this, SampleTakeControl.SampleOf.Blink);
            th = new Thread(controller.run);
            pictureBox1.Image = Image.FromFile(@"C:\sonic2.GIF");
            th.Start();

            autoEvent.WaitOne();

            start_button.Enabled = true;
            GUI.getInstance().removeMindObserver((MindsetObserver)ag);
            att_graph.Enabled = true;
        }


        public class SampleTakeControl
        {
            int samplesTaken = 0;
            int samplesWanted = 10; //default
            long interval = 2000; // 1000 = 1 second
            System.Timers.Timer timer = new System.Timers.Timer();
            MotionGUI bsg;

            public enum SampleOf
            {
                Blink,
                NoBlink,
            }

            public void run()
            {
                timer.Interval = interval; 
                timer.Start();
            }


            public SampleTakeControl(MotionGUI bsg, SampleOf sample)
            {
                this.bsg = bsg;
                
                switch (sample)
                {
                    case SampleOf.Blink:
                        samplesWanted = Convert.ToInt32(bsg.samples2_tb.Text);
                        timer.Elapsed += new ElapsedEventHandler(takeBlinkSample);
                        break;

                    case SampleOf.NoBlink:

                        samplesWanted = Convert.ToInt32(bsg.samples2_tb.Text);
                        timer.Elapsed += new ElapsedEventHandler(takeNOBlinkSample);
                        bsg.scenario_Panel.Invoke(new MethodInvoker(delegate
                        {
                            System.Drawing.Graphics graphicsObj = bsg.scenario_Panel.CreateGraphics();
                            Pen myPen = new Pen(Color.Red, 1);
                            // Create string to draw.
                            String drawString = "Part 1.";
                            // Create font and brush.
                            Font drawFont = new Font("Arial", 16);
                            SolidBrush drawBrush = new SolidBrush(Color.Black);
                            // Create point for upper-left corner of drawing.
                            PointF drawPoint = new PointF(150F, 100F);
                            // Draw string to screen.
                            graphicsObj.DrawString(drawString, drawFont, drawBrush, drawPoint);                         
                            graphicsObj.Dispose();
                            ;
                        }));
                        break;
                }
               
                           
            }

            public void takeBlinkSample(object source, ElapsedEventArgs e)
            {
                if (samplesTaken >= samplesWanted) {
                    ((System.Timers.Timer)source).Stop();
                    autoEvent.Set();
                    
                }else{
                    bsg.scenario_Panel.Invoke(new MethodInvoker(delegate
                    {
                        
                        System.Drawing.Graphics graphicsObj = bsg.scenario_Panel.CreateGraphics();
                        Pen myPen = new Pen(Color.Black, 1);
                        // Create string to draw.
                        String drawString = " Part 2.";
                        // Create font and brush.
                        Font drawFont = new Font("Arial", 16);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);
                        // Create point for upper-left corner of drawing.
                        PointF drawPoint = new PointF(150F, 100F);
                        // Draw string to screen.
                        graphicsObj.DrawString(drawString, drawFont, drawBrush, drawPoint);
                        graphicsObj.Dispose();
                        ;
                    }));
                    GUI.getInstance().sample_button_Click(null, null);
                    Thread.Sleep(300);
                    bsg.scenario_Panel.Invalidate();
                    samplesTaken++;                   
                }
            }

            public void takeNOBlinkSample(object source, ElapsedEventArgs e)
            {
                if (samplesTaken >= samplesWanted)
                {
                    ((System.Timers.Timer)source).Stop();
                    bsg.scenario_Panel.Invalidate();
                    autoEvent.Set();
                }
                else
                {
                    GUI.getInstance().sample_button_Click(null, null);
                    Thread.Sleep(300);
                    samplesTaken++;
                }
               
            }

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (saveSessionPath == null) folder_select_Click(null, null);
            scenarioThread = new Thread(runScenario);
            //runScenario();
            scenarioThread.Start();
        }

        private void scenario_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_form_button_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
    }
}
