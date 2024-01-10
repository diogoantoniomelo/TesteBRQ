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
    public partial class Teste03 : Form
    {
        public Teste03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal c = decimal.Parse(celcius.Text);
            decimal f = 0;
            decimal k = c + 275.15m; 

            f = (f - 32) * 5 / 9;

            kelvin.Text = $"{k}";
            fahrenheit.Text = $"{f}";
        }
    }
}
