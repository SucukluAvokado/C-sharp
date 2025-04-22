
namespace IsletimSistemleriDersUygulamalari
{
    partial class ThreadFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pBoxYesil = new System.Windows.Forms.PictureBox();
            this.pBoxKirmizi = new System.Windows.Forms.PictureBox();
            this.pBoxMavi = new System.Windows.Forms.PictureBox();
            this.pBoxSiyah = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxYesil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKirmizi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMavi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSiyah)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxYesil
            // 
            this.pBoxYesil.BackColor = System.Drawing.Color.Lime;
            this.pBoxYesil.Location = new System.Drawing.Point(12, 12);
            this.pBoxYesil.Name = "pBoxYesil";
            this.pBoxYesil.Size = new System.Drawing.Size(43, 38);
            this.pBoxYesil.TabIndex = 0;
            this.pBoxYesil.TabStop = false;
            // 
            // pBoxKirmizi
            // 
            this.pBoxKirmizi.BackColor = System.Drawing.Color.Red;
            this.pBoxKirmizi.Location = new System.Drawing.Point(12, 127);
            this.pBoxKirmizi.Name = "pBoxKirmizi";
            this.pBoxKirmizi.Size = new System.Drawing.Size(43, 38);
            this.pBoxKirmizi.TabIndex = 0;
            this.pBoxKirmizi.TabStop = false;
            // 
            // pBoxMavi
            // 
            this.pBoxMavi.BackColor = System.Drawing.Color.Blue;
            this.pBoxMavi.Location = new System.Drawing.Point(12, 70);
            this.pBoxMavi.Name = "pBoxMavi";
            this.pBoxMavi.Size = new System.Drawing.Size(43, 38);
            this.pBoxMavi.TabIndex = 0;
            this.pBoxMavi.TabStop = false;
            // 
            // pBoxSiyah
            // 
            this.pBoxSiyah.BackColor = System.Drawing.Color.Black;
            this.pBoxSiyah.Location = new System.Drawing.Point(12, 184);
            this.pBoxSiyah.Name = "pBoxSiyah";
            this.pBoxSiyah.Size = new System.Drawing.Size(43, 38);
            this.pBoxSiyah.TabIndex = 0;
            this.pBoxSiyah.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(694, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 446);
            this.listBox1.TabIndex = 1;
            // 
            // timer2
            // 
            this.timer2.Interval = 2;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ThreadFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pBoxMavi);
            this.Controls.Add(this.pBoxSiyah);
            this.Controls.Add(this.pBoxKirmizi);
            this.Controls.Add(this.pBoxYesil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ThreadFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThreadFormu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThreadFormu_FormClosed);
            this.Load += new System.EventHandler(this.ThreadFormu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ThreadFormu_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThreadFormu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThreadFormu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThreadFormu_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxYesil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKirmizi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMavi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSiyah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxYesil;
        private System.Windows.Forms.PictureBox pBoxKirmizi;
        private System.Windows.Forms.PictureBox pBoxMavi;
        private System.Windows.Forms.PictureBox pBoxSiyah;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer2;
    }
}