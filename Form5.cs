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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            btn1.Click += Btn_Click;
            btn2.Click += Btn_Click;
            btn3.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(input)) return;
            Button clickedBtn = sender as Button;
            if (clickedBtn != null)
                clickedBtn.Text = input;
            txtInput.Clear();
            txtInput.Focus();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }
    }
}
