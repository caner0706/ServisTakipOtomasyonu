using Soytur1.Form_Ekranları;
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
    public partial class Şifre_Sıfırlama : Form
    {
        public Şifre_Sıfırlama()
        {
            InitializeComponent();
        }

        private void Şifre_Sıfırlama_Load(object sender, EventArgs e)
        {

        }

        MailGonderici mg = new MailGonderici();
        private void button1_Click(object sender, EventArgs e)
        {
            mg.Microsoft(textBox1.Text, textBox2.Text,textBox1.Text);
            MessageBox.Show("Yeni Şifreniz Mail Olarak Gönderilecektir.","Durum",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        bool tutus;
        int FareX, FareY;
        private void Şifre_Sıfırlama_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
        }

        private void Şifre_Sıfırlama_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;
            }
        }

        private void Şifre_Sıfırlama_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }
    }
}
