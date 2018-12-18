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
    public partial class frmConcatenation : Form
    {
        public frmConcatenation()
        {
            InitializeComponent();
        }

        private void Concatenation_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void btnConcatenate_Click(object sender, EventArgs e)
        {
            string strValue1;
            string strValue2;
            string strOutput;
            strValue1 = txtValue1.Text;
            strValue2 = txtValue2.Text;
            strOutput = strValue1 + " " + strValue2;
            txtOutput.Text = strOutput;
        }
    }
}
