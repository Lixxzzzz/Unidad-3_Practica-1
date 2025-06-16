

namespace Ejercicio_5
{

    public partial class Verificar : Form
    {
        public Verificar()
        {
            InitializeComponent();
        }
        private void btnVerificar_Click_1(object sender, EventArgs e)
        {
            // Verificar si el número ingresado es válido
            if (int.TryParse(maskedNumero.Text, out int numero))
            {
                if (EsPrimo(numero))
                {
                    MessageBox.Show($"{numero} es un número primo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{numero} NO es un número primo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsPrimo(int num)
        {
            if (num < 2) return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        private void Verificar_Load(object sender, EventArgs e)
        {

        }
    }
}