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
using Excel = Microsoft.Office.Interop.Excel;

namespace Soytur1.IslemlerDetayForm
{
    public partial class ServisIslemleriForm : Form
    {
        public ServisIslemleriForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IslemlerForm islemgeri1 = new IslemlerForm();
            islemgeri1.Show();
            this.Hide();
        }

        bool tutus;
        int FareX, FareY;

        private void ServisIslemleriForm_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
        }

        private void ServisIslemleriForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;
            }
        }

        private void ServisIslemleriForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'soyturDataSet10.Servisİşlem' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.servisİşlemTableAdapter.Fill(this.soyturDataSet10.Servisİşlem);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServisİşlemleriKayıt git = new ServisİşlemleriKayıt();
            git.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServisİşlemleriKayıt git2 = new ServisİşlemleriKayıt();
            git2.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ServisIslemleriForm_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            export_dgw_excel_1(dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            export_dgw_excel_1(dataGridView2);
        }

        //EXXCEL


        bool export_dgw_excel_1(DataGridView dgw)
        {
            //Add Reference Microsoft.Office.Interop.Excel kütüphanesini ekleyin
            //using satırlarına using Excel = Microsoft.Office.Interop.Excel; satırını ekleyin.
            bool durum = false;
            try
            {
                dgw.SelectAll();
                DataObject dataObj = dgw.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
                Excel.Application xlexcel;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                //Kodumuz buraya kadar gelip veri aktarımını tamamladı ise durum true yaparak işlemin başarılı
                //Olduğu bilgisini alıyoruz.
                durum = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DataGrid Verileri Aktarılamadı : " + ex.Message);
            }
            return durum;
        }
    }
}
