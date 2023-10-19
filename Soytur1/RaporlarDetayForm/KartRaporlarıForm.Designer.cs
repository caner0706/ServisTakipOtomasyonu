﻿using Soytur;

namespace Soytur1.RaporlarDetayForm
{
    partial class KartRaporlarıForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KartRaporlarıForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.servisIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temsilciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servisİşlemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soyturDataSet13 = new Soytur.SoyturDataSet13();
            this.servisİşlemTableAdapter = new Soytur.SoyturDataSet13TableAdapters.ServisİşlemTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisİşlemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyturDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(339, 12);
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
            this.button2.TabIndex = 16;
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
            this.groupBox1.Size = new System.Drawing.Size(361, 393);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servis İşlem Raporları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servisIDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.temsilciDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servisİşlemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // servisIDDataGridViewTextBoxColumn
            // 
            this.servisIDDataGridViewTextBoxColumn.DataPropertyName = "ServisID";
            this.servisIDDataGridViewTextBoxColumn.HeaderText = "ServisID";
            this.servisIDDataGridViewTextBoxColumn.Name = "servisIDDataGridViewTextBoxColumn";
            this.servisIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // temsilciDataGridViewTextBoxColumn
            // 
            this.temsilciDataGridViewTextBoxColumn.DataPropertyName = "Temsilci";
            this.temsilciDataGridViewTextBoxColumn.HeaderText = "Temsilci";
            this.temsilciDataGridViewTextBoxColumn.Name = "temsilciDataGridViewTextBoxColumn";
            // 
            // servisİşlemBindingSource
            // 
            this.servisİşlemBindingSource.DataMember = "Servisİşlem";
            this.servisİşlemBindingSource.DataSource = this.soyturDataSet13;
            // 
            // soyturDataSet13
            // 
            this.soyturDataSet13.DataSetName = "SoyturDataSet13";
            this.soyturDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servisİşlemTableAdapter
            // 
            this.servisİşlemTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(45, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 27);
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // KartRaporlarıForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KartRaporlarıForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KartRaporlarıForm";
            this.Load += new System.EventHandler(this.KartRaporlarıForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KartRaporlarıForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KartRaporlarıForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KartRaporlarıForm_MouseUp);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisİşlemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyturDataSet13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SoyturDataSet13 soyturDataSet13;
        private System.Windows.Forms.BindingSource servisİşlemBindingSource;
        private Soytur.SoyturDataSet13TableAdapters.ServisİşlemTableAdapter servisİşlemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn servisIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temsilciDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}