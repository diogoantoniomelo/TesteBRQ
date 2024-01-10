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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teste01 teste01 = new Teste01();
            teste01.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teste02 teste02 = new Teste02();
            teste02.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teste03 teste03 = new Teste03();
            teste03.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Teste04 teste04 = new Teste04();
            teste04.Show();
        }
    }
}