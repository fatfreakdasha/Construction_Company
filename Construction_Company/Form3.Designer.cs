﻿namespace Construction_Company
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDБригадираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имябригадираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDБригадыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бригадирыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.construction_CompanyDataSet = new Construction_Company.Construction_CompanyDataSet();
            this.бригадирыTableAdapter = new Construction_Company.Construction_CompanyDataSetTableAdapters.БригадирыTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бригадирыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_CompanyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDБригадираDataGridViewTextBoxColumn,
            this.имябригадираDataGridViewTextBoxColumn,
            this.iDБригадыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.бригадирыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(908, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDБригадираDataGridViewTextBoxColumn
            // 
            this.iDБригадираDataGridViewTextBoxColumn.DataPropertyName = "ID_Бригадира";
            this.iDБригадираDataGridViewTextBoxColumn.HeaderText = "ID_Бригадира";
            this.iDБригадираDataGridViewTextBoxColumn.Name = "iDБригадираDataGridViewTextBoxColumn";
            this.iDБригадираDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имябригадираDataGridViewTextBoxColumn
            // 
            this.имябригадираDataGridViewTextBoxColumn.DataPropertyName = "Имя_бригадира";
            this.имябригадираDataGridViewTextBoxColumn.HeaderText = "Имя_бригадира";
            this.имябригадираDataGridViewTextBoxColumn.Name = "имябригадираDataGridViewTextBoxColumn";
            // 
            // iDБригадыDataGridViewTextBoxColumn
            // 
            this.iDБригадыDataGridViewTextBoxColumn.DataPropertyName = "ID_Бригады";
            this.iDБригадыDataGridViewTextBoxColumn.HeaderText = "ID_Бригады";
            this.iDБригадыDataGridViewTextBoxColumn.Name = "iDБригадыDataGridViewTextBoxColumn";
            // 
            // бригадирыBindingSource
            // 
            this.бригадирыBindingSource.DataMember = "Бригадиры";
            this.бригадирыBindingSource.DataSource = this.construction_CompanyDataSet;
            // 
            // construction_CompanyDataSet
            // 
            this.construction_CompanyDataSet.DataSetName = "Construction_CompanyDataSet";
            this.construction_CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бригадирыTableAdapter
            // 
            this.бригадирыTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя бригадира";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID_Бригады";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(414, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(811, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бригадирыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_CompanyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Construction_CompanyDataSet construction_CompanyDataSet;
        private System.Windows.Forms.BindingSource бригадирыBindingSource;
        private Construction_CompanyDataSetTableAdapters.БригадирыTableAdapter бригадирыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDБригадираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имябригадираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDБригадыDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}