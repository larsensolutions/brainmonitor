using System;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using ThinkGearNET;
using System.Xml;
using System.Media;

namespace BrainMonitor
{
	public partial class GUI : Form, MindsetObserver
    {
        #region Variables and Constructor

        private static GUI form1 = null;
        private BlinkScenarioGUI form2 = new BlinkScenarioGUI();
        private MotionGUI form3 = new MotionGUI();
        private Snake form4;
		private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();
        private PointF[] rawData;
        private int sample_length = 128;
        private Sample sample = null;
        private ArrayList sampleQue;
        //private bool take_sample = false;
        private NeuralNet _nn;
        public float blink_strength;
        public NNSetup _nnSetup = new NNSetup();
        private ArrayList observers=new ArrayList();
        private ArrayList unsubsribers = new ArrayList();
        private AttentionGraph ag;
        public String saveSessionPath = null;
        public float prev, cur = 0;

        private bool isBlink;

        private int sampleNumber=0;

		private GUI()
		{
            String filename = "C:\\WINDOWS\\Media\\ding.wav";
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(new System.IO.FileInfo(filename).FullName);
            sp.Play();
			InitializeComponent();
            initRawData();
            sampleQue = new ArrayList();    
		}

        public void testSamplesForNN(out float temp, double[] data)
        {
            _nn.Test(out temp, data);
        }

        public static GUI getInstance()
        {
            if (form1 == null) form1 = new GUI();
            return form1;
        }

        public bool isitBlink()
        {
            sampleNumber++;
            number_tb.Text = "" + sampleNumber;
            if (_nn != null)
            {
                train_result.Text = ""+0.0;      
                test_sample_Click(null, null);
                sample = new Sample(128, "", 0);

                return isBlink;
            }
            else return false;
        }
         
        public void setSaveSettionPath(string path){
            saveSessionPath = path;
        }

        #endregion

        #region Initialization and Closing
        private void Form1_Load(object sender, EventArgs e)
        {

            System.Drawing.Graphics graphicsObj;
            graphicsObj = rawEEGpanel.CreateGraphics();

            System.Drawing.Graphics graphicsObj2;
            graphicsObj2 = samplePanel.CreateGraphics();

            System.Drawing.Graphics graphicsObj3;
            graphicsObj3 = fftPanel.CreateGraphics();

            foreach (string port in SerialPort.GetPortNames())
                cboPort.Items.Add(port);
            try
            {
                cboPort.SelectedIndex = 0;
            }
            catch
            {

            }           
            this.observers = new ArrayList();
            addMindObserver(this);

        }

        private void initRawData()
        {
            rawData = new PointF[rawEEGpanel.Width];
            for (int i = 0; i < rawData.Length; i++)
            {
                rawData[i] = new Point(i, (rawEEGpanel.Height / 2));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _thinkGearWrapper.Disconnect();
        }
        #endregion

        #region Mindset and Observer Control

        public void addMindObserver(MindsetObserver observer)
        {
            observers.Add(observer);
        }

        public void removeMindObserver(MindsetObserver observer)
        {
            unsubsribers.Add(observer);
        }

        private void cleanUpObserverList()
        {
            foreach (MindsetObserver u in unsubsribers)
            {
                if(u != null) observers.Remove(u);
            }
            unsubsribers.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper = new ThinkGearWrapper();

            // setup the event
            _thinkGearWrapper.ThinkGearChanged += _thinkGearWrapper_ThinkGearChanged;

            // connect to the device on the specified COM port at 57600 baud
            if (!_thinkGearWrapper.Connect(cboPort.SelectedItem.ToString(), 57600, true))
                MessageBox.Show("Could not connect to headset.");
            else
            {
                sample_button.Enabled = true;
                blink_scenario_button.Enabled = true;

            }
        }

        private void notifyObservers(ThinkGearChangedEventArgs e)
        {
            foreach (MindsetObserver m in observers)
            {
                m.thinkgearChanged(e);
            }

        }

        void _thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
        {
            // update the textbox and sleep for a tiny bit
            BeginInvoke(new MethodInvoker(delegate
            {
                notifyObservers(e);
                cleanUpObserverList();

            }));
            Thread.Sleep(10);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.Disconnect();
            sample_button.Enabled = false;
        }

        private void btnEnableBlink_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.EnableBlinkDetection(true);
        }

        private void btnDisableBlink_Click(object sender, EventArgs e)
        {
            _thinkGearWrapper.EnableBlinkDetection(false);
        }

        #endregion

        #region MindsetObserver Interface Implementation     

