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
    public partial class frmLoops : Form
    {
        public frmLoops()
        {
            InitializeComponent();
        }

        private void rbReturn_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            for (int x = 1; x < 11; x++)
                if (rbForLoop.Checked == true)
                {
                    lstLoop.Items.Add(x);
                }
                else if (rbWhileLoop.Checked == true)
                {
                    int z;
                    z = 0;
                    do
                    {
                        z = z + 1;
                        lstLoop.Items.Add(z);
                    } while (z < 100);
                }

                else if (rbDoWhileLoop.Checked == true)
                {
                    int i = 0;
                    do
                    {
                        lstLoop.Items.Add(i.ToString());
                        i++;
                    } while (i < 10);
                }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstLoop.Items.Clear();
        }

        private void lstLoop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}