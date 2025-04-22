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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("islem_adi");
            dataTable.Columns.Add("varis_ms");
            dataTable.Columns.Add("islem_ms");
            dataTable.Columns.Add("oncelik");
            dataTable.Columns.Add("baslangic");
            dataTable.Columns.Add("bitis");
            dataTable.Columns.Add("bekleme");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = dataGridView1.Rows[i].Cells[0].FormattedValue.ToString();
                dataRow[1] = dataGridView1.Rows[i].Cells[1].FormattedValue.ToString();
                dataRow[2] = dataGridView1.Rows[i].Cells[2].FormattedValue.ToString();
                dataRow[3] = dataGridView1.Rows[i].Cells[3].FormattedValue.ToString();
                dataRow[4] = "0";
                dataRow[5] = "0";
                dataRow[6] = "0";
                dataTable.Rows.Add(dataRow);
            }
            dataGridView1.Sort((DataGridViewColumn)dataGridView1.Columns[1], ListSortDirection.Ascending);
            dataTable.DefaultView.Sort = "varis_ms";
            dataTable = dataTable.DefaultView.ToTable();
             
            decimal toplamBekleme = 0;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                int gecen_sure = 0;
                for (int j = 0; j < i; j++)
                {
                    try
                    {
                        gecen_sure += Convert.ToInt32(dataTable.Rows[j][2]);
                    }
                    catch
                    {

                    }
                }
                if (i > 0)
                {
                    dataTable.Rows[i][4] = gecen_sure;
                    dataTable.Rows[i][5] = dataTable.Rows[i][1];
                    dataTable.Rows[i][6] = gecen_sure - Convert.ToInt32(dataTable.Rows[i][1]);
                    toplamBekleme += Convert.ToDecimal(dataTable.Rows[i][6]);
                }
            }
            string metin ="İLK GELEN ÖNCE" + Environment.NewLine + Environment.NewLine+ "Yanıt Süreleri (başlangıç zamanı - varış zamanı) : " + Environment.NewLine + Environment.NewLine;
            string toplamlar = "( ";
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                toplamlar += dataTable.Rows[i][6].ToString() ;
                if(i<dataTable.Rows.Count-1)
                {
                    toplamlar += " + ";
                }
                metin += dataTable.Rows[i][0].ToString() + " : " + dataTable.Rows[i][4].ToString() + " - " + dataTable.Rows[i][5].ToString() + " = " + dataTable.Rows[i][6].ToString() + "ms" + Environment.NewLine;
            }
            toplamlar += " )";
            metin +=  Environment.NewLine +"Ortalama Yanıt Süresi (toplam yanıt zamanı / işlem sayısı) : " + Environment.NewLine + Environment.NewLine;
            metin +=  "Ortalama = " +toplamlar+" / "+ dataTable.Rows.Count .ToString() + " = "+ Math.Round((toplamBekleme / dataTable.Rows.Count), 2).ToString()+" ms";
            lblSonuc.Text = metin;
      

        }

      
    }
}
