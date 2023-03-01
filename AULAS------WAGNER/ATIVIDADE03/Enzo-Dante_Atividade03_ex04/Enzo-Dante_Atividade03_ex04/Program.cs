/*
 Disciplina - POO -I (2o Anos Informática)
(Lista referente a Primeira Parte do Curso)
exercício 04
 */
using System;

namespace Enzo_Dante_Atividade03_ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 0;
            float T = 0;
            Console.WriteLine("Converter Celsius para Fahrenheit ou Fahrenheit para Celsius:(0- °C > °F / 1-°F > °C");
            r = int.Parse(Console.ReadLine());
            while (r < 0 || r > 1)
            {
                Console.WriteLine("Digite 0-°C > °F ou 1-°F > °C");
                r = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite uma temperatura:");
            T = float.Parse(Console.ReadLine());

            if (r == 0)
            {
                
                float Tf = (9 * T / 5) + 32;
                Console.WriteLine(Tf);
            }
            else
            {
                float Tc = (T - 32);
                Tc = Tc * 5 / 9;
                Console.WriteLine(Tc);
            }
        }
    }
}
