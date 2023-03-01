using System;

namespace Structor_exemplo
{
    public struct retangulo
    {
        public int width, height;
    }
    class Program
    {
        static void Main(string[] args)
        {
            retangulo r = new retangulo();
            r.width = 4;
            r.height = 5;
            Console.WriteLine($"Área do retângulo = {r.width * r.height}");
        }
    }
}
