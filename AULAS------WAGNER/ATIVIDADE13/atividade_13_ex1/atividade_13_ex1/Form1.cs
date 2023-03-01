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

namespace atividade_13_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Nome:";
            label2.Text = "Cidade:";
            label3.Text = "Telefone:";
            label4.Text = @"Insira o caminho e o nome do arquivo na qual será gerado/alterado: exemplo: C:\ex\arquivo.csv";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string cidade = textBox2.Text;
            int telefone = int.Parse(textBox3.Text);
            string caminho = textBox4.Text;

            bool adicionar = true;
            string[] verificar = File.ReadAllLines(caminho);
            foreach(string valor in verificar)
            {
                string[] linhav = valor.Split(',');
                if(nome == linhav[0])
                {
                    label1.Text = "Nome existente!! Digite outro nome:";
                    adicionar = false;
                    break;
                }
            }

            if (adicionar)
            {
                label1.Text = "Nome:";
                string linha = nome + ","+cidade+","+telefone.ToString();

                File.AppendAllText(caminho, linha+Environment.NewLine);
                label5.Text = "Arquivo criado/alterado com sucesso, aguarde alguns segundos!!";
                timer1.Enabled = true;
                timer1.Interval = 2000;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            timer1.Enabled = false;
        }
    }
}
