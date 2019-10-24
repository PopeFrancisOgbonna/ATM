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
    }
}
