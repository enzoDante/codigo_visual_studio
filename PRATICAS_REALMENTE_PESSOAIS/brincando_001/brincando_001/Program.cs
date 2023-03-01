using System;

namespace brincando_001
{
    public class teste
    {
        public int x;
        public int a;
        public int resp;
        public teste(int x)
        {
            this.x = x + 10;
            Console.WriteLine(this.x);
        }
        public void display()
        {
            Console.WriteLine("\nDigite outro número:");
            a = Convert.ToInt32(Console.ReadLine());
            resp = a;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int y = Convert.ToInt32(Console.ReadLine());
            teste t1 = new teste(y);
            teste t2 = new teste(y);
            t1.display();
            t2.display();
            Console.WriteLine("\n\nOs dois valores estão aqui!!!\n");
            Console.WriteLine("valor de t1 = "+t1.resp+" valor de t2 = "+t2.resp);
        }
    }
}
