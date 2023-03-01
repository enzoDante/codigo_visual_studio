using System;
using System.Collections.Generic;

namespace Tutorial_para_todos
{
    class Program
    {
        static void Main(string[] args)
        {
            var demdelista = new List<string> {"teste", "Marcos", "Maria","outros nomes"};

            foreach (var x in demdelista)
            {
                Console.WriteLine($"Nomes: {x}");
            }

            demdelista.Add("novos nomes");
            demdelista.Remove("novos nomes");

            Console.WriteLine("\nAdicione um nome");

            var nome = Console.ReadLine();
            demdelista.Add(nome);

            foreach(var x in demdelista)
            {
                Console.WriteLine($"Nomes: {x}");
            }
            Console.WriteLine("\n\n\n");
            double raio = 2.50;
            double area = Math.PI * raio * raio;
            Console.WriteLine($"{Math.PI} * {raio}^2 = {area}");

        }
    }
}
