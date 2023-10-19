using Soytur;

namespace Soytur1.TanimlarDetayForm
{
    partial class KartTanimlariForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KartTanimlariForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.araçIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.araçSahibiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.araçSahibiTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.araçŞoförüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.araçŞoförüTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.araçTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yılDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakıtKartNumarasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayıtTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.araçKartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soyturDataSet19 = new Soytur.SoyturDataSet19();
            this.araçKartTableAdapter = new Soytur.SoyturDataSet19TableAdapters.AraçKartTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araçKartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyturDataSet19)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(754, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 27);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 27);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 393);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kart Tanımları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.araçIDDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.araçSahibiDataGridViewTextBoxColumn,
            this.araçSahibiTelefonDataGridViewTextBoxColumn,
            this.araçŞoförüDataGridViewTextBoxColumn,
            this.araçŞoförüTelefonDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.araçTipiDataGridViewTextBoxColumn,
            this.yılDataGridViewTextBoxColumn,
            this.kapDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.yakıtKartNumarasıDataGridViewTextBoxColumn,
            this.kayıtTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.araçKartBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // araçIDDataGridViewTextBoxColumn
            // 
            this.araçIDDataGridViewTextBoxColumn.DataPropertyName = "AraçID";
            this.araçIDDataGridViewTextBoxColumn.HeaderText = "AraçID";
            this.araçIDDataGridViewTextBoxColumn.Name = "araçIDDataGridViewTextBoxColumn";
            this.araçIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            // 
            // araçSahibiDataGridViewTextBoxColumn
            // 
            this.araçSahibiDataGridViewTextBoxColumn.DataPropertyName = "AraçSahibi";
            this.araçSahibiDataGridViewTextBoxColumn.HeaderText = "AraçSahibi";
            this.araçSahibiDataGridViewTextBoxColumn.Name = "araçSahibiDataGridViewTextBoxColumn";
            // 
            // araçSahibiTelefonDataGridViewTextBoxColumn
            // 
            this.araçSahibiTelefonDataGridViewTextBoxColumn.DataPropertyName = "AraçSahibiTelefon";
            this.araçSahibiTelefonDataGridViewTextBoxColumn.HeaderText = "AraçSahibiTelefon";
            this.araçSahibiTelefonDataGridViewTextBoxColumn.Name = "araçSahibiTelefonDataGridViewTextBoxColumn";
            // 
            // araçŞoförüDataGridViewTextBoxColumn
            // 
            this.araçŞoförüDataGridViewTextBoxColumn.DataPropertyName = "AraçŞoförü";
            this.araçŞoförüDataGridViewTextBoxColumn.HeaderText = "AraçŞoförü";
            this.araçŞoförüDataGridViewTextBoxColumn.Name = "araçŞoförüDataGridViewTextBoxColumn";
            // 
            // araçŞoförüTelefonDataGridViewTextBoxColumn
            // 
            this.araçŞoförüTelefonDataGridViewTextBoxColumn.DataPropertyName = "AraçŞoförüTelefon";
            this.araçŞoförüTelefonDataGridViewTextBoxColumn.HeaderText = "AraçŞoförüTelefon";
            this.araçŞoförüTelefonDataGridViewTextBoxColumn.Name = "araçŞoförüTelefonDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // araçTipiDataGridViewTextBoxColumn
            // 
            this.araçTipiDataGridViewTextBoxColumn.DataPropertyName = "AraçTipi";
            this.araçTipiDataGridViewTextBoxColumn.HeaderText = "AraçTipi";
            this.araçTipiDataGridViewTextBoxColumn.Name = "araçTipiDataGridViewTextBoxColumn";
            // 
            // yılDataGridViewTextBoxColumn
            // 
            this.yılDataGridViewTextBoxColumn.DataPropertyName = "Yıl";
            this.yılDataGridViewTextBoxColumn.HeaderText = "Yıl";
            this.yılDataGridViewTextBoxColumn.Name = "yılDataGridViewTextBoxColumn";
            // 
            // kapDataGridViewTextBoxColumn
            // 
            this.kapDataGridViewTextBoxColumn.DataPropertyName = "Kap";
            this.kapDataGridViewTextBoxColumn.HeaderText = "Kap";
            this.kapDataGridViewTextBoxColumn.Name = "kapDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // yakıtKartNumarasıDataGridViewTextBoxColumn
            // 
            this.yakıtKartNumarasıDataGridViewTextBoxColumn.DataPropertyName = "YakıtKartNumarası";
            this.yakıtKartNumarasıDataGridViewTextBoxColumn.HeaderText = "YakıtKartNumarası";
            this.yakıtKartNumarasıDataGridViewTextBoxColumn.Name = "yakıtKartNumarasıDataGridViewTextBoxColumn";
            // 
            // kayıtTarihiDataGridViewTextBoxColumn
            // 
            this.kayıtTarihiDataGridViewTextBoxColumn.DataPropertyName = "KayıtTarihi";
            this.kayıtTarihiDataGridViewTextBoxColumn.HeaderText = "KayıtTarihi";
            this.kayıtTarihiDataGridViewTextBoxColumn.Name = "kayıtTarihiDataGridViewTextBoxColumn";
            // 
            // araçKartBindingSource
            // 
            this.araçKartBindingSource.DataMember = "AraçKart";
            this.araçKartBindingSource.DataSource = this.soyturDataSet19;
            // 
            // soyturDataSet19
            // 
            this.soyturDataSet19.DataSetName = "SoyturDataSet19";
            this.soyturDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // araçKartTableAdapter
            // 
            this.araçKartTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(45, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 27);
            this.button4.TabIndex = 23;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // KartTanimlariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KartTanimlariForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KartTanimlariForm";
            this.Load += new System.EventHandler(this.KartTanimlariForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KartTanimlariForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KartTanimlariForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KartTanimlariForm_MouseUp);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araçKartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyturDataSet19)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SoyturDataSet19 soyturDataSet19;
        private System.Windows.Forms.BindingSource araçKartBindingSource;
        private Soytur.SoyturDataSet19TableAdapters.AraçKartTableAdapter araçKartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn araçIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn araçSahibiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn araçSahibiTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn araçŞoförüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn araçŞoförüTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn araçTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yılDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakıtKartNumarasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayıtTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}