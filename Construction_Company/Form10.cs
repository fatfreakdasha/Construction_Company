using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_Company
{
   
    public partial class Form10 : Form
    {
        Construction_CompanyEntities db;
        public Form10()
        {
            db = new Construction_CompanyEntities();
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "construction_CompanyDataSet7.Типы_зданий". При необходимости она может быть перемещена или удалена.
            this.типы_зданийTableAdapter.Fill(this.construction_CompanyDataSet7.Типы_зданий);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Типы_зданий tipi = new Типы_зданий();
            tipi.Название_типа = textBox1.Text;
            tipi.Описание_типа = textBox2.Text;
            db.Типы_зданий.Add(tipi);
            db.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
