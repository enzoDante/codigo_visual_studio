using System;

namespace Enzo_Dante_Atividade02
{
    class Program
    {
        static void Main(string[] args)
        {
            int mult3 = 0, mult5 = 0;
            Console.WriteLine("Quantos números deseja inserir?");
            int total = int.Parse(Console.ReadLine());
            while(total < 1)
            {
                Console.Write("Digite um número maior que 0!!!");
                total = int.Parse(Console.ReadLine());
            }
            for(int i = 1; i <= total; i++)
            {
                Console.WriteLine("Digite o " + i + "º número:");
                int num = int.Parse(Console.ReadLine());

                if (num % 3 == 0)
                    mult3++;

                if (num % 5 == 0)
                    mult5++;

            }
            Console.WriteLine(mult3 + " números múltiplos de 3 digitados");
            Console.WriteLine(mult5 + " números múltiplos de 5 digitados");
        }
    }
}
