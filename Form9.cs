using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Проверяем ввод первого числа (из textBox1)
            if (!double.TryParse(textBox1.Text, out double num1))
            {
                MessageBox.Show("Ошибка ввода! В поле 'число 1' должно быть число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Проверяем ввод второго числа (из textBox3)
            if (!double.TryParse(textBox3.Text, out double num2))
            {
                MessageBox.Show("Ошибка ввода! В поле 'число 2' должно быть число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Получаем знак операции из textBox2 (убираем пробелы по краям)
            string operation = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(operation))
            {
                MessageBox.Show("Ошибка! Введите операцию (+, -, *, /).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double result = 0;

            // 4. Считаем в зависимости от знака
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    // Защита от деления на 0
                    if (num2 == 0)
                    {
                        MessageBox.Show("Ошибка! Деление на 0 невозможно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox4.Text = ""; // Очищаем поле ответа
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    MessageBox.Show("Ошибка! Неизвестная операция. Используйте +, -, * или /.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            // 5. Выводим результат в textBox4
            textBox4.Text = result.ToString();
        }
    }
}
