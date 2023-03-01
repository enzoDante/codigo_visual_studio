using System;

namespace parametros_mais
{
    class Program
    {
        public void novo(params int[] val)
        {
            for(int x = 0; x<val.Length; x++)
            {
                Console.WriteLine(val[x]);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.novo(2,4,6,8,10,12,14);

            string[] teste = { "olá", "bora", "teste", "mais", "um" };
            Console.WriteLine(teste.Length);
            foreach(object ob in teste)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