        public void thinkgearChanged(ThinkGearChangedEventArgs e)
        {
            updateRawData(e.ThinkGearState.Raw);
            lblAttention.Text = "Attention: " + e.ThinkGearState.Attention;
            lblMeditation.Text = "Meditation: " + e.ThinkGearState.Meditation;
            if (cur != prev)
            {
                if (savemode_cb.Checked && !_nnSetup.quicksamples_cb.Checked)
                {
                    lblMeditation.Text = "Change";
                    string sn = sname_tb.Text.Trim();
                    sampleNumber = (int)Convert.ToDouble(number_tb.Text.Trim());
                    if (sn == "") sn = "default";
                        /*
                    sampleQue.Add(new SampleModel(new double[] { e.ThinkGearState.Delta,
                e.ThinkGearState.Theta, e.ThinkGearState.Alpha1, e.ThinkGearState.Alpha2,
                e.ThinkGearState.Beta1, e.ThinkGearState.Beta2, e.ThinkGearState.Gamma1, 
                e.ThinkGearState.Gamma2}, sn, sampleNumber, (int)e.ThinkGearState.Attention, (int)e.ThinkGearState.Meditation));
                        */
                    sampleQue.Add(new Sample(new double[] { e.ThinkGearState.Delta,
                e.ThinkGearState.Theta, e.ThinkGearState.Alpha1+ e.ThinkGearState.Alpha2,
                e.ThinkGearState.Beta1+ e.ThinkGearState.Beta2, e.ThinkGearState.Gamma1+ 
                e.ThinkGearState.Gamma2}, sn, sampleNumber, (int)e.ThinkGearState.Attention, (int)e.ThinkGearState.Meditation));

                    fftPanel.Invalidate();
                    sampleNumber++;
                    number_tb.Text = "" + sampleNumber;
                }
                
            }
            else
            {

                lblMeditation.Text = "NO Change";
            }
                prev = cur;
                cur = e.ThinkGearState.Delta;

            blink_strength = e.ThinkGearState.BlinkStrength;
            txtState.Text = e.ThinkGearState.ToString() + " bs : " + blink_strength;
            rawEEGpanel.Invalidate();
        }
        
        #endregion

        #region Panel View

        public void updateSampleView(Sample sam){
            this.sample = sam;
            samplePanel.Invalidate();
            fftPanel.Invalidate();
            sampleQue.Clear();
        }

        /// <summary>
        /// Maintains the raw data input from the Mindset in a Point array, to
        /// be able to draw it to rawEEGpanel as a polygon.
        /// </summary>
        private void updateRawData(float rd)
        {
            for (int i = 0; i < rawData.Length - 1; i++)
            {
                PointF t = rawData[i + 1];
                t.X--;
                rawData[i] = t;
            }
            //Raw data gets scaled to fit application window
            rawData[338] = (new PointF(338, (rd / 15) + (rawEEGpanel.Height / 2)));
        }

        private void rawEEGPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObj = e.Graphics;
            graphicsObj.DrawLines(new Pen(Color.Red, 1), rawData);       
            graphicsObj.Dispose();
        }

        private void sample_panel_Paint(object sender, PaintEventArgs e)
        {
            if (sample != null)
            {
                Graphics graphicsObj = e.Graphics;
                PointF[] sampleData = new PointF[sample.getSampleSize];
                for (int i = 0; i < sampleData.Length; i++)
                {
                    sampleData[i] = new PointF(i, (float)((sample.getRawData[i] / 25) + (samplePanel.Height / 2)));
                }
                graphicsObj.DrawLines(new Pen(Color.Blue, 2), sampleData);
                graphicsObj.Dispose();
            }
        }

        private void fftPanel_Paint(object sender, PaintEventArgs e)
        {
            if (sample != null)
            {
                if (!_nnSetup.cb.Checked)
                {
                    double[] power = sample.getPowerBands;
                    delta_l.Text = "Delta " + power[0].ToString("0.0000");
                    theta_l.Text = "Theta " + power[1].ToString("0.0000");
                    alpha_l.Text = "Alpha " + power[2].ToString("0.0000");
                    beta_l.Text = "Beta   " + power[3].ToString("0.0000");
                    Gamma_l.Text = "Gamma" + power[4].ToString("0.0000");
                }
                else
                {
                    double[] power = sample.getSpesificPowerBands;
                    delta_l.Text = "Delta " + power[0].ToString("0.0000");
                    theta_l.Text = "Theta " + power[1].ToString("0.0000");
                    alpha1_lb.Text = "1 " + power[2].ToString("0.0000");
                    alpha2_lb.Text = "2 " + power[3].ToString("0.0000");
                    beta1_lb.Text ="1 " + power[4].ToString("0.0000");
                    beta2_lb.Text ="2 " + power[5].ToString("0.0000");
                    gamma1_lb.Text ="1 "+ power[6].ToString("0.0000");
                    gamma2_lb.Text ="2 " + power[7].ToString("0.0000");
                }

                double[] drawData = sample.getFFTabsData;

               
                dom_fre.Text = "Dom Freq " + sample.getHighestBand;

                Graphics graphicsObj = e.Graphics;
                Pen myPen = new Pen(Color.Blue, 2);
                for (int i = 2; i < drawData.Length / 2; i++)
                {
                    graphicsObj.DrawLine(myPen, new Point(i * 4, 0), new PointF(i * 4, (float)((drawData[i] / sample.getPeak) * fftPanel.Height)));

                }
                graphicsObj.Dispose();
            }
        }
        #endregion

