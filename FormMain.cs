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
    }
}
