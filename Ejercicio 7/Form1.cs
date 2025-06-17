namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
     {
                listBoxPrimos.Items.Clear(); // Limpiar el ListBox

                // Validar entrada
                if (int.TryParse(txtInicio.Text, out int inicio) && int.TryParse(txtFin.Text, out int fin) && inicio > 0 && fin > inicio)
                {
                    // Buscar números primos dentro del rango
                    for (int num = inicio; num <= fin; num++)
                    {
                        if (EsPrimo(num))
                        {
                            listBoxPrimos.Items.Add(num); // Agregar número primo al ListBox
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un rango válido (Inicio debe ser menor que Fin).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }
    }

