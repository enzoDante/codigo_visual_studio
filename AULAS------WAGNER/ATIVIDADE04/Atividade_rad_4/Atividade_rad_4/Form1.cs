using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_rad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string nome = "", vencedora = "";
        decimal maior = 0, menor = 0, total = 0;
        decimal media = 0;
        int i = 0;
        bool teste = false;

        private void button1_Click(object sender, EventArgs e)
        {
            total = int.Parse(textBox1.Text);
            if(total > 0)
            {
                teste = true;
                maior = 0;
                menor = 0;
                media = 0;
                i = 1;
                label2.Text = "Nome da " + i + "º candidata";
                label3.Text = "Nota da " + i + "º candidata";
                label1.Text = "Número de candidatas do concurso";
            }
            else
            {
                label1.Text = "Digite quantas pessoas participaram do concurso!!!";
            }
            


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal nota = 0;
            if (i != total + 1 && teste == true)
            {


                nome = textBox2.Text;
                nota = decimal.Parse(textBox3.Text);
                if (nota >= 0 && nota <= 10)
                {
                    if (i == 1)
                    {
                        maior = nota; //recebe a primeira nota inserida
                        menor = maior; //menor também tem o mesmo valor inicial
                        media = maior; //somar todas as notas para tirar a média no final
                    }
                    else
                    {
                        if (nota > maior)
                        {
                            maior = nota;
                            vencedora = nome;

                        }
                        else if (nota < menor)
                            menor = nota;

                        media += nota; //soma todas as notas
                    }






                    if (i == total) //irá mostrar o resultado
                    {

                        media = media / total;
                        textBox4.AppendText("Candidata vencedora: " + vencedora + Environment.NewLine);
                        textBox4.AppendText("Média das notas = " + media + Environment.NewLine);
                        textBox4.AppendText("Maior nota: " + maior + Environment.NewLine + "Menor nota: " + menor + Environment.NewLine);
                    }

                    i++; //controle para limite de candidatos
                    if (i != total + 1)
                    {
                        label2.Text = "Nome da " + i + "º candidata";
                        label3.Text = "Nota da " + i + "º candidata";

                    }
                }
                else
                {
                    label3.Text = "Insira uma nota entre 0 e 10!!!";
                }
            }
            else
            {
                label2.Text = "Todos ja foram inseridos ou não existe total de candidatos!!!";
                label3.Text = "Notas finalizadas! ou falta candidatos";
            }


            
        }
    }
}
