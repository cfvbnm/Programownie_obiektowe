﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    public partial class Form4 : Forms
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBuyComponentsPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lbComponentName.Text = Form3.componentName;
            lbPrize.Text = Form3.componentPrize.ToString();
        }

        void FinalPrize(string d, string i)
        {
            if (d == null || i == "")
            {
                lbFinalPrize.Text = string.Empty;
                lbFinalPrize.Text = "";
            }
            else
            {
                lbFinalPrize.Text = string.Empty;
                double dp = double.Parse(d);
                int ip = int.Parse(i);

                lbFinalPrize.Text = (dp * ip).ToString();
            }
            
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            FinalPrize(lbPrize.Text, textBoxCount.Text);
        }
    }
}
