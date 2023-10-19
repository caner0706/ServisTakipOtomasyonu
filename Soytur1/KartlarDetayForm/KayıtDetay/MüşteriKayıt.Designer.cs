namespace Soytur1.KartlarDetayForm.KayıtDetay
{
    partial class MüşteriKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüşteriKayıt));
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.Tarihmsk = new System.Windows.Forms.MaskedTextBox();
            this.Tarihlbl = new System.Windows.Forms.Label();
            this.Mailtxt = new System.Windows.Forms.TextBox();
            this.Telefonmsk = new System.Windows.Forms.MaskedTextBox();
            this.Temsilcitxt = new System.Windows.Forms.TextBox();
            this.VergiNumarasıtxt = new System.Windows.Forms.TextBox();
            this.VergiDairesitxt = new System.Windows.Forms.TextBox();
            this.TicariÜnavtxt = new System.Windows.Forms.TextBox();
            this.Adtxt = new System.Windows.Forms.TextBox();
            this.Maillbl = new System.Windows.Forms.Label();
            this.Telefonlbl = new System.Windows.Forms.Label();
            this.Mahallelbl = new System.Windows.Forms.Label();
            this.İlcelbl = new System.Windows.Forms.Label();
            this.TicarıUncanlbl = new System.Windows.Forms.Label();
            this.Adlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bakiyetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Kayıtbtn = new System.Windows.Forms.Button();
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
            this.button10.Location = new System.Drawing.Point(276, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(34, 27);
            this.button10.TabIndex = 15;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Tarihmsk
            // 
            this.Tarihmsk.Location = new System.Drawing.Point(112, 244);
            this.Tarihmsk.Mask = "00/00/0000";
            this.Tarihmsk.Name = "Tarihmsk";
            this.Tarihmsk.Size = new System.Drawing.Size(144, 20);
            this.Tarihmsk.TabIndex = 8;
            this.Tarihmsk.ValidatingType = typeof(System.DateTime);
            // 
            // Tarihlbl
            // 
            this.Tarihlbl.AutoSize = true;
            this.Tarihlbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tarihlbl.Location = new System.Drawing.Point(63, 251);
            this.Tarihlbl.Name = "Tarihlbl";
            this.Tarihlbl.Size = new System.Drawing.Size(43, 15);
            this.Tarihlbl.TabIndex = 50;
            this.Tarihlbl.Text = "Tarih : ";
            // 
            // Mailtxt
            // 
            this.Mailtxt.Location = new System.Drawing.Point(112, 192);
            this.Mailtxt.Name = "Mailtxt";
            this.Mailtxt.Size = new System.Drawing.Size(144, 20);
            this.Mailtxt.TabIndex = 6;
            // 
            // Telefonmsk
            // 
            this.Telefonmsk.Location = new System.Drawing.Point(112, 114);
            this.Telefonmsk.Mask = "(999) 000-0000";
            this.Telefonmsk.Name = "Telefonmsk";
            this.Telefonmsk.Size = new System.Drawing.Size(144, 20);
            this.Telefonmsk.TabIndex = 3;
            this.Telefonmsk.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Telefonmsk_MaskInputRejected);
            // 
            // Temsilcitxt
            // 
            this.Temsilcitxt.Location = new System.Drawing.Point(112, 218);
            this.Temsilcitxt.Name = "Temsilcitxt";
            this.Temsilcitxt.Size = new System.Drawing.Size(144, 20);
            this.Temsilcitxt.TabIndex = 7;
            // 
            // VergiNumarasıtxt
            // 
            this.VergiNumarasıtxt.Location = new System.Drawing.Point(112, 166);
            this.VergiNumarasıtxt.Name = "VergiNumarasıtxt";
            this.VergiNumarasıtxt.Size = new System.Drawing.Size(144, 20);
            this.VergiNumarasıtxt.TabIndex = 5;
            // 
            // VergiDairesitxt
            // 
            this.VergiDairesitxt.Location = new System.Drawing.Point(112, 140);
            this.VergiDairesitxt.Name = "VergiDairesitxt";
            this.VergiDairesitxt.Size = new System.Drawing.Size(144, 20);
            this.VergiDairesitxt.TabIndex = 4;
            // 
            // TicariÜnavtxt
            // 
            this.TicariÜnavtxt.Location = new System.Drawing.Point(112, 88);
            this.TicariÜnavtxt.Name = "TicariÜnavtxt";
            this.TicariÜnavtxt.Size = new System.Drawing.Size(144, 20);
            this.TicariÜnavtxt.TabIndex = 2;
            // 
            // Adtxt
            // 
            this.Adtxt.Location = new System.Drawing.Point(112, 60);
            this.Adtxt.Name = "Adtxt";
            this.Adtxt.Size = new System.Drawing.Size(144, 20);
            this.Adtxt.TabIndex = 1;
            // 
            // Maillbl
            // 
            this.Maillbl.AutoSize = true;
            this.Maillbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Maillbl.Location = new System.Drawing.Point(66, 199);
            this.Maillbl.Name = "Maillbl";
            this.Maillbl.Size = new System.Drawing.Size(40, 15);
            this.Maillbl.TabIndex = 49;
            this.Maillbl.Text = "Mail : ";
            // 
            // Telefonlbl
            // 
            this.Telefonlbl.AutoSize = true;
            this.Telefonlbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Telefonlbl.Location = new System.Drawing.Point(50, 121);
            this.Telefonlbl.Name = "Telefonlbl";
            this.Telefonlbl.Size = new System.Drawing.Size(56, 15);
            this.Telefonlbl.TabIndex = 48;
            this.Telefonlbl.Text = "Telefon : ";
            // 
            // Mahallelbl
            // 
            this.Mahallelbl.AutoSize = true;
            this.Mahallelbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mahallelbl.Location = new System.Drawing.Point(47, 223);
            this.Mahallelbl.Name = "Mahallelbl";
            this.Mahallelbl.Size = new System.Drawing.Size(59, 15);
            this.Mahallelbl.TabIndex = 47;
            this.Mahallelbl.Text = "Temsilci : ";
            // 
            // İlcelbl
            // 
            this.İlcelbl.AutoSize = true;
            this.İlcelbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İlcelbl.Location = new System.Drawing.Point(10, 171);
            this.İlcelbl.Name = "İlcelbl";
            this.İlcelbl.Size = new System.Drawing.Size(96, 15);
            this.İlcelbl.TabIndex = 46;
            this.İlcelbl.Text = "Vergi Numarası : ";
            // 
            // TicarıUncanlbl
            // 
            this.TicarıUncanlbl.AutoSize = true;
            this.TicarıUncanlbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TicarıUncanlbl.Location = new System.Drawing.Point(18, 93);
            this.TicarıUncanlbl.Name = "TicarıUncanlbl";
            this.TicarıUncanlbl.Size = new System.Drawing.Size(88, 15);
            this.TicarıUncanlbl.TabIndex = 44;
            this.TicarıUncanlbl.Text = "Ticari Ünvanı : ";
            // 
            // Adlbl
            // 
            this.Adlbl.AutoSize = true;
            this.Adlbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adlbl.Location = new System.Drawing.Point(73, 67);
            this.Adlbl.Name = "Adlbl";
            this.Adlbl.Size = new System.Drawing.Size(33, 15);
            this.Adlbl.TabIndex = 42;
            this.Adlbl.Text = "Ad : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Vergi Dairesi : ";
            // 
            // Bakiyetxt
            // 
            this.Bakiyetxt.Location = new System.Drawing.Point(112, 269);
            this.Bakiyetxt.Name = "Bakiyetxt";
            this.Bakiyetxt.Size = new System.Drawing.Size(144, 20);
            this.Bakiyetxt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "Bakiye : ";
            // 
            // Kayıtbtn
            // 
            this.Kayıtbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Kayıtbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayıtbtn.Location = new System.Drawing.Point(49, 311);
            this.Kayıtbtn.Name = "Kayıtbtn";
            this.Kayıtbtn.Size = new System.Drawing.Size(207, 24);
            this.Kayıtbtn.TabIndex = 10;
            this.Kayıtbtn.Text = "KAYIT";
            this.Kayıtbtn.UseVisualStyleBackColor = false;
            this.Kayıtbtn.Click += new System.EventHandler(this.Kayıtbtn_Click);
            // 
            // MüşteriKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(322, 364);
            this.Controls.Add(this.Kayıtbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bakiyetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tarihmsk);
            this.Controls.Add(this.Tarihlbl);
            this.Controls.Add(this.Mailtxt);
            this.Controls.Add(this.Telefonmsk);
            this.Controls.Add(this.Temsilcitxt);
            this.Controls.Add(this.VergiNumarasıtxt);
            this.Controls.Add(this.VergiDairesitxt);
            this.Controls.Add(this.TicariÜnavtxt);
            this.Controls.Add(this.Adtxt);
            this.Controls.Add(this.Maillbl);
            this.Controls.Add(this.Telefonlbl);
            this.Controls.Add(this.Mahallelbl);
            this.Controls.Add(this.İlcelbl);
            this.Controls.Add(this.TicarıUncanlbl);
            this.Controls.Add(this.Adlbl);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MüşteriKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MüşteriKayıt";
            this.Load += new System.EventHandler(this.MüşteriKayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.MaskedTextBox Tarihmsk;
        private System.Windows.Forms.Label Tarihlbl;
        private System.Windows.Forms.TextBox Mailtxt;
        private System.Windows.Forms.MaskedTextBox Telefonmsk;
        private System.Windows.Forms.TextBox Temsilcitxt;
        private System.Windows.Forms.TextBox VergiNumarasıtxt;
        private System.Windows.Forms.TextBox VergiDairesitxt;
        private System.Windows.Forms.TextBox TicariÜnavtxt;
        private System.Windows.Forms.TextBox Adtxt;
        private System.Windows.Forms.Label Maillbl;
        private System.Windows.Forms.Label Telefonlbl;
        private System.Windows.Forms.Label Mahallelbl;
        private System.Windows.Forms.Label İlcelbl;
        private System.Windows.Forms.Label TicarıUncanlbl;
        private System.Windows.Forms.Label Adlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Bakiyetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Kayıtbtn;
    }
}