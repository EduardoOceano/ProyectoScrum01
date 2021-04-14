
namespace ProyectoScrum01
{
    partial class Ejercicio5
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
            this.intro = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // intro
            // 
            this.intro.Location = new System.Drawing.Point(154, 107);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(100, 20);
            this.intro.TabIndex = 0;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(269, 180);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 20);
            this.resultado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultado de la suma:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonSuma
            // 
            this.botonSuma.Location = new System.Drawing.Point(154, 133);
            this.botonSuma.Name = "botonSuma";
            this.botonSuma.Size = new System.Drawing.Size(75, 23);
            this.botonSuma.TabIndex = 3;
            this.botonSuma.Text = "Suma";
            this.botonSuma.UseVisualStyleBackColor = true;
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonSuma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.intro);
            this.Name = "Ejercicio5";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox intro;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonSuma;
    }
}