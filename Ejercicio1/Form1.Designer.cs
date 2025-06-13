namespace Ejercicio1
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
            btnTabla = new Button();
            lstTabla = new ListBox();
            txtNumero = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnTabla
            // 
            btnTabla.Location = new Point(92, 243);
            btnTabla.Name = "btnTabla";
            btnTabla.Size = new Size(112, 34);
            btnTabla.TabIndex = 0;
            btnTabla.Text = "Mostrar";
            btnTabla.UseVisualStyleBackColor = true;
            btnTabla.Click += button1_Click;
            // 
            // lstTabla
            // 
            lstTabla.FormattingEnabled = true;
            lstTabla.ItemHeight = 25;
            lstTabla.Location = new Point(319, 49);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(218, 354);
            lstTabla.TabIndex = 1;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(79, 170);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(150, 31);
            txtNumero.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(12, 86);
            label1.Name = "label1";
            label1.Size = new Size(290, 38);
            label1.TabIndex = 3;
            label1.Text = "Ingresa un numero ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(580, 433);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(lstTabla);
            Controls.Add(btnTabla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTabla;
        private ListBox lstTabla;
        private TextBox txtNumero;
        private Label label1;
    }
}
