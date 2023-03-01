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

namespace atividade08_ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hipotenusa = Double.Parse(textBox1.Text);
            double cateto1 = Double.Parse(textBox2.Text);

            double cateto2 = Math.Pow(hipotenusa, 2) - Math.Pow(cateto1, 2);
            cateto2 = (double)Math.Sqrt(cateto2);
            label1.Text = "A altura da torre é de: "+cateto2.ToString("0.00");
        }
    }
}
