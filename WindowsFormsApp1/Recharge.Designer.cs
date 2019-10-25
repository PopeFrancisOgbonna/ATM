namespace WindowsFormsApp1
{
    partial class Recharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recharge));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkGlo = new System.Windows.Forms.CheckBox();
            this.chkAirtel = new System.Windows.Forms.CheckBox();
            this.chkMobile = new System.Windows.Forms.CheckBox();
            this.chkMtn = new System.Windows.Forms.CheckBox();
            this.chkOthers = new System.Windows.Forms.CheckBox();
            this.chkVoda = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
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
            this.btnOk2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblDisplay);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 619);
            this.panel1.TabIndex = 1;
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.White;
            this.lblDisplay.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(134, 350);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(383, 46);
            this.lblDisplay.TabIndex = 6;
            this.lblDisplay.Tag = "";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkGlo);
            this.panel3.Controls.Add(this.chkAirtel);
            this.panel3.Controls.Add(this.chkMobile);
            this.panel3.Controls.Add(this.chkMtn);
            this.panel3.Controls.Add(this.chkOthers);
            this.panel3.Controls.Add(this.chkVoda);
            this.panel3.Location = new System.Drawing.Point(136, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 257);
            this.panel3.TabIndex = 5;
            // 
            // chkGlo
            // 
            this.chkGlo.AutoSize = true;
            this.chkGlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGlo.Location = new System.Drawing.Point(192, 51);
            this.chkGlo.Name = "chkGlo";
            this.chkGlo.Size = new System.Drawing.Size(61, 28);
            this.chkGlo.TabIndex = 15;
            this.chkGlo.Text = "Glo";
            this.chkGlo.UseVisualStyleBackColor = true;
            this.chkGlo.CheckedChanged += new System.EventHandler(this.ChkGlo_CheckedChanged);
            // 
            // chkAirtel
            // 
            this.chkAirtel.AutoSize = true;
            this.chkAirtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAirtel.Location = new System.Drawing.Point(17, 113);
            this.chkAirtel.Name = "chkAirtel";
            this.chkAirtel.Size = new System.Drawing.Size(77, 28);
            this.chkAirtel.TabIndex = 14;
            this.chkAirtel.Text = "Airtel";
            this.chkAirtel.UseVisualStyleBackColor = true;
            this.chkAirtel.CheckedChanged += new System.EventHandler(this.ChkAirtel_CheckedChanged);
            // 
            // chkMobile
            // 
            this.chkMobile.AutoSize = true;
            this.chkMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMobile.Location = new System.Drawing.Point(17, 177);
            this.chkMobile.Name = "chkMobile";
            this.chkMobile.Size = new System.Drawing.Size(103, 28);
            this.chkMobile.TabIndex = 13;
            this.chkMobile.Text = "9Mobile";
            this.chkMobile.UseVisualStyleBackColor = true;
            this.chkMobile.CheckedChanged += new System.EventHandler(this.ChkMobile_CheckedChanged);
            // 
            // chkMtn
            // 
            this.chkMtn.AutoSize = true;
            this.chkMtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMtn.Location = new System.Drawing.Point(17, 51);
            this.chkMtn.Name = "chkMtn";
            this.chkMtn.Size = new System.Drawing.Size(74, 28);
            this.chkMtn.TabIndex = 12;
            this.chkMtn.Text = "MTN";
            this.chkMtn.UseVisualStyleBackColor = true;
            this.chkMtn.CheckedChanged += new System.EventHandler(this.ChkMtn_CheckedChanged);
            // 
            // chkOthers
            // 
            this.chkOthers.AutoSize = true;
            this.chkOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOthers.Location = new System.Drawing.Point(192, 177);
            this.chkOthers.Name = "chkOthers";
            this.chkOthers.Size = new System.Drawing.Size(91, 28);
            this.chkOthers.TabIndex = 18;
            this.chkOthers.Text = "Others";
            this.chkOthers.UseVisualStyleBackColor = true;
            this.chkOthers.CheckedChanged += new System.EventHandler(this.ChkOthers_CheckedChanged);
            // 
            // chkVoda
            // 
            this.chkVoda.AutoSize = true;
            this.chkVoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVoda.Location = new System.Drawing.Point(192, 113);
            this.chkVoda.Name = "chkVoda";
            this.chkVoda.Size = new System.Drawing.Size(121, 28);
            this.chkVoda.TabIndex = 17;
            this.chkVoda.Text = "VodaCom";
            this.chkVoda.UseVisualStyleBackColor = true;
            this.chkVoda.CheckedChanged += new System.EventHandler(this.ChkVoda_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOk2);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnCancel);
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
            this.panel2.Location = new System.Drawing.Point(144, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 199);
            this.panel2.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(245, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 58);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(245, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 58);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(245, 7);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 58);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(159, 144);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(67, 37);
            this.button12.TabIndex = 7;
            this.button12.Text = "00";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Numbers);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(86, 146);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 37);
            this.button8.TabIndex = 7;
            this.button8.Text = "0";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Numbers);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(15, 146);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 37);
            this.button7.TabIndex = 6;
            this.button7.Text = ".";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Numbers);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(159, 58);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 37);
            this.button11.TabIndex = 5;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Numbers);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(159, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 37);
            this.button6.TabIndex = 5;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Numbers);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(86, 58);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(67, 37);
            this.button10.TabIndex = 4;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Numbers);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(15, 58);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 37);
            this.button9.TabIndex = 3;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Numbers);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(86, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "8";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Numbers);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(15, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "7";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Numbers);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(86, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Numbers);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(159, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Numbers);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Numbers);
            // 
            // btnOk2
            // 
            this.btnOk2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk2.Location = new System.Drawing.Point(245, 4);
            this.btnOk2.Name = "btnOk2";
            this.btnOk2.Size = new System.Drawing.Size(102, 58);
            this.btnOk2.TabIndex = 11;
            this.btnOk2.Text = "Ok";
            this.btnOk2.UseVisualStyleBackColor = false;
            this.btnOk2.Visible = false;
            this.btnOk2.Click += new System.EventHandler(this.BtnOk2_Click);
            // 
            // Recharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 643);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Recharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
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
        private System.Windows.Forms.CheckBox chkGlo;
        private System.Windows.Forms.CheckBox chkAirtel;
        private System.Windows.Forms.CheckBox chkMobile;
        private System.Windows.Forms.CheckBox chkMtn;
        private System.Windows.Forms.CheckBox chkOthers;
        private System.Windows.Forms.CheckBox chkVoda;
        private System.Windows.Forms.Button btnOk2;
    }
}