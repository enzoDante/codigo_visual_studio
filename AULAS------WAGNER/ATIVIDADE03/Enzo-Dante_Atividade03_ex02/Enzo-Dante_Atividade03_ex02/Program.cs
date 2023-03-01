/*
 Disciplina - POO -I (2o Anos Informática)
(Lista referente a Primeira Parte do Curso)
exercício 02
 */

using System;

namespace Enzo_Dante_Atividade03_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int maior = 0;
            Console.WriteLine("Quantos números deseja digitar? (deve ser maior que 0!!!)");
            int total = int.Parse(Console.ReadLine());
            while(total <= 0)
            {
                Console.WriteLine("Digite um número maior que 0!!!!");
                total = int.Parse(Console.ReadLine());
            }
            for(int i = 1; i <= total; i++)
            {
                Console.WriteLine("Digite " + i + "º número:");
                num = int.Parse(Console.ReadLine());
                if(num > maior)
                {
                    maior = num;
                }
            }
            Console.WriteLine("O maior número digitado foi: " + maior);
        }
    }
}
