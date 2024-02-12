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
    public partial class Form7 : Form
    {
        Construction_CompanyEntities db;

        public Form7()
        {
            db = new Construction_CompanyEntities();
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "construction_CompanyDataSet4.Использование_материалов". При необходимости она может быть перемещена или удалена.
            this.использование_материаловTableAdapter.Fill(this.construction_CompanyDataSet4.Использование_материалов);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Использование_материалов im = new Использование_материалов();
            im.ID_Здания = int.Parse(textBox1.Text);
            im.ID_Материала = int.Parse(textBox2.Text);
            im.Количество_использованных = int.Parse(textBox3.Text);
            db.Использование_материалов.Add(im);
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
