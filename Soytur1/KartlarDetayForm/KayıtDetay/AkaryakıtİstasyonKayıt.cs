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
    public partial class AkaryakıtİstasyonKayıt : Form
    {
        public AkaryakıtİstasyonKayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AkaryatikIstasyonlariForm geri = new AkaryatikIstasyonlariForm();
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
            SqlCommand komut = new SqlCommand("insert into AkaryakıtİstasyonKart(Adı,TicariÜnvanı,Telefon,Yetkili,Bakiye) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Adtxt.Text);
            komut.Parameters.AddWithValue("@p2", TicariÜnvantxt.Text);
            komut.Parameters.AddWithValue("@p3", Telefonmsk.Text);
            komut.Parameters.AddWithValue("@p4", Yetkilitxt.Text);
            komut.Parameters.AddWithValue("@p5", Bakiyetxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
