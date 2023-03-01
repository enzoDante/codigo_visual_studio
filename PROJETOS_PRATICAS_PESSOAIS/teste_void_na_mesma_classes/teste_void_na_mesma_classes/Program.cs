using System;

namespace teste_void_na_mesma_classes
{
    class Program
    {
        public static int v;
        public static int[] num = new int[100];
        static void Main(string[] args)
        {
            Console.WriteLine("\t=====================");
            Console.WriteLine("\t====teste de void====");
            Console.WriteLine("\t=====================\n");

            Console.WriteLine("Quantas vezes deseja repetir o programa?\n");
            v = Convert.ToInt32(Console.ReadLine());
            while(v < 1)
            {
                Console.WriteLine("Digite um número acima de 0:");
                v = Convert.ToInt32(Console.ReadLine());
            }
            num = new int[v];
            for(int x = 0; x < v; x++)
            {
                Console.Write($"Digite o {x + 1}º número: ");
                num[x] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nVocê digitou todas as vezes, escolha uma das opções:");
            Console.WriteLine("\n1-ordenar vetor\n2-jogar para outro vetor\n3-somar para uma variavel\n");
            int escolha = Convert.ToInt32(Console.ReadLine());
            while((escolha < 1) || (escolha > 3))
            {
                Console.WriteLine("Escolha uma das opções!!!!");
                escolha = Convert.ToInt32(Console.ReadLine());
            }
            if(escolha == 1)
            {
                ordem();
            }
            else
            {
                if(escolha == 2)
                {
                    vetornovo();
                }
                else
                {
                    somando();
                }
            }
        }
        public static void ordem()
        {
            int aux2 = v;
            for(int y = v; y > 1; y--)
            {
                for (int x = 0; x < y - 1; x++)
                {
                    if (num[x] > num[x + 1])
                    {
                        int aux = num[x];
                        num[x] = num[x + 1];
                        num[x + 1] = aux;
                    }
                }
            }
            for(int x = 0; x <= v; x++)
            {
                Console.WriteLine($"[{num[x]}]");
            }
        }
        public static void vetornovo()
        {
            int[] nnum = new int[v];
            Console.WriteLine("vetor=====novo vetor\n");
            for(int x = 0; x < v; x++)
            {
                //jogar num[x] p outro vetor
                nnum[x] = num[x];
                Console.Write($"[{num[x]}] novo vetor=");
                Console.WriteLine($"[{nnum[x]}]");

            }
        }
        public static void somando()
        {
            //somar o num[x] em uma variavel
            int soma = 0;
            for(int x = 0; x < v; x++)
            {
                soma += num[x];
            }
            Console.WriteLine($"Soma = [{soma}]");
        }
    }
}
