using System;

namespace Properties_exemp
{
    public class empregado
    {
        private string nome;
        public string Nome
        {
            get {
                return nome;
            }
            set {
                nome = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            empregado e1 = new empregado();
            e1.Nome = "Carlos";
            Console.WriteLine($"nome do empregado {e1.Nome}");
        }
    }
}
