using System;

namespace testando_vetores_e_matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t===================================");
            Console.WriteLine("\t====TESTANDO VETORES E MATRIZES====");
            Console.WriteLine("\t===================================\n");
            Console.WriteLine("Agora você irá digitar uma série de números:");


            //Console.WriteLine("Quantas vezes deseja digitar? ");
            //int qtd = Convert.ToInt32(Console.ReadLine());-----------n deu certo :(
            //int[] num = new int[qtd];--------------------------------/
            
            //VETOR
            int[] num = new int[5];
            
            for(int x = 0; x <= 4; x++)
            {
                Console.WriteLine(String.Format("Digite o {0}º número:",x));
                num[x] = int.Parse(Console.ReadLine()); // ou Convert.ToInt16();
            }
            for(int x = 0; x <= 4; x++)
            {
                Console.WriteLine($"teste valor = [{num[x]}]");
            }
            Console.WriteLine("\n\n");

            //MATRIZ
            int[,] num2 = new int[2, 2];
            for(int x = 0; x <= 1; x++)
            {
                for(int y = 0; y <= 1; y++)
                {
                    Console.WriteLine($"Digite o: linha:{x} coluna:{y}");
                    num2[x,y] = int.Parse(Console.ReadLine());
                }
            }
            for(int x = 0; x<=1; x++)
            {
                for(int y = 0; y <= 1; y++)
                {
                    Console.WriteLine($"valor [{num2[x, y]}]");
                }
            }
        }
    }
}
