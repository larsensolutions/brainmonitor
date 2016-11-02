namespace BrainMonitor
{
    partial class AttentionGraph
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.avg_att_lev_lb = new System.Windows.Forms.Label();
            this.avg_meditation_lb = new System.Windows.Forms.Label();
            this.avg_med_lev_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 29);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(732, 428);
            this.zedGraphControl1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Average Attention Level:";
            // 
            // avg_att_lev_lb
            // 
            this.avg_att_lev_lb.AutoSize = true;
            this.avg_att_lev_lb.Location = new System.Drawing.Point(141, 464);
            this.avg_att_lev_lb.Name = "avg_att_lev_lb";
            this.avg_att_lev_lb.Size = new System.Drawing.Size(13, 13);
            this.avg_att_lev_lb.TabIndex = 3;
            this.avg_att_lev_lb.Text = "..";
            // 
            // avg_meditation_lb
            // 
            this.avg_meditation_lb.AutoSize = true;
            this.avg_meditation_lb.Location = new System.Drawing.Point(195, 464);
            this.avg_meditation_lb.Name = "avg_meditation_lb";
            this.avg_meditation_lb.Size = new System.Drawing.Size(131, 13);
            this.avg_meditation_lb.TabIndex = 5;
            this.avg_meditation_lb.Text = "Average Meditation Level:";
            // 
            // avg_med_lev_lb
            // 
            this.avg_med_lev_lb.AutoSize = true;
            this.avg_med_lev_lb.Location = new System.Drawing.Point(332, 464);
            this.avg_med_lev_lb.Name = "avg_med_lev_lb";
            this.avg_med_lev_lb.Size = new System.Drawing.Size(13, 13);
            this.avg_med_lev_lb.TabIndex = 6;
            this.avg_med_lev_lb.Text = "..";
            // 
            // AttentionGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 536);
            this.Controls.Add(this.avg_med_lev_lb);
            this.Controls.Add(this.avg_meditation_lb);
            this.Controls.Add(this.avg_att_lev_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "AttentionGraph";
            this.Text = "Session Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label avg_att_lev_lb;
        private System.Windows.Forms.Label avg_meditation_lb;
        private System.Windows.Forms.Label avg_med_lev_lb;
    }
}