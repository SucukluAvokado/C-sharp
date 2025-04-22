using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();  

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";

            button4.Text = rnd.Next(1,4).ToString();

            for (int i = 0; i < 100; i++)
            {
                if (button1.Text != button4.Text)
                {
                    button1.Visible = false;
                }
                else if (button2.Text != button4.Text)
                {
                    button2.Visible = false;
                }
                else if(button3.Text != button4.Text)
                {
                    button3.Visible = false;
                }

                
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button4.Text == button1.Text)
            {
                MessageBox.Show("Doğru");
            }
            else
            {
                MessageBox.Show("Yanlış");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (button4.Text == button2.Text)
            {
                MessageBox.Show("Doğru");
            }
            else
            {
                MessageBox.Show("Yanlış");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (button4.Text == button3.Text)
            {
                MessageBox.Show("Doğru");
            }
            else
            {
                MessageBox.Show("Yanlış");
            }
        }
    }
}
