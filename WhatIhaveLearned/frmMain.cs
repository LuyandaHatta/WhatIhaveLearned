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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculations_Click(object sender, EventArgs e)
        {
            frmCalculations frmCalculations = new frmCalculations();
            frmCalculations.Show();
        }

        private void btnFunctions_Click(object sender, EventArgs e)
        {
            frmFunctions frmFunctions = new frmFunctions();
            frmFunctions.Show();
        }

        private void btnLoops_Click(object sender, EventArgs e)
        {
            frmLoops frmLoops = new frmLoops();
            frmLoops.Show();
        }

        private void btnConcatenation_Click(object sender, EventArgs e)
        {
            frmConcatenation frmConcatenation = new frmConcatenation();
            frmConcatenation.Show();
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
