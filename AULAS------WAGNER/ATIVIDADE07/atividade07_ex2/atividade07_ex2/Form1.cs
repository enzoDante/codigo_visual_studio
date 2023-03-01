/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: DD/MM/2020
* Autores do Projeto: Enzo Dante 50210203
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

namespace atividade07_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text);
            double b = Double.Parse(textBox2.Text);
            double grau = Double.Parse(textBox3.Text);
            if ((a <= 0) || (b <= 0))
                label1.Text = "não digite números negativos para os lados!";

            grau = Math.Cos((Math.PI * grau) / 180);
            double valor = (a * a) + (b * b) - (2*a*b*grau);
            valor = Math.Sqrt(valor);

            label1.Text = "Valor da diagonal = "+valor.ToString("0.00");
        }
    }
}
