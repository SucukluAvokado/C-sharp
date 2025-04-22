using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsletimSistemleriDersUygulamalari
{
    public partial class ThreadFormu : Form
    {
        Form form;
        bool cizimOlsunMu = false;
        Point ilkNokta;
        ArrayList arrayList = new ArrayList();
        ArrayList arrayListTumLoglar = new ArrayList();
        public ThreadFormu(Form frm)
        {
            InitializeComponent();
            form = frm;
        }
        private void ThreadFormu_FormClosed(object sender, FormClosedEventArgs e)
        {
            string metin = "";
            for (int i = 0; i < arrayListTumLoglar.Count; i++)
            {
                metin += arrayListTumLoglar[i].ToString() + Environment.NewLine;

            }
            StreamWriter yazici = new StreamWriter(DateTime.Now.ToFileTime().ToString() + ".txt");
            yazici.Write(metin);
            yazici.Close();

            form.Show();
        }

        private void ThreadFormu_Load(object sender, EventArgs e)
        {



        }
        public void MaviKutu()
        {
            Action safeWrite = delegate { MaviKutu(); };
            if (pBoxMavi.InvokeRequired)
            {
                try
                {
                    pBoxMavi.Invoke(safeWrite);
                    listBox1.Invoke(safeWrite);
                }
                catch  
                {
                     
                }
            }
            else
            {
                pBoxMavi.Location = new Point(pBoxMavi.Location.X + 1, pBoxMavi.Location.Y);

            }
            if (!listBox1.InvokeRequired)
                listBox1.Items.Insert(0, "Mavi = " + threadMavi.ThreadState.ToString() + " - " + threadMavi.ManagedThreadId.ToString());
            arrayListTumLoglar.Add("Mavi = " + threadMavi.ThreadState.ToString() + " - " + threadMavi.ManagedThreadId.ToString() + " - " + DateTime.Now.ToString());
        }
        public void SiyahKutu()
        {
            Action safeWrite = delegate { SiyahKutu(); };
            if (pBoxSiyah.InvokeRequired)
            {try { 
                pBoxSiyah.Invoke(safeWrite);
                listBox1.Invoke(safeWrite);
                }
                catch
                {

                }
            }
            else
            {
                pBoxSiyah.Location = new Point(pBoxSiyah.Location.X + 1, pBoxSiyah.Location.Y);
            }
            if (!listBox1.InvokeRequired)
                listBox1.Items.Insert(0, "Siyah = " + threadSiyah.ThreadState.ToString() + " - " + threadSiyah.ManagedThreadId.ToString());
            arrayListTumLoglar.Add("Siyah = " + threadSiyah.ThreadState.ToString() + " - " + threadSiyah.ManagedThreadId.ToString() + " - " + DateTime.Now.ToString());
        }

        public void KirmiziKutu()
        {
            Action safeWrite = delegate { KirmiziKutu(); };
            if (pBoxKirmizi.InvokeRequired)
            {
                try { 
                pBoxKirmizi.Invoke(safeWrite);
                listBox1.Invoke(safeWrite);
                }
                catch
                {

                }

            }
            else
            {
                pBoxKirmizi.Location = new Point(pBoxKirmizi.Location.X + 1, pBoxKirmizi.Location.Y);
            }
            if (!listBox1.InvokeRequired)
                listBox1.Items.Insert(0, "Kırmızı = " + threadKirmizi.ThreadState.ToString() + " - " + threadKirmizi.ManagedThreadId.ToString());
            arrayListTumLoglar.Add("Kırmızı = " + threadKirmizi.ThreadState.ToString() + " - " + threadKirmizi.ManagedThreadId.ToString() + " - " + DateTime.Now.ToString());
        }
        public void YesilKutu()
        {
            Action safeWrite = delegate { YesilKutu(); };
            if (pBoxYesil.InvokeRequired)
            {
                try { 
                pBoxYesil.Invoke(safeWrite);
                listBox1.Invoke(safeWrite);
                }
                catch
                {

                }
            }
            else
            {
                pBoxYesil.Location = new Point(pBoxYesil.Location.X + 1, pBoxYesil.Location.Y);
            }
            if (!listBox1.InvokeRequired)
                listBox1.Items.Insert(0, "Yeşil = " + threadYesil.ThreadState.ToString() + " - " + threadYesil.ManagedThreadId.ToString());
            arrayListTumLoglar.Add("Yeşil = " + threadYesil.ThreadState.ToString() + " - " + threadYesil.ManagedThreadId.ToString() + " - " + DateTime.Now.ToString());
        }

        public void ArkaPlan()
        {
            Action safeWrite = delegate { ArkaPlan(); };
            if (this.InvokeRequired)
            {
                this.Invoke(safeWrite);
                listBox1.Invoke(safeWrite);
            }
            else
            {
                if (BackColor == Color.Pink)
                    BackColor = Color.Yellow;
                else
                    BackColor = Color.Pink;
            }
            if (!listBox1.InvokeRequired)
                listBox1.Items.Insert(0, "Arka Plan = " + threadArkaPlan.ThreadState.ToString() + " - " + threadArkaPlan.ManagedThreadId.ToString());
            arrayListTumLoglar.Add("Arka Plan = " + threadArkaPlan.ThreadState.ToString() + " - " + threadArkaPlan.ManagedThreadId.ToString() + " - " + DateTime.Now.ToString());
        }
        Thread threadMavi;
        Thread threadSiyah;
        Thread threadYesil;
        Thread threadKirmizi;
        Thread threadArkaPlan;
        private void timer1_Tick(object sender, EventArgs e)
        {
            threadYesil = new Thread(new ThreadStart(YesilKutu));
            threadYesil.Start();
            threadMavi = new Thread(new ThreadStart(MaviKutu));
            threadMavi.Start();
            threadSiyah = new Thread(new ThreadStart(SiyahKutu));
            threadSiyah.Start();
            threadKirmizi = new Thread(new ThreadStart(KirmiziKutu));
            threadKirmizi.Start();
            timer2.Start();
        }

        private void ThreadFormu_MouseDown(object sender, MouseEventArgs e)
        {
            cizimOlsunMu = true;
            ilkNokta = e.Location;
        }

        private void ThreadFormu_MouseMove(object sender, MouseEventArgs e)
        {
            Pen p = new Pen(Color.Red, 2);
            if (cizimOlsunMu)
            {
                Graphics g = this.CreateGraphics();
                g.DrawLine(p, ilkNokta, e.Location);
                ilkNokta = e.Location;
                arrayList.Add(ilkNokta);
            }
            p.Dispose();
        }

        private void ThreadFormu_MouseUp(object sender, MouseEventArgs e)
        {
            cizimOlsunMu = false;

        }

        private void ThreadFormu_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                try
                {
                    Pen p = new Pen(Color.Red, 2);

                    Graphics g = this.CreateGraphics();
                    g.DrawLine(p, (Point)arrayList[i - 1], (Point)arrayList[i]);
                    ilkNokta = (Point)arrayList[i];

                    p.Dispose();
                }
                catch
                {

                }
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                threadKirmizi.Interrupt(); 
            }
            catch  
            {
                 
            }
            try
            { 
                threadMavi.Interrupt(); 
            }
            catch
            {

            }
            try
            { 
                threadYesil.Interrupt(); 
            }
            catch
            {

            }
            try
            { 
                threadSiyah.Interrupt();
            }
            catch
            {

            }


            threadArkaPlan = new Thread(new ThreadStart(ArkaPlan));
            threadArkaPlan.Start();

       
        }
    }
}
