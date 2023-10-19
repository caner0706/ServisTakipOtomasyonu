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


namespace Soytur1.IslemlerDetayForm
{
    public partial class AraçİşlemleriKayıt : Form
    {
        public AraçİşlemleriKayıt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AracIslemleriForm geri = new AracIslemleriForm();
            geri.Show();
            this.Hide();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into FişGiriş(Ad,SonFişTarihi,DönemFişAdedi,Kar) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Adtxt.Text);
            komut.Parameters.AddWithValue("@p2", SonFişTarihimsk.Text);
            komut.Parameters.AddWithValue("@p3", DönemFişAdeditxt.Text);
            komut.Parameters.AddWithValue("@p4", Kartxt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Adtxt.Clear();
            SonFişTarihimsk.Clear();
            DönemFişAdeditxt.Clear();
            Kartxt.Clear();

        }
    }
}
