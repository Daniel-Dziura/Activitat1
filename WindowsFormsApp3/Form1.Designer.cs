namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.operador = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.animal1 = new System.Windows.Forms.CheckBox();
            this.animal2 = new System.Windows.Forms.CheckBox();
            this.animal3 = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.botonAnimales = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.botonColores = new System.Windows.Forms.Button();
            this.textBoxColores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(68, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(347, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(347, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(635, 300);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Suma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(524, 340);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 7;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // operador
            // 
            this.operador.Location = new System.Drawing.Point(347, 299);
            this.operador.Name = "operador";
            this.operador.Size = new System.Drawing.Size(100, 22);
            this.operador.TabIndex = 8;
            this.operador.TextChanged += new System.EventHandler(this.operador_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(223, 164);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Num 1";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(223, 231);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "Num 2";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(223, 299);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "Operador";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "-",
            "+"});
            this.listBox1.Location = new System.Drawing.Point(347, 355);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // animal1
            // 
            this.animal1.AutoSize = true;
            this.animal1.Location = new System.Drawing.Point(512, 35);
            this.animal1.Name = "animal1";
            this.animal1.Size = new System.Drawing.Size(80, 21);
            this.animal1.TabIndex = 13;
            this.animal1.Text = "Tortuga";
            this.animal1.UseVisualStyleBackColor = true;
            this.animal1.CheckedChanged += new System.EventHandler(this.animal1_CheckedChanged);
            // 
            // animal2
            // 
            this.animal2.AutoSize = true;
            this.animal2.Location = new System.Drawing.Point(512, 76);
            this.animal2.Name = "animal2";
            this.animal2.Size = new System.Drawing.Size(62, 21);
            this.animal2.TabIndex = 14;
            this.animal2.Text = "Leon";
            this.animal2.UseVisualStyleBackColor = true;
            this.animal2.CheckedChanged += new System.EventHandler(this.animal2_CheckedChanged);
            // 
            // animal3
            // 
            this.animal3.AutoSize = true;
            this.animal3.Location = new System.Drawing.Point(512, 118);
            this.animal3.Name = "animal3";
            this.animal3.Size = new System.Drawing.Size(68, 21);
            this.animal3.TabIndex = 15;
            this.animal3.Text = "Zebra";
            this.animal3.UseVisualStyleBackColor = true;
            this.animal3.CheckedChanged += new System.EventHandler(this.animal3_CheckedChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(598, 35);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(190, 22);
            this.textBox7.TabIndex = 16;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // botonAnimales
            // 
            this.botonAnimales.Location = new System.Drawing.Point(635, 89);
            this.botonAnimales.Name = "botonAnimales";
            this.botonAnimales.Size = new System.Drawing.Size(75, 23);
            this.botonAnimales.TabIndex = 17;
            this.botonAnimales.Text = "OK";
            this.botonAnimales.UseVisualStyleBackColor = true;
            this.botonAnimales.Click += new System.EventHandler(this.botonAnimales_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(894, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 21);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Red";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(894, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 21);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Blue";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(894, 117);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 21);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "White";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // botonColores
            // 
            this.botonColores.Location = new System.Drawing.Point(1027, 118);
            this.botonColores.Name = "botonColores";
            this.botonColores.Size = new System.Drawing.Size(75, 23);
            this.botonColores.TabIndex = 21;
            this.botonColores.Text = "OK";
            this.botonColores.UseVisualStyleBackColor = true;
            this.botonColores.Click += new System.EventHandler(this.botonColores_Click);
            // 
            // textBoxColores
            // 
            this.textBoxColores.Location = new System.Drawing.Point(894, 176);
            this.textBoxColores.Name = "textBoxColores";
            this.textBoxColores.Size = new System.Drawing.Size(219, 22);
            this.textBoxColores.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 560);
            this.Controls.Add(this.textBoxColores);
            this.Controls.Add(this.botonColores);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.botonAnimales);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.animal3);
            this.Controls.Add(this.animal2);
            this.Controls.Add(this.animal1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.operador);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox operador;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox animal1;
        private System.Windows.Forms.CheckBox animal2;
        private System.Windows.Forms.CheckBox animal3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button botonAnimales;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button botonColores;
        private System.Windows.Forms.TextBox textBoxColores;
    }
}

