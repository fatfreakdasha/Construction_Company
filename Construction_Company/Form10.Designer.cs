namespace Construction_Company
{
    partial class Form10
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
            this.iDТипаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиетипаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниетипаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типызданийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.construction_CompanyDataSet7 = new Construction_Company.Construction_CompanyDataSet7();
            this.типы_зданийTableAdapter = new Construction_Company.Construction_CompanyDataSet7TableAdapters.Типы_зданийTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типызданийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_CompanyDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТипаDataGridViewTextBoxColumn,
            this.названиетипаDataGridViewTextBoxColumn,
            this.описаниетипаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.типызданийBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(907, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDТипаDataGridViewTextBoxColumn
            // 
            this.iDТипаDataGridViewTextBoxColumn.DataPropertyName = "ID_Типа";
            this.iDТипаDataGridViewTextBoxColumn.HeaderText = "ID_Типа";
            this.iDТипаDataGridViewTextBoxColumn.Name = "iDТипаDataGridViewTextBoxColumn";
            this.iDТипаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиетипаDataGridViewTextBoxColumn
            // 
            this.названиетипаDataGridViewTextBoxColumn.DataPropertyName = "Название_типа";
            this.названиетипаDataGridViewTextBoxColumn.HeaderText = "Название_типа";
            this.названиетипаDataGridViewTextBoxColumn.Name = "названиетипаDataGridViewTextBoxColumn";
            // 
            // описаниетипаDataGridViewTextBoxColumn
            // 
            this.описаниетипаDataGridViewTextBoxColumn.DataPropertyName = "Описание_типа";
            this.описаниетипаDataGridViewTextBoxColumn.HeaderText = "Описание_типа";
            this.описаниетипаDataGridViewTextBoxColumn.Name = "описаниетипаDataGridViewTextBoxColumn";
            // 
            // типызданийBindingSource
            // 
            this.типызданийBindingSource.DataMember = "Типы_зданий";
            this.типызданийBindingSource.DataSource = this.construction_CompanyDataSet7;
            // 
            // construction_CompanyDataSet7
            // 
            this.construction_CompanyDataSet7.DataSetName = "Construction_CompanyDataSet7";
            this.construction_CompanyDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // типы_зданийTableAdapter
            // 
            this.типы_зданийTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "описание типа";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(433, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Название типа";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(826, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типызданийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_CompanyDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Construction_CompanyDataSet7 construction_CompanyDataSet7;
        private System.Windows.Forms.BindingSource типызданийBindingSource;
        private Construction_CompanyDataSet7TableAdapters.Типы_зданийTableAdapter типы_зданийTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТипаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиетипаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниетипаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}