using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteBRQ
{
    public partial class Teste02 : Form
    {
        public Teste02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataNascimento = dateTimePicker1.Value;
            DateTime dataHoje = DateTime.Now;

            DateTime dataMaxima = new DateTime(2014, 12, 31, 23, 59, 59);
            TimeSpan anos = dataHoje - dataNascimento;

            DateTime idade = new DateTime(anos.Ticks);

            var result = DateTime.Compare(dataNascimento, dataMaxima);
            if (result > 0) 
            {
                texto.Text = "A data informáda é inválida, escolha uma data inferior ao ano de 2015";
            }
            else
            {
                texto.Text = $"Idade {idade.Year - 1} anos, {idade.Month} meses e {idade.Day} dias" ;
            }

        }
    }
}
