using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soytur1.Models;

namespace Soytur1
{
    public partial class Form1 : Form
    {

        Soytur.Models.SoyturEntitiesConnectionDb db = new Soytur.Models.SoyturEntitiesConnectionDb();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static int Id;

        private void button1_Click(object sender, EventArgs e)
        {

            // Veri Tabanından Bilgileri Çekerek Kullanıcının Girmiş Olduğu Bilgiler İle Kontrol Satırı...
            var Durum = db.GirisTablosu.FirstOrDefault(x => x.KullaniciAdi == textBox1.Text && x.Sifre == textBox2.Text);

            if (Durum != null)
            {
                Id = Durum.id;
                GirisPaneli gb = new GirisPaneli();
                gb.Show();
                this.Hide();
            }  
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalıdır...","Durum",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Şifre_Sıfırlama st = new Şifre_Sıfırlama();
            st.Show();
            this.Hide();
         
        }

        bool tutus;
        int FareX, FareY;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if(tutus == true)
            {
                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            linkLabel2.Text= DateTime.Now.ToString();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }

    }
}
