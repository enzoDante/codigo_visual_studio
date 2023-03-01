using System;

namespace static_class_classe_estatica
{
    public static class matematica
    {
        public static float PI = 3.14f;
        public static int cube(int n) { return n * n * n; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("valor de pi = "+ matematica.PI);
            Console.WriteLine("cubo de 3 = "+matematica.cube(3));

        }
    }
}
