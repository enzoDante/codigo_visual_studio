using System;

namespace POO_teste
{
    public class prova
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int idade;
        public int Idade
        {
            get { return idade; }
            set
            {
                while((value < 4) || (value > 100))
                {
                    Console.WriteLine("É bem improvável que faça a prova!");
                    Console.WriteLine("Digite uma idade autentica:");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                if(value < 18)
                {
                    Console.WriteLine("Você não pode fazer a prova!!!");
                }
                else
                {
                    idade = value;
                }
            }
        }
        private double nota;
        public double Nota
        {
            get { return nota; }
            set
            {
                while((value < 1)||(value > 10))
                {
                    Console.WriteLine("Não existe essa nota!! Digite outra:");
                    value = Convert.ToDouble(Console.ReadLine());
                }
                if(value >= 7)
                {
                    Console.WriteLine("O estudante passou!!!");
                    nota = value;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int passaram = 0, reprovaram = 0, n = 0;
            Console.WriteLine("\t===========================");
            Console.WriteLine("\t====Faça o vestibulinho====");
            Console.WriteLine("\t===========================\n");

            prova a1 = new prova();
            prova a2 = new prova();
            prova a3 = new prova();

            Console.WriteLine("Digite o nome do 1º estudante:");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do 1º estudante:");
            a1.Idade = Convert.ToInt32(Console.ReadLine());
            if (a1.Idade >= 18)
            {
                Console.WriteLine("Digite a nota do 1º estudante:");
                a1.Nota = Convert.ToDouble(Console.ReadLine());
                if (a1.Nota >= 7) passaram++;
                else reprovaram++;
            }
            else n++;

            Console.WriteLine("Digite o nome do 2º estudante:");
            a2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do 2º estudante:");
            a2.Idade = Convert.ToInt32(Console.ReadLine());
            if (a2.Idade >= 18)
            {
                Console.WriteLine("Digite a nota do 2º estudante:");
                a2.Nota = Convert.ToDouble(Console.ReadLine());
                if (a2.Nota >= 7) passaram++;
                else reprovaram++;
            }
            else n++;

            Console.WriteLine("Digite o nome do 3º estudante:");
            a3.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do 3º estudante:");
            a3.Idade = Convert.ToInt32(Console.ReadLine());
            if (a3.Idade >= 18)
            {
                Console.WriteLine("Digite a nota do 3º estudante:");
                a3.Nota = Convert.ToDouble(Console.ReadLine());
                if (a3.Nota >= 7) passaram++;
                else reprovaram++;
            }
            else n++;

            if((a1.Nota > a2.Nota) && (a1.Nota > a3.Nota))
            {
                Console.WriteLine($"{a1.Nome} teve a maior nota!!");
                Console.WriteLine($"Nota: {a1.Nota}\n");
            }
            else
            {
                if((a2.Nota > a1.Nota) && (a2.Nota > a2.Nota))
                {
                    Console.WriteLine($"{a2.Nome} teve a maior nota!!");
                    Console.WriteLine($"Nota: {a2.Nota}\n");
                }
                else
                {
                    if((a3.Nota > a1.Nota) && (a3.Nota > a2.Nota))
                    {
                        Console.WriteLine($"{a3.Nome} teve a maior nota!!");
                        Console.WriteLine($"Nota: {a3.Nota}\n");
                    }
                    else
                    {
                        Console.WriteLine("Os concorrentes tiveram notas iguais!!!");
                        if((a1.Nota == a2.Nota) && (a1.Nota == a3.Nota))
                        {
                            Console.WriteLine($"Nome: {a1.Nome} Nota: {a1.Nota}");
                            Console.WriteLine($"Nome: {a2.Nome} Nota: {a2.Nota}");
                            Console.WriteLine($"Nome: {a3.Nome} Nota: {a3.Nota}");
                        }
                        else
                        {
                            if(a1.Nota == a2.Nota)
                            {
                                Console.WriteLine($"Nome: {a1.Nome} Nota: {a1.Nota}");
                                Console.WriteLine($"Nome: {a2.Nome} Nota: {a2.Nota}");
                            }
                            if(a1.Nota == a3.Nota)
                            {
                                Console.WriteLine($"Nome: {a1.Nome} Nota: {a1.Nota}");
                                Console.WriteLine($"Nome: {a3.Nome} Nota: {a3.Nota}");
                            }
                            if(a2.Nota == a3.Nota)
                            {
                                Console.WriteLine($"Nome: {a2.Nome} Nota: {a2.Nota}");
                                Console.WriteLine($"Nome: {a3.Nome} Nota: {a3.Nota}");
                            }
                        }
                        
                    }
                }
            }

            Console.WriteLine($"\npassaram {passaram} \nreprovados {reprovaram} ");
            Console.WriteLine($"Não pode fazer a prova: {n}");
        }
    }
}
