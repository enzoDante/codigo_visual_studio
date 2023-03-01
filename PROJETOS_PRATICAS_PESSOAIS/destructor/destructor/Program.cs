using System;

namespace destructor
{
    public class empregado
    {
        public empregado()
        {
            Console.WriteLine("Constructor");
        }
        ~empregado()
        {
            Console.WriteLine("Destructor");
            //destructor n pode ser publica!!!
            //e n pode ser modificado
        }
    }
    class testempregado
    {
        public static void Main(string[] args)
        {
            empregado e1 = new empregado();
            empregado e2 = new empregado();
        }
    }
}
