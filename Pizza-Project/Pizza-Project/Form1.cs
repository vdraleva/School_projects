using FormThankYou_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        double price = 0;        
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ketchup.Checked)
            {
                price += 0.50;
            }
            if (mayoneza.Checked)
            {
                price += 0.50;
            }
            if (chesnovSos.Checked)
            {
                price += 0.70;
            }
            if (gorchitsa.Checked)
            {
                price += 0.60;
            }
            if (soevSos.Checked)
            {
                price += 0.65;
            }
            if (chili.Checked)
            {
                price += 0.50;
            }
            label2.Text = price.ToString()+" лв.";
            MessageBox.Show($"Вашата поръчка, с номер: {r.Next(1, 1000)}, бе успешно приета и изпратена за изпълнение.");
            FormThankYou f2 = new FormThankYou();          
            f2.Show();
            label2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {           
            
            if (comboBox1.Text == "Маргарита")
            {
                if (malka.Checked)
                {
                    price = 15;                  
                }
                else if (sredna.Checked)
                {
                    price = 17;
                }
                else 
                {
                    price = 20;
                   
                }                
                button1.Enabled = true;
                pictureBox1.BackgroundImage = Properties.Resources.margarita;
                label2.Text = price.ToString() + " лв.";
            }
            if (comboBox1.Text == "Капричоза")
            {
                if (malka.Checked)
                {
                    price = 16;
                }
                else if (sredna.Checked)
                {
                    price = 18;
                }
                else 
                {
                    price = 21;
                }               
                button1.Enabled = true;
                pictureBox1.BackgroundImage = Properties.Resources.kaprichoza;
            }
            if (comboBox1.Text == "Калцоне")
            {
                if (malka.Checked)
                {
                    price = 17;
                }
                else if (sredna.Checked)
                {
                    price = 18;
                }
                else
                {
                    price = 22;
                }                
                button1.Enabled = true;
                pictureBox1.BackgroundImage = Properties.Resources.kalcone;
            }
            if (comboBox1.Text == "Хавай")
            {
                if (malka.Checked)
                {
                    price = 16;
                }
                else if (sredna.Checked)
                {
                    price = 19;
                }
                else
                {
                    price = 24;
                }             
                button1.Enabled = true;
                pictureBox1.BackgroundImage = Properties.Resources.havay;
            }
            if (comboBox1.Text == "Прошуто")
            {
                if (malka.Checked)
                {
                    price = 17;
                }
                else if (sredna.Checked)
                {
                    price = 20;
                }
                else
                {
                    price = 25;
                }          
                button1.Enabled = true;
                pictureBox1.BackgroundImage = Properties.Resources.proshuto;
            }
            if (comboBox1.Text == "Тоскана")
            {
                if (malka.Checked)
                {
                    price = 19;
                }
                else if (sredna.Checked)
                {
                    price = 23;
                }
                else
                {
                    price = 25;
                }           
                button1.Enabled = true;
                pictureBox1.BackgroundImage = Properties.Resources.toskana;
            }
            if (comboBox1.Text == "Вегетариана")
            {
                if (malka.Checked)
                {
                    price = 16;
                }
                else if (sredna.Checked)
                {
                    price = 18;
                }
                else
                {
                    price = 20;
                }          
                button1.Enabled = true;
                pictureBox1.BackgroundImage = Properties.Resources.vegetariana;
            }
        }
    }
}
