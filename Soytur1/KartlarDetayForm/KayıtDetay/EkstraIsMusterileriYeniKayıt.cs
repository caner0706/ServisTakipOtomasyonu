﻿using Soytur1.Form_Ekranları;
using Soytur1.KartlarDetayForm;
using Soytur1.KartlarForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Soytur1.KartlarDetayForm
{
    public partial class EkstraIsMusterileriYeniKayıt : Form
    {
        public EkstraIsMusterileriYeniKayıt()
        {
            InitializeComponent();
        }

        private void EkstraIsMusterileriYeniKayıt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EkstraİşMüş geri = new EkstraİşMüş();
            geri.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void Kayıtbtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kayıt1 (Ad,Soyad,TicariÜnvan,İl,İlçe,Mahalle,Telefon,Mail,Tarih,Bilgi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Adtxt.Text);
            komut.Parameters.AddWithValue("@p2", Soyadtxt.Text);
            komut.Parameters.AddWithValue("@p3", TicariUnvantxt.Text);
            komut.Parameters.AddWithValue("@p4", Iltxt.Text);
            komut.Parameters.AddWithValue("@p5", Ilcetxt.Text);
            komut.Parameters.AddWithValue("@p6", Mahalletxt.Text);
            komut.Parameters.AddWithValue("@p7", Telefonmsk.Text);
            komut.Parameters.AddWithValue("@P8", Mailtxt.Text);
            komut.Parameters.AddWithValue("@p9", Tarihmsk.Text);
            komut.Parameters.AddWithValue("@p10", richTextBox1.Text); 
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Yapılmıştır.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            Adtxt.Clear();
            Soyadtxt.Clear();
            TicariUnvantxt.Clear();
            Iltxt.Clear();
            Ilcetxt.Clear();
            Mahalletxt.Clear();
            Telefonmsk.Clear();
            Mailtxt.Clear();
            Tarihmsk.Clear();
            richTextBox1.Clear();
        }

        private void Tarihmsk_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Notlbl_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tarihlbl_Click(object sender, EventArgs e)
        {

        }

        private void Mailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefonmsk_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Mahalletxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ilcetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Iltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void TicariUnvantxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Soyadtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Maillbl_Click(object sender, EventArgs e)
        {

        }

        private void Telefonlbl_Click(object sender, EventArgs e)
        {

        }

        private void Mahallelbl_Click(object sender, EventArgs e)
        {

        }

        private void İlcelbl_Click(object sender, EventArgs e)
        {

        }

        private void İllbl_Click(object sender, EventArgs e)
        {

        }

        private void Soyadlbl_Click(object sender, EventArgs e)
        {

        }

        private void Adlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
