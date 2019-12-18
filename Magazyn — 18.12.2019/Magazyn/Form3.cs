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
    public partial class Form3 : Forms
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void btnComponentsPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void btnComponentsBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void lvComponentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var x = lvComponentType.SelectedItems.ToString();
            if (x == "Procesory")
            {
                lvComponentsOfType.Items.Clear();
                foreach (var y  in processors)
                {
                    var row = new string[] { "depti" };
                    var a = new ListViewItem(row);
                    a.Tag = y;
                    lvComponentsOfType.Items.Add(a);
                }
            }
            
        }
    }
}
