using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string s, s2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(s) % 2 != 0)
                label2.Text = "Число не делится на 2";
            else label2.Text = "Число делится на 2";
            if (Convert.ToInt32(s) % 4 == 0)
            label3.Text = "Число делится на 4";
            else label3.Text = "Число не делится на 4";
            if (Convert.ToInt32(s) % Convert.ToInt32(s2) == 0)
                label5.Text = "Число 1 делится на число 2";
            else if (Convert.ToInt32(s2) % Convert.ToInt32(s) == 0)
                label5.Text = "Число 2 делится на число 1";
            else label5.Text = "Числа не делятся друг на друга";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s2 = textBox2.Text;
        }
    }
}
