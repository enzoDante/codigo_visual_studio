using System;

namespace Properties_exemp03
{
    public class empregado
    {
        private static int contador;
        public empregado()
        {
            contador++;
        }
        public static int Contador
        {
            get {
                return contador;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            empregado e1 = new empregado();
            empregado e2 = new empregado();
            empregado e3 = new empregado();
            Console.WriteLine($"Nº de empregados = {empregado.Contador}");
        }
    }
}
