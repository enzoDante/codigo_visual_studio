using System;

namespace Goto_comando
{
    class Program
    {
        static void Main(string[] args)
        {
            voltaqui:
            Console.WriteLine("Vc n pode votar");

            Console.WriteLine("Digite sua idade:");
            int id = Convert.ToInt32(Console.ReadLine());
            if(id < 18)
            {
                goto voltaqui;
            }
            else
            {
                Console.WriteLine("Vc pode votar");
            }

        }
    }
}
