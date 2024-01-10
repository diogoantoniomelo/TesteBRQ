namespace TesteBRQ
{
    public partial class Teste01 : Form
    {
        public Teste01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var valor = txtValor.Text;
            if (valor.All(Char.IsDigit))
            {
                if (Convert.ToInt32(valor) % 2 == 0)
                {
                    txtResultado.Text = "O valor digitado é par";
                }
                else
                {
                    txtResultado.Text = "O valor digitado é impar";
                }
            }
            else
            {
                txtResultado.Text = "O valor digitado é inválido";
            }
        }
    }
}
