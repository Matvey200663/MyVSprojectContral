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
    public partial class FormAuthorization : Form
    {
        ИСПП6_Вар6_Агапов_АндреевEntities1 qwest;
        public FormAuthorization()
        {
            InitializeComponent();
            qwest = new ИСПП6_Вар6_Агапов_АндреевEntities1();
        }


        private void buttonToRegistration_Click(object sender, EventArgs e)
        {
            FormRegister newForm = new FormRegister();
            newForm.Show();
            this.Hide();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
          bool exists = qwest.Пользователь.Any(i => i.ЭлектроннаяПочта == textBoxLogin.Text && i.Пароль == textBoxPassword.Text);
            if (!exists)
            {
                MessageBox.Show("Такого пользователя нет");
            }
            else
            {
                FormMain newForm = new FormMain();
                newForm.Show();
                this.Hide();
            }
        }
       
    }
}
