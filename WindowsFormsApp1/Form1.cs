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
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Numbers(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            lblDisplay.Text += number.Text.ToString();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length == 4)
            {
                Transaction transact = new Transaction();
                transact.ShowDialog();
                this.Close();
            }
            else
            {

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Abort Transaction?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (message == DialogResult.Yes)
            {
                lblDisplay.Text = "";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }
    }
}
