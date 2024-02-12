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
    public partial class Form4 : Form
    {
        Construction_CompanyEntities db;
        public Form4()
        {
            db = new Construction_CompanyEntities();
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "construction_CompanyDataSet1.Бригады". При необходимости она может быть перемещена или удалена.
            this.бригадыTableAdapter.Fill(this.construction_CompanyDataSet1.Бригады);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Бригады bd = new Бригады();
            bd.Название_бригады = textBox1.Text;
            bd.Специализация = textBox2.Text;
            db.Бригады.Add(bd);
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
