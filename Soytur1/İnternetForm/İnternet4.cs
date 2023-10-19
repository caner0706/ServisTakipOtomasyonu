using Soytur1.Form_Ekranları;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soytur1.İnternetForm
{
    public partial class İnternet4 : Form
    {
        public İnternet4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TanimlarForm geri = new TanimlarForm();
            geri.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void İnternet4_Load(object sender, EventArgs e)
        {
            StringBuilder adres = new StringBuilder();
            adres.Append("https://www.google.com/maps/place/");
            webBrowser1.Navigate(adres.ToString());
        }
    }
}
