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

        private void BtnBillOk_Click(object sender, EventArgs e)
        {

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
        public double balance;

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
    }
}
