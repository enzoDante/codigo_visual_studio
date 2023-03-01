using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t=============================");
            Console.WriteLine("\t====CALCULADORA SIMULATOR====");
            Console.WriteLine("\t=============================\n\n");
            var escolha = "sim";
            while((escolha == "sim") || (escolha == "s"))
            {
                Console.WriteLine("Digite um número:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite outro número:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                //double teste = Convert.ToDouble(Console.ReadLine());



                Console.WriteLine("====Escolha uma das opções abaixo:\n");
                Console.WriteLine("a = somar\nb = subtrair\nc = multiplicar\nd = dividir\n\n");
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.WriteLine("");
                        break;
                }






                Console.WriteLine("deseja calcular novamente?\n");
                escolha = Console.ReadLine().ToLower();
            }
        }
    }
}
