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
        int listCode;
        
        public static string componentName;
        public static double componentPrize;
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

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void lvComponentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lvComponentType.Items[0].Selected)
            {
                lvComponentsOfType.Items.Clear();
                foreach (var y in processors)
                {
                    var row = new string[] { y.name.ToString() };
                    var a = new ListViewItem(row);
                    a.Tag = y;
                    lvComponentsOfType.Items.Add(a);
                }
                listCode = 1;
            }
            else if (lvComponentType.Items[1].Selected)
            {
                lvComponentsOfType.Items.Clear();
                foreach (var y in graphicCards)
                {
                    var row = new string[] { y.name.ToString() };
                    var a = new ListViewItem(row);
                    a.Tag = y;
                    lvComponentsOfType.Items.Add(a);
                }
                listCode = 2;
            }
            else if (lvComponentType.Items[2].Selected)
            {
                lvComponentsOfType.Items.Clear();
                foreach (var y in rams)
                {
                    var row = new string[] { y.name.ToString() };
                    var a = new ListViewItem(row);
                    a.Tag = y;
                    lvComponentsOfType.Items.Add(a);
                }
                listCode = 3;
            }
            else if (lvComponentType.Items[3].Selected)
            {
                lvComponentsOfType.Items.Clear();
                foreach (var y in motherboards)
                {
                    var row = new string[] { y.name.ToString() };
                    var a = new ListViewItem(row);
                    a.Tag = y;
                    lvComponentsOfType.Items.Add(a);
                }
                listCode = 4;
            }
            else if (lvComponentType.Items[4].Selected)
            {
                lvComponentsOfType.Items.Clear();
                foreach (var y in powerSupplies)
                {
                    var row = new string[] { y.name.ToString() };
                    var a = new ListViewItem(row);
                    a.Tag = y;
                    lvComponentsOfType.Items.Add(a);
                   
                }
                listCode = 5;
            }
            else if (lvComponentType.Items[5].Selected)
            {
                lvComponentsOfType.Items.Clear();
                foreach (var y in disks)
                {
                    var row = new string[] { y.name.ToString() };
                    var a = new ListViewItem(row);
                    a.Tag = y;
                    lvComponentsOfType.Items.Add(a);
                }
                listCode = 6;
            }
        }

        private void lvComponentsOfType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;
            int j = 0;
            for (i = 0; i < lvComponentsOfType.Items.Count; i++)
            {
                if (lvComponentsOfType.Items[i].Selected)
                {
                    break;
                }
                j++;
            }
            if (j == lvComponentsOfType.Items.Count)
            {
                lbName.Text = string.Empty;
                componentName = string.Empty;
                lbPrize.Text = string.Empty;
                componentPrize = 0;
                lbParam1.Text = string.Empty;
                lbParam2.Text = string.Empty;
                lbParam3.Text = string.Empty;
                return;
            }

            var x = lvComponentsOfType.Items[i];
            switch (listCode)
            {
                case 1:
                    var lista = processors.Where(part => part.name == x.Text);
                    lbName.Text = lista.First().name;
                    componentName = lista.First().name;
                    lbPrize.Text = lista.First().price.ToString() + " Złotych";
                    componentPrize = lista.First().price;
                    lbParam1.Text = lista.First().numOfCores.ToString() + " rdzeni";
                    lbParam2.Text = lista.First().coreClock.ToString() + " GHz";
                    lbParam3.Text = "Socket:" + lista.First()._socket.ToString();
                    break;

                case 2:
                    var lista1 = graphicCards.Where(part => part.name == x.Text);
                    lbName.Text = lista1.First().name;
                    componentName = lista1.First().name;
                    lbPrize.Text = lista1.First().price.ToString() + " Złotych";
                    componentPrize = lista1.First().price;
                    lbParam1.Text = lista1.First().memory.ToString() + " GB";
                    lbParam2.Text = lista1.First().coreClock.ToString() + " GHz";
                    lbParam3.Text = lista1.First().sliCompatible ? "SLI" : "brak SLI";
                    break;

                case 3:
                    var lista2 = rams.Where(part => part.name == x.Text);
                    lbName.Text = lista2.First().name;
                    componentName = lista2.First().name;
                    lbPrize.Text = lista2.First().price.ToString() + " Złotych";
                    componentPrize = lista2.First().price;
                    lbParam1.Text = lista2.First().memorySize.ToString() + " GB";
                    lbParam2.Text = lista2.First().memoryClockFrequency.ToString() + " MHz";
                    lbParam3.Text = "Typ:" + lista2.First()._memoryType.ToString();
                    break;

                case 4:
                    var lista3 = motherboards.Where(part => part.name == x.Text);
                    lbName.Text = lista3.First().name;
                    componentName = lista3.First().name;
                    lbPrize.Text = lista3.First().price.ToString() + " Złotych";
                    componentPrize = lista3.First().price;
                    lbParam1.Text = lista3.First().networkCard ? "Posiada kartę sieciową": "Nie posiada karty sieciowej";
                    lbParam2.Text = lista3.First().ramSlots.ToString() + "Sloty RAM";
                    lbParam3.Text = "Rozmiar:" + lista3.First()._size.ToString();
                    break;

                case 5:
                    var lista4 = powerSupplies.Where(part => part.name == x.Text);
                    lbName.Text = lista4.First().name;
                    componentName = lista4.First().name;
                    lbPrize.Text = lista4.First().price.ToString() + " Złotych";
                    componentPrize = lista4.First().price;
                    lbParam1.Text = "Moc: " + lista4.First().powerInWatts.ToString();
                    lbParam2.Text = "Standard: " + lista4.First()._standardOfPowerSupply.ToString();
                    lbParam3.Text = "Rozmiar:" + lista4.First().size.ToString();
                    break;

                case 6:
                    var lista5 = disks.Where(part => part.name == x.Text);
                    lbName.Text = lista5.First().name;
                    componentName = lista5.First().name;
                    lbPrize.Text = lista5.First().price.ToString() + " Złotych";
                    componentPrize = lista5.First().price;
                    lbParam1.Text = lista5.First().capacity.ToString() + "GB";
                    lbParam2.Text = "Typ: " + lista5.First()._diskType.ToString();
                    lbParam3.Text = string.Empty;
                    break;
                default:
                    break;



            }
        }
    }
}
