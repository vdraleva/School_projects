using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droben_kaukulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int nod(int a,int b)
        { while(b!=0)
            { int x = b;
                b = a % b;
                a = x;
            }
            return a;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            a = a * d + b * c;
            b = b * d;
            int ch = nod(a, b);
            a = a / ch;
            b = b / ch;
            label5.Text = a.ToString();
            label6.Text = b.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            a = a * d - b * c;
            b = b * d;
            int ch = nod(a, b);
            a = a / ch;
            b = b / ch;
            label5.Text = a.ToString();
            label6.Text = b.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            a = a * c;
            b = b * d;            
            label5.Text = a.ToString();
            label6.Text = b.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            a = a * d;
            b = b * c;            
            label5.Text = a.ToString();
            label6.Text = b.ToString();
        }
    }
}
