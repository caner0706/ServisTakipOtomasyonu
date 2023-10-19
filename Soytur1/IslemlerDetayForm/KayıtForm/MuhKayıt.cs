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
    public partial class MuhKayıt : Form
    {
        public MuhKayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MuhasebeIslemleriForm geri = new MuhasebeIslemleriForm();
            geri.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Muhasebeİşlem(FişTarihi,FişTipi,FişNumarası,Açıklama) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Tarihmsk.Text);
            komut.Parameters.AddWithValue("@p2", FişTipitxt.Text);
            komut.Parameters.AddWithValue("@p3", FişNumarasıtxt.Text);
            komut.Parameters.AddWithValue("@p4", Açıklamatxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Tarihmsk.Clear();
            FişNumarasıtxt.Clear();
            FişTipitxt.Clear();
            Açıklamatxt.Clear();
        }
    }
}
