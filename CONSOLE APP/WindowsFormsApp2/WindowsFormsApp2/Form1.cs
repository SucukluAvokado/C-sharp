﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SoundPlayer sound = new SoundPlayer(@"C:\\Users\\yunus\\Desktop\\Yunus\\Müzikli şarkılar.mp3");

        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sound.Play();
        }
    }
}
