using System;

namespace Procedimento_sem_passagem_parametro
{
    class Program
    {
        public void exemplo()
        {
            Console.WriteLine("sem passagem de parâmetro");
        }
        
        static void Main(string[] args)
        {
            Program programa = new Program();
            programa.exemplo();

        }
    }
}
