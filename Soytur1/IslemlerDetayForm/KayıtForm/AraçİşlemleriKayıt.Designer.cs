﻿namespace Soytur1.IslemlerDetayForm
{
    partial class AraçİşlemleriKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AraçİşlemleriKayıt));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Adtxt = new System.Windows.Forms.TextBox();
            this.DönemFişAdeditxt = new System.Windows.Forms.TextBox();
            this.Kartxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SonFişTarihimsk = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Soytur1.Properties.Resources.WhatsApp_Image_2022_10_17_at_12_461;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(295, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 32);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Son Fiş Tarihi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Dönem Fiş Adedi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kar : ";
            // 
            // Adtxt
            // 
            this.Adtxt.Location = new System.Drawing.Point(122, 56);
            this.Adtxt.Name = "Adtxt";
            this.Adtxt.Size = new System.Drawing.Size(130, 20);
            this.Adtxt.TabIndex = 1;
            // 
            // DönemFişAdeditxt
            // 
            this.DönemFişAdeditxt.Location = new System.Drawing.Point(122, 108);
            this.DönemFişAdeditxt.Name = "DönemFişAdeditxt";
            this.DönemFişAdeditxt.Size = new System.Drawing.Size(130, 20);
            this.DönemFişAdeditxt.TabIndex = 3;
            // 
            // Kartxt
            // 
            this.Kartxt.Location = new System.Drawing.Point(122, 134);
            this.Kartxt.Name = "Kartxt";
            this.Kartxt.Size = new System.Drawing.Size(130, 20);
            this.Kartxt.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(138, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 26);
            this.button3.TabIndex = 5;
            this.button3.Text = "KAYIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SonFişTarihimsk
            // 
            this.SonFişTarihimsk.Location = new System.Drawing.Point(123, 81);
            this.SonFişTarihimsk.Mask = "00/00/0000";
            this.SonFişTarihimsk.Name = "SonFişTarihimsk";
            this.SonFişTarihimsk.Size = new System.Drawing.Size(129, 20);
            this.SonFişTarihimsk.TabIndex = 2;
            this.SonFişTarihimsk.ValidatingType = typeof(System.DateTime);
            // 
            // AraçİşlemleriKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(337, 208);
            this.Controls.Add(this.SonFişTarihimsk);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Kartxt);
            this.Controls.Add(this.DönemFişAdeditxt);
            this.Controls.Add(this.Adtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AraçİşlemleriKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AraçİşlemleriKayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Adtxt;
        private System.Windows.Forms.TextBox DönemFişAdeditxt;
        private System.Windows.Forms.TextBox Kartxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox SonFişTarihimsk;
    }
}