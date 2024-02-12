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
    public partial class Form6 : Form
    {
        Construction_CompanyEntities db;
        public Form6()
        {
            db = new Construction_CompanyEntities();
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "construction_CompanyDataSet3.Здания". При необходимости она может быть перемещена или удалена.
            this.зданияTableAdapter.Fill(this.construction_CompanyDataSet3.Здания);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Здания zd = new Здания();
            zd.Название_здания = textBox1.Text;
            zd.ID_Типа = int.Parse(textBox2.Text);
            db.Здания.Add(zd);
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
