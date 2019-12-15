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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void Numbers(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            lblDisplay.Text += number.Text;
        }
        int pin = 0, pin1 = 0;
        public double balance;
        double amount = 0;
        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (chkBalance.Checked || chkBill.Checked || chkPin.Checked || chkRecharge.Checked || chkTransfer.Checked || chkWithdraw.Checked)
            {
                //lblDisplay.Text = "";
                if (chkPin.Checked)
                {
                    pin = int.Parse(lblDisplay.Text);
                    lblDisplay.Text = "";
                    btnOk2.Visible = true;
                    btnOk.Visible = false;
                    MessageBox.Show("Confirm pin and click OK)");
                }

                if (chkBalance.Checked)
                {
                    MessageBox.Show("Your Account Balance is " + balance);
                }
                if (chkWithdraw.Checked)
                {
                    MessageBox.Show("Enter Amount");
                    btnOk.Visible = false;
                    btnOk2.Visible = true;
                }
                if (chkBill.Checked)
                {
                    Bills bill = new Bills();
                    bill.balance = balance;
                    bill.ShowDialog();
                    this.Close();
                }
                if (chkTransfer.Checked)
                {
                    Fund transfer = new Fund();
                    transfer.balance = balance;
                    transfer.ShowDialog();
                    this.Close();
                }
                if (chkRecharge.Checked)
                {
                    Recharge card = new Recharge();
                    card.balance = balance;
                    card.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an Option");
            }
           
           
        }

        private void BtnTransactCancel_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Cancel Transaction?", "Transaction Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                lblDisplay.Text = "";
                Form1 form = new Form1();
                form.ShowDialog();
                this.Close();
            }
            
        }

        private void BtnTransactClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }

        private void ChkPin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPin.Checked)
            {
                chkBalance.Enabled = false;
                chkBill.Enabled = false;
                chkRecharge.Enabled = false;
                chkTransfer.Enabled = false;
                chkWithdraw.Enabled = false;
                MessageBox.Show("Enter new pin and click OK");
            }
            else
            {
                chkWithdraw.Enabled = true;
                chkBill.Enabled = true;
                chkRecharge.Enabled = true;
                chkTransfer.Enabled = true;
                chkBalance.Enabled = true;
            }
        }

        private void ChkTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransfer.Checked)
            {
                chkPin.Enabled = false;
                chkBill.Enabled = false;
                chkBalance.Enabled = false;
                chkRecharge.Enabled = false;
                chkWithdraw.Enabled = false;
            }
            else
            {
                chkPin.Enabled = true;
                chkBill.Enabled = true;
                chkBalance.Enabled = true;
                chkTransfer.Enabled = true;
                chkRecharge.Enabled = true;
                chkWithdraw.Enabled = true;
            }
        }

        private void ChkBalance_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBalance.Checked)
            {
                chkBill.Enabled = false;
                chkPin.Enabled = false;
                chkRecharge.Enabled = false;
                chkTransfer.Enabled = false;
                chkWithdraw.Enabled = false;
            }
            else
            {
                chkBill.Enabled = true;
                chkPin.Enabled = true;
                chkRecharge.Enabled = true;
                chkTransfer.Enabled = true;
                chkWithdraw.Enabled = true;
            }
        }

        private void ChkBill_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBill.Checked)
            {
                chkBalance.Enabled = false;
                chkPin.Enabled = false;
                chkRecharge.Enabled = false;
                chkTransfer.Enabled = false;
                chkWithdraw.Enabled = false;
            }
            else
            {
                chkBalance.Enabled = true;
                chkPin.Enabled = true;
                chkRecharge.Enabled = true;
                chkTransfer.Enabled = true;
                chkWithdraw.Enabled = true;
            }
        }

        private void ChkWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWithdraw.Checked)
            {
                chkPin.Enabled = false;
                chkBalance.Enabled = false;
                chkBill.Enabled = false;
                chkRecharge.Enabled = false;
                chkTransfer.Enabled = false;
            }
            else
            {
                chkPin.Enabled = true;
                chkBalance.Enabled = true;
                chkBill.Enabled = true;
                chkRecharge.Enabled = true;
                chkTransfer.Enabled = true;
            }
        }

        private void ChkRecharge_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRecharge.Checked)
            {
                chkPin.Enabled = false;
                chkBill.Enabled = false;
                chkBalance.Enabled = false;
                chkTransfer.Enabled = false;
                chkWithdraw.Enabled = false;
            }
            else
            {
                chkWithdraw.Enabled = true;
                chkTransfer.Enabled = true;
                chkBalance.Enabled = true;
                chkBill.Enabled = true;
                chkPin.Enabled = true;
            }
        }

        private void BtnOk2_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkPin.Checked && pin != 0)
                {
                    pin1 = int.Parse(lblDisplay.Text);
                    btnOk.Visible = true;
                    btnOk2.Visible = false;
                    if (pin1 != 0)
                    {
                        MessageBox.Show("Pin changed");
                    }
                }
                if (chkWithdraw.Checked)
                {
                    amount = double.Parse(lblDisplay.Text);
                    btnOk.Visible = true;
                    btnOk2.Visible = false;
                    if (amount <= balance)
                    {
                        MessageBox.Show(amount + " has been deducted from your account");
                    }
                    else
                    {
                        MessageBox.Show("Insurficient Balance");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
            lblDisplay.Text = "";
        }
    }
}
