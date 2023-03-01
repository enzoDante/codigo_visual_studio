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

namespace atividade07_ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int total = 0;
        int cont = 0;
        double menor = 0;
        string msg = "";

        private void button1_Click(object sender, EventArgs e)
        {
            total = int.Parse(textBox1.Text);
            if(total <= 0)
                label2.Text = "Informe a quantidade de terrenos!!!";
            else
            {
                label2.Text = "";
                if (cont <= total)
                {
                    cont++;
                    if(cont < total)
                        label1.Text = "Digite a "+(cont+1)+"º área";
                    int area = int.Parse(textBox2.Text); 
                    double lado = Math.Sqrt(area);

                    double valor = lado * 4;
                    if (cont == 1)
                        menor = valor;
                    menor = Math.Min(menor, valor);

                    textBox2.Text = "";
                    msg += "Perímetro("+cont.ToString()+") = " + valor.ToString("0.00") + Environment.NewLine;
                    if (cont == total)
                    {
                        msg = "Menor perímetro: "+menor.ToString()+Environment.NewLine + msg;
                        textBox3.Text = msg;
                        textBox1.Text = "";
                        label1.Text = "Digite o 1º valor";
                        label2.Text = "Informe a quantidade de terreno";
                        cont = 0;
                        total = 0;
                        msg = "";
                    }
                        

                }
            }
            
        }
    }
}
