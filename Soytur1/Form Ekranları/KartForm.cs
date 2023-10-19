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

namespace Soytur1.Form_Ekranları
{
    public partial class KartForm : Form
    {
        public KartForm()
        {
            InitializeComponent();
        }

        private void KartlarForm_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AkaryatikIstasyonlariForm geri3 = new AkaryatikIstasyonlariForm();
            geri3.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PersonelKartlariForm geri8 = new PersonelKartlariForm();
            geri8.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MusteriKartlaribtn_Click(object sender, EventArgs e)
        {
            MusteriKartiForm geri1 = new MusteriKartiForm();
            geri1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirisPaneli krtgeri = new GirisPaneli();
            krtgeri.Show();
            this.Hide();
        }

        private void TedarikciKartlaribtn_Click(object sender, EventArgs e)
        {
            TedarikciKartlariForm geri2 = new TedarikciKartlariForm();
            geri2.Show();
            this.Hide();
        }

        private void AracSahipleribtn_Click(object sender, EventArgs e)
        {
            AracSahipleriKartlariForm geri4 = new AracSahipleriKartlariForm();
            //KartlarForm.KartlarForm geri4 = new KartlarForm.KartlarForm();
            geri4.Show();
            this.Hide();
        }

        private void AracKartlaribtn_Click(object sender, EventArgs e)
        {
            KartlarForm.Araç geri5 = new KartlarForm.Araç();
            geri5.Show();
            this.Hide();
        }

        private void Pazarlamabtn_Click(object sender, EventArgs e)
        {
            PazarlamaKartlariForm geri6 = new PazarlamaKartlariForm();
            geri6.Show();
            this.Hide();
        }

        private void Muhasebebtn_Click(object sender, EventArgs e)
        {
            MuhasebeKartlariForm geri7 = new MuhasebeKartlariForm();
            geri7.Show();
            this.Hide();
        }

        private void EkstraİsMusteribtn_Click(object sender, EventArgs e)
        {
            EkstraİşMüş git = new EkstraİşMüş();
            git.Show();
            this.Hide();
        }

        bool tutus;
        int FareX, FareY;

        private void KartForm_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
        }

        private void KartForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İnternetForm.İnternet2 git = new İnternetForm.İnternet2();
            git.Show();
            this.Hide();
        }

        private void KartForm_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }
    }
}
