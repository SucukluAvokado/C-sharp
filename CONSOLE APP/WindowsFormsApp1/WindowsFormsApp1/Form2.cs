﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            form1.listBox1.Items.Add(textBox1.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Owner = this;
            form1.Show();
        }
    }
}
