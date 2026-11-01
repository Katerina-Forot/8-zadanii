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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string userText = txtInput.Text;

            if (string.IsNullOrWhiteSpace(userText))
            {
                MessageBox.Show("Поле ввода пустое. Пожалуйста, введите текст.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show(userText, "Введенный текст", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
