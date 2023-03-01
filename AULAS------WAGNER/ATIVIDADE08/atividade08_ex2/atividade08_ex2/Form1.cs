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

namespace atividade08_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v = 0;
            int cont = 0;
            bool teste = true;
            for (int x = 1; x <= 4; x++)
            {
                if (teste)
                {
                    textBox1.AppendText("De " + v + " até " + (v + 90) + " = Quadrante [+]" + Environment.NewLine);
                    if ((cont == 0) || (cont == 2))
                        teste = false;

                }
                else
                {
                    textBox1.AppendText("De " + v + " até " + (v + 90) + " = Quadrante [-]" + Environment.NewLine);
                    if (cont == 2)
                        teste = true;
                }
                cont++;
                v += 90;
            }
        }
    }
}
