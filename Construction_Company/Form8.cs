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
    public partial class Form8 : Form
    {
        Construction_CompanyEntities db;
        public Form8()
        {
            db = new Construction_CompanyEntities();
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "construction_CompanyDataSet5.Материалы". При необходимости она может быть перемещена или удалена.
            this.материалыTableAdapter.Fill(this.construction_CompanyDataSet5.Материалы);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Материалы material = new Материалы();
            material.Название_материала = textBox1.Text;
            material.Количество_на_складе = int.Parse(textBox2.Text);
            db.Материалы.Add(material);
            db.SaveChanges();
        }
    }
}
