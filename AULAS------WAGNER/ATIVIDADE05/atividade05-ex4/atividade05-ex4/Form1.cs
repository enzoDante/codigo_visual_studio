/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: DD/MM/2020
* Autores do Projeto: Enzo Dante Mícoli
*                     
* Turma: 2H
* Atividade Proposta em aula
* Observação: atividade 5 ex 4
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

namespace atividade05_ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = 0, b = 0, c = 0;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            c = float.Parse(textBox3.Text);

            if (a < 1 || b < 1 || c < 1)
            {
                label1.Text = "Não existe triângulo com lado negativo!!!";
            }
            else
            {
                if (a + b > c && a + c > b && c + b > a)
                {
                    if (a == b && b == c)
                    {
                        label1.Text = "Triângulo equilátero";
                    }
                    else
                    {
                        if (a == b || a == c || b == c)
                        {
                            label1.Text = "Triângulo isóceles";
                        }
                        else
                        {
                            label1.Text = "Triângulo escaleno";
                        }
                    }


                }
                else
                {
                    label1.Text = "Não é possível formar um triângulo com esses números!!!";
                }
            }
        }
    }
}
