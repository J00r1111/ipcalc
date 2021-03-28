
namespace IPCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IPTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaskTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.networkAdressTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BroadcastTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ipOctet1 = new System.Windows.Forms.NumericUpDown();
            this.ipOctet2 = new System.Windows.Forms.NumericUpDown();
            this.ipOctet3 = new System.Windows.Forms.NumericUpDown();
            this.ipOctet4 = new System.Windows.Forms.NumericUpDown();
            this.first = new System.Windows.Forms.MaskedTextBox();
            this.last = new System.Windows.Forms.MaskedTextBox();
            this.firstlabel = new System.Windows.Forms.Label();
            this.lastlabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cidrTexBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidrTexBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IPTextBox1
            // 
            this.IPTextBox1.Location = new System.Drawing.Point(397, 104);
            this.IPTextBox1.Mask = "###\\.###\\.###\\.###";
            this.IPTextBox1.Name = "IPTextBox1";
            this.IPTextBox1.Size = new System.Drawing.Size(100, 23);
            this.IPTextBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adres IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maska:";
            // 
            // MaskTextBox1
            // 
            this.MaskTextBox1.Location = new System.Drawing.Point(397, 137);
            this.MaskTextBox1.Mask = "###\\.###\\.###\\.###";
            this.MaskTextBox1.Name = "MaskTextBox1";
            this.MaskTextBox1.Size = new System.Drawing.Size(100, 23);
            this.MaskTextBox1.TabIndex = 2;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(362, 320);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Policz";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateIP);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres sieci:";
            // 
            // networkAdressTextBox
            // 
            this.networkAdressTextBox.Location = new System.Drawing.Point(397, 173);
            this.networkAdressTextBox.Mask = "###\\.###\\.###\\.###";
            this.networkAdressTextBox.Name = "networkAdressTextBox";
            this.networkAdressTextBox.ReadOnly = true;
            this.networkAdressTextBox.Size = new System.Drawing.Size(100, 23);
            this.networkAdressTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adres rozgłoszeniowy:";
            // 
            // BroadcastTextBox
            // 
            this.BroadcastTextBox.Location = new System.Drawing.Point(397, 202);
            this.BroadcastTextBox.Mask = "###\\.###\\.###\\.###";
            this.BroadcastTextBox.Name = "BroadcastTextBox";
            this.BroadcastTextBox.ReadOnly = true;
            this.BroadcastTextBox.Size = new System.Drawing.Size(100, 23);
            this.BroadcastTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adres IP:";
            // 
            // ipOctet1
            // 
            this.ipOctet1.Location = new System.Drawing.Point(201, 25);
            this.ipOctet1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet1.Name = "ipOctet1";
            this.ipOctet1.Size = new System.Drawing.Size(43, 23);
            this.ipOctet1.TabIndex = 10;
            this.ipOctet1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // ipOctet2
            // 
            this.ipOctet2.Location = new System.Drawing.Point(250, 25);
            this.ipOctet2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet2.Name = "ipOctet2";
            this.ipOctet2.Size = new System.Drawing.Size(43, 23);
            this.ipOctet2.TabIndex = 11;
            this.ipOctet2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // ipOctet3
            // 
            this.ipOctet3.Location = new System.Drawing.Point(299, 25);
            this.ipOctet3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet3.Name = "ipOctet3";
            this.ipOctet3.Size = new System.Drawing.Size(43, 23);
            this.ipOctet3.TabIndex = 12;
            this.ipOctet3.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // ipOctet4
            // 
            this.ipOctet4.Location = new System.Drawing.Point(348, 25);
            this.ipOctet4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet4.Name = "ipOctet4";
            this.ipOctet4.Size = new System.Drawing.Size(43, 23);
            this.ipOctet4.TabIndex = 13;
            this.ipOctet4.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(397, 231);
            this.first.Mask = "###\\.###\\.###\\.###";
            this.first.Name = "first";
            this.first.ReadOnly = true;
            this.first.Size = new System.Drawing.Size(100, 23);
            this.first.TabIndex = 14;
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(397, 260);
            this.last.Mask = "###\\.###\\.###\\.###";
            this.last.Name = "last";
            this.last.ReadOnly = true;
            this.last.Size = new System.Drawing.Size(100, 23);
            this.last.TabIndex = 15;
            // 
            // firstlabel
            // 
            this.firstlabel.AutoSize = true;
            this.firstlabel.Location = new System.Drawing.Point(260, 234);
            this.firstlabel.Name = "firstlabel";
            this.firstlabel.Size = new System.Drawing.Size(133, 15);
            this.firstlabel.TabIndex = 16;
            this.firstlabel.Text = "Pierwszy możliwy adres:";
            // 
            // lastlabel
            // 
            this.lastlabel.AutoSize = true;
            this.lastlabel.Location = new System.Drawing.Point(259, 263);
            this.lastlabel.Name = "lastlabel";
            this.lastlabel.Size = new System.Drawing.Size(126, 15);
            this.lastlabel.TabIndex = 17;
            this.lastlabel.Text = "Ostatni możliwy adres:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Maska:";
            // 
            // cidrTexBox
            // 
            this.cidrTexBox.Location = new System.Drawing.Point(476, 25);
            this.cidrTexBox.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.cidrTexBox.Name = "cidrTexBox";
            this.cidrTexBox.Size = new System.Drawing.Size(43, 23);
            this.cidrTexBox.TabIndex = 19;
            this.cidrTexBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "POLICZ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cidrTexBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lastlabel);
            this.Controls.Add(this.firstlabel);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Controls.Add(this.ipOctet4);
            this.Controls.Add(this.ipOctet3);
            this.Controls.Add(this.ipOctet2);
            this.Controls.Add(this.ipOctet1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BroadcastTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.networkAdressTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaskTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidrTexBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox IPTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MaskTextBox1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox networkAdressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox BroadcastTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ipOctet1;
        private System.Windows.Forms.NumericUpDown ipOctet2;
        private System.Windows.Forms.NumericUpDown ipOctet3;
        private System.Windows.Forms.NumericUpDown ipOctet4;
        private System.Windows.Forms.MaskedTextBox first;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label firstlabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown cidrTexBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lastlabel;
        private System.Windows.Forms.MaskedTextBox last;
    }
}

