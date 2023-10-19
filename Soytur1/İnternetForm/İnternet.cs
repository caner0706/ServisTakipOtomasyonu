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
    public partial class İnternet : Form
    {
        public İnternet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IslemlerForm geri = new IslemlerForm();
            geri.Show();
            this.Hide();
        }



        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void İnternet_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void İnternet_Load(object sender, EventArgs e)
        {
            StringBuilder adres = new StringBuilder();
            adres.Append("https://www.google.com/");
            webBrowser1.Navigate(adres.ToString());
        }
    }
}
