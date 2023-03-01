using System;

namespace procedimento_com_passagem_parametro
{
    class Program
    {
        public void teste(int x, string b)
        {
            Console.Write(x + " " + b);
        }
        static void Main(string[] args)
        {
            int a = 20;
            Program exemplo = new Program();
            exemplo.teste(a, "Olá mundo");
        }
    }
}
