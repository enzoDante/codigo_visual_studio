using System;

namespace struct_e_constructor_juntos
{
    public struct retangulo
    {
        public int width, height;
        public retangulo(int w, int h)
        {
            width = w;
            height = h;
        }
        public void area()
        {
            Console.WriteLine($"Área = {width*height}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            retangulo r = new retangulo(5, 6);
            r.area();
        }
    }
}
