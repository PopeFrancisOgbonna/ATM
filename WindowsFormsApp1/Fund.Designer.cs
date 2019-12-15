namespace WindowsFormsApp1
{
    partial class Fund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fund));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkFidelity = new System.Windows.Forms.CheckBox();
            this.chkZenith = new System.Windows.Forms.CheckBox();
            this.chkUnion = new System.Windows.Forms.CheckBox();
            this.chkDiamond = new System.Windows.Forms.CheckBox();
            this.chkUba = new System.Windows.Forms.CheckBox();
            this.chkfirst = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOk2 = new System.Windows.Forms.Button();
            this.btnFundClear = new System.Windows.Forms.Button();
            this.btnfundCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDisplay);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 638);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(558, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.White;
            this.lblDisplay.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(134, 346);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(401, 63);
            this.lblDisplay.TabIndex = 6;
            this.lblDisplay.Tag = "";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.chkFidelity);
            this.panel3.Controls.Add(this.chkZenith);
            this.panel3.Controls.Add(this.chkUnion);
            this.panel3.Controls.Add(this.chkDiamond);
            this.panel3.Controls.Add(this.chkUba);
            this.panel3.Controls.Add(this.chkfirst);
            this.panel3.Location = new System.Drawing.Point(134, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 229);
            this.panel3.TabIndex = 5;
            // 
            // chkFidelity
            // 
            this.chkFidelity.AutoSize = true;
            this.chkFidelity.BackColor = System.Drawing.Color.Transparent;
            this.chkFidelity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFidelity.ForeColor = System.Drawing.Color.DarkMagenta;
            this.chkFidelity.Location = new System.Drawing.Point(208, 176);
            this.chkFidelity.Name = "chkFidelity";
            this.chkFidelity.Size = new System.Drawing.Size(148, 28);
            this.chkFidelity.TabIndex = 5;
            this.chkFidelity.Text = "Fidelity Bank";
            this.chkFidelity.UseVisualStyleBackColor = false;
            this.chkFidelity.CheckedChanged += new System.EventHandler(this.ChkFidelity_CheckedChanged);
            // 
            // chkZenith
            // 
            this.chkZenith.AutoSize = true;
            this.chkZenith.BackColor = System.Drawing.Color.Transparent;
            this.chkZenith.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkZenith.ForeColor = System.Drawing.Color.DarkMagenta;
            this.chkZenith.Location = new System.Drawing.Point(208, 112);
            this.chkZenith.Name = "chkZenith";
            this.chkZenith.Size = new System.Drawing.Size(140, 28);
            this.chkZenith.TabIndex = 4;
            this.chkZenith.Text = "Zenith Bank";
            this.chkZenith.UseVisualStyleBackColor = false;
            this.chkZenith.CheckedChanged += new System.EventHandler(this.ChkZenith_CheckedChanged);
            // 
            // chkUnion
            // 
            this.chkUnion.AutoSize = true;
            this.chkUnion.BackColor = System.Drawing.Color.Transparent;
            this.chkUnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnion.ForeColor = System.Drawing.Color.DarkMagenta;
            this.chkUnion.Location = new System.Drawing.Point(208, 50);
            this.chkUnion.Name = "chkUnion";
            this.chkUnion.Size = new System.Drawing.Size(136, 28);
            this.chkUnion.TabIndex = 3;
            this.chkUnion.Text = "Union Bank";
            this.chkUnion.UseVisualStyleBackColor = false;
            this.chkUnion.CheckedChanged += new System.EventHandler(this.ChkUnion_CheckedChanged);
            // 
            // chkDiamond
            // 
            this.chkDiamond.AutoSize = true;
            this.chkDiamond.BackColor = System.Drawing.Color.Transparent;
            this.chkDiamond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiamond.ForeColor = System.Drawing.Color.DarkMagenta;
            this.chkDiamond.Location = new System.Drawing.Point(33, 112);
            this.chkDiamond.Name = "chkDiamond";
            this.chkDiamond.Size = new System.Drawing.Size(164, 28);
            this.chkDiamond.TabIndex = 2;
            this.chkDiamond.Text = "Diamond Bank";
            this.chkDiamond.UseVisualStyleBackColor = false;
            this.chkDiamond.CheckedChanged += new System.EventHandler(this.ChkDiamond_CheckedChanged);
            // 
            // chkUba
            // 
            this.chkUba.AutoSize = true;
            this.chkUba.BackColor = System.Drawing.Color.Transparent;
            this.chkUba.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUba.ForeColor = System.Drawing.Color.DarkMagenta;
            this.chkUba.Location = new System.Drawing.Point(33, 176);
            this.chkUba.Name = "chkUba";
            this.chkUba.Size = new System.Drawing.Size(122, 28);
            this.chkUba.TabIndex = 1;
            this.chkUba.Text = "UBA Bank";
            this.chkUba.UseVisualStyleBackColor = false;
            this.chkUba.CheckedChanged += new System.EventHandler(this.ChkUba_CheckedChanged);
            // 
            // chkfirst
            // 
            this.chkfirst.AutoSize = true;
            this.chkfirst.BackColor = System.Drawing.Color.Transparent;
            this.chkfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkfirst.ForeColor = System.Drawing.Color.DarkMagenta;
            this.chkfirst.Location = new System.Drawing.Point(33, 50);
            this.chkfirst.Name = "chkfirst";
            this.chkfirst.Size = new System.Drawing.Size(121, 28);
            this.chkfirst.TabIndex = 0;
            this.chkfirst.Text = "First Bank";
            this.chkfirst.UseVisualStyleBackColor = false;
            this.chkfirst.CheckedChanged += new System.EventHandler(this.Chkfirst_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOk2);
            this.panel2.Controls.Add(this.btnFundClear);
            this.panel2.Controls.Add(this.btnfundCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(160, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 199);
            this.panel2.TabIndex = 4;
            // 
            // btnOk2
            // 
            this.btnOk2.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk2.ForeColor = System.Drawing.Color.Transparent;
            this.btnOk2.Location = new System.Drawing.Point(245, 7);
            this.btnOk2.Name = "btnOk2";
            this.btnOk2.Size = new System.Drawing.Size(102, 58);
            this.btnOk2.TabIndex = 11;
            this.btnOk2.Text = "Ok";
            this.btnOk2.UseVisualStyleBackColor = false;
            this.btnOk2.Visible = false;
            this.btnOk2.Click += new System.EventHandler(this.BtnOk2_Click);
            // 
            // btnFundClear
            // 
            this.btnFundClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFundClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFundClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnFundClear.Location = new System.Drawing.Point(245, 135);
            this.btnFundClear.Name = "btnFundClear";
            this.btnFundClear.Size = new System.Drawing.Size(102, 58);
            this.btnFundClear.TabIndex = 10;
            this.btnFundClear.Text = "Clear";
            this.btnFundClear.UseVisualStyleBackColor = false;
            this.btnFundClear.Click += new System.EventHandler(this.BtnFundClear_Click);
            // 
            // btnfundCancel
            // 
            this.btnfundCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnfundCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfundCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnfundCancel.Location = new System.Drawing.Point(245, 71);
            this.btnfundCancel.Name = "btnfundCancel";
            this.btnfundCancel.Size = new System.Drawing.Size(102, 58);
            this.btnfundCancel.TabIndex = 9;
            this.btnfundCancel.Text = "Cancel";
            this.btnfundCancel.UseVisualStyleBackColor = false;
            this.btnfundCancel.Click += new System.EventHandler(this.BtnfundCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Transparent;
            this.btnOk.Location = new System.Drawing.Point(245, 7);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 58);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.SlateGray;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(159, 144);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(67, 37);
            this.button12.TabIndex = 7;
            this.button12.Text = "00";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Numbers);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SlateGray;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(86, 146);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 37);
            this.button8.TabIndex = 7;
            this.button8.Text = "0";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Numbers);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SlateGray;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(15, 146);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 37);
            this.button7.TabIndex = 6;
            this.button7.Text = ".";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Numbers);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.SlateGray;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(159, 58);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 37);
            this.button11.TabIndex = 5;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Numbers);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SlateGray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(159, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 37);
            this.button6.TabIndex = 5;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Numbers);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.SlateGray;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(86, 58);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(67, 37);
            this.button10.TabIndex = 4;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Numbers);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SlateGray;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(15, 58);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 37);
            this.button9.TabIndex = 3;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Numbers);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SlateGray;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(86, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "8";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Numbers);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SlateGray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(15, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "7";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Numbers);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(86, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Numbers);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(159, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "3";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Numbers);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Numbers);
            // 
            // Fund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 643);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Fund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkFidelity;
        private System.Windows.Forms.CheckBox chkZenith;
        private System.Windows.Forms.CheckBox chkUnion;
        private System.Windows.Forms.CheckBox chkDiamond;
        private System.Windows.Forms.CheckBox chkUba;
        private System.Windows.Forms.CheckBox chkfirst;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOk2;
        private System.Windows.Forms.Button btnFundClear;
        private System.Windows.Forms.Button btnfundCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}