﻿namespace Soytur1.IslemlerDetayForm.KayıtForm
{
    partial class MuhKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuhKayıt));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tarihmsk = new System.Windows.Forms.MaskedTextBox();
            this.FişTipitxt = new System.Windows.Forms.TextBox();
            this.FişNumarasıtxt = new System.Windows.Forms.TextBox();
            this.Açıklamatxt = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
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
            this.button2.Location = new System.Drawing.Point(640, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 32);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fiş Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fiş Tipi : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fiş Numarası :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Açıklama :";
            // 
            // Tarihmsk
            // 
            this.Tarihmsk.Location = new System.Drawing.Point(118, 65);
            this.Tarihmsk.Mask = "00/00/0000";
            this.Tarihmsk.Name = "Tarihmsk";
            this.Tarihmsk.Size = new System.Drawing.Size(132, 20);
            this.Tarihmsk.TabIndex = 1;
            this.Tarihmsk.ValidatingType = typeof(System.DateTime);
            // 
            // FişTipitxt
            // 
            this.FişTipitxt.Location = new System.Drawing.Point(118, 91);
            this.FişTipitxt.Name = "FişTipitxt";
            this.FişTipitxt.Size = new System.Drawing.Size(132, 20);
            this.FişTipitxt.TabIndex = 2;
            // 
            // FişNumarasıtxt
            // 
            this.FişNumarasıtxt.Location = new System.Drawing.Point(118, 117);
            this.FişNumarasıtxt.Name = "FişNumarasıtxt";
            this.FişNumarasıtxt.Size = new System.Drawing.Size(132, 20);
            this.FişNumarasıtxt.TabIndex = 3;
            // 
            // Açıklamatxt
            // 
            this.Açıklamatxt.Location = new System.Drawing.Point(375, 65);
            this.Açıklamatxt.Name = "Açıklamatxt";
            this.Açıklamatxt.Size = new System.Drawing.Size(236, 72);
            this.Açıklamatxt.TabIndex = 4;
            this.Açıklamatxt.Text = "";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(433, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 26);
            this.button3.TabIndex = 5;
            this.button3.Text = "KAYIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MuhKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(682, 207);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Açıklamatxt);
            this.Controls.Add(this.FişNumarasıtxt);
            this.Controls.Add(this.FişTipitxt);
            this.Controls.Add(this.Tarihmsk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MuhKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MuhKayıt";
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
        private System.Windows.Forms.MaskedTextBox Tarihmsk;
        private System.Windows.Forms.TextBox FişTipitxt;
        private System.Windows.Forms.TextBox FişNumarasıtxt;
        private System.Windows.Forms.RichTextBox Açıklamatxt;
        private System.Windows.Forms.Button button3;
    }
}