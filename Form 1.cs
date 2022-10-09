using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

            numericUpDown1.Value = 10;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 15;
        }

    private void button1_Click(object sender, EventArgs e)
        {
            Randgen passGen = new Randgen();
            richTextBox1.Text = passGen.Rand_gen((int)numericUpDown1.Value);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //выделяет цифры
            for (int i = 0; i < 10; i++)
            {
                if (richTextBox1.Find(Convert.ToString(i)) > 0)
                {
                    richTextBox1.SelectionStart = richTextBox1.Find(Convert.ToString(i));
                    richTextBox1.SelectionLength = Convert.ToString(i).Length;
                    richTextBox1.SelectionFont = new Font("Times New Roman", 22, FontStyle.Bold);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //копирует в буфер обмена
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.Text.Length;
            Clipboard.SetText(richTextBox1.SelectedText);
        }
    }
}
