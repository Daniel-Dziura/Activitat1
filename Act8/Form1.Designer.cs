namespace Act8
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botonAula1 = new System.Windows.Forms.Button();
            this.botonAula2 = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(73, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(389, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // botonAula1
            // 
            this.botonAula1.Location = new System.Drawing.Point(73, 173);
            this.botonAula1.Name = "botonAula1";
            this.botonAula1.Size = new System.Drawing.Size(75, 23);
            this.botonAula1.TabIndex = 2;
            this.botonAula1.Text = "Aula1";
            this.botonAula1.UseVisualStyleBackColor = true;
            this.botonAula1.Click += new System.EventHandler(this.botonAula1_Click);
            // 
            // botonAula2
            // 
            this.botonAula2.Location = new System.Drawing.Point(73, 224);
            this.botonAula2.Name = "botonAula2";
            this.botonAula2.Size = new System.Drawing.Size(75, 23);
            this.botonAula2.TabIndex = 3;
            this.botonAula2.Text = "Aula2";
            this.botonAula2.UseVisualStyleBackColor = true;
            this.botonAula2.Click += new System.EventHandler(this.botonAula2_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.Location = new System.Drawing.Point(73, 272);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(75, 23);
            this.botonBorrar.TabIndex = 4;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonAula2);
            this.Controls.Add(this.botonAula1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botonAula1;
        private System.Windows.Forms.Button botonAula2;
        private System.Windows.Forms.Button botonBorrar;
    }
}

