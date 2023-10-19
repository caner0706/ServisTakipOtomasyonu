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

namespace Soytur1.IslemlerDetayForm.KayıtForm
{
    public partial class EkstraİşKayıt : Form
    {
        public EkstraİşKayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EksrtaIs geri = new EksrtaIs();
            geri.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into EkstraİşKayıt(MüşteriAdı,Referans,FiyatProfili,HizmetTipi,BaşlamaTarihi,BaşlamaYeri,BitişTarihi,BitişYeri,YolcuSayısı,Güzergah,Açıklama) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MüşteriAdıtxt.Text);
            komut.Parameters.AddWithValue("@p2", Referanstxt.Text);
            komut.Parameters.AddWithValue("@p3", FiyatProfilitxt.Text);
            komut.Parameters.AddWithValue("@p4", HizmetTipitxt.Text);
            komut.Parameters.AddWithValue("@p5", BaşlamaTarihimsk.Text);
            komut.Parameters.AddWithValue("@p6", BaşlamaYeritxt.Text);
            komut.Parameters.AddWithValue("@p7", BitişTarihimsk.Text);
            komut.Parameters.AddWithValue("@p8", BitişYeritxt.Text);
            komut.Parameters.AddWithValue("@p9", YolcuSayısıtxt.Text);
            komut.Parameters.AddWithValue("@p10", Güzergahtxt.Text);
            komut.Parameters.AddWithValue("@p11", Açıklamatxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MüşteriAdıtxt.Clear();
            Referanstxt.Clear();
            FiyatProfilitxt.Clear();
            HizmetTipitxt.Clear();
            BaşlamaTarihimsk.Clear();
            BaşlamaYeritxt.Clear();
            BitişTarihimsk.Clear();
            BitişYeritxt.Clear();
            YolcuSayısıtxt.Clear();
            Güzergahtxt.Clear();
            Açıklamatxt.Clear();
        }

        private void EkstraİşKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
