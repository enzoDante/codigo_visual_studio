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

namespace atividade07_ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int maior = 0;
        int menor = 0;
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            if(i == 0)
            {
                maior = num;
                menor = num;
                i++;
            }
            maior = Math.Max(maior, num);
            menor = Math.Min(menor, num);

            label1.Text = "Maior valor = "+maior;
            label2.Text = "Menor valor = "+menor;


        }
    }
}
