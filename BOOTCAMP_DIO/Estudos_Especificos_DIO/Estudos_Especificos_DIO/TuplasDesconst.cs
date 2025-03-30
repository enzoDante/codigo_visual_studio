using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Estudos_Especificos_DIO
{
    internal class TuplasDesconst
    {

        (int, string, string) tupla = (3, "vitor", "a");
        
        public void testea()
        {
            Console.WriteLine(tupla);
            Console.WriteLine(tupla.Item1);
            Console.WriteLine(tupla.Item2);


            (int valor, string ta, string te) tuplas = (3, "vitor", "a");
            Console.WriteLine(tuplas.valor);
            Console.WriteLine(tuplas.ta);
            Console.WriteLine(tuplas.te);

            ValueTuple<int, String, String> outroExemplo = (2, "a", "b");
            var exeplo3 = Tuple.Create(1, "a", "b");

            var (sucesso, linh) = tuplasRetorno();

            var (sucessoa, _) = tuplasRetorno(); // _ é descartar valor que não for usar

        }


        public (bool sucesso, String[] linhas) tuplasRetorno()
        {
            return (true, ["linha1", "linha2..."]);
        }

        public String Nome { get; set; }

        public void Deconstruct(out String valor)
        {
            valor = Nome; // valor recebe Nome
        }

    }
}
