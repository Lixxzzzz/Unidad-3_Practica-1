namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
            {
                // Verificar si el número ingresado es válido
                if (int.TryParse(maskedTextBoxNumero.Text, out int numero))
                {
                    if (EsPerfecto(numero))
                    {
                        MessageBox.Show($"{numero} es un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"{numero} NO es un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private bool EsPerfecto(int num)
            {
                if (num < 2) return false;

                int sumaDivisores = 1; // Iniciar con 1, ya que todos los números son divisibles por 1.

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        sumaDivisores += i;
                        if (i != num / i) sumaDivisores += num / i;
                    }
                }

                return sumaDivisores == num;
            }
        }
    }

