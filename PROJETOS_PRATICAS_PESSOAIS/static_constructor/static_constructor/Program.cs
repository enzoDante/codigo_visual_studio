using System;

namespace static_constructor
{
    public class conta
    {
        public int id;
        public string nome;
        public static float interese;
        public conta(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
        static conta()
        {
            interese = 9.5f;
        }
        public void display()
        {
            Console.WriteLine(id+" "+nome+" "+interese);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            conta a1 = new conta(101,"Sonoo");
            conta a2 = new conta(102,"outra pessoa");
            a1.display();
            a2.display();
        }
    }
}
