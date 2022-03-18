using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace самостоятельная_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            //string[] path =File.ReadAllLines(@"E:\МИША\Text.txt");
            //textBox1.Text = path[0];
            //sr.Close();


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // string t = label1.Text;

            List<string> a = new List<string>
            {
            };
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    a.Add(item.Text);
                }
            }
            a.Reverse();
            File.WriteAllLines(@"D:\МИША\Text.txt", a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] path = File.ReadAllLines(@"D:\МИША\Text.txt");
            TextBox[] a = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5 };
            for (int i = 0; i < a.Length; i++)
            {
                a[i].Text = path[i];
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] path = new string[4];
            TextBox[] a = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5 };
            {
            for (int i = 0; i < a.Length; i++)
                path[i] = a[i].Text;
            }
                File.WriteAllLines(@"D:\МИША\NewText.txt", path);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"D:\МИША\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                TextBox[] a = new TextBox[] { textBox1, textBox2, textBox3, textBox4,textBox5 };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    string[] path = File.ReadAllLines(filePath);
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i].Text = path[i];
                    }
                }
            }
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            List<string> a = new List<string>
            {
            };
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    a.Add(item.Text);
                }
            }
            a.Reverse();
            File.WriteAllLines(filename, a);
            MessageBox.Show("Файл сохранен");
        }
    }
}
