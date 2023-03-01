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
using System.IO;

namespace atividade13_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Insira o caminho do arquivo para procurar por um nome:";
            label2.Text = "Digite o nome que deseja procurar:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caminho = textBox1.Text;
            string nome = textBox2.Text;

            string[] linhas = File.ReadAllLines(caminho);
            foreach (string valor in linhas)
            {
                string[] valor_linha = valor.Split(',');
                if (nome == valor_linha[0])
                {
                    label2.Text = "Digite o nome que deseja procurar:";
                    textBox3.Text = valor_linha[0];
                    textBox4.Text = valor_linha[1];
                    textBox5.Text = valor_linha[2];
                    break;
                }
                else
                    label2.Text = "Nome não encontrado no arquivo!!!";
            }
        }
    }
}
