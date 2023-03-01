/*
 Disciplina - POO -I (2o Anos Informática)
(Lista referente a Primeira Parte do Curso)

exercício 01
 */

using System;

namespace Enzo_Dante_Atividade03_ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas = 0;
            Console.WriteLine("Digite a hora (somente números inteiro)");
            horas = int.Parse(Console.ReadLine());
            int min = horas * 60;
            Console.WriteLine("O valor em minutos das horas digitadas é " + min + " minutos");
        }
    }
}
