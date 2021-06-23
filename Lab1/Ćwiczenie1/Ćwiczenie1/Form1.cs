using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ćwiczenie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            MessageBox.Show("2 odblokowany");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Koiec");
        }
    }
}
