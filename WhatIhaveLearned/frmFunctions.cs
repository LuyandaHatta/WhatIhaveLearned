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
    public partial class frmFunctions : Form
    {
        public frmFunctions()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int intValue1;
            int intValue2;
            string strValue1 = "";
            string strValue2 = "";
            int intOutput = 0; 
            double dblValue1;
            double dblOutput;

            if (rbsABS.Checked == true)
            {
                intValue1 = -9;
                intOutput = Math.Abs(intValue1);
                txtOutput.Text = intOutput.ToString();
            }
            else if (rbSquareRoot.Checked == true)
            {
                dblValue1 = 9;
                dblOutput = Math.Sqrt(dblValue1);
                txtOutput.Text = dblOutput.ToString();
            }
            else if (rbStringLength.Checked == true)
            {
                intValue1 = txtValue1.Text.Length;
                txtOutput.Text = intValue1.ToString();
            }
            else if (rbStringCompare.Checked == true)
            {
                intOutput = string.Compare(strValue1, strValue2);

                if (intOutput == 0)
                {
                    txtOutput.Text = "Values Match";
                }
                else if (intOutput == -1)
                {
                    txtOutput.Text = "Values do not Match";
                }
            }
            else if (rbDateTime.Checked == true)
            {
                txtOutput.Text = System.DateTime.Now.ToString();

            }
        }
    }
}
