using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        public static double balance = 78400;

        private void Numbers(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Visible = false;
            Button number = (Button)sender;
            lblDisplay.Text += number.Text.ToString();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length == 4 && lblDisplay.Text.Equals("1234"))
            {
                Transaction transact = new Transaction();
                transact.balance = balance;
                transact.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong pin,Please checkyour pin and try again");
                lblDisplay.Text = "";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Abort Transaction?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (message == DialogResult.Yes)
            {
                lblDisplay.Text = "";
            }
            timer1.Start();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }
        int i = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i <= 5)
            {
                label1.Visible = true;
            }
            if (i >= 6)
            {
                label1.Visible = false;
            }
            if (i >= 9)
            {
                i = 0;
            }

        }
    }
}
