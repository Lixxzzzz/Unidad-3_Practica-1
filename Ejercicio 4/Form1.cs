namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            {
                string palabra = textBox1.Text.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(palabra))
                {
                    MessageBox.Show("Por favor, ingrese una palabra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string invertida = new string(palabra.Reverse().ToArray());

                if (palabra == invertida)
                {
                    MessageBox.Show($"La palabra \"{textBox1.Text}\" es un palíndromo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"La palabra \"{textBox1.Text}\" no es un palíndromo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

