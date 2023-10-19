using Soytur1.Form_Ekranları;
using Soytur1.IslemlerDetayForm.KayıtForm;
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
    public partial class EksrtaIs : Form
    {
        public EksrtaIs()
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

        private void button3_Click(object sender, EventArgs e)
        {
            EkstraİşKayıt git = new EkstraİşKayıt();
            git.Show();
            this.Hide();
        }

        private void EksrtaIs_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'soyturDataSet.EkstraİşKayıt' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ekstraİşKayıtTableAdapter.Fill(this.soyturDataSet.EkstraİşKayıt);

        }

        bool tutus;
        int FareX, FareY;

        private void EksrtaIs_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
        }

        private void EksrtaIs_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;
            }
        }

        private void EksrtaIs_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            export_dgw_excel_1(dataGridView1);
        }

        //EXCEL


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
