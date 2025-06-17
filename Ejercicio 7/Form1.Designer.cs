namespace Ejercicio_7
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
            txtInicio = new TextBox();
            txtFin = new TextBox();
            btnCalcular = new Button();
            listBoxPrimos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtInicio
            // 
            txtInicio.BackColor = Color.WhiteSmoke;
            txtInicio.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInicio.Location = new Point(162, 108);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(150, 35);
            txtInicio.TabIndex = 0;
            // 
            // txtFin
            // 
            txtFin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFin.Location = new Point(162, 170);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(150, 35);
            txtFin.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.RosyBrown;
            btnCalcular.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(162, 252);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 70);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // listBoxPrimos
            // 
            listBoxPrimos.BackColor = Color.RosyBrown;
            listBoxPrimos.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxPrimos.FormattingEnabled = true;
            listBoxPrimos.ItemHeight = 26;
            listBoxPrimos.Location = new Point(355, 47);
            listBoxPrimos.Name = "listBoxPrimos";
            listBoxPrimos.Size = new Size(180, 368);
            listBoxPrimos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 95);
            label1.Name = "label1";
            label1.Size = new Size(107, 45);
            label1.TabIndex = 4;
            label1.Text = "Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 157);
            label2.Name = "label2";
            label2.Size = new Size(95, 45);
            label2.TabIndex = 5;
            label2.Text = "Final";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(625, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxPrimos);
            Controls.Add(btnCalcular);
            Controls.Add(txtFin);
            Controls.Add(txtInicio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInicio;
        private TextBox txtFin;
        private Button btnCalcular;
        private ListBox listBoxPrimos;
        private Label label1;
        private Label label2;
    }
}
