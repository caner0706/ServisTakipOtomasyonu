using Soytur;

namespace Soytur1.IslemlerDetayForm
{
    partial class MuhasebeIslemleriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuhasebeIslemleriForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fişIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fişTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fişTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fişNumarasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.açıklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muhasebeİşlemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soyturDataSet11 = new Soytur.SoyturDataSet11();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.muhasebeİşlemTableAdapter = new Soytur.SoyturDataSet11TableAdapters.MuhasebeİşlemTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeİşlemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyturDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 393);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Muhasebe Fiş Girişi ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fişIDDataGridViewTextBoxColumn,
            this.fişTarihiDataGridViewTextBoxColumn,
            this.fişTipiDataGridViewTextBoxColumn,
            this.fişNumarasıDataGridViewTextBoxColumn,
            this.açıklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.muhasebeİşlemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // fişIDDataGridViewTextBoxColumn
            // 
            this.fişIDDataGridViewTextBoxColumn.DataPropertyName = "FişID";
            this.fişIDDataGridViewTextBoxColumn.HeaderText = "FişID";
            this.fişIDDataGridViewTextBoxColumn.Name = "fişIDDataGridViewTextBoxColumn";
            this.fişIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fişTarihiDataGridViewTextBoxColumn
            // 
            this.fişTarihiDataGridViewTextBoxColumn.DataPropertyName = "FişTarihi";
            this.fişTarihiDataGridViewTextBoxColumn.HeaderText = "FişTarihi";
            this.fişTarihiDataGridViewTextBoxColumn.Name = "fişTarihiDataGridViewTextBoxColumn";
            // 
            // fişTipiDataGridViewTextBoxColumn
            // 
            this.fişTipiDataGridViewTextBoxColumn.DataPropertyName = "FişTipi";
            this.fişTipiDataGridViewTextBoxColumn.HeaderText = "FişTipi";
            this.fişTipiDataGridViewTextBoxColumn.Name = "fişTipiDataGridViewTextBoxColumn";
            // 
            // fişNumarasıDataGridViewTextBoxColumn
            // 
            this.fişNumarasıDataGridViewTextBoxColumn.DataPropertyName = "FişNumarası";
            this.fişNumarasıDataGridViewTextBoxColumn.HeaderText = "FişNumarası";
            this.fişNumarasıDataGridViewTextBoxColumn.Name = "fişNumarasıDataGridViewTextBoxColumn";
            // 
            // açıklamaDataGridViewTextBoxColumn
            // 
            this.açıklamaDataGridViewTextBoxColumn.DataPropertyName = "Açıklama";
            this.açıklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.açıklamaDataGridViewTextBoxColumn.Name = "açıklamaDataGridViewTextBoxColumn";
            // 
            // muhasebeİşlemBindingSource
            // 
            this.muhasebeİşlemBindingSource.DataMember = "Muhasebeİşlem";
            this.muhasebeİşlemBindingSource.DataSource = this.soyturDataSet11;
            // 
            // soyturDataSet11
            // 
            this.soyturDataSet11.DataSetName = "SoyturDataSet11";
            this.soyturDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(45, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 27);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Soytur1.Properties.Resources.WhatsApp_Image_2022_10_17_at_12_461;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(541, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 32);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // muhasebeİşlemTableAdapter
            // 
            this.muhasebeİşlemTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(78, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 27);
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MuhasebeIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MuhasebeIslemleriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MuhasebeIslemleriForm";
            this.Load += new System.EventHandler(this.MuhasebeIslemleriForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MuhasebeIslemleriForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MuhasebeIslemleriForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MuhasebeIslemleriForm_MouseUp);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeİşlemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyturDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private SoyturDataSet11 soyturDataSet11;
        private System.Windows.Forms.BindingSource muhasebeİşlemBindingSource;
        private Soytur.SoyturDataSet11TableAdapters.MuhasebeİşlemTableAdapter muhasebeİşlemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fişIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fişTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fişTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fişNumarasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn açıklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}