using Soytur;

namespace Soytur1.TanimlarDetayForm
{
    partial class EkstraIsFiyatProfiliForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EkstraIsFiyatProfiliForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.müşteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatProfiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hizmetTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.başlamaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.başlamaYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitişTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitişYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yolcuSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.güzergahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.açıklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekstraİşKayıtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soyturDataSet18 = new Soytur.SoyturDataSet18();
            this.ekstraİşKayıtTableAdapter = new Soytur.SoyturDataSet18TableAdapters.EkstraİşKayıtTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraİşKayıtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyturDataSet18)).BeginInit();
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
            this.groupBox1.Text = "Ekstra İş Fiyat Profili";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.müşteriIDDataGridViewTextBoxColumn,
            this.müşteriAdıDataGridViewTextBoxColumn,
            this.referansDataGridViewTextBoxColumn,
            this.fiyatProfiliDataGridViewTextBoxColumn,
            this.hizmetTipiDataGridViewTextBoxColumn,
            this.başlamaTarihiDataGridViewTextBoxColumn,
            this.başlamaYeriDataGridViewTextBoxColumn,
            this.bitişTarihiDataGridViewTextBoxColumn,
            this.bitişYeriDataGridViewTextBoxColumn,
            this.yolcuSayısıDataGridViewTextBoxColumn,
            this.güzergahDataGridViewTextBoxColumn,
            this.açıklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ekstraİşKayıtBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // müşteriIDDataGridViewTextBoxColumn
            // 
            this.müşteriIDDataGridViewTextBoxColumn.DataPropertyName = "MüşteriID";
            this.müşteriIDDataGridViewTextBoxColumn.HeaderText = "MüşteriID";
            this.müşteriIDDataGridViewTextBoxColumn.Name = "müşteriIDDataGridViewTextBoxColumn";
            this.müşteriIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // müşteriAdıDataGridViewTextBoxColumn
            // 
            this.müşteriAdıDataGridViewTextBoxColumn.DataPropertyName = "MüşteriAdı";
            this.müşteriAdıDataGridViewTextBoxColumn.HeaderText = "MüşteriAdı";
            this.müşteriAdıDataGridViewTextBoxColumn.Name = "müşteriAdıDataGridViewTextBoxColumn";
            // 
            // referansDataGridViewTextBoxColumn
            // 
            this.referansDataGridViewTextBoxColumn.DataPropertyName = "Referans";
            this.referansDataGridViewTextBoxColumn.HeaderText = "Referans";
            this.referansDataGridViewTextBoxColumn.Name = "referansDataGridViewTextBoxColumn";
            // 
            // fiyatProfiliDataGridViewTextBoxColumn
            // 
            this.fiyatProfiliDataGridViewTextBoxColumn.DataPropertyName = "FiyatProfili";
            this.fiyatProfiliDataGridViewTextBoxColumn.HeaderText = "FiyatProfili";
            this.fiyatProfiliDataGridViewTextBoxColumn.Name = "fiyatProfiliDataGridViewTextBoxColumn";
            // 
            // hizmetTipiDataGridViewTextBoxColumn
            // 
            this.hizmetTipiDataGridViewTextBoxColumn.DataPropertyName = "HizmetTipi";
            this.hizmetTipiDataGridViewTextBoxColumn.HeaderText = "HizmetTipi";
            this.hizmetTipiDataGridViewTextBoxColumn.Name = "hizmetTipiDataGridViewTextBoxColumn";
            // 
            // başlamaTarihiDataGridViewTextBoxColumn
            // 
            this.başlamaTarihiDataGridViewTextBoxColumn.DataPropertyName = "BaşlamaTarihi";
            this.başlamaTarihiDataGridViewTextBoxColumn.HeaderText = "BaşlamaTarihi";
            this.başlamaTarihiDataGridViewTextBoxColumn.Name = "başlamaTarihiDataGridViewTextBoxColumn";
            // 
            // başlamaYeriDataGridViewTextBoxColumn
            // 
            this.başlamaYeriDataGridViewTextBoxColumn.DataPropertyName = "BaşlamaYeri";
            this.başlamaYeriDataGridViewTextBoxColumn.HeaderText = "BaşlamaYeri";
            this.başlamaYeriDataGridViewTextBoxColumn.Name = "başlamaYeriDataGridViewTextBoxColumn";
            // 
            // bitişTarihiDataGridViewTextBoxColumn
            // 
            this.bitişTarihiDataGridViewTextBoxColumn.DataPropertyName = "BitişTarihi";
            this.bitişTarihiDataGridViewTextBoxColumn.HeaderText = "BitişTarihi";
            this.bitişTarihiDataGridViewTextBoxColumn.Name = "bitişTarihiDataGridViewTextBoxColumn";
            // 
            // bitişYeriDataGridViewTextBoxColumn
            // 
            this.bitişYeriDataGridViewTextBoxColumn.DataPropertyName = "BitişYeri";
            this.bitişYeriDataGridViewTextBoxColumn.HeaderText = "BitişYeri";
            this.bitişYeriDataGridViewTextBoxColumn.Name = "bitişYeriDataGridViewTextBoxColumn";
            // 
            // yolcuSayısıDataGridViewTextBoxColumn
            // 
            this.yolcuSayısıDataGridViewTextBoxColumn.DataPropertyName = "YolcuSayısı";
            this.yolcuSayısıDataGridViewTextBoxColumn.HeaderText = "YolcuSayısı";
            this.yolcuSayısıDataGridViewTextBoxColumn.Name = "yolcuSayısıDataGridViewTextBoxColumn";
            // 
            // güzergahDataGridViewTextBoxColumn
            // 
            this.güzergahDataGridViewTextBoxColumn.DataPropertyName = "Güzergah";
            this.güzergahDataGridViewTextBoxColumn.HeaderText = "Güzergah";
            this.güzergahDataGridViewTextBoxColumn.Name = "güzergahDataGridViewTextBoxColumn";
            // 
            // açıklamaDataGridViewTextBoxColumn
            // 
            this.açıklamaDataGridViewTextBoxColumn.DataPropertyName = "Açıklama";
            this.açıklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.açıklamaDataGridViewTextBoxColumn.Name = "açıklamaDataGridViewTextBoxColumn";
            // 
            // ekstraİşKayıtBindingSource
            // 
            this.ekstraİşKayıtBindingSource.DataMember = "EkstraİşKayıt";
            this.ekstraİşKayıtBindingSource.DataSource = this.soyturDataSet18;
            // 
            // soyturDataSet18
            // 
            this.soyturDataSet18.DataSetName = "SoyturDataSet18";
            this.soyturDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ekstraİşKayıtTableAdapter
            // 
            this.ekstraİşKayıtTableAdapter.ClearBeforeFill = true;
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
            // EkstraIsFiyatProfiliForm
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
            this.Name = "EkstraIsFiyatProfiliForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EkstraIsFiyatProfiliForm";
            this.Load += new System.EventHandler(this.EkstraIsFiyatProfiliForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EkstraIsFiyatProfiliForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EkstraIsFiyatProfiliForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EkstraIsFiyatProfiliForm_MouseUp);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekstraİşKayıtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyturDataSet18)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SoyturDataSet18 soyturDataSet18;
        private System.Windows.Forms.BindingSource ekstraİşKayıtBindingSource;
        private Soytur.SoyturDataSet18TableAdapters.EkstraİşKayıtTableAdapter ekstraİşKayıtTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatProfiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hizmetTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn başlamaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn başlamaYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitişTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitişYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yolcuSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn güzergahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn açıklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}