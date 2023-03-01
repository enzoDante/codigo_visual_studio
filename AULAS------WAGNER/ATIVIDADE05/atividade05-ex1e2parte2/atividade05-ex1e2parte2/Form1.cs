using System;
/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: DD/MM/2020
* Autores do Projeto: Enzo Dante Mícoli
*                     
* Turma: 2H
* Atividade Proposta em aula
* Observação: atividade 5 ex 2
* 
* problema_aula.cs
* ************************************************************/

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade05_ex1e2parte2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int f = 1;

            while (n > 1)
            {
                f = f * n;
                n = n - 1;
            }
            textBox2.AppendText("numero " + f + Environment.NewLine);
        }
    }
}
