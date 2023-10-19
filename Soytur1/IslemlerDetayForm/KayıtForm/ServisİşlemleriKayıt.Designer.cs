namespace Soytur1.IslemlerDetayForm
{
    partial class ServisİşlemleriKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServisİşlemleriKayıt));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Adtxt = new System.Windows.Forms.TextBox();
            this.Temsilcitxt = new System.Windows.Forms.TextBox();
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
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Soytur1.Properties.Resources.WhatsApp_Image_2022_10_17_at_12_461;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(306, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 32);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Temsilci :";
            // 
            // Adtxt
            // 
            this.Adtxt.Location = new System.Drawing.Point(114, 66);
            this.Adtxt.Name = "Adtxt";
            this.Adtxt.Size = new System.Drawing.Size(143, 20);
            this.Adtxt.TabIndex = 1;
            // 
            // Temsilcitxt
            // 
            this.Temsilcitxt.Location = new System.Drawing.Point(114, 95);
            this.Temsilcitxt.Name = "Temsilcitxt";
            this.Temsilcitxt.Size = new System.Drawing.Size(143, 20);
            this.Temsilcitxt.TabIndex = 2;
            // 
            // Kayıtbtn
            // 
            this.Kayıtbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Kayıtbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayıtbtn.Location = new System.Drawing.Point(104, 132);
            this.Kayıtbtn.Name = "Kayıtbtn";
            this.Kayıtbtn.Size = new System.Drawing.Size(153, 24);
            this.Kayıtbtn.TabIndex = 3;
            this.Kayıtbtn.Text = "KAYIT";
            this.Kayıtbtn.UseVisualStyleBackColor = false;
            this.Kayıtbtn.Click += new System.EventHandler(this.Kayıtbtn_Click);
            // 
            // ServisİşlemleriKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(348, 177);
            this.Controls.Add(this.Kayıtbtn);
            this.Controls.Add(this.Temsilcitxt);
            this.Controls.Add(this.Adtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServisİşlemleriKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServisİşlemleriKayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Adtxt;
        private System.Windows.Forms.TextBox Temsilcitxt;
        private System.Windows.Forms.Button Kayıtbtn;
    }
}