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
    public partial class Recharge : Form
    {
        public Recharge()
        {
            InitializeComponent();
        }
        public double balance;
        double amount = 0;

        private void BtnOk2_Click(object sender, EventArgs e)
        {
            if (amount == 0)
            {
                amount = double.Parse(lblDisplay.Text);
                btnOk.Visible = true;
                btnOk2.Visible = false;
                if (amount != 0 && amount <= balance && !chkOthers.Checked)
                {
                    MessageBox.Show(amount + " Has been deducted from your account for Recharge Card Payment ");
                }
                if (amount != 0 && amount > balance && !chkOthers.Checked)//checks that balance is not less than amount
                {
                    MessageBox.Show("Insuficient Balance.", "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (amount != 0 && amount <= balance && chkOthers.Checked || (amount != 0 && amount <= balance && chkOthers.Checked))
                {
                    MessageBox.Show("Sorry This Service is currently unavailabe", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                amount = 0;//To ensure more transactions in sequense
            }
            lblDisplay.Text = "";
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (amount == 0)
            {
                MessageBox.Show("Enter Amount");
                btnOk.Visible = false;
                btnOk2.Visible = true;
            }
            lblDisplay.Text = "";
        }

        private void BtnCancel_Click(object sender, EventArgs e)//Cancels the transaction in progress
        {
            var message = MessageBox.Show("Cancel Transaction?", "Transaction Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                lblDisplay.Text = "";
                Form1 form = new Form1();
                form.ShowDialog();
                this.Close();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)//Clears user input
        {
            lblDisplay.Text = "";
        }

        private void Numbers(object sender, EventArgs e)//displays the numbers typed by users
        {
            Button numbers = (Button)sender;
            lblDisplay.Text += numbers.Text;
        }

        private void ChkVoda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVoda.Checked)
            {
                chkAirtel.Enabled = false;
                chkGlo.Enabled = false;
                chkMobile.Enabled = false;
                chkMtn.Enabled = false;
                chkOthers.Enabled = false;
            }
            else
            {
                chkAirtel.Enabled =true;
                chkGlo.Enabled = true;
                chkMobile.Enabled = true;
                chkMtn.Enabled = true;
                chkOthers.Enabled = true;
            }
        }

        private void ChkAirtel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAirtel.Checked)
            {
                chkGlo.Enabled = false;
                chkMtn.Enabled = false;
                chkMobile.Enabled = false;
                chkOthers.Enabled = false;
                chkVoda.Enabled = false;
            }
            else
            {
                chkGlo.Enabled = true;
                chkMtn.Enabled = true;
                chkMobile.Enabled = true;
                chkOthers.Enabled = true;
                chkVoda.Enabled = true;
            }
        }

        private void ChkMtn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMtn.Checked)
            {
                chkAirtel.Enabled = false;
                chkGlo.Enabled = false;
                chkMobile.Enabled = false;
                chkOthers.Enabled = false;
                chkVoda.Enabled = false;
            }
            else
            {
                chkAirtel.Enabled =true;
                chkGlo.Enabled = true;
                chkMobile.Enabled = true;
                chkOthers.Enabled = true;
                chkVoda.Enabled = true;
            }
        }

        private void ChkGlo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGlo.Checked)
            {
                chkAirtel.Enabled = false;
                chkMtn.Enabled = false;
                chkMobile.Enabled = false;
                chkVoda.Enabled = false;
                chkOthers.Enabled = false;
            }
            else
            {
                chkAirtel.Enabled = true;
                chkMtn.Enabled = true;
                chkMobile.Enabled = true;
                chkVoda.Enabled = true;
                chkOthers.Enabled = true;
            }
        }

        private void ChkMobile_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMobile.Checked)
            {
                chkMtn.Enabled = false;
                chkGlo.Enabled = false;
                chkVoda.Enabled = false;
                chkOthers.Enabled = false;
                chkAirtel.Enabled = false;
            }
            else
            {
                chkMtn.Enabled = true;
                chkGlo.Enabled = true;
                chkVoda.Enabled = true;
                chkOthers.Enabled = true;
                chkAirtel.Enabled = true;
            }
        }

        private void ChkOthers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOthers.Checked)
            {
                chkMtn.Enabled = false;
                chkAirtel.Enabled = false;
                chkVoda.Enabled = false;
                chkMobile.Enabled = false;
                chkGlo.Enabled = false;
            }
            else
            {
                chkMtn.Enabled = true;
                chkAirtel.Enabled = true;
                chkVoda.Enabled = true;
                chkMobile.Enabled = true;
                chkGlo.Enabled = true;
            }
        }
    }
}
