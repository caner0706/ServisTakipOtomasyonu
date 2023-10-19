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
    public partial class AraçSahipleriKayıt : Form
    {
        public AraçSahipleriKayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AracSahipleriKartlariForm geri = new AracSahipleriKartlariForm();
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
            SqlCommand komut = new SqlCommand("insert into AraçSahipleriKart(Adı,TC,CepTelefonu,Müşteri,Kategori,Bakiye) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Adtxt.Text);
            komut.Parameters.AddWithValue("@p2", TCmsk.Text);
            komut.Parameters.AddWithValue("@p3", Telefonmsk.Text);
            komut.Parameters.AddWithValue("@p4", Müşteritxt.Text);
            komut.Parameters.AddWithValue("@p5", Kategoritxt.Text);
            komut.Parameters.AddWithValue("@p6", Bakiyetxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Adtxt.Clear();
            TCmsk.Clear();
            Telefonmsk.Clear();
            Müşteritxt.Clear();
            Kategoritxt.Clear();
            Bakiyetxt.Clear();

        }
    }
}
