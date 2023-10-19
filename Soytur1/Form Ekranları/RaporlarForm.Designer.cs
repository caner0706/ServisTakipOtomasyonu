namespace Soytur1.Form_Ekranları
{
    partial class RaporlarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporlarForm));
            this.button1 = new System.Windows.Forms.Button();
            this.KartRaporlaribtn = new System.Windows.Forms.Button();
            this.AracRaporlaribtn = new System.Windows.Forms.Button();
            this.MhasebeRaporlaribtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(271, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 27);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KartRaporlaribtn
            // 
            this.KartRaporlaribtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.KartRaporlaribtn.Location = new System.Drawing.Point(68, 50);
            this.KartRaporlaribtn.Name = "KartRaporlaribtn";
            this.KartRaporlaribtn.Size = new System.Drawing.Size(163, 23);
            this.KartRaporlaribtn.TabIndex = 12;
            this.KartRaporlaribtn.Text = "Kart Raporları";
            this.KartRaporlaribtn.UseVisualStyleBackColor = false;
            this.KartRaporlaribtn.Click += new System.EventHandler(this.KartRaporlaribtn_Click);
            // 
            // AracRaporlaribtn
            // 
            this.AracRaporlaribtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AracRaporlaribtn.Location = new System.Drawing.Point(68, 89);
            this.AracRaporlaribtn.Name = "AracRaporlaribtn";
            this.AracRaporlaribtn.Size = new System.Drawing.Size(163, 23);
            this.AracRaporlaribtn.TabIndex = 13;
            this.AracRaporlaribtn.Text = "Araç Raporları";
            this.AracRaporlaribtn.UseVisualStyleBackColor = false;
            this.AracRaporlaribtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // MhasebeRaporlaribtn
            // 
            this.MhasebeRaporlaribtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MhasebeRaporlaribtn.Location = new System.Drawing.Point(68, 130);
            this.MhasebeRaporlaribtn.Name = "MhasebeRaporlaribtn";
            this.MhasebeRaporlaribtn.Size = new System.Drawing.Size(163, 23);
            this.MhasebeRaporlaribtn.TabIndex = 14;
            this.MhasebeRaporlaribtn.Text = "Muhasebe Raporları";
            this.MhasebeRaporlaribtn.UseVisualStyleBackColor = false;
            this.MhasebeRaporlaribtn.Click += new System.EventHandler(this.MhasebeRaporlaribtn_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 27);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(68, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "İnternet";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // RaporlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(317, 228);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MhasebeRaporlaribtn);
            this.Controls.Add(this.AracRaporlaribtn);
            this.Controls.Add(this.KartRaporlaribtn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RaporlarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporlarForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RaporlarForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RaporlarForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RaporlarForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button KartRaporlaribtn;
        private System.Windows.Forms.Button AracRaporlaribtn;
        private System.Windows.Forms.Button MhasebeRaporlaribtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}