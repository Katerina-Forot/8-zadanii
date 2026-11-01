using System;
using System.IO;
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
    public partial class Form7 : Form
    {
        private string _filePath = "note.txt";
        public Form7()
        {
            InitializeComponent();
        }

        
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(_filePath, txtNote.Text);
                MessageBox.Show("Заметка успешно сохранена!", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Не удалось сохранить заметку: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Файл заметки не найден. Сначала сохраните заметку.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить заметку: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
