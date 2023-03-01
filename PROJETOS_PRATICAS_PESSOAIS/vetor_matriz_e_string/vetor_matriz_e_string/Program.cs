using System;

namespace vetor_matriz_e_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            string[] nome = new string[10];
            
            for(int x = 0; x <= 9; x++)
            {
                Console.WriteLine($"Digite o {x}º número e nome:");
                num[x] = Convert.ToInt16(Console.ReadLine());
                //ou num[x] = Int.Parse(Console.ReadLine());
                nome[x] = Console.ReadLine();
            }
            for (int x = 0; x <= 9; x++)
            {
                Console.WriteLine($"número: {num[x]}\nNome: {nome[x]}");
            }
            int[,] num2 = new int[10, 10];
            for(int x = 0; x <= 9; x++)
            {
                for(int y = 0; y <= 9; y++)
                {
                    Console.WriteLine($"Digite o {x}:{y} número:");
                    num2[x, y] = int.Parse(Console.ReadLine());
                }
            }
            for (int x = 0; x <= 9; x++)
            {
                for (int y = 0; y <= 9; y++)
                {
                    Console.WriteLine($"número: [{num2[x,y]}]");
                }
            }


        }
    }
}
