
using System;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        int tiempoRestante; // Variable para el tiempo restante en segundos

        public Form1()
        {
            InitializeComponent();
        }

        private void reiniciar() // Método para reiniciar el temporizador
        {
            Cronometro.Stop(); // Detiene el temporizador
            tiempoRestante = 0; // Reinicia la variable de tiempo
            lblMostrado.Text = "00:00:00"; // Reinicia la etiqueta
            txtTiempo.Text = ""; // Limpia el TextBox
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMostrado.Text = "00:00:00"; // Inicializa la etiqueta
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTiempo.Text, out tiempoRestante) && tiempoRestante > 0)
            {
                Cronometro.Start(); // Inicia el temporizador
            }
            else
            {
                MessageBox.Show("Ingrese un número válido mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            Cronometro.Stop(); // Detiene el temporizador
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reiniciar(); // Reinicia el temporizador
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                tiempoRestante--; // Reduce el tiempo
                int hh = tiempoRestante / 3600;
                int mm = (tiempoRestante % 3600) / 60;
                int ss = tiempoRestante % 60;
                lblMostrado.Text = $"{hh:D2}:{mm:D2}:{ss:D2}"; // Muestra el tiempo restante
            }
            else
            {
                Cronometro.Stop();
                MessageBox.Show("¡Tiempo agotado!", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}


