using System;

namespace static_estatico
{
    public class conta
    {
        public int x;
        public string nome;
        public static float interese = 8.8f;
        public conta(int x, string nome)
        {
            this.x = x;
            this.nome = nome;
        }
        public void display()
        {
            Console.WriteLine($"{x} {nome} {interese}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            conta a1 = new conta(101,"Sonoo");
            conta a2 = new conta(102,"aadasdsa");
            a1.display();
            a2.display();
        }
    }
}
