namespace BrainMonitor
{
    partial class Snake
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
            this.gameView_panel = new System.Windows.Forms.Panel();
            this.lb = new System.Windows.Forms.Label();
            this.go_panel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.teller = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameView_panel
            // 
            this.gameView_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameView_panel.BackColor = System.Drawing.SystemColors.ControlText;
            this.gameView_panel.Location = new System.Drawing.Point(12, 59);
            this.gameView_panel.Name = "gameView_panel";
            this.gameView_panel.Size = new System.Drawing.Size(756, 537);
            this.gameView_panel.TabIndex = 0;
            this.gameView_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.gameView_panel_Paint);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(12, 599);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(35, 13);
            this.lb.TabIndex = 2;
            this.lb.Text = "label1";
            // 
            // go_panel
            // 
            this.go_panel.BackColor = System.Drawing.Color.Red;
            this.go_panel.Location = new System.Drawing.Point(339, 12);
            this.go_panel.Name = "go_panel";
            this.go_panel.Size = new System.Drawing.Size(49, 28);
            this.go_panel.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Green light - Focus on next instruction";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(394, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(374, 28);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Baseline task to turn RIGHT. Mental count tast to turn LEFT";
            // 
            // teller
            // 
            this.teller.AutoSize = true;
            this.teller.Location = new System.Drawing.Point(12, 40);
            this.teller.Name = "teller";
            this.teller.Size = new System.Drawing.Size(32, 13);
            this.teller.TabIndex = 6;
            this.teller.Text = "result";
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 650);
            this.Controls.Add(this.teller);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.go_panel);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.gameView_panel);
            this.KeyPreview = true;
            this.Name = "Snake";
            this.Text = "Snake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameView_panel;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Panel go_panel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label teller;
    }
}