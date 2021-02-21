using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassMyMath;

namespace random_numbers
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        string st= "random.txt";
        double sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {  
            StreamWriter w = new StreamWriter(st, false, Encoding.GetEncoding("windows-1251"));
            Random r = new Random();
            int n = r.Next(1,100);
            w.WriteLine(n);
            for (int i = 1; i <=n; i++)
            {
                int k = r.Next(1, 100);
                w.WriteLine($"{k}");
                sum += k;
            }
            sum = sum/n;
            w.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter r = new StreamWriter(st);
            StreamWriter w = new StreamWriter("Prosti", false, Encoding.GetEncoding("windows-1251"));
            string line = "";
            while (line!=null)
            {
                //line =r.ReadLine();
                if (line!=null)
                {
                    int n = int.Parse(line);
                    if (MyMath.IsPrime(n))
                    {
                        w.WriteLine(n);
                    }
                }
            }
            r.Close();
            w.Close();
        }
    }
}
