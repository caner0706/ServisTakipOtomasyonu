using Soytur1.IslemlerDetayForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soytur1.Form_Ekranları
{
    public partial class IslemlerForm : Form
    {
        public IslemlerForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EksrtaIs git = new EksrtaIs();
            git.Show();
            this.Hide();
        }

        private void IslemlerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirisPaneli islgeri = new GirisPaneli();
            islgeri.Show();
            this.Hide();
        }

        private void ServisIslemleribtn_Click(object sender, EventArgs e)
        {
            ServisIslemleriForm islemgit1 = new ServisIslemleriForm();
            islemgit1.Show();
            this.Hide();
        }

        private void AaracIslemleribtn_Click(object sender, EventArgs e)
        {
            AracIslemleriForm islemgit2 = new AracIslemleriForm();
            islemgit2.Show();
            this.Hide();
        }

        private void MuhasebeIslemleribtn_Click(object sender, EventArgs e)
        {
            MuhasebeIslemleriForm islemgit3 = new MuhasebeIslemleriForm();
            islemgit3.Show();
            this.Hide();
        }

        private void FaturaIslemleribtn_Click(object sender, EventArgs e)
        {
        }
        
        bool tutus;
        int FareX, FareY;
        private void IslemlerForm_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
        }

        private void IslemlerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            İnternetForm.İnternet git = new İnternetForm.İnternet();
            git.Show();
            this.Hide();
        }

        private void IslemlerForm_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }
    }
}
