namespace BrainMonitor
{
    partial class MotionGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotionGUI));
            this.scenario_Panel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.start_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.main_form_button = new System.Windows.Forms.Button();
            this.folder_select = new System.Windows.Forms.Button();
            this.att_graph = new System.Windows.Forms.Button();
            this.info_label = new System.Windows.Forms.Label();
            this.part1_tb = new System.Windows.Forms.TextBox();
            this.part2_tb = new System.Windows.Forms.TextBox();
            this.samples1_tb = new System.Windows.Forms.TextBox();
            this.samples2_tb = new System.Windows.Forms.TextBox();
            this.sample_lb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scenario_Panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scenario_Panel
            // 
            this.scenario_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scenario_Panel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.scenario_Panel.Controls.Add(this.pictureBox1);
            this.scenario_Panel.Location = new System.Drawing.Point(77, 41);
            this.scenario_Panel.Name = "scenario_Panel";
            this.scenario_Panel.Size = new System.Drawing.Size(538, 350);
            this.scenario_Panel.TabIndex = 6;
            this.scenario_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.scenario_Panel_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(349, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 150);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instuctions";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 125);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Controls.Add(this.sample_lb);
            this.groupBox1.Controls.Add(this.samples2_tb);
            this.groupBox1.Controls.Add(this.samples1_tb);
            this.groupBox1.Controls.Add(this.part2_tb);
            this.groupBox1.Controls.Add(this.part1_tb);
            this.groupBox1.Controls.Add(this.info_label);
            this.groupBox1.Controls.Add(this.att_graph);
            this.groupBox1.Controls.Add(this.folder_select);
            this.groupBox1.Controls.Add(this.start_button);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.main_form_button);
            this.groupBox1.Location = new System.Drawing.Point(77, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scenario Navigation";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(91, 123);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(172, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(6, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // main_form_button
            // 
            this.main_form_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.main_form_button.Location = new System.Drawing.Point(6, 19);
            this.main_form_button.Name = "main_form_button";
            this.main_form_button.Size = new System.Drawing.Size(75, 23);
            this.main_form_button.TabIndex = 0;
            this.main_form_button.Text = "Quit";
            this.main_form_button.UseVisualStyleBackColor = false;
            this.main_form_button.Click += new System.EventHandler(this.main_form_button_Click_1);
            // 
            // folder_select
            // 
            this.folder_select.Location = new System.Drawing.Point(130, 97);
            this.folder_select.Name = "folder_select";
            this.folder_select.Size = new System.Drawing.Size(117, 23);
            this.folder_select.TabIndex = 4;
            this.folder_select.Text = "Save Directory";
            this.folder_select.UseVisualStyleBackColor = true;
            this.folder_select.Click += new System.EventHandler(this.folder_select_Click);
            // 
            // att_graph
            // 
            this.att_graph.Enabled = false;
            this.att_graph.Location = new System.Drawing.Point(88, 20);
            this.att_graph.Name = "att_graph";
            this.att_graph.Size = new System.Drawing.Size(95, 23);
            this.att_graph.TabIndex = 5;
            this.att_graph.Text = "View Attention";
            this.att_graph.UseVisualStyleBackColor = true;
            this.att_graph.Click += new System.EventHandler(this.view_att_Click);
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(6, 52);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(121, 13);
            this.info_label.TabIndex = 6;
            this.info_label.Text = "Session name. Part 1 | 2";
            // 
            // part1_tb
            // 
            this.part1_tb.Location = new System.Drawing.Point(130, 49);
            this.part1_tb.Name = "part1_tb";
            this.part1_tb.Size = new System.Drawing.Size(53, 20);
            this.part1_tb.TabIndex = 7;
            // 
            // part2_tb
            // 
            this.part2_tb.Location = new System.Drawing.Point(190, 48);
            this.part2_tb.Name = "part2_tb";
            this.part2_tb.Size = new System.Drawing.Size(57, 20);
            this.part2_tb.TabIndex = 8;
            // 
            // samples1_tb
            // 
            this.samples1_tb.Location = new System.Drawing.Point(130, 71);
            this.samples1_tb.Name = "samples1_tb";
            this.samples1_tb.Size = new System.Drawing.Size(54, 20);
            this.samples1_tb.TabIndex = 9;
            // 
            // samples2_tb
            // 
            this.samples2_tb.Location = new System.Drawing.Point(189, 71);
            this.samples2_tb.Name = "samples2_tb";
            this.samples2_tb.Size = new System.Drawing.Size(57, 20);
            this.samples2_tb.TabIndex = 10;
            // 
            // sample_lb
            // 
            this.sample_lb.AutoSize = true;
            this.sample_lb.Location = new System.Drawing.Point(6, 74);
            this.sample_lb.Name = "sample_lb";
            this.sample_lb.Size = new System.Drawing.Size(124, 13);
            this.sample_lb.TabIndex = 11;
            this.sample_lb.Text = "SampleNumber Part 1 | 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 322);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MotionGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(692, 588);
            this.Controls.Add(this.scenario_Panel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MotionGUI";
            this.Text = "MotionGUI";
            this.scenario_Panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel scenario_Panel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button main_form_button;
        private System.Windows.Forms.TextBox part1_tb;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Button att_graph;
        private System.Windows.Forms.Button folder_select;
        private System.Windows.Forms.TextBox part2_tb;
        private System.Windows.Forms.Label sample_lb;
        private System.Windows.Forms.TextBox samples2_tb;
        private System.Windows.Forms.TextBox samples1_tb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}