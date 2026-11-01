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
    public partial class Form3 : Form
    {
        private readonly Random _random;
        public Form3()
        {
            InitializeComponent();
            _random = new Random();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnRandomColor_Click(object sender, EventArgs e)
        {
            int r = _random.Next(256);
            int g = _random.Next(256);
            int b = _random.Next(256);

            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
