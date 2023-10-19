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
    public partial class AraçKartlarıKayıt : Form
    {
        public AraçKartlarıKayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araç geri = new Araç();
            geri.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AraçKartlarıKayıt_Load(object sender, EventArgs e)
        {

        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void Kayıtbtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into AraçKart(Plaka,AraçSahibi,AraçSahibiTelefon,AraçŞoförü,AraçŞoförüTelefon,Marka,Model,AraçTipi,Yıl,Kap,Kategori,YakıtKartNumarası,KayıtTarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Plakatxt.Text);
            komut.Parameters.AddWithValue("@p2", AraçSahibitxt.Text);
            komut.Parameters.AddWithValue("@p3", AraçSahibiTelefonmsk.Text);
            komut.Parameters.AddWithValue("@p4", AraçŞoförütxt.Text);
            komut.Parameters.AddWithValue("@p5", AraçŞoförüTelefonmsk.Text);
            komut.Parameters.AddWithValue("@p6", Markatxt.Text);
            komut.Parameters.AddWithValue("@p7", Modeltxt.Text);
            komut.Parameters.AddWithValue("@p8", AraçTipitxt.Text);
            komut.Parameters.AddWithValue("@p9", Yıltxt.Text);
            komut.Parameters.AddWithValue("@p10", Kaptxt.Text);
            komut.Parameters.AddWithValue("@p11", Kategoritxt.Text);
            komut.Parameters.AddWithValue("@p12", YakıtKartNumarasıtxt.Text);
            komut.Parameters.AddWithValue("@p13", Tarihmsk.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Plakatxt.Clear();
            AraçSahibitxt.Clear();
            AraçSahibiTelefonmsk.Clear();
            AraçŞoförütxt.Clear();
            AraçŞoförüTelefonmsk.Clear();
            Markatxt.Clear();
            AraçTipitxt.Clear();
            Yıltxt.Clear();
            Kaptxt.Clear();
            Kategoritxt.Clear();
            YakıtKartNumarasıtxt.Clear();
            Tarihmsk.Clear();
        }
    }
}
