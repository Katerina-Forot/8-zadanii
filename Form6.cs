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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.Load += Form6_Load;
            btn1.Click += Btn1_Click;
            btn2.Click += Btn2_Click;
            btn3.Click += Btn3_Click;
            btn4.Click += Btn4_Click;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
        }
        private void Btn1_Click(object sender, EventArgs e) => lbl1.Visible = true;
        private void Btn2_Click(object sender, EventArgs e) => lbl2.Visible = true;
        private void Btn3_Click(object sender, EventArgs e) => lbl3.Visible = true;
        private void Btn4_Click(object sender, EventArgs e) => lbl4.Visible = true;

    }
}
