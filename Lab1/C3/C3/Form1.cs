using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(textBoxX.Text);
                textBoxWynik.Text = (x * x).ToString();
            }
            catch (Exception){
                MessageBox.Show("Podano błedne dane", "Uwaga!", MessageBoxButtons.OK);

            }
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
