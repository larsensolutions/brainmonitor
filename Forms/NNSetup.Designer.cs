namespace BrainMonitor
{
    partial class NNSetup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.inputLayer_cb = new System.Windows.Forms.ComboBox();
            this.hiddenLayer_cb = new System.Windows.Forms.ComboBox();
            this.outputLayer_cb = new System.Windows.Forms.ComboBox();
            this.cb = new System.Windows.Forms.CheckBox();
            this.quicksamples_cb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "InputLayer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HiddenLayer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "OutputLayer";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(245, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Neurons";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(205, 238);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 8;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(124, 238);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // inputLayer_cb
            // 
            this.inputLayer_cb.FormattingEnabled = true;
            this.inputLayer_cb.Items.AddRange(new object[] {
            "Linear",
            "Sigmoid",
            "Tanh"});
            this.inputLayer_cb.Location = new System.Drawing.Point(91, 1);
            this.inputLayer_cb.Name = "inputLayer_cb";
            this.inputLayer_cb.Size = new System.Drawing.Size(89, 21);
            this.inputLayer_cb.TabIndex = 10;
            this.inputLayer_cb.SelectedIndexChanged += new System.EventHandler(this.inputLayer_cb_SelectedIndexChanged);
            // 
            // hiddenLayer_cb
            // 
            this.hiddenLayer_cb.FormattingEnabled = true;
            this.hiddenLayer_cb.Items.AddRange(new object[] {
            "Sigmoid",
            "Tanh",
            "Linear"});
            this.hiddenLayer_cb.Location = new System.Drawing.Point(91, 28);
            this.hiddenLayer_cb.Name = "hiddenLayer_cb";
            this.hiddenLayer_cb.Size = new System.Drawing.Size(89, 21);
            this.hiddenLayer_cb.TabIndex = 11;
            this.hiddenLayer_cb.SelectedIndexChanged += new System.EventHandler(this.hiddenLayer_cb_SelectedIndexChanged);
            // 
            // outputLayer_cb
            // 
            this.outputLayer_cb.FormattingEnabled = true;
            this.outputLayer_cb.Items.AddRange(new object[] {
            "Sigmoid",
            "Tanh",
            "Linear"});
            this.outputLayer_cb.Location = new System.Drawing.Point(91, 55);
            this.outputLayer_cb.Name = "outputLayer_cb";
            this.outputLayer_cb.Size = new System.Drawing.Size(89, 21);
            this.outputLayer_cb.TabIndex = 12;
            this.outputLayer_cb.SelectedIndexChanged += new System.EventHandler(this.outputLayer_cb_SelectedIndexChanged);
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Location = new System.Drawing.Point(88, 98);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(136, 17);
            this.cb.TabIndex = 13;
            this.cb.Text = "8 input, spesific powers";
            this.cb.UseVisualStyleBackColor = true;
            // 
            // quicksamples_cb
            // 
            this.quicksamples_cb.AutoSize = true;
            this.quicksamples_cb.Location = new System.Drawing.Point(88, 122);
            this.quicksamples_cb.Name = "quicksamples_cb";
            this.quicksamples_cb.Size = new System.Drawing.Size(90, 17);
            this.quicksamples_cb.TabIndex = 14;
            this.quicksamples_cb.Text = "quicksamples";
            this.quicksamples_cb.UseVisualStyleBackColor = true;
            // 
            // NNSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.quicksamples_cb);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.outputLayer_cb);
            this.Controls.Add(this.hiddenLayer_cb);
            this.Controls.Add(this.inputLayer_cb);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NNSetup";
            this.Text = "NNSetup";
            this.Load += new System.EventHandler(this.NNSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ComboBox inputLayer_cb;
        private System.Windows.Forms.ComboBox hiddenLayer_cb;
        private System.Windows.Forms.ComboBox outputLayer_cb;
        public System.Windows.Forms.CheckBox cb;
        public System.Windows.Forms.CheckBox quicksamples_cb;
    }
}