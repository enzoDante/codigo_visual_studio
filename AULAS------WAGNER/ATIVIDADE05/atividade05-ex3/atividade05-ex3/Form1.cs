/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: DD/MM/2020
* Autores do Projeto: Enzo Dante Mícoli
*                     
* Turma: 2H
* Atividade Proposta em aula
* Observação: atividade 5 ex 3
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

namespace atividade05_ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int primo = 0;
            int x = int.Parse(textBox1.Text);


            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    primo++;
                }
            }
            if (primo == 2)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Número primo";
            }
            else
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Número não primo";
            }
        }
    }
}
