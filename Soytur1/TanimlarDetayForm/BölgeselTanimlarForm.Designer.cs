using Soytur;

namespace Soytur1.TanimlarDetayForm
{
    partial class BölgeselTanimlarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BölgeselTanimlarForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ülkeAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ülkeKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ülkelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soyturDataSet15 = new Soytur.SoyturDataSet15();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ilAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telKoduDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.illerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soyturDataSet16 = new Soytur.SoyturDataSet16();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ilçeAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilçeKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilçelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soyturDataSet17 = new Soytur.SoyturDataSet17();
            this.ülkelerTableAdapter = new Soytur.SoyturDataSet15TableAdapters.ÜlkelerTableAdapter();
            this.İllerTableAdapter = new Soytur.SoyturDataSet16TableAdapters.İllerTableAdapter();
            this.İlçelerTableAdapter = new Soytur.SoyturDataSet17TableAdapters.İlçelerTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ülkelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyturDataSet15)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyturDataSet16)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilçelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyturDataSet17)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(819, 12);
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
            this.groupBox1.Size = new System.Drawing.Size(287, 393);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ülkeler ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ülkeAdıDataGridViewTextBoxColumn,
            this.ülkeKoduDataGridViewTextBoxColumn,
            this.telKoduDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ülkelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(275, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // ülkeAdıDataGridViewTextBoxColumn
            // 
            this.ülkeAdıDataGridViewTextBoxColumn.DataPropertyName = "ÜlkeAdı";
            this.ülkeAdıDataGridViewTextBoxColumn.HeaderText = "ÜlkeAdı";
            this.ülkeAdıDataGridViewTextBoxColumn.Name = "ülkeAdıDataGridViewTextBoxColumn";
            // 
            // ülkeKoduDataGridViewTextBoxColumn
            // 
            this.ülkeKoduDataGridViewTextBoxColumn.DataPropertyName = "ÜlkeKodu";
            this.ülkeKoduDataGridViewTextBoxColumn.HeaderText = "ÜlkeKodu";
            this.ülkeKoduDataGridViewTextBoxColumn.Name = "ülkeKoduDataGridViewTextBoxColumn";
            // 
            // telKoduDataGridViewTextBoxColumn
            // 
            this.telKoduDataGridViewTextBoxColumn.DataPropertyName = "Tel_Kodu";
            this.telKoduDataGridViewTextBoxColumn.HeaderText = "Tel_Kodu";
            this.telKoduDataGridViewTextBoxColumn.Name = "telKoduDataGridViewTextBoxColumn";
            // 
            // ülkelerBindingSource
            // 
            this.ülkelerBindingSource.DataMember = "Ülkeler";
            this.ülkelerBindingSource.DataSource = this.soyturDataSet15;
            // 
            // soyturDataSet15
            // 
            this.soyturDataSet15.DataSetName = "SoyturDataSet15";
            this.soyturDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(305, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 393);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İller";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ilAdıDataGridViewTextBoxColumn,
            this.telKoduDataGridViewTextBoxColumn1,
            this.plakaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.illerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(274, 366);
            this.dataGridView2.TabIndex = 0;
            // 
            // ilAdıDataGridViewTextBoxColumn
            // 
            this.ilAdıDataGridViewTextBoxColumn.DataPropertyName = "İlAdı";
            this.ilAdıDataGridViewTextBoxColumn.HeaderText = "İlAdı";
            this.ilAdıDataGridViewTextBoxColumn.Name = "ilAdıDataGridViewTextBoxColumn";
            // 
            // telKoduDataGridViewTextBoxColumn1
            // 
            this.telKoduDataGridViewTextBoxColumn1.DataPropertyName = "Tel_Kodu";
            this.telKoduDataGridViewTextBoxColumn1.HeaderText = "Tel_Kodu";
            this.telKoduDataGridViewTextBoxColumn1.Name = "telKoduDataGridViewTextBoxColumn1";
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            // 
            // illerBindingSource
            // 
            this.illerBindingSource.DataMember = "İller";
            this.illerBindingSource.DataSource = this.soyturDataSet16;
            // 
            // soyturDataSet16
            // 
            this.soyturDataSet16.DataSetName = "SoyturDataSet16";
            this.soyturDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(597, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 393);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İlçe Adı";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ilçeAdıDataGridViewTextBoxColumn,
            this.ilçeKoduDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.ilçelerBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(5, 20);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(243, 366);
            this.dataGridView3.TabIndex = 1;
            // 
            // ilçeAdıDataGridViewTextBoxColumn
            // 
            this.ilçeAdıDataGridViewTextBoxColumn.DataPropertyName = "İlçeAdı";
            this.ilçeAdıDataGridViewTextBoxColumn.HeaderText = "İlçeAdı";
            this.ilçeAdıDataGridViewTextBoxColumn.Name = "ilçeAdıDataGridViewTextBoxColumn";
            // 
            // ilçeKoduDataGridViewTextBoxColumn
            // 
            this.ilçeKoduDataGridViewTextBoxColumn.DataPropertyName = "İlçeKodu";
            this.ilçeKoduDataGridViewTextBoxColumn.HeaderText = "İlçeKodu";
            this.ilçeKoduDataGridViewTextBoxColumn.Name = "ilçeKoduDataGridViewTextBoxColumn";
            // 
            // ilçelerBindingSource
            // 
            this.ilçelerBindingSource.DataMember = "İlçeler";
            this.ilçelerBindingSource.DataSource = this.soyturDataSet17;
            // 
            // soyturDataSet17
            // 
            this.soyturDataSet17.DataSetName = "SoyturDataSet17";
            this.soyturDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ülkelerTableAdapter
            // 
            this.ülkelerTableAdapter.ClearBeforeFill = true;
            // 
            // İllerTableAdapter
            // 
            this.İllerTableAdapter.ClearBeforeFill = true;
            // 
            // İlçelerTableAdapter
            // 
            this.İlçelerTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(45, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 27);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BölgeselTanimlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BölgeselTanimlarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BölgeselTanimlarForm";
            this.Load += new System.EventHandler(this.BölgeselTanimlarForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BölgeselTanimlarForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BölgeselTanimlarForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BölgeselTanimlarForm_MouseUp);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ülkelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyturDataSet15)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyturDataSet16)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilçelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyturDataSet17)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private SoyturDataSet15 soyturDataSet15;
        private System.Windows.Forms.BindingSource ülkelerBindingSource;
        private Soytur.SoyturDataSet15TableAdapters.ÜlkelerTableAdapter ülkelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ülkeAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ülkeKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private SoyturDataSet16 soyturDataSet16;
        private System.Windows.Forms.BindingSource illerBindingSource;
        private Soytur.SoyturDataSet16TableAdapters.İllerTableAdapter İllerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telKoduDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private SoyturDataSet17 soyturDataSet17;
        private System.Windows.Forms.BindingSource ilçelerBindingSource;
        private Soytur.SoyturDataSet17TableAdapters.İlçelerTableAdapter İlçelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilçeAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilçeKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}