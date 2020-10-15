using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Convert.ToString(operador.Text);
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                if (Convert.ToString(operador.Text) == "-")
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();

                if (Convert.ToString(operador.Text) == "+")
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();

                if (listBox1.SelectedIndex == 0)
                {
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
                }
                if (listBox1.SelectedIndex == 1)
                {
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
                }
            }
                
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void operador_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Animales

        private void animal1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void animal2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void animal3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonAnimales_Click(object sender, EventArgs e)
        {
            String animales = "Animales: ";

            if (animal1.CheckState == CheckState.Checked) 
            {
                animales = animales + animal1.Text + " ";
            }

            if (animal2.CheckState == CheckState.Checked)
            {
                animales = animales + animal2.Text + " ";
            }

            if (animal3.CheckState == CheckState.Checked)
            {
                animales = animales + animal3.Text + " ";
            }

            textBox7.Text = animales;
        }

        //colores
        private void botonColores_Click(object sender, EventArgs e)
        {
            String colores = "Colores: ";

            if (radioButton1.Checked)
            {
                textBoxColores.Text = "Color: " + radioButton1.Text;
            }

            if (radioButton2.Checked)
            {
                textBoxColores.Text = "Color: " + radioButton2.Text;
            }

            if (radioButton3.Checked)
            {
                textBoxColores.Text = "Color: " + radioButton3.Text;
            }

        }
    }
}
