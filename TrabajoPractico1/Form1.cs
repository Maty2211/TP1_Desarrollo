using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroA = Convert.ToInt32(textBox1.Text);
            int numeroB = Convert.ToInt32(textBox2.Text);

            textBox3.Text= (numeroA + numeroB).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numeroA = Convert.ToInt32(textBox1.Text);
            int numeroB = Convert.ToInt32(textBox2.Text);

            textBox4.Text = (numeroA+""+numeroB).ToString();
        }
    }
}
