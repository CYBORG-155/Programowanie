using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public string Operand;
        public string N1;
        public bool N2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (N2)
            {
                N2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if(textBox1.Text == "0")
            {
                textBox1.Text = B.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + B.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            Operand = B.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;

            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);

            if (Operand == "+")
            {
                res = dn1 + dn2;
                textBox1.Text = res.ToString();
            }
            if (Operand == "-")
            {
                res = dn1 - dn2;
                textBox1.Text = res.ToString();
            }
            if (Operand == "*")
            {
                res = dn1 * dn2;
                textBox1.Text = res.ToString();
            }
            if (Operand == "/")
            {
                    if(textBox1.Text == "0")
                    {
                    textBox1.Text = "Error";
                    }
                else
                {
                    res = dn1 / dn2;
                    textBox1.Text = res.ToString();
                }
                

            }
            N2 = true;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains(","))
            textBox1.Text = textBox1.Text + ",";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
