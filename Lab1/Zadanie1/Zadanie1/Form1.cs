using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(textBoxX.Text);
                float y = float.Parse(textBoxY.Text);
                float z = float.Parse(textBoxZ.Text);

                textBoxAnswer.Text = (x + y + z).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błedne dane, wprowadź tylko cyfry", "Uwaga", MessageBoxButtons.OK);
            }
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(textBoxX.Text);
                float y = float.Parse(textBoxY.Text);
                float z = float.Parse(textBoxZ.Text);

                textBoxAnswer.Text = (x * y * z).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błedne dane, wprowadź tylko cyfry", "Uwaga", MessageBoxButtons.OK);
            }
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            Application.Exit();     //this.Close();
        }
    }
}
