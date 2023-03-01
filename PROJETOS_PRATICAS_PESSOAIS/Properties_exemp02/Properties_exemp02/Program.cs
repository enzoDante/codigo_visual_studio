using System;

namespace Properties_exemp02
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
                nome = value + " Outro valor";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            empregado e1 = new empregado();
            e1.Nome = "Carlos";
            Console.WriteLine($"empregado = {e1.Nome}");
        }
    }
}
