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
    public partial class Form5 : Form
    {
        Construction_CompanyEntities db;
        public Form5()
        {
            db = new Construction_CompanyEntities();
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "construction_CompanyDataSet2.График_работ". При необходимости она может быть перемещена или удалена.
            this.график_работTableAdapter.Fill(this.construction_CompanyDataSet2.График_работ);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            График_работ graf = new График_работ();
            graf.ID_Здания = int.Parse(textBox1.Text);
            graf.Дата_начала = dateTimePicker1.Value;
            graf.Дата_окончания =dateTimePicker2.Value;
            db.График_работ.Add(graf);
            db.SaveChanges();
        }
    }
}
