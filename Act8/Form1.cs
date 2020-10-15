using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Text;
        }

        private void botonAula1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Insert(0, "Alumo1");
            listBox1.Items.Insert(1, "Alumo2");
            listBox1.Items.Insert(2, "Alumo3");

        }

        private void botonAula2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("AlumoA");
            listBox1.Items.Add("AlumoB");
            listBox1.Items.Add("AlumoC");
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
