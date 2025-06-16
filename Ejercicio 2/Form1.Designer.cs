namespace Ejercicio_2
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
            components = new System.ComponentModel.Container();
            btnIniciar = new Button();
            btnDetener = new Button();
            btnReiniciar = new Button();
            lblMostrado = new Label();
            Cronometro = new System.Windows.Forms.Timer(components);
            txtTiempo = new TextBox();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Cyan;
            btnIniciar.Location = new Point(63, 317);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(176, 59);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.BackColor = Color.Cyan;
            btnDetener.Location = new Point(245, 317);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(165, 57);
            btnDetener.TabIndex = 1;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = false;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.Cyan;
            btnReiniciar.Location = new Point(416, 317);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(171, 59);
            btnReiniciar.TabIndex = 2;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lblMostrado
            // 
            lblMostrado.AutoSize = true;
            lblMostrado.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMostrado.Location = new Point(177, 62);
            lblMostrado.Name = "lblMostrado";
            lblMostrado.Size = new Size(264, 96);
            lblMostrado.TabIndex = 3;
            lblMostrado.Text = "00 : 00";
            // 
            // Cronometro
            // 
            Cronometro.Tick += Cronometro_Tick;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(195, 232);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(246, 31);
            txtTiempo.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(644, 450);
            Controls.Add(txtTiempo);
            Controls.Add(lblMostrado);
            Controls.Add(btnReiniciar);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Button btnDetener;
        private Button btnReiniciar;
        private Label lblMostrado;
        private System.Windows.Forms.Timer Cronometro;
        private TextBox txtTiempo;
    }
}
