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
    public partial class Form3 : Form
    {
        Construction_CompanyEntities db;
        public Form3()
        {
            db = new Construction_CompanyEntities();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "construction_CompanyDataSet.Бригадиры". При необходимости она может быть перемещена или удалена.
            this.бригадирыTableAdapter.Fill(this.construction_CompanyDataSet.Бригадиры);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Бригадиры br = new Бригадиры();
            br.Имя_бригадира = textBox1.Text;
            br.ID_Бригады = int.Parse(textBox2.Text);
            db.Бригадиры.Add(br);
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
