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
    public partial class Form2 : Form
    {
        private int _secretNumber;
        private int _attemepts;
        public Form2()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            Random random = new Random();
            _secretNumber = random.Next(1, 101);

            _attemepts = 0;
            lblAttempts.Text = "Попыток: 0";

            lblHint.Text = "";
            txtGuess.Clear();
            txtGuess.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            _attemepts++;
            lblAttempts.Text = $"Попыток: {_attemepts}";

            if (!int.TryParse(txtGuess.Text, out int userGuess))
            {
                lblHint.Text = "Пожалуйста, введите корректное целое число";
                return;
            }

            if (userGuess == _secretNumber)
            {
                lblHint.Text = "Поздравляем, Вы угадали число!";
                MessageBox.Show("Вы победили! Число было:" + _secretNumber, "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeGame();
            }
            else if (userGuess < _secretNumber)
            {
                lblHint.Text = "Загаданное число больше";
            }
            else
            {
                lblHint.Text = "Загаданное число меньше";
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }
        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGuess.PerformClick(); 
            }
        }
    }
}
