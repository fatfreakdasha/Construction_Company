namespace Construction_Company
{
    partial class Form6
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
            this.iDЗданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиезданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDТипаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зданияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.construction_CompanyDataSet3 = new Construction_Company.Construction_CompanyDataSet3();
            this.зданияTableAdapter = new Construction_Company.Construction_CompanyDataSet3TableAdapters.ЗданияTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зданияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_CompanyDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЗданияDataGridViewTextBoxColumn,
            this.названиезданияDataGridViewTextBoxColumn,
            this.iDТипаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.зданияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(916, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDЗданияDataGridViewTextBoxColumn
            // 
            this.iDЗданияDataGridViewTextBoxColumn.DataPropertyName = "ID_Здания";
            this.iDЗданияDataGridViewTextBoxColumn.HeaderText = "ID_Здания";
            this.iDЗданияDataGridViewTextBoxColumn.Name = "iDЗданияDataGridViewTextBoxColumn";
            this.iDЗданияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиезданияDataGridViewTextBoxColumn
            // 
            this.названиезданияDataGridViewTextBoxColumn.DataPropertyName = "Название_здания";
            this.названиезданияDataGridViewTextBoxColumn.HeaderText = "Название_здания";
            this.названиезданияDataGridViewTextBoxColumn.Name = "названиезданияDataGridViewTextBoxColumn";
            // 
            // iDТипаDataGridViewTextBoxColumn
            // 
            this.iDТипаDataGridViewTextBoxColumn.DataPropertyName = "ID_Типа";
            this.iDТипаDataGridViewTextBoxColumn.HeaderText = "ID_Типа";
            this.iDТипаDataGridViewTextBoxColumn.Name = "iDТипаDataGridViewTextBoxColumn";
            // 
            // зданияBindingSource
            // 
            this.зданияBindingSource.DataMember = "Здания";
            this.зданияBindingSource.DataSource = this.construction_CompanyDataSet3;
            // 
            // construction_CompanyDataSet3
            // 
            this.construction_CompanyDataSet3.DataSetName = "Construction_CompanyDataSet3";
            this.construction_CompanyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // зданияTableAdapter
            // 
            this.зданияTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 335);
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
            this.label2.Location = new System.Drawing.Point(487, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID типа";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(454, 239);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название здания";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(326, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(819, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зданияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_CompanyDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Construction_CompanyDataSet3 construction_CompanyDataSet3;
        private System.Windows.Forms.BindingSource зданияBindingSource;
        private Construction_CompanyDataSet3TableAdapters.ЗданияTableAdapter зданияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиезданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТипаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}