using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMainProvider_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 provider = new Form2();
            provider.ShowDialog();
        }

        private void btnMainComponents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 components = new Form3();
            components.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
