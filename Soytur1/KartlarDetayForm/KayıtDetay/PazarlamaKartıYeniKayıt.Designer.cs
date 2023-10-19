namespace Soytur1.KartlarDetayForm
{
    partial class PazarlamaKartıYeniKayıt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PazarlamaKartıYeniKayıt));
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.Tarihmsk = new System.Windows.Forms.MaskedTextBox();
            this.Kayıtbtn = new System.Windows.Forms.Button();
            this.Notlbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Tarihlbl = new System.Windows.Forms.Label();
            this.Mailtxt = new System.Windows.Forms.TextBox();
            this.Telefonmsk = new System.Windows.Forms.MaskedTextBox();
            this.Mahalletxt = new System.Windows.Forms.TextBox();
            this.Ilcetxt = new System.Windows.Forms.TextBox();
            this.Iltxt = new System.Windows.Forms.TextBox();
            this.TicariUnvantxt = new System.Windows.Forms.TextBox();
            this.Soyadtxt = new System.Windows.Forms.TextBox();
            this.Adtxt = new System.Windows.Forms.TextBox();
            this.Maillbl = new System.Windows.Forms.Label();
            this.Telefonlbl = new System.Windows.Forms.Label();
            this.Mahallelbl = new System.Windows.Forms.Label();
            this.İlcelbl = new System.Windows.Forms.Label();
            this.İllbl = new System.Windows.Forms.Label();
            this.TicarıUncanlbl = new System.Windows.Forms.Label();
            this.Soyadlbl = new System.Windows.Forms.Label();
            this.Adlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Location = new System.Drawing.Point(590, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(34, 27);
            this.button10.TabIndex = 16;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Tarihmsk
            // 
            this.Tarihmsk.Location = new System.Drawing.Point(103, 286);
            this.Tarihmsk.Mask = "00/00/0000";
            this.Tarihmsk.Name = "Tarihmsk";
            this.Tarihmsk.Size = new System.Drawing.Size(144, 20);
            this.Tarihmsk.TabIndex = 9;
            this.Tarihmsk.ValidatingType = typeof(System.DateTime);
            // 
            // Kayıtbtn
            // 
            this.Kayıtbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Kayıtbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayıtbtn.Location = new System.Drawing.Point(337, 293);
            this.Kayıtbtn.Name = "Kayıtbtn";
            this.Kayıtbtn.Size = new System.Drawing.Size(207, 24);
            this.Kayıtbtn.TabIndex = 44;
            this.Kayıtbtn.Text = "KAYIT";
            this.Kayıtbtn.UseVisualStyleBackColor = false;
            this.Kayıtbtn.Click += new System.EventHandler(this.Kayıtbtn_Click);
            // 
            // Notlbl
            // 
            this.Notlbl.AutoSize = true;
            this.Notlbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Notlbl.Location = new System.Drawing.Point(298, 76);
            this.Notlbl.Name = "Notlbl";
            this.Notlbl.Size = new System.Drawing.Size(33, 15);
            this.Notlbl.TabIndex = 43;
            this.Notlbl.Text = "Not :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(337, 71);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(207, 209);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Tarihlbl
            // 
            this.Tarihlbl.AutoSize = true;
            this.Tarihlbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tarihlbl.Location = new System.Drawing.Point(56, 293);
            this.Tarihlbl.Name = "Tarihlbl";
            this.Tarihlbl.Size = new System.Drawing.Size(43, 15);
            this.Tarihlbl.TabIndex = 53;
            this.Tarihlbl.Text = "Tarih : ";
            // 
            // Mailtxt
            // 
            this.Mailtxt.Location = new System.Drawing.Point(103, 260);
            this.Mailtxt.Name = "Mailtxt";
            this.Mailtxt.Size = new System.Drawing.Size(144, 20);
            this.Mailtxt.TabIndex = 8;
            // 
            // Telefonmsk
            // 
            this.Telefonmsk.Location = new System.Drawing.Point(103, 234);
            this.Telefonmsk.Mask = "(999) 000-0000";
            this.Telefonmsk.Name = "Telefonmsk";
            this.Telefonmsk.Size = new System.Drawing.Size(144, 20);
            this.Telefonmsk.TabIndex = 7;
            // 
            // Mahalletxt
            // 
            this.Mahalletxt.Location = new System.Drawing.Point(103, 208);
            this.Mahalletxt.Name = "Mahalletxt";
            this.Mahalletxt.Size = new System.Drawing.Size(144, 20);
            this.Mahalletxt.TabIndex = 6;
            // 
            // Ilcetxt
            // 
            this.Ilcetxt.Location = new System.Drawing.Point(103, 182);
            this.Ilcetxt.Name = "Ilcetxt";
            this.Ilcetxt.Size = new System.Drawing.Size(144, 20);
            this.Ilcetxt.TabIndex = 5;
            // 
            // Iltxt
            // 
            this.Iltxt.Location = new System.Drawing.Point(103, 156);
            this.Iltxt.Name = "Iltxt";
            this.Iltxt.Size = new System.Drawing.Size(144, 20);
            this.Iltxt.TabIndex = 4;
            // 
            // TicariUnvantxt
            // 
            this.TicariUnvantxt.Location = new System.Drawing.Point(103, 130);
            this.TicariUnvantxt.Name = "TicariUnvantxt";
            this.TicariUnvantxt.Size = new System.Drawing.Size(144, 20);
            this.TicariUnvantxt.TabIndex = 3;
            // 
            // Soyadtxt
            // 
            this.Soyadtxt.Location = new System.Drawing.Point(103, 104);
            this.Soyadtxt.Name = "Soyadtxt";
            this.Soyadtxt.Size = new System.Drawing.Size(144, 20);
            this.Soyadtxt.TabIndex = 2;
            // 
            // Adtxt
            // 
            this.Adtxt.Location = new System.Drawing.Point(103, 76);
            this.Adtxt.Name = "Adtxt";
            this.Adtxt.Size = new System.Drawing.Size(144, 20);
            this.Adtxt.TabIndex = 1;
            // 
            // Maillbl
            // 
            this.Maillbl.AutoSize = true;
            this.Maillbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Maillbl.Location = new System.Drawing.Point(61, 267);
            this.Maillbl.Name = "Maillbl";
            this.Maillbl.Size = new System.Drawing.Size(40, 15);
            this.Maillbl.TabIndex = 52;
            this.Maillbl.Text = "Mail : ";
            // 
            // Telefonlbl
            // 
            this.Telefonlbl.AutoSize = true;
            this.Telefonlbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Telefonlbl.Location = new System.Drawing.Point(44, 241);
            this.Telefonlbl.Name = "Telefonlbl";
            this.Telefonlbl.Size = new System.Drawing.Size(56, 15);
            this.Telefonlbl.TabIndex = 51;
            this.Telefonlbl.Text = "Telefon : ";
            // 
            // Mahallelbl
            // 
            this.Mahallelbl.AutoSize = true;
            this.Mahallelbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mahallelbl.Location = new System.Drawing.Point(44, 215);
            this.Mahallelbl.Name = "Mahallelbl";
            this.Mahallelbl.Size = new System.Drawing.Size(59, 15);
            this.Mahallelbl.TabIndex = 50;
            this.Mahallelbl.Text = "Mahalle : ";
            // 
            // İlcelbl
            // 
            this.İlcelbl.AutoSize = true;
            this.İlcelbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İlcelbl.Location = new System.Drawing.Point(64, 189);
            this.İlcelbl.Name = "İlcelbl";
            this.İlcelbl.Size = new System.Drawing.Size(35, 15);
            this.İlcelbl.TabIndex = 49;
            this.İlcelbl.Text = "İlçe : ";
            // 
            // İllbl
            // 
            this.İllbl.AutoSize = true;
            this.İllbl.Location = new System.Drawing.Point(79, 163);
            this.İllbl.Name = "İllbl";
            this.İllbl.Size = new System.Drawing.Size(18, 13);
            this.İllbl.TabIndex = 48;
            this.İllbl.Text = "İl :";
            // 
            // TicarıUncanlbl
            // 
            this.TicarıUncanlbl.AutoSize = true;
            this.TicarıUncanlbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TicarıUncanlbl.Location = new System.Drawing.Point(15, 135);
            this.TicarıUncanlbl.Name = "TicarıUncanlbl";
            this.TicarıUncanlbl.Size = new System.Drawing.Size(88, 15);
            this.TicarıUncanlbl.TabIndex = 47;
            this.TicarıUncanlbl.Text = "Ticari Ünvanı : ";
            // 
            // Soyadlbl
            // 
            this.Soyadlbl.AutoSize = true;
            this.Soyadlbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Soyadlbl.Location = new System.Drawing.Point(51, 111);
            this.Soyadlbl.Name = "Soyadlbl";
            this.Soyadlbl.Size = new System.Drawing.Size(50, 15);
            this.Soyadlbl.TabIndex = 46;
            this.Soyadlbl.Text = "Soyad : ";
            // 
            // Adlbl
            // 
            this.Adlbl.AutoSize = true;
            this.Adlbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adlbl.Location = new System.Drawing.Point(68, 83);
            this.Adlbl.Name = "Adlbl";
            this.Adlbl.Size = new System.Drawing.Size(33, 15);
            this.Adlbl.TabIndex = 45;
            this.Adlbl.Text = "Ad : ";
            // 
            // PazarlamaKartıYeniKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(636, 386);
            this.Controls.Add(this.Tarihmsk);
            this.Controls.Add(this.Kayıtbtn);
            this.Controls.Add(this.Notlbl);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Tarihlbl);
            this.Controls.Add(this.Mailtxt);
            this.Controls.Add(this.Telefonmsk);
            this.Controls.Add(this.Mahalletxt);
            this.Controls.Add(this.Ilcetxt);
            this.Controls.Add(this.Iltxt);
            this.Controls.Add(this.TicariUnvantxt);
            this.Controls.Add(this.Soyadtxt);
            this.Controls.Add(this.Adtxt);
            this.Controls.Add(this.Maillbl);
            this.Controls.Add(this.Telefonlbl);
            this.Controls.Add(this.Mahallelbl);
            this.Controls.Add(this.İlcelbl);
            this.Controls.Add(this.İllbl);
            this.Controls.Add(this.TicarıUncanlbl);
            this.Controls.Add(this.Soyadlbl);
            this.Controls.Add(this.Adlbl);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PazarlamaKartıYeniKayıt";
            this.Text = "PazarlamaKartıYeniKayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.MaskedTextBox Tarihmsk;
        private System.Windows.Forms.Button Kayıtbtn;
        private System.Windows.Forms.Label Notlbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Tarihlbl;
        private System.Windows.Forms.TextBox Mailtxt;
        private System.Windows.Forms.MaskedTextBox Telefonmsk;
        private System.Windows.Forms.TextBox Mahalletxt;
        private System.Windows.Forms.TextBox Ilcetxt;
        private System.Windows.Forms.TextBox Iltxt;
        private System.Windows.Forms.TextBox TicariUnvantxt;
        private System.Windows.Forms.TextBox Soyadtxt;
        private System.Windows.Forms.TextBox Adtxt;
        private System.Windows.Forms.Label Maillbl;
        private System.Windows.Forms.Label Telefonlbl;
        private System.Windows.Forms.Label Mahallelbl;
        private System.Windows.Forms.Label İlcelbl;
        private System.Windows.Forms.Label İllbl;
        private System.Windows.Forms.Label TicarıUncanlbl;
        private System.Windows.Forms.Label Soyadlbl;
        private System.Windows.Forms.Label Adlbl;
    }
}