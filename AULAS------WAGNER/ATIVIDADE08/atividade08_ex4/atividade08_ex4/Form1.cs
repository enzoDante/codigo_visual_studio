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

namespace atividade08_ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int total = 0;
        int cont = 0;
        string produto = "";
        string msg = "";

        private void button1_Click(object sender, EventArgs e)
        {
            total = int.Parse(textBox1.Text);
            if (total <= 0)
                label2.Text = "Informe a quantidade de terrenos!!!";
            else
            {
                label2.Text = "";                
                if (cont <= total)
                {
                    cont++;
                    if (cont < total)
                    {
                        label1.Text = "Digite a " + (cont + 1) + "º área";
                        label3.Text = "Digite o nome do" + (cont + 1) + "º produto";
                    }
                        
                    double area = Double.Parse(textBox2.Text);
                    double raio = Math.Sqrt(area/Math.PI); //area /(2 * Math.PI)
                    produto = textBox3.Text;

                    msg += "raio do "+produto+" é " + raio.ToString("0.00") + Environment.NewLine;

                    textBox2.Text = "";
                    textBox3.Text = "";
                    if (cont == total)
                    {
                        
                        textBox4.Text = msg;
                        textBox1.Text = "";
                        textBox3.Text = "";
                        label1.Text = "Digite o 1º valor";
                        label3.Text = "Digite o nome do 1º produto";
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
