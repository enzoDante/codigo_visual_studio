using System;

namespace novo_teste_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 42;
            int b = 119;
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadKey(); //espera uma tecla ser pressionada
            Console.WriteLine();

            Console.WriteLine("teste, quero ver o barra c#\r"); // n sei oq o \r faz :(

            int n = 0, n1 = 0;
            Console.WriteLine(value: $"número {n} e {n1}\n"); //n precisa do value:
            Console.WriteLine($"Digite um número no lugar de {n}");
            n = Convert.ToInt32(Console.ReadLine()); //digite número é desta forma
            Console.WriteLine($"valor digitado = {n}");

            Console.WriteLine("Digite outro número:");
            n1 = Convert.ToInt32(Console.ReadLine());
            var n2 = n1 + n;
            //Console.WriteLine($"A soma de {n} + {n1} = {n + n1} ou {n2}");
            int teste = 0;
            while(teste == 0)
            {
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        Console.WriteLine($"soma {n} + {n1} = " + (n + n1));
                        break;
                    case "s":
                        Console.WriteLine($"subtração {n} - {n1} = " + (n - n1));
                        break;
                    case "m":
                        Console.WriteLine($"multiplicação {n} * {n1} = " + (n * n1));
                        break;
                    case "d":
                        double r = 0;
                        r = n / n1;
                        Console.WriteLine($"divisão {n} / {n1} = " + (n / n1));
                        Console.WriteLine($"{n}/ {n1} = {r}");
                        break;

                }
                Console.WriteLine("Escolher outro? 0-sim/1-não\n");
                teste = Convert.ToInt32(Console.ReadLine());
                while((teste < 0) || (teste > 1))
                {
                    Console.WriteLine("Digite 0-sim/1-não\n");
                    teste = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Digite um número real, isso é um teste\n");
            double nr = Convert.ToDouble(Console.ReadLine()); //double é mais preciso q float, só relaxa ;)
            Console.WriteLine("Digite outro número p somar\n");
            double nr2 = Convert.ToDouble(Console.ReadLine());//use "," e n "."
            Console.WriteLine($"{nr} * {nr2} = " + (nr * nr2)); 

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();

        }
    }
}
