namespace Construction_Company
{
    partial class Form5
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
            this.construction_CompanyDataSet2 = new Construction_Company.Construction_CompanyDataSet2();
            this.графикработBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.график_работTableAdapter = new Construction_Company.Construction_CompanyDataSet2TableAdapters.График_работTableAdapter();
            this.iDГрафикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЗданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаначалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаокончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_CompanyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.графикработBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDГрафикаDataGridViewTextBoxColumn,
            this.iDЗданияDataGridViewTextBoxColumn,
            this.датаначалаDataGridViewTextBoxColumn,
            this.датаокончанияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.графикработBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(889, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // construction_CompanyDataSet2
            // 
            this.construction_CompanyDataSet2.DataSetName = "Construction_CompanyDataSet2";
            this.construction_CompanyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // графикработBindingSource
            // 
            this.графикработBindingSource.DataMember = "График_работ";
            this.графикработBindingSource.DataSource = this.construction_CompanyDataSet2;
            // 
            // график_работTableAdapter
            // 
            this.график_работTableAdapter.ClearBeforeFill = true;
            // 
            // iDГрафикаDataGridViewTextBoxColumn
            // 
            this.iDГрафикаDataGridViewTextBoxColumn.DataPropertyName = "ID_Графика";
            this.iDГрафикаDataGridViewTextBoxColumn.HeaderText = "ID_Графика";
            this.iDГрафикаDataGridViewTextBoxColumn.Name = "iDГрафикаDataGridViewTextBoxColumn";
            this.iDГрафикаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDЗданияDataGridViewTextBoxColumn
            // 
            this.iDЗданияDataGridViewTextBoxColumn.DataPropertyName = "ID_Здания";
            this.iDЗданияDataGridViewTextBoxColumn.HeaderText = "ID_Здания";
            this.iDЗданияDataGridViewTextBoxColumn.Name = "iDЗданияDataGridViewTextBoxColumn";
            // 
            // датаначалаDataGridViewTextBoxColumn
            // 
            this.датаначалаDataGridViewTextBoxColumn.DataPropertyName = "Дата_начала";
            this.датаначалаDataGridViewTextBoxColumn.HeaderText = "Дата_начала";
            this.датаначалаDataGridViewTextBoxColumn.Name = "датаначалаDataGridViewTextBoxColumn";
            // 
            // датаокончанияDataGridViewTextBoxColumn
            // 
            this.датаокончанияDataGridViewTextBoxColumn.DataPropertyName = "Дата_окончания";
            this.датаокончанияDataGridViewTextBoxColumn.HeaderText = "Дата_окончания";
            this.датаокончанияDataGridViewTextBoxColumn.Name = "датаокончанияDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата начала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID здания";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(361, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата окончания";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(503, 214);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(804, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_CompanyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.графикработBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Construction_CompanyDataSet2 construction_CompanyDataSet2;
        private System.Windows.Forms.BindingSource графикработBindingSource;
        private Construction_CompanyDataSet2TableAdapters.График_работTableAdapter график_работTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГрафикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаначалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаокончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
    }
}