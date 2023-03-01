/*
 Disciplina - POO -I (2o Anos Informática)
(Lista referente a Primeira Parte do Curso)
exercício 05
 */
using System;

namespace Enzo_Dante_Atividade03_ex05
{
    class Program
    {
        static void Main(string[] args)
        {            
            int a = 0, b = 1, c = 0;
            
            Console.WriteLine("Digite um valor para calcular seu fibonacci:");
            int num = int.Parse(Console.ReadLine());
            //Console.Write(a+" "+ b);

            for (int i = 1; i < num; i++)
            {
                c = a + b;
                //Console.Write(" "+c);
                a = b;
                b = c;
            }
            Console.WriteLine("fibonacci de "+num+" = " + c);
        }
    }
}
