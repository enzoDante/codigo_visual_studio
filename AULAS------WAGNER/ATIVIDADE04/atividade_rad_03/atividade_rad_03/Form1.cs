using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_rad_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Enzo Dante Mícoli --- 2H
          ATIVIDADE 04
          Ex-03
        */

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            if (numero <= 0)
            {
                label1.Text = "Digite um número positivo acima de 0!!!";
            }
            else
            {
                label1.Text = "Digite um número:";
                int divisor = 0;
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                        divisor++;
                }
                if (divisor == 2)
                    textBox2.AppendText(numero + " é um número primo!" + Environment.NewLine);
                else
                    textBox2.AppendText(numero + " não é um número primo!" + Environment.NewLine);
            }
        }
    }
}
