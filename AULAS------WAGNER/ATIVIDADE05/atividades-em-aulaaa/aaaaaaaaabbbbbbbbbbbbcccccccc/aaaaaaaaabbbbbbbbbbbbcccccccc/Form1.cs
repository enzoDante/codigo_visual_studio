using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaaaaaaaabbbbbbbbbbbbcccccccc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int maior = 0, menor = 0, numero = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*menor = numero;
            textBox2.AppendText("" + menor);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = maior.ToString();
            label2.Text = menor.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero = int.Parse(textBox1.Text);
            maior = System.Math.Max(numero, maior);
            menor = System.Math.Min(numero, menor);
            
        }

    }
}
