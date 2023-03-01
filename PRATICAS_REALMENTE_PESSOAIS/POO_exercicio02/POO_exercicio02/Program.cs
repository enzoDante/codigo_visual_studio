using System;

namespace POO_exercicio02
{
    public class animal
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }
        private string tipo;
        public string Tipo //valores Cachorro gato peixe
        {
            get { return tipo; }
            set { 
                if(value == "CACHORRO" || value == "GATO" || value == "PEIXE")
                {
                    tipo = value;
                }
                else
                {
                    tipo = "PEIXE";
                }
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            animal a1 = new animal(); //5 objetos
            animal a2 = new animal();
            animal a3 = new animal();
            animal a4 = new animal();
            animal a5 = new animal();
            int tc = 0, tg = 0, tp = 0;

            Console.Write("Digite o nome de seu 1º bixo:  ");
            a1.Nome = Console.ReadLine();
            Console.Write("Digite que animal é (Cachorro, Gato ou Peixe):  ");
            a1.Tipo = Console.ReadLine().ToUpper();
            if (a1.Tipo == "CACHORRO") tc++;
            if (a1.Tipo == "GATO") tg++;
            if (a1.Tipo == "PEIXE") tp++;

            Console.Write("Digite o nome de seu 2º bixo:  ");
            a2.Nome = Console.ReadLine();
            Console.Write("Digite que animal é (Cachorro, Gato ou Peixe):  ");
            a2.Tipo = Console.ReadLine().ToUpper();
            if (a2.Tipo == "CACHORRO") tc++;
            if (a2.Tipo == "GATO") tg++;
            if (a2.Tipo == "PEIXE") tp++;

            Console.Write("Digite o nome de seu 3º bixo:  ");
            a3.Nome = Console.ReadLine();
            Console.Write("Digite que animal é (Cachorro, Gato ou Peixe):  ");
            a3.Tipo = Console.ReadLine().ToUpper();
            if (a3.Tipo == "CACHORRO") tc++;
            if (a3.Tipo == "GATO") tg++;
            if (a3.Tipo == "PEIXE") tp++;

            Console.Write("Digite o nome de seu 4º bixo:  ");
            a4.Nome = Console.ReadLine();
            Console.Write("Digite que animal é (Cachorro, Gato ou Peixe):  ");
            a4.Tipo = Console.ReadLine().ToUpper();
            if (a4.Tipo == "CACHORRO") tc++;
            if (a4.Tipo == "GATO") tg++;
            if (a4.Tipo == "PEIXE") tp++;

            Console.Write("Digite o nome de seu 5º bixo:  ");
            a5.Nome = Console.ReadLine();
            Console.Write("Digite que animal é (Cachorro, Gato ou Peixe):  ");
            a5.Tipo = Console.ReadLine().ToUpper();
            if (a5.Tipo == "CACHORRO") tc++;
            if (a5.Tipo == "GATO") tg++;
            if (a5.Tipo == "PEIXE") tp++;

            Console.Write($"Cachorro(s): [{tc}]\nGato(s): [{tg}]\nPeixe(s): [{tp}]\n");
            Console.ReadKey();
        }
    }
}