        #region Button and Checkbox Control

        #region Sample Control

        private void track_button_Click(object sender, EventArgs e)
        {
            ag = new AttentionGraph(sname_tb.Text, Convert.ToInt16(number_tb.Text));
            GUI.getInstance().addMindObserver((MindsetObserver)ag);
            track_button.Enabled = false;
            stop_button.Enabled = true;
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            if (ag != null)
            {
                GUI.getInstance().removeMindObserver((MindsetObserver)ag);
                ag.Owner = this;
                ag.Show();
                ((AttentionGraph)ag).CreateChart();
                track_button.Enabled = true;
                stop_button.Enabled = false;
                if (savemode_cb.Checked) ag.saveAttentionGraph(saveSessionPath);
            }

        }

        private void open_track_button_Click(object sender, EventArgs e)
        {
            ag = new AttentionGraph(IOService.SelectTextFile(saveSessionPath));
            if (ag.isComplete())
            {
                ag.CreateChart();
                ag.Show();
            }

        }

        public void sample_button_Click(object sender, EventArgs e)
        {

            string sn = sname_tb.Text.Trim();
            sampleNumber = (int)Convert.ToDouble(number_tb.Text.Trim());
            if (sn == "") sn = "default";
            sampleQue.Add(new Sample(sample_length, sn, sampleNumber));
            sampleNumber++;
            number_tb.Text = ""+sampleNumber;
            test_sample.Enabled = true;

        }

        private void openSample_button_Click(object sender, EventArgs e)
        {
            sample = new Sample(IOService.SelectTextFile(saveSessionPath), false);
            if (sample.isSampleComplete())
            {
                sname_tb.Text = sample.getName;

                fftPanel.Invalidate();
                samplePanel.Invalidate();
            }
            if (_nn != null) test_sample.Enabled = true;
        }

