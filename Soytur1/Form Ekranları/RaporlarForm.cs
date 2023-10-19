using Soytur1.RaporlarDetayForm;
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
    public partial class RaporlarForm : Form
    {
        public RaporlarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AracRaporlariForm raporgit2 = new AracRaporlariForm();
            raporgit2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisPaneli rprgeri = new GirisPaneli();
            rprgeri.Show();
            this.Hide();
        }

        private void KartRaporlaribtn_Click(object sender, EventArgs e)
        {
            KartRaporlarıForm raporgit1 = new KartRaporlarıForm();
            raporgit1.Show();
            this.Hide();
        }

        private void MhasebeRaporlaribtn_Click(object sender, EventArgs e)
        {
            MuhasebeRaporlarıForm raporgit3 = new MuhasebeRaporlarıForm();
            raporgit3.Show();
            this.Hide();
        }

        bool tutus;
        int FareX, FareY;

        private void RaporlarForm_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
        }

        private void RaporlarForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            İnternetForm.İnternet3 git = new İnternetForm.İnternet3();
            git.Show();
            this.Hide();
        }

        private void RaporlarForm_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }
    }
}
