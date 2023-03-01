/*
 Disciplina - POO -I (2o Anos Informática)
(Lista referente a Primeira Parte do Curso)
exercício 03
 */
using System;

namespace Enzo_Dante_Atividade03_ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("O número digitado é par");
            else
                Console.WriteLine("O número digitado é ímpar");
        }
    }
}
