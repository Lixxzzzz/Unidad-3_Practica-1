namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
            {
                string oracion = txtOracion.Text.Trim(); // Eliminar espacios extra

                if (string.IsNullOrEmpty(oracion))
                {
                    lblResultado.Text = "Por favor, ingrese una oración.";
                    return;
                }

                int cantidadPalabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                lblResultado.Text = $"Número de palabras: {cantidadPalabras}";
            }
        }
    }

