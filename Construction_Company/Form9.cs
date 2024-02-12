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
    public partial class Form9 : Form
    {
        Construction_CompanyEntities db;
        public Form9()
        {
            db = new Construction_CompanyEntities();
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "construction_CompanyDataSet6.Рабочие". При необходимости она может быть перемещена или удалена.
            this.рабочиеTableAdapter.Fill(this.construction_CompanyDataSet6.Рабочие);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Рабочие rabochie = new Рабочие();
            rabochie.Имя_рабочего = textBox1.Text;
            rabochie.Специальности = textBox2.Text;
            rabochie.ID_Бригады = int.Parse(textBox3.Text);
            db.Рабочие.Add( rabochie );
            db.SaveChanges();
        }
    }
}
