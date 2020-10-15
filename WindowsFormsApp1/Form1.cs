using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox1.Text = "El color es: " + comboBox1.Text;
                    break;
                case 1:
                    textBox1.Text = "El color es: " + comboBox1.Text;
                    break;
                case 2:
                    textBox1.Text = "El color es: " + comboBox1.Text;
                    break;
                case 3:
                    textBox1.Text = "El color es: " + comboBox1.Text;
                    break;
                case 4:
                    textBox1.Text = "El color es: " + comboBox1.Text;
                    break;
                default:
                    textBox1.Text = "El color es: ";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
