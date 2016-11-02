namespace BrainMonitor
{
    partial class BlinkScenarioGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlinkScenarioGUI));
            this.main_form_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sessionName = new System.Windows.Forms.TextBox();
            this.att_graph = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.scenario_Panel = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.choose_folder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.main_form_button.Click += new System.EventHandler(this.main_form_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Controls.Add(this.choose_folder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sessionName);
            this.groupBox1.Controls.Add(this.att_graph);
            this.groupBox1.Controls.Add(this.start_button);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.main_form_button);
            this.groupBox1.Location = new System.Drawing.Point(151, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scenario Navigation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Session Name";
            // 
            // sessionName
            // 
            this.sessionName.Location = new System.Drawing.Point(87, 48);
            this.sessionName.Name = "sessionName";
            this.sessionName.Size = new System.Drawing.Size(75, 20);
            this.sessionName.TabIndex = 5;
            // 
            // att_graph
            // 
            this.att_graph.Enabled = false;
            this.att_graph.Location = new System.Drawing.Point(87, 19);
            this.att_graph.Name = "att_graph";
            this.att_graph.Size = new System.Drawing.Size(75, 23);
            this.att_graph.TabIndex = 4;
            this.att_graph.Text = "Attention Graph";
            this.att_graph.UseVisualStyleBackColor = true;
            this.att_graph.Click += new System.EventHandler(this.att_graph_Click);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(91, 119);
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
            this.button2.Location = new System.Drawing.Point(172, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(7, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(423, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 150);
            this.groupBox2.TabIndex = 2;
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
            // scenario_Panel
            // 
            this.scenario_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scenario_Panel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.scenario_Panel.Location = new System.Drawing.Point(151, 45);
            this.scenario_Panel.Name = "scenario_Panel";
            this.scenario_Panel.Size = new System.Drawing.Size(538, 350);
            this.scenario_Panel.TabIndex = 3;
            this.scenario_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.scenario_Panel_Paint);
            // 
            // choose_folder
            // 
            this.choose_folder.Location = new System.Drawing.Point(7, 71);
            this.choose_folder.Name = "choose_folder";
            this.choose_folder.Size = new System.Drawing.Size(155, 23);
            this.choose_folder.TabIndex = 7;
            this.choose_folder.Text = "Save Directory";
            this.choose_folder.UseVisualStyleBackColor = true;
            this.choose_folder.Click += new System.EventHandler(this.choose_folder_Click);
            // 
            // BlinkScenarioGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(822, 620);
            this.Controls.Add(this.scenario_Panel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "BlinkScenarioGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlinkScenarioGUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button main_form_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Panel scenario_Panel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button att_graph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sessionName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button choose_folder;
    }
}