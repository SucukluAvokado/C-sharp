﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\yunus\\Desktop\\1.mp3";
            pictureBox1.ImageLocation = "C:\\Users\\yunus\\Desktop\\Yunus\\images.jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\yunus\\Desktop\\2.mp3";
            pictureBox1.ImageLocation = "C:\\Users\\yunus\\Desktop\\Yunus\\kapakfotografi2.jpg";
        }
    }
}
