using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_par_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    comboBox1.Items.Add(i);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Numero: " + comboBox1.Text;
        }

        private void button2_inpar_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    comboBox1.Items.Add(i);
                }
            }
        }
    }
}
