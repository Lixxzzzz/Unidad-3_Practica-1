namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
           lstTabla.Items.Clear();
              if (int.TryParse(txtNumero.Text, out int numero) && numero > 0)
              {
                for (int i = 1; i <= 10; i++)
                {
                     lstTabla.Items.Add($"{numero} x {i} = {numero * i}");
                }
              }
              else
              {
                MessageBox.Show("Por favor, ingrese un número válido mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
