using System;

namespace Switch_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero:");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 10:
                    //caso digite 1
                    Console.WriteLine("è 10");
                    break;
                case 2:
                    //caso digite 2
                    Console.WriteLine("é 2");
                    break;
                case 45:
                    Console.WriteLine("é 45");
                    break;
                default:
                    //caso n seja nenhum dos valores anteriores
                    Console.WriteLine("n é 10, 2 e 45");
                    break;
            }

            for(int a = 0; a <= 5; a++)
            {
                if(a == 3)
                {
                    break;
                }
                Console.WriteLine(a);
            }
            Console.WriteLine("\n\n");
            for(int z = 0; z <= 10; z++)
            {
                if(z == 2)
                {
                    continue;
                }
                Console.WriteLine(z);
            }
        }
    }
}
