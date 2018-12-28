using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int i, n;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 4;
            n = Convert.ToInt32(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label4.Text = "";
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                label4.Text = "Неверный формат данных";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            for (i = 1; i < n; i++)
                if (n % i == 0)
                    label2.Text = label2.Text + i + "\n";
        }
    }
}
