
namespace ProyectoScrum01
{
    partial class Ejercicio6
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
            this.Resultado = new System.Windows.Forms.TextBox();
            this.intro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(240, 220);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(100, 20);
            this.Resultado.TabIndex = 0;
            // 
            // intro
            // 
            this.intro.Location = new System.Drawing.Point(128, 146);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(100, 20);
            this.intro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduce números separados por comas \",\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado de la suma:";
            // 
            // botonSuma
            // 
            this.botonSuma.Location = new System.Drawing.Point(128, 173);
            this.botonSuma.Name = "botonSuma";
            this.botonSuma.Size = new System.Drawing.Size(75, 23);
            this.botonSuma.TabIndex = 4;
            this.botonSuma.Text = "Suma";
            this.botonSuma.UseVisualStyleBackColor = true;
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonSuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intro);
            this.Controls.Add(this.Resultado);
            this.Name = "Ejercicio6";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.TextBox intro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonSuma;
    }
}