using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TesteBRQ
{
    public partial class Teste04 : Form
    {
        public Teste04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> sequencia = [-34, 77, -89, -25, -19, 14, -20, 46, -32, 91];
            List<string> listaPositivoNegativo = [];
            textBox1.Text = string.Empty;
            var texto = string.Empty; ;



            foreach (var i in sequencia)
            {
                if (i > 0)
                {
                    listaPositivoNegativo.Add("Postivo");
                }
                else if (i < 0) 
                {
                    listaPositivoNegativo.Add("Negativo");
                }
            }

            foreach (var lista in listaPositivoNegativo)
            {
                texto = texto + "," + lista ;
            }

            textBox1.Text = texto.Substring(1);
        }
    }
}
