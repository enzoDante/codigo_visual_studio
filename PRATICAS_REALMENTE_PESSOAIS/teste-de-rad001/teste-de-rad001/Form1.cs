using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_de_rad001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numero = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            numero = int.Parse(textBox1.Text);
            int aux = 1;
            textBox2.AppendText("Sequencia do fatorial de " + numero + Environment.NewLine);
            for(int i = 1; i <= numero; i++)
            {
                aux = aux * i;
                textBox2.AppendText(aux + Environment.NewLine);
            }
        }
    }
}
