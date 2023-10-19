using Soytur1.TanimlarDetayForm;
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
    public partial class TanimlarForm : Form
    {
        public TanimlarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisPaneli tnmgeri = new GirisPaneli();
            tnmgeri.Show();
            this.Hide();
        }

        private void BölgeselTanimlarrbtn_Click(object sender, EventArgs e)
        {
            BölgeselTanimlarForm tanimlargit1 = new BölgeselTanimlarForm();
            tanimlargit1.Show();
            this.Hide();
        }

        private void FinansalTanimlarbtn_Click(object sender, EventArgs e)
        {
            FinansalTanimlarForm tanimlargit2 = new FinansalTanimlarForm();
            tanimlargit2.Show();
            this.Hide();
        }

        private void KartTanimalribtn_Click(object sender, EventArgs e)
        {
            KartTanimlariForm tanimlargit3 = new KartTanimlariForm();
            tanimlargit3.Show();
            this.Hide();
        }

        private void GüzergahTanimlaribtn_Click(object sender, EventArgs e)
        {
        }

        private void BelgeTanimlaribtn_Click(object sender, EventArgs e)
        {
        }

        private void SabitGiderlerbtn_Click(object sender, EventArgs e)
        {
        }

        private void EkstraIsFiyatProfilibtn_Click(object sender, EventArgs e)
        {
            EkstraIsFiyatProfiliForm tanimlargit7 = new EkstraIsFiyatProfiliForm();
            tanimlargit7.Show();
            this.Hide();
        }

        bool tutus;
        int FareX, FareY;
        private void TanimlarForm_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
        }

        private void TanimlarForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            İnternetForm.İnternet4 git = new İnternetForm.İnternet4();
            git.Show();
            this.Hide();
        }

        private void TanimlarForm_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }
    }
}
