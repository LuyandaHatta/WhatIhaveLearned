using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatIhaveLearned
{
    public partial class frmCalculations : Form
    {
        public frmCalculations()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int intValue1;
            int intValue2;
            int intOutput;
            intValue1 = int.Parse(txtValue1.Text);
            intValue2 = int.Parse(txtValue2.Text);
            if (rbAdd.Checked == true)
            {
                intOutput = intValue1 + intValue2;
                txtOutput.Text = intOutput.ToString();
            }
            else if (rbSubtract.Checked == true)
            {
                intOutput = intValue1 - intValue2;
                txtOutput.Text = intOutput.ToString();
            }
            else if (rbMultiple.Checked == true)
            {
                intOutput = intValue1 * intValue2;
                txtOutput.Text = intOutput.ToString();
            }
            else if (rbDivide.Checked == true)
            {
                intOutput = intValue1 /intValue2;
                txtOutput.Text = intOutput.ToString();
            }
        }
    }
}
