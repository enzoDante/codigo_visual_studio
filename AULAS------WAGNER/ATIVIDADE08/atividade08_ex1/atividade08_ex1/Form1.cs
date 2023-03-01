/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: DD/MM/2020
* Autores do Projeto: Enzo Dante
* 
* Turma: 2H
* Atividade Proposta em aula
* Observação: <colocar se houver>
* 
* problema_aula.cs
* ************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade08_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0, f = 1;
            double area = Double.Parse(textBox1.Text);
            double r = Math.Sqrt(area / 3.14);
            r = (int)r;
            int cima = (int)r + 1;
            textBox2.Text = "";

            for (int x = 1; x <= cima; x++)
            {
                i += f;
                f += i;

                if ((i == r) || (i == cima))
                {
                    //label1.Text = "valor = " + i + "  do valor digitado ";
                    textBox2.AppendText("àrea" + area + Environment.NewLine);
                    textBox2.AppendText("valor " + i + Environment.NewLine);
                    break;
                }
                if ((f == r) || (f == cima))
                {
                    textBox2.AppendText("àrea" + area + Environment.NewLine);
                    textBox2.AppendText("valor " + f + Environment.NewLine);
                    break;
                }
            }
        }
    }
}
