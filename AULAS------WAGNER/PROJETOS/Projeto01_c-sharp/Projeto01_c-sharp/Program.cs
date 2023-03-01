 /* *******************************************************************
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 28/03/2022
 * Autores do Projeto: Enzo Dante e Samuel Pascoal
 *                     
 * Turma: 2H
 * Atividade Proposta em aula
 * Observação: 
 * 
 * problema_aula.cs
 * ************************************************************/     

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto01_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salario = 0, P_25anos_salario = 0, P_cursoSuperior_salario = 0, diferenca_media_salario = 0;
            decimal P_menos25_salario = 0, P_cursoMedio_salario = 0, diferenca_media_salario2 = 0;
            decimal percentual_p_cursoPrimario = 0, percentual_p_cursoSuperior = 0;
            decimal maior_salario = 0, menor_salario = 0;
            
            int idade = 0, grau_instr = 0, P_grauSuperior_500reais = 0, total_p_25anos = 0, total_p_curso3 = 0;
            int total_p_menos25anos = 0, total_p_curso2 = 0;
            int idade_media_curso2 = 0, idade_curso2 = 0, idade_curso3 = 0;




            Console.WriteLine("Quantas pessoas serão analisadas?\n");
            int total = int.Parse(Console.ReadLine());
            while(total < 1)
            {
                Console.WriteLine("Digite um número acima de 0!!!\n");
                total = int.Parse(Console.ReadLine());
            }

            for(int i = 1; i <= total; i++)
            {
                Console.WriteLine("\n=============================================================");
                Console.WriteLine("\n\n"+i + "º pessoa");
                Console.Write("Valor de seu salário: R$");
                salario = decimal.Parse(Console.ReadLine());
                //===================================================================

                if(i == 1)
                {
                    maior_salario = salario;
                    menor_salario = salario;
                } 
                //cálculo de maior e menor salário

                if (salario > maior_salario)
                    maior_salario = salario;
                else if (salario < menor_salario)
                    menor_salario = salario;
                //=============================================
                
                Console.WriteLine("Digite a sua idade:");
                idade = int.Parse(Console.ReadLine());
                while(idade < 0)
                {
                    Console.WriteLine("Digite a sua idade:");
                    idade = int.Parse(Console.ReadLine());
                }
                //=======================================================================================
                if(idade > 25)
                {
                    P_25anos_salario += salario; //soma de salario das pessoas com mais de 25 anos
                    total_p_25anos++; //total de pessoas com + de 25 anos
                }
                else
                {
                    total_p_menos25anos++; //total de pessoas com menos de 25 anos e o total de salário delas
                    P_menos25_salario += salario;
                }


                Console.WriteLine("Grau de instrução((1) Primário, (2) Médio e (3) Superior)\nDigite um dos número!!!");
                grau_instr = int.Parse(Console.ReadLine());
                while(grau_instr < 1 || grau_instr > 3)
                {
                    Console.WriteLine("Digite um número válido!!!\n(1) Primário, (2) Médio e (3) Superior\n");
                    grau_instr = int.Parse(Console.ReadLine());
                }

                //===============================================================================================================
                if (grau_instr == 3)
                {
                    P_cursoSuperior_salario += salario; //pessoas curso superior salário e total de pessoas no curso superior
                    total_p_curso3++;

                    idade_curso3 += idade; //idade total de pessoas de curso superior

                    if (salario < 500)
                        P_grauSuperior_500reais++; //pessoas curso superior e com menos de 500 reais

                    //==========================================================================================================
                }else if(grau_instr == 2)
                {
                    P_cursoMedio_salario += salario; //soma de salario das pessoas de curso médio e total dessas pessoas
                    total_p_curso2++;

                    idade_curso2 += idade; //idade das pessoas de curso médio
                }
                //===============================================================================================================
                else
                {
                    percentual_p_cursoPrimario++;
                }


            }
            //================================[APÓS LAÇO DE REPETIÇÃO!]================================================================
            //==========================BLOCOS SEPARADO POR COMENTÁRIOS!!!===============================

            //abaixo calculo de média dos dados tirados acima!
            if(total_p_25anos != 0) //média do salário de pessoas com mais de 25 anos
                P_25anos_salario = P_25anos_salario / total_p_25anos;
            //==============================================================================================

            if (total_p_curso3 != 0)
            { //média do salário de pessoas de curso superior e percentual de pessoas com curso superior
                P_cursoSuperior_salario = P_cursoSuperior_salario / total_p_curso3;
                percentual_p_cursoSuperior = total_p_curso3 * 100 / total;

                idade_curso3 = idade_curso3 / total_p_curso3; //cálculo de idade média das pessoas de curso superior
            }

            diferenca_media_salario = P_cursoSuperior_salario - P_25anos_salario; //calculo da diferença das médias obtida acima
            //===========================================================================================

            if(total_p_menos25anos != 0)//média do salário de pessoas com menos de 25 anos
                P_menos25_salario = P_menos25_salario / total_p_menos25anos;

            if(total_p_curso2 != 0)//média do salário de pessoas de curso médio
                P_cursoMedio_salario = P_cursoMedio_salario / total_p_curso2;

            diferenca_media_salario2 = P_menos25_salario - P_cursoMedio_salario; //calcula da diferença das médias

            //=========================================================================================================

            if (total_p_curso2 != 0)
                idade_media_curso2 = idade_curso2 / total_p_curso2; //calculo da média da idade das pessoas de curso médio

            if (percentual_p_cursoPrimario != 0) //calcula a porcentagem de pessoas com grau primário 
                percentual_p_cursoPrimario = percentual_p_cursoPrimario * 100 / total;

            //=====================[SAÍDAS ABAIXO, INFORMANDO TODOS OS RESULTADOS OBTIDOS DAS OPERAÇÕES ACIMA!]====================


            Console.WriteLine("\n\nPessoas de curso superior e recebe menos de R$ 500,00 = "+P_grauSuperior_500reais.ToString("0.00"));
            Console.WriteLine("A diferença entre a média dos salários de pessoas com nível superior das pessoas com mais de 25 anos = R$"+ diferenca_media_salario.ToString("0.00"));
            Console.WriteLine("A diferença entre a média dos salários com menos de 25 anos de pessoas com ensino médio = R$"+diferenca_media_salario2.ToString("0.00"));
            Console.WriteLine("Idade média das pessoas que possuem 2º grau = "+ idade_media_curso2.ToString("0.00") + " anos");
            Console.WriteLine("O percentual de pessoas que possuem o curso Primário = " + percentual_p_cursoPrimario.ToString("0.00") + "%");
            Console.WriteLine("O percentual de pessoas que possuem curso superior "+percentual_p_cursoSuperior.ToString("0.00")+"%");
            Console.WriteLine("A idade média das pessoas com nível superior = "+idade_curso3.ToString("0.00")+" anos");
            Console.WriteLine("O maior salário foi: R$"+maior_salario.ToString("0.00"));
            Console.WriteLine("O menor salário foi: R$"+menor_salario.ToString("0.00"));

        }
    }
}