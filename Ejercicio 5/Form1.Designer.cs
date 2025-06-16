namespace Ejercicio_5
{
    partial class Verificar
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
            maskedNumero = new MaskedTextBox();
            btnVerificar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // maskedNumero
            // 
            maskedNumero.Location = new Point(130, 171);
            maskedNumero.Name = "maskedNumero";
            maskedNumero.Size = new Size(172, 31);
            maskedNumero.TabIndex = 0;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(192, 192, 0);
            btnVerificar.Location = new Point(143, 253);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(139, 65);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 63);
            label1.Name = "label1";
            label1.Size = new Size(342, 45);
            label1.TabIndex = 2;
            label1.Text = "Ingresa solo numeros";
            // 
            // Verificar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(437, 450);
            Controls.Add(label1);
            Controls.Add(btnVerificar);
            Controls.Add(maskedNumero);
            Name = "Verificar";
            Text = "Verificar";
            Load += Verificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedNumero;
        private Button btnVerificar;
        private Label label1;
    }
}
