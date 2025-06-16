
using System.Diagnostics.Eventing.Reader;

namespace Ejercicio_2

{
    public partial class Form1 : Form


    {
        int hh, mm, ss; // Variables para horas, minutos y segundos
        string m, s; // Variables para minutos y segundos como cadenas

        public Form1()
        {
            InitializeComponent();

        }
        private void reiniciar() // Método para reiniciar el cronómetro
        {
            hh = 0;
            mm = 0;
            ss = 0;
            lblMostrado.Text = "00:00:00";
            Cronometro.Stop(); // Detiene el cronómetro

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblMostrado.Text = "00:00:00"; // Inicializa la etiqueta con el tiempo 00:00:00
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Cronometro.Start(); // Inicia el cronómetro
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            Cronometro.Stop(); // Detiene el cronómetro
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reiniciar(); // Llama al método para reiniciar el cronómetro
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            ss += 1; // Incrementa los segundos
            lblMostrado.Text = $"{hh:D2}:{mm:D2}:{ss:D2}";

            if (ss == 60) // Si los segundos llegan a 60
            {
                ss = 0; // Reinicia los segundos
                mm += 1; // Incrementa los minutos
                if (mm == 60) // Si los minutos llegan a 60
                {
                    mm = 0; // Reinicia los minutos
                    hh += 1; // Incrementa las horas

                }
            }

            // Condición para mostrar el mensaje cuando el tiempo se agote
            if (hh == 0 && mm == 2 && ss == 0) 
            {
                MessageBox.Show("¡El tiempo se ha agotado!", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cronometro.Stop(); 
            }
        }
    }
}



