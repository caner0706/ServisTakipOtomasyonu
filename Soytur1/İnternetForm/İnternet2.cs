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
    public partial class İnternet2 : Form
    {
        public İnternet2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KartForm geri = new KartForm();
            geri.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void İnternet2_Load(object sender, EventArgs e)
        {
            StringBuilder adres = new StringBuilder();
            adres.Append("https://www.google.com/");
            webBrowser1.Navigate(adres.ToString());
        }
    }
}
