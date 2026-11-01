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
    public partial class Form8 : Form
    {
        private double firstNumber;
        private string operation;
        private bool isNewEntry;

        public Form8()
        {
            InitializeComponent();
        }

        private void DigitalButton_Click(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                txtDisplay.Clear();
                isNewEntry = false;
            }

            Button btn = sender as Button;
            if (btn != null)
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            // Используем TryParse для безопасного ввода
            if (double.TryParse(txtDisplay.Text, out firstNumber))
            {
                Button btn = sender as Button;
                if (btn != null)
                {
                    operation = btn.Text;
                    isNewEntry = true;
                }
            }
            else
            {
                MessageBox.Show("Ошибка ввода! Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDisplay.Text = "0";
                isNewEntry = true;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            // Безопасно получаем второе число
            if (!double.TryParse(txtDisplay.Text, out double secondNumber))
            {
                MessageBox.Show("Ошибка ввода! Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDisplay.Text = "0";
                isNewEntry = true;
                return;
            }

            double result = 0;
            bool error = false;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        txtDisplay.Text = "Ошибка: Деление на 0";
                        isNewEntry = true;
                        error = true;
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                    }
                    break;
                default:
                    
                    result = secondNumber;
                    break;
            }

            if (!error)
            {
                
                txtDisplay.Text = result.ToString();
                isNewEntry = true;
                operation = ""; 
            }
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            operation = "";
            isNewEntry = true;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            isNewEntry = true;
        }
    }
}
