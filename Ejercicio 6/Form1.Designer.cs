namespace Ejercicio_6
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
            maskedTextBoxNumero = new MaskedTextBox();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // maskedTextBoxNumero
            // 
            maskedTextBoxNumero.Location = new Point(53, 127);
            maskedTextBoxNumero.Name = "maskedTextBoxNumero";
            maskedTextBoxNumero.Size = new Size(304, 31);
            maskedTextBoxNumero.TabIndex = 0;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.Red;
            btnVerificar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificar.Location = new Point(118, 224);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(175, 60);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(435, 450);
            Controls.Add(btnVerificar);
            Controls.Add(maskedTextBoxNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBoxNumero;
        private Button btnVerificar;
    }
}
