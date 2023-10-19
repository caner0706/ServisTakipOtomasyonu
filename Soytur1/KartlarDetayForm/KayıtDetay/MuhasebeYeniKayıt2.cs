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
    public partial class MuhasebeYeniKayıt2 : Form
    {
        public MuhasebeYeniKayıt2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MuhasebeKartlariForm geri = new MuhasebeKartlariForm();
            geri.Show();
            this.Hide();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into MüşteriKasaKayıt(HesapAdı,Bakiye) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", HesapAdıtxt.Text);
            komut.Parameters.AddWithValue("@p2", Bakiyetxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HesapAdıtxt.Clear();
            Bakiyetxt.Clear();
        }
    }
}
