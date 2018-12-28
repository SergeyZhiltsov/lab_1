using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        string result, result2;
        string s = "qwertyuiopasdfghjklzxcvbnm";
        string s1 = "QWERTYUIOPASDFGHJKLZXCVBNM";
        string s2 = "123456789";
        string s3 = "_";
        string s4 = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM123456789____";
        int l;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int lng = s.Length;
            int lng1 = s1.Length;
            int lng2 = s2.Length;
            int lng3 = s3.Length;
            int lng4 = s4.Length;
            result = "";
            result += s[rnd.Next(lng)];
            result += s1[rnd.Next(lng1)];
            result += s2[rnd.Next(lng2)];
            result += s3[rnd.Next(lng3)];
            for(int i=0; i<l-4; i++)
            {
                result += s4[rnd.Next(lng4)];
            }

            char[] charStr = result.ToCharArray();
            for (int i = 0; i < charStr.Length; i++)
               {
                int j = rnd.Next(i + 1);
                // обменять значения data[j] и data[i]
                var temp = charStr[j];
                charStr[j] = charStr[i];
                charStr[i] = temp;
               }
            result = new string(charStr);
            label2.Text = result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 16;
           l = Convert.ToInt32(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
