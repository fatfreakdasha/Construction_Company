namespace Construction_Company
{
    partial class Form8
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
            this.construction_CompanyDataSet5 = new Construction_Company.Construction_CompanyDataSet5();
            this.материалыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.материалыTableAdapter = new Construction_Company.Construction_CompanyDataSet5TableAdapters.МатериалыTableAdapter();
            this.iDМатериалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиематериалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествонаскладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_CompanyDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМатериалаDataGridViewTextBoxColumn,
            this.названиематериалаDataGridViewTextBoxColumn,
            this.количествонаскладеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.материалыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(904, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // construction_CompanyDataSet5
            // 
            this.construction_CompanyDataSet5.DataSetName = "Construction_CompanyDataSet5";
            this.construction_CompanyDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // материалыBindingSource
            // 
            this.материалыBindingSource.DataMember = "Материалы";
            this.материалыBindingSource.DataSource = this.construction_CompanyDataSet5;
            // 
            // материалыTableAdapter
            // 
            this.материалыTableAdapter.ClearBeforeFill = true;
            // 
            // iDМатериалаDataGridViewTextBoxColumn
            // 
            this.iDМатериалаDataGridViewTextBoxColumn.DataPropertyName = "ID_Материала";
            this.iDМатериалаDataGridViewTextBoxColumn.HeaderText = "ID_Материала";
            this.iDМатериалаDataGridViewTextBoxColumn.Name = "iDМатериалаDataGridViewTextBoxColumn";
            this.iDМатериалаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиематериалаDataGridViewTextBoxColumn
            // 
            this.названиематериалаDataGridViewTextBoxColumn.DataPropertyName = "Название_материала";
            this.названиематериалаDataGridViewTextBoxColumn.HeaderText = "Название_материала";
            this.названиематериалаDataGridViewTextBoxColumn.Name = "названиематериалаDataGridViewTextBoxColumn";
            // 
            // количествонаскладеDataGridViewTextBoxColumn
            // 
            this.количествонаскладеDataGridViewTextBoxColumn.DataPropertyName = "Количество_на_складе";
            this.количествонаскладеDataGridViewTextBoxColumn.HeaderText = "Количество_на_складе";
            this.количествонаскладеDataGridViewTextBoxColumn.Name = "количествонаскладеDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Количество на складе";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(437, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название материала";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(820, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_CompanyDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Construction_CompanyDataSet5 construction_CompanyDataSet5;
        private System.Windows.Forms.BindingSource материалыBindingSource;
        private Construction_CompanyDataSet5TableAdapters.МатериалыTableAdapter материалыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМатериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиематериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествонаскладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}