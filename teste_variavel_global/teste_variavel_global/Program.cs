using System;

namespace teste_variavel_global
{
    public class globalteste
    {
        public static int x;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vc irá digitar uma sequencia de números!!");
            globalteste.x = int.Parse(Console.ReadLine());
            Console.WriteLine(globalteste.x);
        }
    }
}
