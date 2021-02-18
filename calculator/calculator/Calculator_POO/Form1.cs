using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_POO
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operatie;
        double rezultat = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void B0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text +=input;
        }

        private void B1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void B4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void B5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void B6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void B7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void B8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void B9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void EgalB_Click(object sender, EventArgs e)
        {
           
          
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

            if (operatie == '+')
            {
                rezultat = num1 + num2;
                textBox1.Text = rezultat.ToString();
            }
            else if (operatie == '-')
            {
                rezultat = num1 - num2;
                textBox1.Text = rezultat.ToString();
            }
            else if (operatie == '*')
            {
                rezultat = num1 * num2;
                textBox1.Text = rezultat.ToString();
            }
            else if (operatie == '/')
            {
                if (num2 != 0)
                {
                    rezultat = num1 / num2;
                    textBox1.Text = rezultat.ToString();
                }
                else
                {
                    textBox1.Text = "error";
                }

            }

        }

        private void MinusB_Click(object sender, EventArgs e)
        {
            
            operand1 = input;
            operatie = '-';
            input = string.Empty;
            
        }

        private void SumaB_Click(object sender, EventArgs e)
        {
            
            operand1 = input;
            operatie = '+';
            input = string.Empty;
            
        }

        private void inmultireB_Click(object sender, EventArgs e)
        {
            
            operand1 = input;
            operatie = '*';
            input = string.Empty;
           
        }

        private void impartireB_Click(object sender, EventArgs e)
        {
            
            operand1 = input;
            operatie = '/';
            input = string.Empty;
            
        }

        private void VirgulaB_Click(object sender, EventArgs e)
        {
          

            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;

        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
