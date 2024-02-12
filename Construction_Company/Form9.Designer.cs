namespace Construction_Company
{
    partial class Form9
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
            this.construction_CompanyDataSet6 = new Construction_Company.Construction_CompanyDataSet6();
            this.рабочиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рабочиеTableAdapter = new Construction_Company.Construction_CompanyDataSet6TableAdapters.РабочиеTableAdapter();
            this.iDРаботникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имярабочегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDБригадыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_CompanyDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рабочиеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDРаботникаDataGridViewTextBoxColumn,
            this.имярабочегоDataGridViewTextBoxColumn,
            this.специальностиDataGridViewTextBoxColumn,
            this.iDБригадыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.рабочиеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(910, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // construction_CompanyDataSet6
            // 
            this.construction_CompanyDataSet6.DataSetName = "Construction_CompanyDataSet6";
            this.construction_CompanyDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рабочиеBindingSource
            // 
            this.рабочиеBindingSource.DataMember = "Рабочие";
            this.рабочиеBindingSource.DataSource = this.construction_CompanyDataSet6;
            // 
            // рабочиеTableAdapter
            // 
            this.рабочиеTableAdapter.ClearBeforeFill = true;
            // 
            // iDРаботникаDataGridViewTextBoxColumn
            // 
            this.iDРаботникаDataGridViewTextBoxColumn.DataPropertyName = "ID_Работника";
            this.iDРаботникаDataGridViewTextBoxColumn.HeaderText = "ID_Работника";
            this.iDРаботникаDataGridViewTextBoxColumn.Name = "iDРаботникаDataGridViewTextBoxColumn";
            this.iDРаботникаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имярабочегоDataGridViewTextBoxColumn
            // 
            this.имярабочегоDataGridViewTextBoxColumn.DataPropertyName = "Имя_рабочего";
            this.имярабочегоDataGridViewTextBoxColumn.HeaderText = "Имя_рабочего";
            this.имярабочегоDataGridViewTextBoxColumn.Name = "имярабочегоDataGridViewTextBoxColumn";
            // 
            // специальностиDataGridViewTextBoxColumn
            // 
            this.специальностиDataGridViewTextBoxColumn.DataPropertyName = "Специальности";
            this.специальностиDataGridViewTextBoxColumn.HeaderText = "Специальности";
            this.специальностиDataGridViewTextBoxColumn.Name = "специальностиDataGridViewTextBoxColumn";
            // 
            // iDБригадыDataGridViewTextBoxColumn
            // 
            this.iDБригадыDataGridViewTextBoxColumn.DataPropertyName = "ID_Бригады";
            this.iDБригадыDataGridViewTextBoxColumn.HeaderText = "ID_Бригады";
            this.iDБригадыDataGridViewTextBoxColumn.Name = "iDБригадыDataGridViewTextBoxColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "ID бригады";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(389, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Специальности";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(444, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Имя рабочего";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(326, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(819, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_CompanyDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рабочиеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Construction_CompanyDataSet6 construction_CompanyDataSet6;
        private System.Windows.Forms.BindingSource рабочиеBindingSource;
        private Construction_CompanyDataSet6TableAdapters.РабочиеTableAdapter рабочиеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDРаботникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имярабочегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDБригадыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}