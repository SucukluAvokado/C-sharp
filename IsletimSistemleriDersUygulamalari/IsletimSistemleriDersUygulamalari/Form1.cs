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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string icerik = "";
            string sistem_bilgi = "SELECT * FROM Win32_OperatingSystem";
            ManagementObjectSearcher isletimSistemleri = new ManagementObjectSearcher(sistem_bilgi);
            foreach (ManagementObject bilgi in isletimSistemleri.Get())
            { 
                icerik = "Başlık = " +bilgi.Properties["Caption"].Value.ToString().Trim() + Environment.NewLine;
                icerik+= "Version = " + bilgi.Properties["Version"].Value.ToString() +
                  " SP " + bilgi.Properties["ServicePackMajorVersion"].Value.ToString()
                  + "." + bilgi.Properties["ServicePackMinorVersion"].Value.ToString() + Environment.NewLine;
            } 
            string sistem_turu = "SELECT * FROM Win32_Processor";
            ManagementObjectSearcher islemciler = new ManagementObjectSearcher(sistem_turu);
            foreach (ManagementObject bilgi in islemciler.Get())
            {
                icerik += "İşlemci = " +bilgi.Properties["AddressWidth"].Value.ToString() + "-bit" + Environment.NewLine;
            }
            lblSonuc.Text = icerik;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ThreadFormu threadFormu = new ThreadFormu(this);
            threadFormu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
