using System;

namespace constructor_e_destructor
{
    public class empregado
    {
        public empregado()
        {
            Console.WriteLine("teste, vai aparecer duas vezes!");
        }
        static void Main(string[] args)
        {
            empregado e1 = new empregado();
            empregado e2 = new empregado();
        }
    }
}
