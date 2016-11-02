namespace BrainMonitor
{
	partial class GUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblAttention = new System.Windows.Forms.Label();
            this.lblMeditation = new System.Windows.Forms.Label();
            this.btnEnableBlink = new System.Windows.Forms.Button();
            this.btnDisableBlink = new System.Windows.Forms.Button();
            this.rawEEGpanel = new System.Windows.Forms.Panel();
            this.sample_button = new System.Windows.Forms.Button();
            this.samplePanel = new System.Windows.Forms.Panel();
            this.fftPanel = new System.Windows.Forms.Panel();
            this.total_l = new System.Windows.Forms.Label();
            this.delta_l = new System.Windows.Forms.Label();
            this.theta_l = new System.Windows.Forms.Label();
            this.alpha_l = new System.Windows.Forms.Label();
            this.beta_l = new System.Windows.Forms.Label();
            this.Gamma_l = new System.Windows.Forms.Label();
            this.dom_fre = new System.Windows.Forms.Label();
            this.trainNN_button = new System.Windows.Forms.Button();
            this.testBlink_button = new System.Windows.Forms.Button();
            this.train_result = new System.Windows.Forms.Label();
            this.testNoBlink_button = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.test_sample = new System.Windows.Forms.Button();
            this.nc_l = new System.Windows.Forms.Label();
            this.cycles_l = new System.Windows.Forms.Label();
            this.learnRate_l = new System.Windows.Forms.Label();
            this.neruonCount_tb = new System.Windows.Forms.TextBox();
            this.trainCycles_tb = new System.Windows.Forms.TextBox();
            this.learnRate_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openSample_button = new System.Windows.Forms.Button();
            this.sname_tb = new System.Windows.Forms.TextBox();
            this.sam_name = new System.Windows.Forms.Label();
            this.savemode_cb = new System.Windows.Forms.CheckBox();
            this.number_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputType_cb = new System.Windows.Forms.CheckBox();
            this.blink_scenario_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbNeuralSetup = new System.Windows.Forms.GroupBox();
            this.adv_sett_button = new System.Windows.Forms.Button();
            this.nc_l2 = new System.Windows.Forms.Label();
            this.gbNeuralTest = new System.Windows.Forms.GroupBox();
            this.stat_button = new System.Windows.Forms.Button();
            this.corr_res_lb = new System.Windows.Forms.Label();
            this.test_set_button = new System.Windows.Forms.Button();
            this.gbSampleView = new System.Windows.Forms.GroupBox();
            this.gamma2_lb = new System.Windows.Forms.Label();
            this.gamma1_lb = new System.Windows.Forms.Label();
            this.beta2_lb = new System.Windows.Forms.Label();
            this.beta1_lb = new System.Windows.Forms.Label();
            this.alpha2_lb = new System.Windows.Forms.Label();
            this.alpha1_lb = new System.Windows.Forms.Label();
            this.gbTestScenario = new System.Windows.Forms.GroupBox();
            this.snake_button = new System.Windows.Forms.Button();
            this.gbMindControl = new System.Windows.Forms.GroupBox();
            this.gbSampleControl = new System.Windows.Forms.GroupBox();
            this.test_hz_button = new System.Windows.Forms.Button();
            this.filter_cb = new System.Windows.Forms.CheckBox();
            this.filter_button = new System.Windows.Forms.Button();
            this.graph_it_button = new System.Windows.Forms.Button();
            this.choose_folder = new System.Windows.Forms.Button();
            this.open_track_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.track_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbNeuralSetup.SuspendLayout();
            this.gbNeuralTest.SuspendLayout();
            this.gbSampleView.SuspendLayout();
            this.gbTestScenario.SuspendLayout();
            this.gbMindControl.SuspendLayout();
            this.gbSampleControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPort
            // 
            this.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(79, 23);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(121, 21);
            this.cboPort.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(20, 50);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(84, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(7, 131);
            this.txtState.Multiline = true;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(204, 245);
            this.txtState.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM Port:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(116, 50);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(84, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblAttention
            // 
            this.lblAttention.AutoSize = true;
            this.lblAttention.Location = new System.Drawing.Point(17, 100);
            this.lblAttention.Name = "lblAttention";
            this.lblAttention.Size = new System.Drawing.Size(49, 13);
            this.lblAttention.TabIndex = 5;
            this.lblAttention.Text = "Attention";
            // 
            // lblMeditation
            // 
            this.lblMeditation.AutoSize = true;
            this.lblMeditation.Location = new System.Drawing.Point(17, 113);
            this.lblMeditation.Name = "lblMeditation";
            this.lblMeditation.Size = new System.Drawing.Size(56, 13);
            this.lblMeditation.TabIndex = 5;
            this.lblMeditation.Text = "Meditation";
            // 
            // btnEnableBlink
            // 
            this.btnEnableBlink.Location = new System.Drawing.Point(20, 74);
            this.btnEnableBlink.Name = "btnEnableBlink";
            this.btnEnableBlink.Size = new System.Drawing.Size(84, 23);
            this.btnEnableBlink.TabIndex = 6;
            this.btnEnableBlink.Text = "Enable Blink";
            this.btnEnableBlink.UseVisualStyleBackColor = true;
            this.btnEnableBlink.Click += new System.EventHandler(this.btnEnableBlink_Click);
            // 
            // btnDisableBlink
            // 
            this.btnDisableBlink.Location = new System.Drawing.Point(116, 74);
            this.btnDisableBlink.Name = "btnDisableBlink";
            this.btnDisableBlink.Size = new System.Drawing.Size(84, 23);
            this.btnDisableBlink.TabIndex = 7;
            this.btnDisableBlink.Text = "Disable Blink";
            this.btnDisableBlink.UseVisualStyleBackColor = true;
            this.btnDisableBlink.Click += new System.EventHandler(this.btnDisableBlink_Click);
            // 
            // rawEEGpanel
            // 
            this.rawEEGpanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.rawEEGpanel.Location = new System.Drawing.Point(219, 13);
            this.rawEEGpanel.Name = "rawEEGpanel";
            this.rawEEGpanel.Size = new System.Drawing.Size(339, 363);
            this.rawEEGpanel.TabIndex = 9;
            this.rawEEGpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rawEEGPanel_Paint);
            // 
            // sample_button
            // 
            this.sample_button.Enabled = false;
            this.sample_button.Location = new System.Drawing.Point(6, 16);
            this.sample_button.Name = "sample_button";
            this.sample_button.Size = new System.Drawing.Size(96, 23);
            this.sample_button.TabIndex = 10;
            this.sample_button.Text = "Take Sample";
            this.sample_button.UseVisualStyleBackColor = true;
            this.sample_button.Click += new System.EventHandler(this.sample_button_Click);
            // 
            // samplePanel
            // 
            this.samplePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.samplePanel.Location = new System.Drawing.Point(122, 15);
            this.samplePanel.Name = "samplePanel";
            this.samplePanel.Size = new System.Drawing.Size(128, 104);
            this.samplePanel.TabIndex = 11;
            this.samplePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sample_panel_Paint);
            // 
            // fftPanel
            // 
            this.fftPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fftPanel.Location = new System.Drawing.Point(6, 199);
            this.fftPanel.Name = "fftPanel";
            this.fftPanel.Size = new System.Drawing.Size(244, 177);
            this.fftPanel.TabIndex = 12;
            this.fftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.fftPanel_Paint);
            // 
            // total_l
            // 
            this.total_l.AutoSize = true;
            this.total_l.Location = new System.Drawing.Point(6, 29);
            this.total_l.Name = "total_l";
            this.total_l.Size = new System.Drawing.Size(31, 13);
            this.total_l.TabIndex = 13;
            this.total_l.Text = "Total";
            // 
            // delta_l
            // 
            this.delta_l.AutoSize = true;
            this.delta_l.Location = new System.Drawing.Point(6, 40);
            this.delta_l.Name = "delta_l";
            this.delta_l.Size = new System.Drawing.Size(32, 13);
            this.delta_l.TabIndex = 15;
            this.delta_l.Text = "Delta";
            // 
            // theta_l
            // 
            this.theta_l.AutoSize = true;
            this.theta_l.Location = new System.Drawing.Point(6, 53);
            this.theta_l.Name = "theta_l";
            this.theta_l.Size = new System.Drawing.Size(35, 13);
            this.theta_l.TabIndex = 16;
            this.theta_l.Text = "Theta";
            // 
            // alpha_l
            // 
            this.alpha_l.AutoSize = true;
            this.alpha_l.Location = new System.Drawing.Point(7, 66);
            this.alpha_l.Name = "alpha_l";
            this.alpha_l.Size = new System.Drawing.Size(34, 13);
            this.alpha_l.TabIndex = 17;
            this.alpha_l.Text = "Alpha";
            // 
            // beta_l
            // 
            this.beta_l.AutoSize = true;
            this.beta_l.Location = new System.Drawing.Point(4, 106);
            this.beta_l.Name = "beta_l";
            this.beta_l.Size = new System.Drawing.Size(29, 13);
            this.beta_l.TabIndex = 18;
            this.beta_l.Text = "Beta";
            // 
            // Gamma_l
            // 
            this.Gamma_l.AutoSize = true;
            this.Gamma_l.Location = new System.Drawing.Point(6, 143);
            this.Gamma_l.Name = "Gamma_l";
            this.Gamma_l.Size = new System.Drawing.Size(43, 13);
            this.Gamma_l.TabIndex = 19;
            this.Gamma_l.Text = "Gamma";
            // 
            // dom_fre
            // 
            this.dom_fre.AutoSize = true;
            this.dom_fre.Location = new System.Drawing.Point(7, 16);
            this.dom_fre.Name = "dom_fre";
            this.dom_fre.Size = new System.Drawing.Size(53, 13);
            this.dom_fre.TabIndex = 20;
            this.dom_fre.Text = "Dom Freq";
            // 
            // trainNN_button
            // 
            this.trainNN_button.Location = new System.Drawing.Point(6, 106);
            this.trainNN_button.Name = "trainNN_button";
            this.trainNN_button.Size = new System.Drawing.Size(75, 23);
            this.trainNN_button.TabIndex = 21;
            this.trainNN_button.Text = "Train";
            this.trainNN_button.UseVisualStyleBackColor = true;
            this.trainNN_button.Click += new System.EventHandler(this.trainNN_button_Click);
            // 
            // testBlink_button
            // 
            this.testBlink_button.Enabled = false;
            this.testBlink_button.Location = new System.Drawing.Point(6, 74);
            this.testBlink_button.Name = "testBlink_button";
            this.testBlink_button.Size = new System.Drawing.Size(75, 23);
            this.testBlink_button.TabIndex = 22;
            this.testBlink_button.Text = "Test Blink";
            this.testBlink_button.UseVisualStyleBackColor = true;
            this.testBlink_button.Click += new System.EventHandler(this.testBlink_button_Click);
            // 
            // train_result
            // 
            this.train_result.AutoSize = true;
            this.train_result.Location = new System.Drawing.Point(6, 145);
            this.train_result.Name = "train_result";
            this.train_result.Size = new System.Drawing.Size(43, 13);
            this.train_result.TabIndex = 23;
            this.train_result.Text = "Result :";
            // 
            // testNoBlink_button
            // 
            this.testNoBlink_button.Enabled = false;
            this.testNoBlink_button.Location = new System.Drawing.Point(6, 45);
            this.testNoBlink_button.Name = "testNoBlink_button";
            this.testNoBlink_button.Size = new System.Drawing.Size(75, 23);
            this.testNoBlink_button.TabIndex = 24;
            this.testNoBlink_button.Text = "Test  !Blink";
            this.testNoBlink_button.UseVisualStyleBackColor = true;
            this.testNoBlink_button.Click += new System.EventHandler(this.testNoBlink_button_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 135);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(185, 23);
            this.progressBar.TabIndex = 25;
            // 
            // test_sample
            // 
            this.test_sample.Enabled = false;
            this.test_sample.Location = new System.Drawing.Point(6, 16);
            this.test_sample.Name = "test_sample";
            this.test_sample.Size = new System.Drawing.Size(75, 23);
            this.test_sample.TabIndex = 26;
            this.test_sample.Text = "Test Sample";
            this.test_sample.UseVisualStyleBackColor = true;
            this.test_sample.Click += new System.EventHandler(this.test_sample_Click);
            // 
            // nc_l
            // 
            this.nc_l.AutoSize = true;
            this.nc_l.Location = new System.Drawing.Point(6, 21);
            this.nc_l.Name = "nc_l";
            this.nc_l.Size = new System.Drawing.Size(70, 13);
            this.nc_l.TabIndex = 27;
            this.nc_l.Text = "HiddenLayer:";
            // 
            // cycles_l
            // 
            this.cycles_l.AutoSize = true;
            this.cycles_l.Location = new System.Drawing.Point(6, 46);
            this.cycles_l.Name = "cycles_l";
            this.cycles_l.Size = new System.Drawing.Size(65, 13);
            this.cycles_l.TabIndex = 28;
            this.cycles_l.Text = "TrainCycles:";
            // 
            // learnRate_l
            // 
            this.learnRate_l.AutoSize = true;
            this.learnRate_l.Location = new System.Drawing.Point(6, 71);
            this.learnRate_l.Name = "learnRate_l";
            this.learnRate_l.Size = new System.Drawing.Size(60, 13);
            this.learnRate_l.TabIndex = 29;
            this.learnRate_l.Text = "LearnRate:";
            // 
            // neruonCount_tb
            // 
            this.neruonCount_tb.Location = new System.Drawing.Point(90, 15);
            this.neruonCount_tb.Name = "neruonCount_tb";
            this.neruonCount_tb.Size = new System.Drawing.Size(48, 20);
            this.neruonCount_tb.TabIndex = 30;
            this.neruonCount_tb.Text = "128";
            // 
            // trainCycles_tb
            // 
            this.trainCycles_tb.Location = new System.Drawing.Point(90, 39);
            this.trainCycles_tb.Name = "trainCycles_tb";
            this.trainCycles_tb.Size = new System.Drawing.Size(48, 20);
            this.trainCycles_tb.TabIndex = 31;
            this.trainCycles_tb.Text = "5000";
            // 
            // learnRate_tb
            // 
            this.learnRate_tb.Location = new System.Drawing.Point(90, 64);
            this.learnRate_tb.Name = "learnRate_tb";
            this.learnRate_tb.Size = new System.Drawing.Size(48, 20);
            this.learnRate_tb.TabIndex = 32;
            this.learnRate_tb.Text = "0.25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "1 = Blink, 0 = !Blink";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Frequency Spectrum:";
            // 
            // openSample_button
            // 
            this.openSample_button.Location = new System.Drawing.Point(108, 16);
            this.openSample_button.Name = "openSample_button";
            this.openSample_button.Size = new System.Drawing.Size(50, 23);
            this.openSample_button.TabIndex = 36;
            this.openSample_button.Text = "Open Sample";
            this.openSample_button.UseVisualStyleBackColor = true;
            this.openSample_button.Click += new System.EventHandler(this.openSample_button_Click);
            // 
            // sname_tb
            // 
            this.sname_tb.Location = new System.Drawing.Point(86, 64);
            this.sname_tb.Name = "sname_tb";
            this.sname_tb.Size = new System.Drawing.Size(68, 20);
            this.sname_tb.TabIndex = 37;
            // 
            // sam_name
            // 
            this.sam_name.AutoSize = true;
            this.sam_name.Location = new System.Drawing.Point(7, 68);
            this.sam_name.Name = "sam_name";
            this.sam_name.Size = new System.Drawing.Size(73, 13);
            this.sam_name.TabIndex = 38;
            this.sam_name.Text = "Sample Name";
            // 
            // savemode_cb
            // 
            this.savemode_cb.AutoSize = true;
            this.savemode_cb.Location = new System.Drawing.Point(87, 45);
            this.savemode_cb.Name = "savemode_cb";
            this.savemode_cb.Size = new System.Drawing.Size(15, 14);
            this.savemode_cb.TabIndex = 39;
            this.savemode_cb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savemode_cb.UseVisualStyleBackColor = true;
            // 
            // number_tb
            // 
            this.number_tb.Location = new System.Drawing.Point(86, 90);
            this.number_tb.Name = "number_tb";
            this.number_tb.Size = new System.Drawing.Size(68, 20);
            this.number_tb.TabIndex = 40;
            this.number_tb.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Start Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Save Sample";
            // 
            // inputType_cb
            // 
            this.inputType_cb.AutoSize = true;
            this.inputType_cb.Location = new System.Drawing.Point(9, 87);
            this.inputType_cb.Name = "inputType_cb";
            this.inputType_cb.Size = new System.Drawing.Size(121, 17);
            this.inputType_cb.TabIndex = 44;
            this.inputType_cb.Text = "(on) FFT | (off) RAW";
            this.inputType_cb.UseVisualStyleBackColor = true;
            this.inputType_cb.CheckedChanged += new System.EventHandler(this.inputType_cb_CheckedChanged);
            // 
            // blink_scenario_button
            // 
            this.blink_scenario_button.Location = new System.Drawing.Point(7, 16);
            this.blink_scenario_button.Name = "blink_scenario_button";
            this.blink_scenario_button.Size = new System.Drawing.Size(94, 23);
            this.blink_scenario_button.TabIndex = 45;
            this.blink_scenario_button.Text = "Blink";
            this.blink_scenario_button.UseVisualStyleBackColor = true;
            this.blink_scenario_button.Click += new System.EventHandler(this.blink_scenario_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "Generic";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.generic_scenario_button_Click);
            // 
            // gbNeuralSetup
            // 
            this.gbNeuralSetup.Controls.Add(this.adv_sett_button);
            this.gbNeuralSetup.Controls.Add(this.nc_l2);
            this.gbNeuralSetup.Controls.Add(this.progressBar);
            this.gbNeuralSetup.Controls.Add(this.trainNN_button);
            this.gbNeuralSetup.Controls.Add(this.nc_l);
            this.gbNeuralSetup.Controls.Add(this.inputType_cb);
            this.gbNeuralSetup.Controls.Add(this.cycles_l);
            this.gbNeuralSetup.Controls.Add(this.learnRate_l);
            this.gbNeuralSetup.Controls.Add(this.neruonCount_tb);
            this.gbNeuralSetup.Controls.Add(this.trainCycles_tb);
            this.gbNeuralSetup.Controls.Add(this.learnRate_tb);
            this.gbNeuralSetup.Location = new System.Drawing.Point(222, 415);
            this.gbNeuralSetup.Name = "gbNeuralSetup";
            this.gbNeuralSetup.Size = new System.Drawing.Size(195, 164);
            this.gbNeuralSetup.TabIndex = 47;
            this.gbNeuralSetup.TabStop = false;
            this.gbNeuralSetup.Text = "Neural Network Setup";
            // 
            // adv_sett_button
            // 
            this.adv_sett_button.Location = new System.Drawing.Point(87, 106);
            this.adv_sett_button.Name = "adv_sett_button";
            this.adv_sett_button.Size = new System.Drawing.Size(104, 23);
            this.adv_sett_button.TabIndex = 46;
            this.adv_sett_button.Text = "Advance Settings";
            this.adv_sett_button.UseVisualStyleBackColor = true;
            this.adv_sett_button.Click += new System.EventHandler(this.adv_sett_button_Click);
            // 
            // nc_l2
            // 
            this.nc_l2.AutoSize = true;
            this.nc_l2.Location = new System.Drawing.Point(144, 21);
            this.nc_l2.Name = "nc_l2";
            this.nc_l2.Size = new System.Drawing.Size(47, 13);
            this.nc_l2.TabIndex = 45;
            this.nc_l2.Text = "Neurons";
            // 
            // gbNeuralTest
            // 
            this.gbNeuralTest.Controls.Add(this.stat_button);
            this.gbNeuralTest.Controls.Add(this.corr_res_lb);
            this.gbNeuralTest.Controls.Add(this.test_set_button);
            this.gbNeuralTest.Controls.Add(this.testBlink_button);
            this.gbNeuralTest.Controls.Add(this.testNoBlink_button);
            this.gbNeuralTest.Controls.Add(this.test_sample);
            this.gbNeuralTest.Controls.Add(this.label2);
            this.gbNeuralTest.Controls.Add(this.train_result);
            this.gbNeuralTest.Location = new System.Drawing.Point(419, 415);
            this.gbNeuralTest.Name = "gbNeuralTest";
            this.gbNeuralTest.Size = new System.Drawing.Size(157, 164);
            this.gbNeuralTest.TabIndex = 48;
            this.gbNeuralTest.TabStop = false;
            this.gbNeuralTest.Text = "Neural Network Testing";
            // 
            // stat_button
            // 
            this.stat_button.Location = new System.Drawing.Point(90, 74);
            this.stat_button.Name = "stat_button";
            this.stat_button.Size = new System.Drawing.Size(50, 23);
            this.stat_button.TabIndex = 36;
            this.stat_button.Text = "Stat";
            this.stat_button.UseVisualStyleBackColor = true;
            this.stat_button.Click += new System.EventHandler(this.stat_button_Click);
            // 
            // corr_res_lb
            // 
            this.corr_res_lb.AutoSize = true;
            this.corr_res_lb.Location = new System.Drawing.Point(87, 50);
            this.corr_res_lb.Name = "corr_res_lb";
            this.corr_res_lb.Size = new System.Drawing.Size(63, 13);
            this.corr_res_lb.TabIndex = 35;
            this.corr_res_lb.Text = "Correctness";
            // 
            // test_set_button
            // 
            this.test_set_button.Location = new System.Drawing.Point(87, 16);
            this.test_set_button.Name = "test_set_button";
            this.test_set_button.Size = new System.Drawing.Size(64, 23);
            this.test_set_button.TabIndex = 34;
            this.test_set_button.Text = "Test Set";
            this.test_set_button.UseVisualStyleBackColor = true;
            this.test_set_button.Click += new System.EventHandler(this.test_set_button_Click);
            // 
            // gbSampleView
            // 
            this.gbSampleView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbSampleView.Controls.Add(this.gamma2_lb);
            this.gbSampleView.Controls.Add(this.gamma1_lb);
            this.gbSampleView.Controls.Add(this.beta2_lb);
            this.gbSampleView.Controls.Add(this.beta1_lb);
            this.gbSampleView.Controls.Add(this.alpha2_lb);
            this.gbSampleView.Controls.Add(this.alpha1_lb);
            this.gbSampleView.Controls.Add(this.dom_fre);
            this.gbSampleView.Controls.Add(this.delta_l);
            this.gbSampleView.Controls.Add(this.samplePanel);
            this.gbSampleView.Controls.Add(this.total_l);
            this.gbSampleView.Controls.Add(this.Gamma_l);
            this.gbSampleView.Controls.Add(this.theta_l);
            this.gbSampleView.Controls.Add(this.beta_l);
            this.gbSampleView.Controls.Add(this.fftPanel);
            this.gbSampleView.Controls.Add(this.alpha_l);
            this.gbSampleView.Controls.Add(this.label4);
            this.gbSampleView.Location = new System.Drawing.Point(582, 27);
            this.gbSampleView.Name = "gbSampleView";
            this.gbSampleView.Size = new System.Drawing.Size(256, 382);
            this.gbSampleView.TabIndex = 49;
            this.gbSampleView.TabStop = false;
            this.gbSampleView.Text = "Sample View";
            // 
            // gamma2_lb
            // 
            this.gamma2_lb.AutoSize = true;
            this.gamma2_lb.Location = new System.Drawing.Point(14, 169);
            this.gamma2_lb.Name = "gamma2_lb";
            this.gamma2_lb.Size = new System.Drawing.Size(52, 13);
            this.gamma2_lb.TabIndex = 41;
            this.gamma2_lb.Text = "Gamma 2";
            // 
            // gamma1_lb
            // 
            this.gamma1_lb.AutoSize = true;
            this.gamma1_lb.Location = new System.Drawing.Point(14, 156);
            this.gamma1_lb.Name = "gamma1_lb";
            this.gamma1_lb.Size = new System.Drawing.Size(52, 13);
            this.gamma1_lb.TabIndex = 40;
            this.gamma1_lb.Text = "Gamma 1";
            // 
            // beta2_lb
            // 
            this.beta2_lb.AutoSize = true;
            this.beta2_lb.Location = new System.Drawing.Point(14, 132);
            this.beta2_lb.Name = "beta2_lb";
            this.beta2_lb.Size = new System.Drawing.Size(38, 13);
            this.beta2_lb.TabIndex = 39;
            this.beta2_lb.Text = "Beta 2";
            // 
            // beta1_lb
            // 
            this.beta1_lb.AutoSize = true;
            this.beta1_lb.Location = new System.Drawing.Point(15, 119);
            this.beta1_lb.Name = "beta1_lb";
            this.beta1_lb.Size = new System.Drawing.Size(38, 13);
            this.beta1_lb.TabIndex = 38;
            this.beta1_lb.Text = "Beta 1";
            // 
            // alpha2_lb
            // 
            this.alpha2_lb.AutoSize = true;
            this.alpha2_lb.Location = new System.Drawing.Point(15, 92);
            this.alpha2_lb.Name = "alpha2_lb";
            this.alpha2_lb.Size = new System.Drawing.Size(43, 13);
            this.alpha2_lb.TabIndex = 37;
            this.alpha2_lb.Text = "Alpha 2";
            // 
            // alpha1_lb
            // 
            this.alpha1_lb.AutoSize = true;
            this.alpha1_lb.Location = new System.Drawing.Point(15, 79);
            this.alpha1_lb.Name = "alpha1_lb";
            this.alpha1_lb.Size = new System.Drawing.Size(43, 13);
            this.alpha1_lb.TabIndex = 36;
            this.alpha1_lb.Text = "Alpha 1";
            // 
            // gbTestScenario
            // 
            this.gbTestScenario.Controls.Add(this.snake_button);
            this.gbTestScenario.Controls.Add(this.blink_scenario_button);
            this.gbTestScenario.Controls.Add(this.button2);
            this.gbTestScenario.Location = new System.Drawing.Point(12, 415);
            this.gbTestScenario.Name = "gbTestScenario";
            this.gbTestScenario.Size = new System.Drawing.Size(200, 164);
            this.gbTestScenario.TabIndex = 50;
            this.gbTestScenario.TabStop = false;
            this.gbTestScenario.Text = "Test Scenarioes";
            // 
            // snake_button
            // 
            this.snake_button.Location = new System.Drawing.Point(6, 135);
            this.snake_button.Name = "snake_button";
            this.snake_button.Size = new System.Drawing.Size(98, 23);
            this.snake_button.TabIndex = 47;
            this.snake_button.Text = "Snake";
            this.snake_button.UseVisualStyleBackColor = true;
            this.snake_button.Click += new System.EventHandler(this.snake_button_Click);
            // 
            // gbMindControl
            // 
            this.gbMindControl.Controls.Add(this.label1);
            this.gbMindControl.Controls.Add(this.cboPort);
            this.gbMindControl.Controls.Add(this.btnConnect);
            this.gbMindControl.Controls.Add(this.btnDisconnect);
            this.gbMindControl.Controls.Add(this.lblAttention);
            this.gbMindControl.Controls.Add(this.rawEEGpanel);
            this.gbMindControl.Controls.Add(this.btnEnableBlink);
            this.gbMindControl.Controls.Add(this.txtState);
            this.gbMindControl.Controls.Add(this.lblMeditation);
            this.gbMindControl.Controls.Add(this.btnDisableBlink);
            this.gbMindControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMindControl.Location = new System.Drawing.Point(12, 27);
            this.gbMindControl.Name = "gbMindControl";
            this.gbMindControl.Size = new System.Drawing.Size(564, 382);
            this.gbMindControl.TabIndex = 51;
            this.gbMindControl.TabStop = false;
            this.gbMindControl.Text = "Mindset Control";
            // 
            // gbSampleControl
            // 
            this.gbSampleControl.Controls.Add(this.test_hz_button);
            this.gbSampleControl.Controls.Add(this.filter_cb);
            this.gbSampleControl.Controls.Add(this.filter_button);
            this.gbSampleControl.Controls.Add(this.graph_it_button);
            this.gbSampleControl.Controls.Add(this.choose_folder);
            this.gbSampleControl.Controls.Add(this.open_track_button);
            this.gbSampleControl.Controls.Add(this.stop_button);
            this.gbSampleControl.Controls.Add(this.track_button);
            this.gbSampleControl.Controls.Add(this.label6);
            this.gbSampleControl.Controls.Add(this.label5);
            this.gbSampleControl.Controls.Add(this.number_tb);
            this.gbSampleControl.Controls.Add(this.savemode_cb);
            this.gbSampleControl.Controls.Add(this.sname_tb);
            this.gbSampleControl.Controls.Add(this.sam_name);
            this.gbSampleControl.Controls.Add(this.openSample_button);
            this.gbSampleControl.Controls.Add(this.sample_button);
            this.gbSampleControl.Location = new System.Drawing.Point(582, 415);
            this.gbSampleControl.Name = "gbSampleControl";
            this.gbSampleControl.Size = new System.Drawing.Size(256, 164);
            this.gbSampleControl.TabIndex = 10;
            this.gbSampleControl.TabStop = false;
            this.gbSampleControl.Text = "Sample Control";
            // 
            // test_hz_button
            // 
            this.test_hz_button.Location = new System.Drawing.Point(7, 110);
            this.test_hz_button.Name = "test_hz_button";
            this.test_hz_button.Size = new System.Drawing.Size(70, 23);
            this.test_hz_button.TabIndex = 50;
            this.test_hz_button.Text = "Test 10Hz";
            this.test_hz_button.UseVisualStyleBackColor = true;
            this.test_hz_button.Click += new System.EventHandler(this.test_hz_button_Click);
            // 
            // filter_cb
            // 
            this.filter_cb.AutoSize = true;
            this.filter_cb.Location = new System.Drawing.Point(164, 95);
            this.filter_cb.Name = "filter_cb";
            this.filter_cb.Size = new System.Drawing.Size(70, 17);
            this.filter_cb.TabIndex = 49;
            this.filter_cb.Text = "AutoFilter";
            this.filter_cb.UseVisualStyleBackColor = true;
            // 
            // filter_button
            // 
            this.filter_button.Location = new System.Drawing.Point(164, 66);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(75, 23);
            this.filter_button.TabIndex = 48;
            this.filter_button.Text = "Filter";
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // graph_it_button
            // 
            this.graph_it_button.Location = new System.Drawing.Point(164, 40);
            this.graph_it_button.Name = "graph_it_button";
            this.graph_it_button.Size = new System.Drawing.Size(75, 23);
            this.graph_it_button.TabIndex = 47;
            this.graph_it_button.Text = "Graph it";
            this.graph_it_button.UseVisualStyleBackColor = true;
            this.graph_it_button.Click += new System.EventHandler(this.graph_it_button_Click);
            // 
            // choose_folder
            // 
            this.choose_folder.Location = new System.Drawing.Point(164, 16);
            this.choose_folder.Name = "choose_folder";
            this.choose_folder.Size = new System.Drawing.Size(75, 23);
            this.choose_folder.TabIndex = 46;
            this.choose_folder.Text = "Save Dir";
            this.choose_folder.UseVisualStyleBackColor = true;
            this.choose_folder.Click += new System.EventHandler(this.choose_folder_Click);
            // 
            // open_track_button
            // 
            this.open_track_button.Location = new System.Drawing.Point(164, 135);
            this.open_track_button.Name = "open_track_button";
            this.open_track_button.Size = new System.Drawing.Size(75, 23);
            this.open_track_button.TabIndex = 45;
            this.open_track_button.Text = "Open Track";
            this.open_track_button.UseVisualStyleBackColor = true;
            this.open_track_button.Click += new System.EventHandler(this.open_track_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Enabled = false;
            this.stop_button.Location = new System.Drawing.Point(83, 135);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 44;
            this.stop_button.Text = "Stop Track";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // track_button
            // 
            this.track_button.Location = new System.Drawing.Point(7, 135);
            this.track_button.Name = "track_button";
            this.track_button.Size = new System.Drawing.Size(69, 23);
            this.track_button.TabIndex = 43;
            this.track_button.Text = "Start Track";
            this.track_button.UseVisualStyleBackColor = true;
            this.track_button.Click += new System.EventHandler(this.track_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Enabled = false;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Enabled = false;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 585);
            this.Controls.Add(this.gbSampleControl);
            this.Controls.Add(this.gbMindControl);
            this.Controls.Add(this.gbTestScenario);
            this.Controls.Add(this.gbSampleView);
            this.Controls.Add(this.gbNeuralTest);
            this.Controls.Add(this.gbNeuralSetup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brain Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbNeuralSetup.ResumeLayout(false);
            this.gbNeuralSetup.PerformLayout();
            this.gbNeuralTest.ResumeLayout(false);
            this.gbNeuralTest.PerformLayout();
            this.gbSampleView.ResumeLayout(false);
            this.gbSampleView.PerformLayout();
            this.gbTestScenario.ResumeLayout(false);
            this.gbMindControl.ResumeLayout(false);
            this.gbMindControl.PerformLayout();
            this.gbSampleControl.ResumeLayout(false);
            this.gbSampleControl.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboPort;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Label lblAttention;
		private System.Windows.Forms.Label lblMeditation;
		private System.Windows.Forms.Button btnEnableBlink;
        private System.Windows.Forms.Button btnDisableBlink;
        private System.Windows.Forms.Panel rawEEGpanel;
        private System.Windows.Forms.Button sample_button;
        private System.Windows.Forms.Panel samplePanel;
        private System.Windows.Forms.Panel fftPanel;
        private System.Windows.Forms.Label total_l;
        private System.Windows.Forms.Label delta_l;
        private System.Windows.Forms.Label theta_l;
        private System.Windows.Forms.Label alpha_l;
        private System.Windows.Forms.Label beta_l;
        private System.Windows.Forms.Label Gamma_l;
        private System.Windows.Forms.Label dom_fre;
        private System.Windows.Forms.Button trainNN_button;
        private System.Windows.Forms.Button testBlink_button;
        private System.Windows.Forms.Label train_result;
        private System.Windows.Forms.Button testNoBlink_button;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button test_sample;
        private System.Windows.Forms.Label nc_l;
        private System.Windows.Forms.Label cycles_l;
        private System.Windows.Forms.Label learnRate_l;
        private System.Windows.Forms.TextBox neruonCount_tb;
        private System.Windows.Forms.TextBox trainCycles_tb;
        private System.Windows.Forms.TextBox learnRate_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button openSample_button;
        public System.Windows.Forms.TextBox sname_tb;
        private System.Windows.Forms.Label sam_name;
        public System.Windows.Forms.CheckBox savemode_cb;
        public System.Windows.Forms.TextBox number_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox inputType_cb;
        private System.Windows.Forms.Button blink_scenario_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbNeuralSetup;
        private System.Windows.Forms.GroupBox gbNeuralTest;
        private System.Windows.Forms.GroupBox gbSampleView;
        private System.Windows.Forms.GroupBox gbTestScenario;
        private System.Windows.Forms.GroupBox gbMindControl;
        private System.Windows.Forms.GroupBox gbSampleControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label nc_l2;
        private System.Windows.Forms.Button adv_sett_button;
        private System.Windows.Forms.Button track_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button open_track_button;
        private System.Windows.Forms.Button choose_folder;
        private System.Windows.Forms.Button test_set_button;
        private System.Windows.Forms.Label corr_res_lb;
        private System.Windows.Forms.Button snake_button;
        private System.Windows.Forms.Button graph_it_button;
        private System.Windows.Forms.Button filter_button;
        public System.Windows.Forms.CheckBox filter_cb;
        private System.Windows.Forms.Button test_hz_button;
        private System.Windows.Forms.Label gamma2_lb;
        private System.Windows.Forms.Label gamma1_lb;
        private System.Windows.Forms.Label beta2_lb;
        private System.Windows.Forms.Label beta1_lb;
        private System.Windows.Forms.Label alpha2_lb;
        private System.Windows.Forms.Label alpha1_lb;
        private System.Windows.Forms.Button stat_button;
	}
}

