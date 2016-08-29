namespace Grundforlobsprove
{
    partial class Form1
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
            this.ipAd01 = new System.Windows.Forms.TextBox();
            this.ipAd02 = new System.Windows.Forms.TextBox();
            this.ipAd03 = new System.Windows.Forms.TextBox();
            this.ipAd04 = new System.Windows.Forms.TextBox();
            this.subMa01 = new System.Windows.Forms.TextBox();
            this.subMa02 = new System.Windows.Forms.TextBox();
            this.subMa03 = new System.Windows.Forms.TextBox();
            this.subMa04 = new System.Windows.Forms.TextBox();
            this.slashNotation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.netAddShow = new System.Windows.Forms.Label();
            this.broadAddShow = new System.Windows.Forms.Label();
            this.subMaskShow = new System.Windows.Forms.Label();
            this.useAddShow = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipAd01
            // 
            this.ipAd01.Location = new System.Drawing.Point(13, 13);
            this.ipAd01.Name = "ipAd01";
            this.ipAd01.Size = new System.Drawing.Size(25, 20);
            this.ipAd01.TabIndex = 0;
            this.ipAd01.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ipAd02
            // 
            this.ipAd02.Location = new System.Drawing.Point(44, 13);
            this.ipAd02.Name = "ipAd02";
            this.ipAd02.Size = new System.Drawing.Size(25, 20);
            this.ipAd02.TabIndex = 1;
            this.ipAd02.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ipAd03
            // 
            this.ipAd03.Location = new System.Drawing.Point(75, 13);
            this.ipAd03.Name = "ipAd03";
            this.ipAd03.Size = new System.Drawing.Size(25, 20);
            this.ipAd03.TabIndex = 2;
            this.ipAd03.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ipAd04
            // 
            this.ipAd04.Location = new System.Drawing.Point(106, 13);
            this.ipAd04.Name = "ipAd04";
            this.ipAd04.Size = new System.Drawing.Size(25, 20);
            this.ipAd04.TabIndex = 3;
            this.ipAd04.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // subMa01
            // 
            this.subMa01.Enabled = false;
            this.subMa01.Location = new System.Drawing.Point(13, 39);
            this.subMa01.Name = "subMa01";
            this.subMa01.Size = new System.Drawing.Size(25, 20);
            this.subMa01.TabIndex = 4;
            this.subMa01.Text = "255";
            // 
            // subMa02
            // 
            this.subMa02.Location = new System.Drawing.Point(44, 39);
            this.subMa02.Name = "subMa02";
            this.subMa02.Size = new System.Drawing.Size(25, 20);
            this.subMa02.TabIndex = 5;
            this.subMa02.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // subMa03
            // 
            this.subMa03.Location = new System.Drawing.Point(75, 39);
            this.subMa03.Name = "subMa03";
            this.subMa03.Size = new System.Drawing.Size(25, 20);
            this.subMa03.TabIndex = 6;
            this.subMa03.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // subMa04
            // 
            this.subMa04.Location = new System.Drawing.Point(106, 39);
            this.subMa04.Name = "subMa04";
            this.subMa04.Size = new System.Drawing.Size(25, 20);
            this.subMa04.TabIndex = 7;
            this.subMa04.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // slashNotation
            // 
            this.slashNotation.Location = new System.Drawing.Point(155, 13);
            this.slashNotation.Name = "slashNotation";
            this.slashNotation.Size = new System.Drawing.Size(25, 20);
            this.slashNotation.TabIndex = 8;
            this.slashNotation.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "/";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(260, 12);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 10;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Network address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Broadcast address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Subnet mask";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Useable addresses";
            // 
            // netAddShow
            // 
            this.netAddShow.AutoSize = true;
            this.netAddShow.Location = new System.Drawing.Point(117, 66);
            this.netAddShow.Name = "netAddShow";
            this.netAddShow.Size = new System.Drawing.Size(35, 13);
            this.netAddShow.TabIndex = 15;
            this.netAddShow.Text = "label6";
            // 
            // broadAddShow
            // 
            this.broadAddShow.AutoSize = true;
            this.broadAddShow.Location = new System.Drawing.Point(117, 83);
            this.broadAddShow.Name = "broadAddShow";
            this.broadAddShow.Size = new System.Drawing.Size(35, 13);
            this.broadAddShow.TabIndex = 16;
            this.broadAddShow.Text = "label7";
            // 
            // subMaskShow
            // 
            this.subMaskShow.AutoSize = true;
            this.subMaskShow.Location = new System.Drawing.Point(117, 100);
            this.subMaskShow.Name = "subMaskShow";
            this.subMaskShow.Size = new System.Drawing.Size(35, 13);
            this.subMaskShow.TabIndex = 17;
            this.subMaskShow.Text = "label8";
            // 
            // useAddShow
            // 
            this.useAddShow.AutoSize = true;
            this.useAddShow.Location = new System.Drawing.Point(117, 117);
            this.useAddShow.Name = "useAddShow";
            this.useAddShow.Size = new System.Drawing.Size(35, 13);
            this.useAddShow.TabIndex = 18;
            this.useAddShow.Text = "label9";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(260, 41);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 19;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 262);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.useAddShow);
            this.Controls.Add(this.subMaskShow);
            this.Controls.Add(this.broadAddShow);
            this.Controls.Add(this.netAddShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slashNotation);
            this.Controls.Add(this.subMa04);
            this.Controls.Add(this.subMa03);
            this.Controls.Add(this.subMa02);
            this.Controls.Add(this.subMa01);
            this.Controls.Add(this.ipAd04);
            this.Controls.Add(this.ipAd03);
            this.Controls.Add(this.ipAd02);
            this.Controls.Add(this.ipAd01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipAd01;
        private System.Windows.Forms.TextBox ipAd02;
        private System.Windows.Forms.TextBox ipAd03;
        private System.Windows.Forms.TextBox ipAd04;
        private System.Windows.Forms.TextBox subMa01;
        private System.Windows.Forms.TextBox subMa02;
        private System.Windows.Forms.TextBox subMa03;
        private System.Windows.Forms.TextBox subMa04;
        private System.Windows.Forms.TextBox slashNotation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label netAddShow;
        private System.Windows.Forms.Label broadAddShow;
        private System.Windows.Forms.Label subMaskShow;
        private System.Windows.Forms.Label useAddShow;
        private System.Windows.Forms.Button Cancel;
    }
}

