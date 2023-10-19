using Soytur1.Form_Ekranları;
using System;
using System.Windows.Forms;
using Soytur1.KartlarForm;


namespace Soytur1
{
    public partial class GirisPaneli : Form
    {
        public GirisPaneli()
        {
            InitializeComponent();
        }

        private void GirisPaneli_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Islemlerlbl_Click(object sender, EventArgs e)
        {

        }

        private void Kartlarbtn_Click(object sender, EventArgs e)
        {
            // Diğer Forma Geçmek İçin O Formdan Nesne Türet.
            KartForm krt = new KartForm();
            krt.Show();
            //  Geride Bırakılan Form Ekranını Hide Metoduyla Kapat.
            this.Hide();
        }

        private void Islemlerbtn_Click(object sender, EventArgs e)
        {
            IslemlerForm ıslm = new IslemlerForm();
            ıslm.Show();
            this.Hide();
        }

        private void Raporlarbtn_Click(object sender, EventArgs e)
        {
            RaporlarForm rpr = new RaporlarForm();
            rpr.Show();
            this.Hide();
        }

        private void Hesabımbtn_Click(object sender, EventArgs e)
        {
        }

        private void Tanımlarbtn_Click(object sender, EventArgs e)
        {
            TanimlarForm tnm = new TanimlarForm();
            tnm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        bool tutus;
        int FareX, FareY;
        private void GirisPaneli_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
        }

        private void GirisPaneli_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;
            }
        }

        private void GirisPaneli_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }
    }
}
