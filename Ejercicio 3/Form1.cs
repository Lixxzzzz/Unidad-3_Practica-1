namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Metros", "Centímetros", "Pulgadas" });
            comboBox2.Items.AddRange(new string[] { "Metros", "Centímetros", "Pulgadas" });
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double valor))
            {
                double resultado= Convertir (valor, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
               label1.Text = $"Resultado: {resultado:F2} {comboBox2.SelectedItem}";
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private double Convertir(double valor, string entrada, string salida)
        {
            // Conversión a metros
            if (entrada == "Centímetros") valor /= 100;
            else if (entrada == "Pulgadas") valor *= 0.0254;

            // Conversión desde metros a la unidad deseada
            if (salida == "Centímetros") valor *= 100;
            else if (salida == "Pulgadas") valor /= 0.0254;

            return valor;
        }
    }
}




