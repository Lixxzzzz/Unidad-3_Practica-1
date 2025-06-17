namespace Ejercicio_8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResultado = new Label();
            txtOracion = new TextBox();
            btnContar = new Button();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(29, 325);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(256, 32);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Número de palabras";
            // 
            // txtOracion
            // 
            txtOracion.Location = new Point(29, 108);
            txtOracion.Name = "txtOracion";
            txtOracion.Size = new Size(460, 31);
            txtOracion.TabIndex = 1;
            // 
            // btnContar
            // 
            btnContar.BackColor = Color.FromArgb(255, 128, 128);
            btnContar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContar.Location = new Point(166, 192);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(150, 60);
            btnContar.TabIndex = 2;
            btnContar.Text = "Contar";
            btnContar.UseVisualStyleBackColor = false;
            btnContar.Click += btnContar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(526, 450);
            Controls.Add(btnContar);
            Controls.Add(txtOracion);
            Controls.Add(lblResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private TextBox txtOracion;
        private Button btnContar;
    }
}
