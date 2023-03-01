using System;

namespace get_set_teste01
{
    public class teste
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int x;
        public int X
        {
            get { return x; }
            set { x = value + 50; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            teste t1 = new teste();
            t1.Nome = "Mestre Dante";
            Console.WriteLine("Olá Sr. " + t1.Nome);
            Console.Write("Digite um número: ");
            t1.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(t1.X);

        }
    }
}
