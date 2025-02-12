using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openfile
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            Open.Click += Open_Click;
            Save.Click += Save_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем путь к выбранному файлу
            string filename = openFileDialog1.FileName;

            if (filename.IndexOf("txt") > 0)
            {
                // читаем файл в строку
                string fileText = System.IO.File.ReadAllText(filename);

                richTextBox1.Text = fileText;

                MessageBox.Show("Файл открыт");
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;

            if (filename.IndexOf("txt") > 0)
            {

                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, richTextBox1.Text);

                MessageBox.Show("Файл сохранен");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

    }
}
