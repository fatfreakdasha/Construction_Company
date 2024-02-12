namespace Construction_Company
{
    partial class Form7
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
            this.construction_CompanyDataSet4 = new Construction_Company.Construction_CompanyDataSet4();
            this.использованиематериаловBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.использование_материаловTableAdapter = new Construction_Company.Construction_CompanyDataSet4TableAdapters.Использование_материаловTableAdapter();
            this.iDИспользованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЗданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМатериалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоиспользованныхDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_CompanyDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.использованиематериаловBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDИспользованияDataGridViewTextBoxColumn,
            this.iDЗданияDataGridViewTextBoxColumn,
            this.iDМатериалаDataGridViewTextBoxColumn,
            this.количествоиспользованныхDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.использованиематериаловBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // construction_CompanyDataSet4
            // 
            this.construction_CompanyDataSet4.DataSetName = "Construction_CompanyDataSet4";
            this.construction_CompanyDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // использованиематериаловBindingSource
            // 
            this.использованиематериаловBindingSource.DataMember = "Использование_материалов";
            this.использованиематериаловBindingSource.DataSource = this.construction_CompanyDataSet4;
            // 
            // использование_материаловTableAdapter
            // 
            this.использование_материаловTableAdapter.ClearBeforeFill = true;
            // 
            // iDИспользованияDataGridViewTextBoxColumn
            // 
            this.iDИспользованияDataGridViewTextBoxColumn.DataPropertyName = "ID_Использования";
            this.iDИспользованияDataGridViewTextBoxColumn.HeaderText = "ID_Использования";
            this.iDИспользованияDataGridViewTextBoxColumn.Name = "iDИспользованияDataGridViewTextBoxColumn";
            this.iDИспользованияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDЗданияDataGridViewTextBoxColumn
            // 
            this.iDЗданияDataGridViewTextBoxColumn.DataPropertyName = "ID_Здания";
            this.iDЗданияDataGridViewTextBoxColumn.HeaderText = "ID_Здания";
            this.iDЗданияDataGridViewTextBoxColumn.Name = "iDЗданияDataGridViewTextBoxColumn";
            // 
            // iDМатериалаDataGridViewTextBoxColumn
            // 
            this.iDМатериалаDataGridViewTextBoxColumn.DataPropertyName = "ID_Материала";
            this.iDМатериалаDataGridViewTextBoxColumn.HeaderText = "ID_Материала";
            this.iDМатериалаDataGridViewTextBoxColumn.Name = "iDМатериалаDataGridViewTextBoxColumn";
            // 
            // количествоиспользованныхDataGridViewTextBoxColumn
            // 
            this.количествоиспользованныхDataGridViewTextBoxColumn.DataPropertyName = "Количество_использованных";
            this.количествоиспользованныхDataGridViewTextBoxColumn.HeaderText = "Количество_использованных";
            this.количествоиспользованныхDataGridViewTextBoxColumn.Name = "количествоиспользованныхDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 273);
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
            this.label2.Location = new System.Drawing.Point(461, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID материала";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(444, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID здания";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(326, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Количество использованных";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(389, 234);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 20);
            this.textBox3.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(830, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_CompanyDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.использованиематериаловBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Construction_CompanyDataSet4 construction_CompanyDataSet4;
        private System.Windows.Forms.BindingSource использованиематериаловBindingSource;
        private Construction_CompanyDataSet4TableAdapters.Использование_материаловTableAdapter использование_материаловTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИспользованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМатериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоиспользованныхDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
    }
}