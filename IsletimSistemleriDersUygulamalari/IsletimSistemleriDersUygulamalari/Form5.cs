using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Mantıksal Adres");
            dataTable.Columns.Add("Sayfa No");
            dataTable.Columns.Add("Ofset No");
            for (int i = 0; i < Convert.ToInt32(txtBellekBoyutu.Text); i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = i;
                dataRow[1] = i / Convert.ToInt32(txtSayfaUzunlugu.Text);
                dataRow[2] = i % Convert.ToInt32(txtSayfaUzunlugu.Text);
                dataTable.Rows.Add(dataRow);
            }
            dataGridView1.DataSource = dataTable;


            dataTable = new DataTable(); 
            dataTable.Columns.Add("Sayfa No");
            dataTable.Columns.Add("Çerçeve No");
            Random random = new Random();

            for (int i = 0; i < Convert.ToInt32(txtBellekBoyutu.Text)/Convert.ToInt32(txtSayfaUzunlugu.Text); i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = i;
                dataRow[1] = random.Next(1,50) ; 
                dataTable.Rows.Add(dataRow);
            }
            dataGridView2.DataSource = dataTable;


        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mantiksal_adres = Convert.ToInt32(textBox1.Text) ;
            int cerceve_no = 0;
            int cerceve_boyutu = Convert.ToInt32(txtSayfaUzunlugu.Text);
            int ofset = 0;
            int sayfa_no = 0;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                try
                {
                    if (mantiksal_adres.ToString() == dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        sayfa_no = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        ofset = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    }
                }
                catch  
                {
                     
                }
            }
            for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
            {
                try
                {
                    if (sayfa_no.ToString() == dataGridView2.Rows[i].Cells[0].Value.ToString())
                    {
                        cerceve_no = Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    }
                }
                catch  
                {
                     
                }
            }

            int sonuc = cerceve_no * cerceve_boyutu + ofset;
            lblSonuc.Text = "SONUÇ = " + sonuc.ToString();
        }
    }
}
