using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormMain : Form
    {
        ИСПП6_Вар6_Агапов_АндреевEntities1 qwest;

        public FormMain()
        {
            InitializeComponent();
            qwest = new ИСПП6_Вар6_Агапов_АндреевEntities1();

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var questions = qwest.Сотрудники.Select(i => i).ToList();
            dataGridView1.DataSource = questions;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var questions = qwest.УчетРабочегоВремени.Select(i => i).ToList();
            dataGridView1.DataSource = questions;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var questions = qwest.Тендеры.Select(i => i).ToList();
            dataGridView1.DataSource = questions;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var questions = qwest.Договоры.Select(i => i).ToList();
            dataGridView1.DataSource = questions;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var questions = qwest.Поставщики.Select(i => i).ToList();
            dataGridView1.DataSource = questions;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var questions = qwest.УчастникиТендера.Select(i => i).ToList();
            dataGridView1.DataSource = questions;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var questions = qwest.ОбъектыНедвижимости.Select(i => i).ToList();
            dataGridView1.DataSource = questions;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var questions = qwest.РасчетЗарплаты.Select(i => i).ToList();
            dataGridView1.DataSource = questions;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var questions = qwest.ИспользованиеНедвижимости.Select(i => i).ToList();
            dataGridView1.DataSource = questions;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var questions = qwest.Проекты.Select(i => i).ToList();
            dataGridView1.DataSource = questions;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var questions = qwest.РесурсыПроекта.Select(i => i).ToList();
            dataGridView1.DataSource = questions;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var questions = qwest.ЗатратыПроекта.Select(i => i).ToList();
            dataGridView1.DataSource = questions;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var questions = qwest.ЗадачиПроекта.Select(i => i).ToList();
            dataGridView1.DataSource = questions;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
