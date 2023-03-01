using System;

namespace procedimento_pass_parametro_com_return
{
    class Program
    {
        public int teste(int valor)
        {
            valor = valor + 5;
            return valor;
        }
        public string mostrar(string mensagem)
        {
            return mensagem;
        }
        static void Main(string[] args)
        {
            Program este = new Program();
            int y = 10;
            string mensagem = este.mostrar("estudos");
            int x = este.teste(y);
            Console.WriteLine($"Olá {mensagem}");
            Console.WriteLine($"valor = {x}");
        }
    }
}
