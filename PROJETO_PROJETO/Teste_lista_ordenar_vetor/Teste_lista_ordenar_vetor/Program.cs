using System;
using System.Collections.Generic;

namespace Teste_lista_ordenar_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num;
            var lugarvetor = new List<int> { };
            Console.WriteLine("TESTE DE LISTA NO LUGAR DE VETOR");
            for(int x = 0; x < 10; x++)
            {
                Console.Write($"Digite o {x}° número: ");
                num = Convert.ToInt32(Console.ReadLine());
                lugarvetor.Add(num);
            }
            foreach(int x in lugarvetor)
            {
                Console.WriteLine($"[{x}]");
            }*/
            int[] processos = new int[10];
            int menor = 0;
            int escolha = 0;
            while (true)
            {
                Console.WriteLine("Escolha uma das opções\n1-Inserir processo\n2-processar processo\n3-Ordenar processo\n");
                escolha = Convert.ToInt32(Console.ReadLine());
                while(escolha < 1 || escolha > 3)
                {
                    Console.WriteLine("Escolha uma das opções!!!");
                    escolha = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();
                if(escolha == 1)
                {
                    for(int x = 0; x <= 9; x++)
                    {
                        Console.WriteLine($"Digite o {x}º número:");
                        processos[x] = int.Parse(Console.ReadLine());
                    }
                    Console.Clear();
                    for(int x = 0; x<= 9; x++)
                    {
                        Console.WriteLine($"[{processos[x]}]");
                    }
                }
                else if(escolha == 2)
                {
                    for(int x = 0; x<= 9; x++)
                    {
                        if(x == 0)
                        {
                            menor = processos[x];
                        }
                        else if(menor > processos[x])
                        {
                            menor = processos[x];
                        }
                    }
                    for(int x = 0; x <= 9; x++)
                    {
                        if(menor == processos[x])
                        {
                            processos[x] = 0;
                        }
                    }
                    
                }
            }
        }
    }
}
