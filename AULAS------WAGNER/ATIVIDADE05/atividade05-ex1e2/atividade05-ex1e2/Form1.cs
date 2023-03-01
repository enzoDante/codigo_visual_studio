/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: DD/MM/2020
* Autores do Projeto: Enzo Dante Mícoli
*                     
* Turma: 2H
* Atividade Proposta em aula
* Observação: atividade 5 ex 1
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

namespace atividade05_ex1e2
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
            do
            {
                f = f * n;

                n = n - 1;
            } while (n > 1);
            textBox2.AppendText("numero " + f + Environment.NewLine);
        }
        /*O fluxograma (B) é o que funcionária da forma mais adequada, no caso se testarmos o valor "0" seu fatorial deve ser "1"
              no fluxograma(A) o valor daria "0" porque ele entraria no loop antes da condição, fazendo "0 * 1 = 0"
              no fluxograma(B) o valor daria "1"(correto) porque antes de entrar no loop, ele verifica se o valor digitado é maior que 1, se for maior que 1, fará o cálculo dentro do loop

             */
    }
}