        private void choose_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            DialogResult res = fb.ShowDialog();
            if (res == DialogResult.OK)
            {
                saveSessionPath = fb.SelectedPath + @"\";
            }
        }

        private void graph_it_button_Click(object sender, EventArgs e)
        {
            if (sample != null)
            {
                SampleGraph sg = new SampleGraph(sample);
                sg.CreateChart();
                sg.Show();
            }
            
        }

        //Do not work on quicksamples, only samples with raw data
        private void filter_button_Click(object sender, EventArgs e)
        {
            if (sample != null)
            {
                sample.averageFilter(3);
                sample.resetFFTdata();
                sample.FFT(true);
                samplePanel.Invalidate();
                fftPanel.Invalidate();
            }
        }

        private void test_hz_button_Click(object sender, EventArgs e)
        {
            sample = new Sample(128);
            sample.FFT(true);           
            samplePanel.Invalidate();
            fftPanel.Invalidate();

        }

        #endregion

        #region Neural Network Control

        private void trainNN_button_Click(object sender, EventArgs e)
        {
            testBlink_button.Enabled = false;
            testNoBlink_button.Enabled = false;
            string[] files = IOService.SelectTextFiles(saveSessionPath);
            if (files != null)
            {

                if (inputType_cb.Checked && !_nnSetup.cb.Checked)
                {
                    _nn = new NeuralNet(Convert.ToInt32(trainCycles_tb.Text.Trim()), Convert.ToInt32(neruonCount_tb.Text.Trim()), Convert.ToDouble(learnRate_tb.Text.Trim()), new int[] { _nnSetup._inputLayer, _nnSetup._hiddenLayer, _nnSetup._outputLayer} );
                    _nn.makeNetwork(5, 5);

                }
                else if (_nnSetup.quicksamples_cb.Checked)
                {
                    
                        _nn = new NeuralNet(Convert.ToInt32(trainCycles_tb.Text.Trim()), Convert.ToInt32(neruonCount_tb.Text.Trim()), Convert.ToDouble(learnRate_tb.Text.Trim()), new int[] { _nnSetup._inputLayer, _nnSetup._hiddenLayer, _nnSetup._outputLayer });
                        _nn.makeNetwork(5, 5);
                        //_nn.makeNetwork(7, 7);
                }
                else
                {
                    _nn = new NeuralNet(Convert.ToInt32(trainCycles_tb.Text.Trim()), Convert.ToInt32(neruonCount_tb.Text.Trim()), Convert.ToDouble(learnRate_tb.Text.Trim()), new int[] { _nnSetup._inputLayer, _nnSetup._hiddenLayer, _nnSetup._outputLayer });
                    _nn.makeNetwork(128, 128);
                }
                foreach (string f in files)
                {
                    if (inputType_cb.Checked && !_nnSetup.cb.Checked)
                    {
                        _nn.addTrainingSet(new Sample(f, false).getPowerBands, 1d);
                    }
                    else if (_nnSetup.cb.Checked)
                    {
                        _nn.addTrainingSet(new Sample(f, false).getSpesificPowerBands, 1d);
                    }
                    else if (_nnSetup.quicksamples_cb.Checked)
                    {
                        Sample g = new Sample(f, true);
                        //_nn.addTrainingSet(new double[] { g.getSpesificPowerBands[2], g.getSpesificPowerBands[3] }, 0d);
                        _nn.addTrainingSet(new Sample(f, true).getSpesificPowerBands, 1d);
                    }
                    else
                        _nn.addTrainingSet(new Sample(f, false).getRawData, 1d);
                }
                string[] files2 = IOService.SelectTextFiles(saveSessionPath);
                if (files2 != null)
                {
                   
                    foreach (string f in files2)
                    {
                        if (inputType_cb.Checked && !_nnSetup.cb.Checked)
                        {
                            _nn.addTrainingSet(new Sample(f,false).getPowerBands, 0d);
                        }
                        else if (_nnSetup.cb.Checked)
                        {
                            _nn.addTrainingSet(new Sample(f, false).getSpesificPowerBands, 0d);
                        }
                        else if (_nnSetup.quicksamples_cb.Checked)
                        {
                            Sample g = new Sample(f, true);
                            //_nn.addTrainingSet(new double[] { g.getSpesificPowerBands[2], g.getSpesificPowerBands[3] }, 0d);
                            _nn.addTrainingSet(new Sample(f, true).getSpesificPowerBands, 0d);
                        }
                        else
                            _nn.addTrainingSet(new Sample(f, false).getRawData, 0d);
                    }

                    _nn.train(progressBar);
                   
                }
            }
            if (_nn != null)
            {
                testBlink_button.Enabled = true;
                testNoBlink_button.Enabled = true;
                if(sample!=null)test_sample.Enabled = true;
            }
        }

        private void testBlink_button_Click(object sender, EventArgs e)
        {
            Sample blink = new Sample(@"C:\blink1.txt",false);
            if (inputType_cb.Checked)
            {
                 _nn.Test(train_result, blink.getPowerBands);
            }else 
                _nn.Test(train_result, blink.getRawData);
        }

        private void testNoBlink_button_Click(object sender, EventArgs e)
        {
            Sample noBlink = new Sample(@"C:\noblink1.txt",false);
            if (inputType_cb.Checked)
            {   
                _nn.Test(train_result, noBlink.getPowerBands);
            } else 
                _nn.Test(train_result, noBlink.getRawData);
        }

        private void test_sample_Click(object sender, EventArgs e)
        {
            if (inputType_cb.Checked && !_nnSetup.cb.Checked)
            {
                _nn.Test(train_result, sample.getPowerBands);
            }
            else if (inputType_cb.Checked &&_nnSetup.cb.Checked)
            {
                _nn.Test(train_result, sample.getSpesificPowerBands);
            }
            else 
                _nn.Test(train_result, sample.getRawData);

            if (Convert.ToDouble(train_result.Text.Trim()) > 0.95)
            {
                
                isBlink = true;
            }
            else
            {
                isBlink = false;
            }
        }

        private void test_set_button_Click(object sender, EventArgs e)
        {
            String[] testSet = IOService.SelectTextFiles(saveSessionPath);
            if (testSet != null && testSet.Length>0)
            {
                double set_size = Convert.ToDouble(testSet.Length);
                float correctness = 0.000000f;
                foreach (String sam in testSet)
                {
                    Sample t = null;
                    if (_nnSetup.quicksamples_cb.Checked)
                    {
                        t = new Sample(sam, true);
                    }
                    else
                    {
                        t = new Sample(sam, false);
                    }
                    float temp;

                    if (inputType_cb.Checked && !_nnSetup.cb.Checked)
                    {
                        _nn.Test(out temp, t.getPowerBands);
                    }
                    else if (_nnSetup.quicksamples_cb.Checked || _nnSetup.cb.Checked)
                    {
                        // _nn.Test(out temp, new double[] { t.getSpesificPowerBands[2], t.getSpesificPowerBands[3] });
                        //_nn.Test(out temp, t.getSpesificPowerBands);
                        _nn.Test(out temp, t.getPowerBands);
                    }
                    else
                    {
                        _nn.Test(out temp, t.getRawData);
                    }

                    correctness += temp;

                }
                correctness /= (float)set_size;
                corr_res_lb.Text = correctness.ToString();
            }

        }

        private void adv_sett_button_Click(object sender, EventArgs e)
        {
            _nnSetup.Show();
        }

        private void inputType_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (inputType_cb.Checked && !_nnSetup.cb.Checked) neruonCount_tb.Text = "" + 5;
            else if (inputType_cb.Checked && _nnSetup.cb.Checked) { neruonCount_tb.Text = "" + 8; }
            else neruonCount_tb.Text = "" + 128;
        }

        #endregion

        #region Scenario Control

        private void blink_scenario_button_Click(object sender, EventArgs e)
        {
            form2.Owner = this;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.WindowState = FormWindowState.Maximized;
            form2.Left = Screen.PrimaryScreen.Bounds.X;
            form2.Width = Screen.PrimaryScreen.Bounds.Width;
            form2.Top = Screen.PrimaryScreen.Bounds.Y;
            form2.Height = Screen.PrimaryScreen.Bounds.Height;
            form2.TopMost = true;
            
            form2.Show();
            form1.Hide();
        }

        private void generic_scenario_button_Click(object sender, EventArgs e)
        {
            form3.Owner = this;
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.WindowState = FormWindowState.Maximized;
            form3.Left = Screen.PrimaryScreen.Bounds.X;
            form3.Width = Screen.PrimaryScreen.Bounds.Width;
            form3.Top = Screen.PrimaryScreen.Bounds.Y;
            form3.Height = Screen.PrimaryScreen.Bounds.Height;
            form3.TopMost = true;

            form3.Show();
            form1.Hide();
        }

        private void snake_button_Click(object sender, EventArgs e)
        {
            form4 = new Snake();
            form4.Owner = this;
            form4.FormBorderStyle = FormBorderStyle.None;
            form4.WindowState = FormWindowState.Maximized;
            form4.Left = Screen.PrimaryScreen.Bounds.X;
            form4.Width = Screen.PrimaryScreen.Bounds.Width;
            form4.Top = Screen.PrimaryScreen.Bounds.Y;
            form4.Height = Screen.PrimaryScreen.Bounds.Height;
            form4.TopMost = true;

            form4.Show();
            form1.Hide();
            form4.Activate();
            form4.Visible = true;
            form4.CreateControl();
            form4.start();

        }

        #endregion

        #endregion

        #region Menu Item Control

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }

        #endregion

        private void stat_button_Click(object sender, EventArgs e)
        {
            String[] test_set = IOService.SelectTextFiles(saveSessionPath);
            if (test_set != null)
            {
                double set_size = Convert.ToDouble(test_set.Length);
                double delta = 0;
                double theta = 0;
                double alpha = 0;
                double beta = 0;
                double gamma = 0;
                double att = 0;
                double med = 0;
                foreach (String sam in test_set)
                {
                    QuickSample qsm = new QuickSample(sam);
                    delta += qsm.getPowerBands[0];
                    theta += qsm.getPowerBands[1];
                    alpha += qsm.getPowerBands[2];
                    beta += qsm.getPowerBands[3];
                    gamma += qsm.getPowerBands[4];
                    att += qsm.att;
                    med += qsm.med;
                }
                double total = delta + theta + alpha + beta + gamma;
                string sn = sname_tb.Text.Trim();
                IOService.writePowerStatData(saveSessionPath, new double[] { delta, theta, alpha, beta, gamma, total }, att, med, sn);
                IOService.writePowerStatData(saveSessionPath, new double[] { delta / set_size, theta / set_size, alpha / set_size, beta / set_size, gamma / set_size }, att, med, sn + "scaled");
            }
        }

        
    }
}
//end of file
