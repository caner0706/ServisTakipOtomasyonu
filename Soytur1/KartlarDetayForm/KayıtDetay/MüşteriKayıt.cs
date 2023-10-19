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
    public partial class MüşteriKayıt : Form
    {
        public MüşteriKayıt()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriKartiForm geri = new MusteriKartiForm();
            geri.Show();
            this.Hide();
        }

        private void MüşteriKayıt_Load(object sender, EventArgs e)
        {

        }

        private void Telefonmsk_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void Kayıtbtn_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into MüşteriKart (Adı,TicariÜnavı,Telefon,VergiDairesi,VergiNumarası,Mail,Temsilci,İşAlımTarihi,Bakiye) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Adtxt.Text);
            komut.Parameters.AddWithValue("@p2", TicariÜnavtxt.Text);
            komut.Parameters.AddWithValue("@p3", Telefonmsk.Text);
            komut.Parameters.AddWithValue("@p4", VergiDairesitxt.Text);
            komut.Parameters.AddWithValue("@p5", VergiNumarasıtxt.Text);
            komut.Parameters.AddWithValue("@p6", Mailtxt.Text);
            komut.Parameters.AddWithValue("@p7", Temsilcitxt.Text);
            komut.Parameters.AddWithValue("@p8", Tarihmsk.Text);
            komut.Parameters.AddWithValue("@p9", Bakiyetxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Adtxt.Clear();
            TicariÜnavtxt.Clear();
            Telefonmsk.Clear();
            VergiDairesitxt.Clear();
            VergiNumarasıtxt.Clear();
            Mailtxt.Clear();
            Temsilcitxt.Clear();
            Tarihmsk.Clear();
            Bakiyetxt.Clear();
        }
    }
}
