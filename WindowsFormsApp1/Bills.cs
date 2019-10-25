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
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
        }

        private void Numbers(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            lblDisplay.Text += number.Text;
        }
        public double balance;
        double amount = 0;
        private void BtnBillOk_Click(object sender, EventArgs e)
        {
            if (amount == 0)
            {
                MessageBox.Show("Enter Amount");
                btnBillOk.Visible = false;
                btnOk2.Visible = true;
            }
           
           
            lblDisplay.Text = "";
        }

        private void BtnBillCancel_Click(object sender, EventArgs e)
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

        private void BtnBillClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }
      

        private void ChkOthers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOthers.Checked)
            {
                chkRevenue.Enabled = false;
                chkTax.Enabled = false;
                chkWater.Enabled = false;
                chkElectric.Enabled = false;
                chkDrive.Enabled = false;
            }
            else
            {
                chkRevenue.Enabled = true;
                chkTax.Enabled = true;
                chkElectric.Enabled = true;
                chkDrive.Enabled = true;
                chkWater.Enabled = true;
            }
        }

        private void ChkRevenue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRevenue.Checked)
            {
                chkOthers.Enabled = false;
                chkWater.Enabled = false;
                chkElectric.Enabled = false;
                chkDrive.Enabled = false;
                chkTax.Enabled = false;
            }
            else
            {
                chkOthers.Enabled = true;
                chkDrive.Enabled = true;
                chkWater.Enabled = true;
                chkElectric.Enabled = true;
                chkTax.Enabled = true;
            }
        }

        private void ChkElectric_CheckedChanged(object sender, EventArgs e)
        {
            if (chkElectric.Checked)
            {
                chkOthers.Enabled = false;
                chkRevenue.Enabled = false;
                chkWater.Enabled = false;
                chkTax.Enabled = false;
                chkDrive.Enabled = false;
            }
            else
            {
                chkOthers.Enabled = true;
                chkRevenue.Enabled =true;
                chkDrive.Enabled = true;
                chkWater.Enabled = true;
                chkTax.Enabled = true;
            }
        }

        private void ChkWater_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWater.Checked)
            {
                chkElectric.Enabled = false;
                chkOthers.Enabled = false;
                chkRevenue.Enabled = false;
                chkTax.Enabled = false;
                chkDrive.Enabled = false;
            }
            else
            {
                chkElectric.Enabled = true;
                chkOthers.Enabled = true;
                chkTax.Enabled = true;
                chkRevenue.Enabled = true;
                chkDrive.Enabled = true;
            }
        }

        private void ChkDrive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDrive.Checked)
            {
                chkElectric.Enabled = false;
                chkWater.Enabled = false;
                chkTax.Enabled = false;
                chkOthers.Enabled = false;
                chkRevenue.Enabled = false;
            }
            else
            {
                chkElectric.Enabled = true;
                chkWater.Enabled = true;
                chkTax.Enabled = true;
                chkRevenue.Enabled = true;
                chkOthers.Enabled = true;
            }
        }

        private void ChkTax_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTax.Checked)
            {
                chkOthers.Enabled = false;
                chkWater.Enabled = false;
                chkElectric.Enabled = false;
                chkDrive.Enabled = false;
                chkRevenue.Enabled = false;
            }
            else
            {
                chkOthers.Enabled = true;
                chkRevenue.Enabled = true;
                chkWater.Enabled = true;
                chkElectric.Enabled = true;
                chkDrive.Enabled = true;
            }
        }

        private void BtnOk2_Click(object sender, EventArgs e)
        {
            if (amount == 0)
            {
                amount = double.Parse(lblDisplay.Text);
                btnBillOk.Visible = true;
                btnOk2.Visible = false;
                if (amount != 0 && amount <= balance && !chkOthers.Checked)
                {
                    MessageBox.Show(amount + " Has been deducted from your account for Bill Payment");
                }
                if(amount != 0 && amount > balance && !chkOthers.Checked)//checks that balance is not less than amount
                {
                    MessageBox.Show("Insuficient Balance.", "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (amount != 0 && amount <= balance && chkOthers.Checked ||(amount != 0 && amount <= balance && chkOthers.Checked))
                {
                    MessageBox.Show("Sorry This Service is currently unavailabe", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                amount = 0;//To ensure more transactions in sequense
            }
            lblDisplay.Text = "";
        }
    }
}
