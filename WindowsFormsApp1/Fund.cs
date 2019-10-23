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
            if()
        }

        private void ChkUnion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkUba_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
