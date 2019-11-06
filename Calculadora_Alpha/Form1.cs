using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Alpha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }
        double v1, v2, r;
        char op;
        private void Clear_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            catch
            {
                MessageBox.Show("Lugar Vazio", " Calculadora diz",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         textBox1.Clear();
        }
        private void Number_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
        private void Number_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void Number_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void Number_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void Number_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void Number_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void Number_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void Number_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void Number_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void Subtrção_Click(object sender, EventArgs e)
        {

            v1 = double.Parse(textBox1.Text);
            op = '-';
            textBox1.Clear();
        }

        private void Multiplicação_Click(object sender, EventArgs e)
        {

            v1 = double.Parse(textBox1.Text);
            op = 'x';
            textBox1.Clear();
        }

        private void Divisão_Click(object sender, EventArgs e)
        {

            v1 = double.Parse(textBox1.Text);
            op = '/';
            textBox1.Clear();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            v2 = double.Parse(textBox1.Text);
            switch (op)
            {
                case '+':
                    r = v1 + v2;
                    break;
                case '-':
                    r = v1 - v2;
                    break;
                case 'x':
                    r = v1 * v2;
                    break;
                case '/':
                    r = v1 / v2;
                    break;
            }
            textBox1.Text = r.ToString();
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void Number_0_Click(object sender, EventArgs e)
        {
           textBox1.Text = textBox1.Text + "0";
        }

        private void Adição_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(textBox1.Text);
            op = '+';
            textBox1.Clear();
        }
       
       }      
    }

