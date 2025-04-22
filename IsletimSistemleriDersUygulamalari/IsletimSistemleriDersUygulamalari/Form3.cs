using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsletimSistemleriDersUygulamalari
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            try
            {
                var searcher = new ManagementObjectSearcher("SELECT * FROM " + listBox1.SelectedItem.ToString() + "");
                int sayac = 1;
                foreach (ManagementObject mo in searcher.Get())
                {
                    label1.Text += sayac.ToString() + " = " + Environment.NewLine;
                    foreach (PropertyData pd in mo.Properties)
                    {
                        label1.Text += pd.Name + " : " + pd.Value + Environment.NewLine;
                    }
                    label1.Text += "--------------------------" + Environment.NewLine;
                    sayac++;
                }
            }
            catch  
            {
                 
            }
        }
    }
}
