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
    public partial class FormRegister : Form
    {
        ИСПП6_Вар6_Агапов_АндреевEntities1 qwest;

        public FormRegister()
        {
            InitializeComponent();
            qwest = new ИСПП6_Вар6_Агапов_АндреевEntities1();
            LoadSecretQuestions(); 
        }

        private void LoadSecretQuestions()
        {
            try
            {
                var questions = qwest.СекретныйВопрос.Select(i => i.СекретныйВопрос1).ToList();
                comboBox1.DataSource = questions;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки вопросов: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            if (!checkBox1.Checked)
            {
                MessageBox.Show("Вы не согласны с условиями!!!");
                return;
            }

            try
            {
                var selectedQuestion = comboBox1.SelectedItem.ToString();
                var secretQuestion = qwest.СекретныйВопрос
                    .FirstOrDefault(i => i.СекретныйВопрос1 == selectedQuestion);

                if (secretQuestion == null)
                {
                    MessageBox.Show("Ошибка: секретный вопрос не найден!");
                    return;
                }

                var newUser = new Пользователь
                {
                    Фамилия = textBox1.Text.Trim(),
                    Имя = textBox2.Text.Trim(),
                    ЭлектроннаяПочта = textBox3.Text.Trim(),
                    Пароль = textBox4.Text.Trim(),
                    КодовоеСлово = textBox5.Text.Trim(),
                    ОтветНаСекретныйВопрос = textBox6.Text.Trim(),
                    КодСекретныйВопрос = secretQuestion.КодСекретныйВопрос
                };

                qwest.Пользователь.Add(newUser);
                qwest.SaveChanges();


                MessageBox.Show($"Пользователь {textBox1.Text} {textBox2.Text} добавлен!");

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении пользователя: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.SelectedIndex = -1;
            checkBox1.Checked = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Иванов")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}