namespace WindowsFormsApp1
{
    partial class Bills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bills));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkOthers = new System.Windows.Forms.CheckBox();
            this.chkDrive = new System.Windows.Forms.CheckBox();
            this.chkWater = new System.Windows.Forms.CheckBox();
            this.chkRevenue = new System.Windows.Forms.CheckBox();
            this.chkTax = new System.Windows.Forms.CheckBox();
            this.chkElectric = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBillClear = new System.Windows.Forms.Button();
            this.btnBillCancel = new System.Windows.Forms.Button();
            this.btnBillOk = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 638);
            this.panel1.TabIndex = 2;
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.White;
            this.lblDisplay.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(134, 346);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(383, 63);
            this.lblDisplay.TabIndex = 6;
            this.lblDisplay.Tag = "";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkOthers);
            this.panel3.Controls.Add(this.chkDrive);
            this.panel3.Controls.Add(this.chkWater);
            this.panel3.Controls.Add(this.chkRevenue);
            this.panel3.Controls.Add(this.chkTax);
            this.panel3.Controls.Add(this.chkElectric);
            this.panel3.Location = new System.Drawing.Point(136, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 257);
            this.panel3.TabIndex = 5;
            // 
            // chkOthers
            // 
            this.chkOthers.AutoSize = true;
            this.chkOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOthers.Location = new System.Drawing.Point(205, 177);
            this.chkOthers.Name = "chkOthers";
            this.chkOthers.Size = new System.Drawing.Size(91, 28);
            this.chkOthers.TabIndex = 11;
            this.chkOthers.Text = "Others";
            this.chkOthers.UseVisualStyleBackColor = true;
            this.chkOthers.CheckedChanged += new System.EventHandler(this.ChkOthers_CheckedChanged);
            // 
            // chkDrive
            // 
            this.chkDrive.AutoSize = true;
            this.chkDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDrive.Location = new System.Drawing.Point(205, 113);
            this.chkDrive.Name = "chkDrive";
            this.chkDrive.Size = new System.Drawing.Size(173, 28);
            this.chkDrive.TabIndex = 10;
            this.chkDrive.Text = "Driving License";
            this.chkDrive.UseVisualStyleBackColor = true;
            this.chkDrive.CheckedChanged += new System.EventHandler(this.ChkDrive_CheckedChanged);
            // 
            // chkWater
            // 
            this.chkWater.AutoSize = true;
            this.chkWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWater.Location = new System.Drawing.Point(205, 51);
            this.chkWater.Name = "chkWater";
            this.chkWater.Size = new System.Drawing.Size(117, 28);
            this.chkWater.TabIndex = 9;
            this.chkWater.Text = "Water Bill";
            this.chkWater.UseVisualStyleBackColor = true;
            this.chkWater.CheckedChanged += new System.EventHandler(this.ChkWater_CheckedChanged);
            // 
            // chkRevenue
            // 
            this.chkRevenue.AutoSize = true;
            this.chkRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRevenue.Location = new System.Drawing.Point(30, 113);
            this.chkRevenue.Name = "chkRevenue";
            this.chkRevenue.Size = new System.Drawing.Size(113, 28);
            this.chkRevenue.TabIndex = 8;
            this.chkRevenue.Text = "Revenue";
            this.chkRevenue.UseVisualStyleBackColor = true;
            this.chkRevenue.CheckedChanged += new System.EventHandler(this.ChkRevenue_CheckedChanged);
            // 
            // chkTax
            // 
            this.chkTax.AutoSize = true;
            this.chkTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTax.Location = new System.Drawing.Point(30, 177);
            this.chkTax.Name = "chkTax";
            this.chkTax.Size = new System.Drawing.Size(64, 28);
            this.chkTax.TabIndex = 7;
            this.chkTax.Text = "Tax";
            this.chkTax.UseVisualStyleBackColor = true;
            this.chkTax.CheckedChanged += new System.EventHandler(this.ChkTax_CheckedChanged);
            // 
            // chkElectric
            // 
            this.chkElectric.AutoSize = true;
            this.chkElectric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkElectric.Location = new System.Drawing.Point(30, 51);
            this.chkElectric.Name = "chkElectric";
            this.chkElectric.Size = new System.Drawing.Size(153, 28);
            this.chkElectric.TabIndex = 6;
            this.chkElectric.Text = "Electricity Bill";
            this.chkElectric.UseVisualStyleBackColor = true;
            this.chkElectric.CheckedChanged += new System.EventHandler(this.ChkElectric_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOk2);
            this.panel2.Controls.Add(this.btnBillClear);
            this.panel2.Controls.Add(this.btnBillCancel);
            this.panel2.Controls.Add(this.btnBillOk);
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
            this.panel2.Location = new System.Drawing.Point(143, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 199);
            this.panel2.TabIndex = 4;
            // 
            // btnBillClear
            // 
            this.btnBillClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillClear.Location = new System.Drawing.Point(245, 135);
            this.btnBillClear.Name = "btnBillClear";
            this.btnBillClear.Size = new System.Drawing.Size(102, 58);
            this.btnBillClear.TabIndex = 10;
            this.btnBillClear.Text = "Clear";
            this.btnBillClear.UseVisualStyleBackColor = true;
            this.btnBillClear.Click += new System.EventHandler(this.BtnBillClear_Click);
            // 
            // btnBillCancel
            // 
            this.btnBillCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillCancel.Location = new System.Drawing.Point(245, 71);
            this.btnBillCancel.Name = "btnBillCancel";
            this.btnBillCancel.Size = new System.Drawing.Size(102, 58);
            this.btnBillCancel.TabIndex = 9;
            this.btnBillCancel.Text = "Cancel";
            this.btnBillCancel.UseVisualStyleBackColor = true;
            this.btnBillCancel.Click += new System.EventHandler(this.BtnBillCancel_Click);
            // 
            // btnBillOk
            // 
            this.btnBillOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillOk.Location = new System.Drawing.Point(245, 7);
            this.btnBillOk.Name = "btnBillOk";
            this.btnBillOk.Size = new System.Drawing.Size(102, 58);
            this.btnBillOk.TabIndex = 8;
            this.btnBillOk.Text = "Ok";
            this.btnBillOk.UseVisualStyleBackColor = true;
            this.btnBillOk.Click += new System.EventHandler(this.BtnBillOk_Click);
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
            this.btnOk2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk2.Location = new System.Drawing.Point(245, 7);
            this.btnOk2.Name = "btnOk2";
            this.btnOk2.Size = new System.Drawing.Size(102, 58);
            this.btnOk2.TabIndex = 11;
            this.btnOk2.Text = "Ok";
            this.btnOk2.UseVisualStyleBackColor = false;
            this.btnOk2.Visible = false;
            this.btnOk2.Click += new System.EventHandler(this.BtnOk2_Click);
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 643);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Bills";
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
        private System.Windows.Forms.Button btnBillClear;
        private System.Windows.Forms.Button btnBillCancel;
        private System.Windows.Forms.Button btnBillOk;
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
        private System.Windows.Forms.CheckBox chkOthers;
        private System.Windows.Forms.CheckBox chkDrive;
        private System.Windows.Forms.CheckBox chkWater;
        private System.Windows.Forms.CheckBox chkRevenue;
        private System.Windows.Forms.CheckBox chkTax;
        private System.Windows.Forms.CheckBox chkElectric;
        private System.Windows.Forms.Button btnOk2;
    }
}