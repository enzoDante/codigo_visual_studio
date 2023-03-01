using System;

namespace Mais_procedimentos
{
    class Program
    {
        public void novo(int val)
        {
            val *= val;
            Console.WriteLine("variável " + val); //2500
        }
        public void referencia(ref int a)
        {
            a *= a;
            Console.WriteLine($"{a}"); //2500
        }

        public void sai(out int x)
        {
            int quadrado = 5;
            x = quadrado;
            x *= x;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            int x = 50;
            Console.WriteLine($"{x}"); //50
            program.sai(out x);
            Console.WriteLine($"{x}"); //25

            int a = 50;
            Console.WriteLine($"{a}"); //50
            program.referencia(ref a);
            Console.WriteLine($"{a}"); //2500


            int val = 50;
            Console.WriteLine("variável "+val);//50
            program.novo(val);
            Console.WriteLine("variável " + val);//50

        }
    }
}
