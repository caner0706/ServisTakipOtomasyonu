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


namespace Soytur1.KartlarDetayForm.KayıtDetay
{
    public partial class PersonelKayıt : Form
    {
        public PersonelKayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelKartlariForm geri = new PersonelKartlariForm();
            geri.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void Kayıtbtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into PersonelKart(Ad,Soyad,TC,Telefon,İşGirişTarihi,Departman,Görev,Bakiye) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Adtxt.Text);
            komut.Parameters.AddWithValue("@p2", Soyadtxt.Text);
            komut.Parameters.AddWithValue("@p3", TCmsk.Text);
            komut.Parameters.AddWithValue("@p4", Telefonmsk.Text);
            komut.Parameters.AddWithValue("@p5", İşGirişTarihimsk.Text);
            komut.Parameters.AddWithValue("@p6", Departmantxt.Text);
            komut.Parameters.AddWithValue("@p7", Görevtxt.Text);
            komut.Parameters.AddWithValue("@p8", Bakiyetxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Adtxt.Clear();
            Soyadtxt.Clear();
            TCmsk.Clear();
            Telefonmsk.Clear();
            İşGirişTarihimsk.Clear();
            Departmantxt.Clear();
            Görevtxt.Clear();
            Bakiyetxt.Clear();
        }
    }
}
