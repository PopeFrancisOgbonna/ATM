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
    public partial class Fund : Form
    {
        public Fund()
        {
            InitializeComponent();
        }
        //Code to ensure the user checks only one option begins here
        private void Chkfirst_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfirst.Checked)
            {
                chkFidelity.Enabled = false;
                chkDiamond.Enabled = false;
                chkUba.Enabled = false;
                chkZenith.Enabled = false;
                chkUnion.Enabled = false;
            }
            else
            {
                chkFidelity.Enabled = true;
                chkDiamond.Enabled = true;
                chkUba.Enabled = true;
                chkZenith.Enabled = true;
                chkUnion.Enabled = true;
            }
        }

        private void ChkFidelity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFidelity.Checked)
            {
                chkfirst.Enabled = false;
                chkDiamond.Enabled = false;
                chkUba.Enabled = false;
                chkZenith.Enabled = false;
                chkUnion.Enabled = false;
            }
            else
            {
                chkfirst.Enabled = true;
                chkDiamond.Enabled = true;
                chkUba.Enabled = true;
                chkUnion.Enabled = true;
                chkZenith.Enabled = true;
            }
        }

        private void ChkZenith_CheckedChanged(object sender, EventArgs e)
        {
            if (chkZenith.Checked)
            {
                chkfirst.Enabled = false;
                chkFidelity.Enabled = false;
                chkDiamond.Enabled = false;
                chkUba.Enabled = false;
                chkUnion.Enabled = false;
            }
            else
            {
                chkfirst.Enabled = true;
                chkFidelity.Enabled = true;
                chkDiamond.Enabled = true;
                chkUba.Enabled = true;
                chkUnion.Enabled = true;
            }
        }

        private void ChkDiamond_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiamond.Checked)
            {
                chkfirst.Enabled = false;
                chkFidelity.Enabled = false;
                chkZenith.Enabled = false;
                chkUba.Enabled = false;
                chkUnion.Enabled = false;
            }
            else
            {
                chkfirst.Enabled = true;
                chkFidelity.Enabled = true;
                chkUba.Enabled = true;
                chkUnion.Enabled = true;
                chkZenith.Enabled = true;
            }
        }

        private void ChkUnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnion.Checked)
            {
                chkfirst.Enabled = false ;
                chkFidelity.Enabled = false;
                chkUba.Enabled = false;
                chkZenith.Enabled = false;
                chkDiamond.Enabled = false;
            }
            else
            {
                chkfirst.Enabled = true;
                chkFidelity.Enabled = true;
                chkZenith.Enabled = true;
                chkDiamond.Enabled = true;
                chkUba.Enabled = true;
            }
        }

        private void ChkUba_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUba.Checked)
            {
                chkUnion.Enabled = false;
                chkfirst.Enabled = false;
                chkFidelity.Enabled = false;
                chkDiamond.Enabled = false;
                chkZenith.Enabled = false;
            }
            else
            {
                chkUnion.Enabled = true;
                chkfirst.Enabled = true;
                chkFidelity.Enabled = true;
                chkDiamond.Enabled = true;
                chkZenith.Enabled = true;
            }
        }//end of code to ensure that the user checks onlyt one option 
        UInt64 acNo = 0;//variable to hold recievers account number
        double amount = 0;//variable to hold amount to be transfered
        public double balance;

        private void BtnFundClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";//clllears the display
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (chkDiamond.Checked || chkfirst.Checked || chkfirst.Checked || chkUba.Checked || chkUnion.Checked || chkZenith.Checked)
            {
                try
                {
                    if (acNo == 0)
                    {
                        MessageBox.Show("Enter Reciepient's Account Number");
                        btnOk.Visible = false;
                        btnOk2.Visible = true;
                    }
                    if (acNo != 0)
                    {
                        amount = Convert.ToUInt64(lblDisplay.Text);
                        btnOk.Visible = false;
                        btnOk2.Visible = true;

                        if (acNo > 0 && amount != 0 && amount <= balance)
                        {
                            MessageBox.Show(amount + " Has been transfered to  " + acNo + " Successfully");
                            btnOk2.Visible = false;
                            btnOk.Visible = true;
                        }
                        //reset Account number and Amount to enable user perform another operation instantly
                        acNo = 0;
                        amount = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please Select a Bank");
            }
           
            lblDisplay.Text = "";//clears the display
        }

        private void BtnfundCancel_Click(object sender, EventArgs e)
        {
            //confirms the user intends to cancel a transaction 
            var message = MessageBox.Show("Do you want to Cancel Transaction?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                lblDisplay.Text = "";
                Form1 form = new Form1();
                form.ShowDialog();
                this.Close();
            }
        }

        private void BtnOk2_Click(object sender, EventArgs e)
        {
            try
            {
                if (acNo == 0)
                {
                    acNo = Convert.ToUInt64(lblDisplay.Text);
                    btnOk2.Visible = false;
                    btnOk.Visible = true;
                    MessageBox.Show("Please enter Amount");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message.ToString());
            }
            
            lblDisplay.Text = "";
        }

        private void Numbers(object sender, EventArgs e)//Gets the Numbers to display 
        {
            Button number = (Button)sender;
            lblDisplay.Text += number.Text;
        }
    }
}
