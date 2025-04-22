using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsletimSistemleriDersUygulamalari
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        ArrayList isListesi = new ArrayList();
        int kafaAnlik = 1;
        private void Form4_Load(object sender, EventArgs e)
        {
            int bas = 1;
            int bit = 500;
            Random random = new Random();
            for (int i = 0; i < 11; i++)
            { 
                isListesi.Add(random.Next(bas, bit));
                listBox1.Items.Add(isListesi[i]);
            }
            kafaAnlik = random.Next(bas, bit);
            label1.Text = "ANLIK KAFA = " + kafaAnlik.ToString() + Environment.NewLine + "TOPLAM İZ= 500";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int geciciKafaAnlik = kafaAnlik;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Bir Sonraki İz");
            dataTable.Columns.Add("Geçilen İz");
            decimal toplamHareket = 0;
            for (int i = 0; i < isListesi.Count; i++)
            {
                int deger = geciciKafaAnlik - Convert.ToInt32(isListesi[i]);
                if (deger < 0)
                    deger *= -1;
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = isListesi[i];
                dataRow[1] = deger;
                dataTable.Rows.Add(dataRow);
                geciciKafaAnlik = deger;
                toplamHareket += deger;
            }
            DataRow dataRow2 = dataTable.NewRow();
            dataRow2[0] = "Ortalama";
            dataRow2[1] =Math.Round(toplamHareket/dataTable.Rows.Count,2);
            dataTable.Rows.Add(dataRow2);
            dataGridView1.DataSource = dataTable;
        }

       
    }
}
