using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_rad_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Enzo Dante Mícoli --- 2H
          ATIVIDADE 04
          Ex-04
        */
        //========algumas variaveis=================
        string nome = "", vencedora = "", nota_vazia="";
        decimal maior = 0, menor = 0;
        decimal media = 0;
        int i = 1;
        bool permitir_botao2 = false;


        //=================botao de calcular e mostrar dados=========================
        private void button2_Click(object sender, EventArgs e)
        {
            if (permitir_botao2)
            {
                media = media / (i-1); //calcula a média das notas
                textBox3.AppendText("Candidata vencedora: "+vencedora+Environment.NewLine);
                textBox3.AppendText("Média das notas = "+media.ToString("0.00")+Environment.NewLine);
                textBox3.AppendText("Maior nota: " + maior + Environment.NewLine + "Menor nota: " + menor + Environment.NewLine);
                i = 1; //controle de candidatas volta a ser 1

                label1.Text = "Digite o nome da "+i+"º candidata:";
                label2.Text = "Digite a nota da " + i + "º candidata:";

                label3.Text = " ";
                permitir_botao2 = false;//deverá adicionar pelo menos 1 candidato para ficar true

            }
            else
            {
                label1.Text = "Digite o nome da " + i + "º candidata:";
                label2.Text = "Digite a nota da " + i + "º candidata:";
                label3.Text = "Você deve adicionar pelo menos uma candidata!";
            }


        }       
        //=====================botao de adicionar nomes e notas abaixo================

        private void button1_Click(object sender, EventArgs e)
        {
            decimal nota = 0;
            
            
            nome = textBox1.Text;
            nota_vazia = textBox2.Text;
            if(nome == "" || nota_vazia == "") //verifica se os campos estão vazios
            {
                label1.Text = "Campo nome está vazio ou campo nota está vazio!";
            }
            else
            {
                nota = decimal.Parse(textBox2.Text);
                if(nota >= 0 && nota <= 10) //verifica se a nota esta entre 0 e 10
                {
                    if(i == 1) //primeira candidata sempre será a vencedora com maior e menor nota
                    {
                        maior = nota;
                        menor = nota;
                        media = nota;
                        vencedora = nome;
                    }
                    else
                    {
                        if (nota > maior) //atualiza maior e menor nota e a vencedora
                        {
                            maior = nota;
                            vencedora = nome;
                        }
                        else if (nota < menor)
                            menor = nota;

                        media += nota; //adiciona todas as notas para calcular a média
                    }


                    i++; //controle de candidatas
                    permitir_botao2 = true; //caso tenha pelo menos uma candidata, o próximo botão irá mostrar os dados

                    label1.Text = "Digite o nome da " + i + "º candidata:";
                    label2.Text = "Digite a nota da " + i + "º candidata:";
                }
                else
                {
                    label2.Text = "Insira uma nota entre 0 e 10";
                }
            }

        }
    }
}
