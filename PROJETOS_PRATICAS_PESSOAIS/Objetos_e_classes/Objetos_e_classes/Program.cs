using System;

namespace Objetos_e_classes
{
    public class teste //n preciso dizer q teste é uma classe
    {
        public int id;
        public String name;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            teste a = new teste(); // a é um objeto
            a.id = 101;
            a.name = "nome falou?";
            Console.WriteLine(a.id);
            Console.WriteLine(a.name);
        }
    }
}
