namespace Act9
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1_par = new System.Windows.Forms.Button();
            this.button2_inpar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1_par
            // 
            this.button1_par.Location = new System.Drawing.Point(399, 56);
            this.button1_par.Name = "button1_par";
            this.button1_par.Size = new System.Drawing.Size(75, 23);
            this.button1_par.TabIndex = 1;
            this.button1_par.Text = "Par";
            this.button1_par.UseVisualStyleBackColor = true;
            this.button1_par.Click += new System.EventHandler(this.button1_par_Click);
            // 
            // button2_inpar
            // 
            this.button2_inpar.Location = new System.Drawing.Point(597, 56);
            this.button2_inpar.Name = "button2_inpar";
            this.button2_inpar.Size = new System.Drawing.Size(75, 23);
            this.button2_inpar.TabIndex = 2;
            this.button2_inpar.Text = "Inpar";
            this.button2_inpar.UseVisualStyleBackColor = true;
            this.button2_inpar.Click += new System.EventHandler(this.button2_inpar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 259);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2_inpar);
            this.Controls.Add(this.button1_par);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1_par;
        private System.Windows.Forms.Button button2_inpar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

