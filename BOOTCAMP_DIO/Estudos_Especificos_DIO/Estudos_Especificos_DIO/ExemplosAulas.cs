using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos_Especificos_DIO
{
    internal class ExemplosAulas
    {
        private String _nome;

        public String Nome 
        { 
            //get { return _nome + " wow"; }
            // ou
            get => _nome;

            set 
            { 
                if(value == "")
                {
                    //abrir uma Exception
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value; 
            }
        
        }


        public void testarFilasEPilhas()
        {
            //fila = queue
            Queue<int> filaN = new Queue<int>();
            filaN.Enqueue(1);
            filaN.Enqueue(2);
            filaN.Enqueue(3);
            filaN.Enqueue(4);
            filaN.Enqueue(5);

            foreach (int n in filaN)
            {
                Console.WriteLine(n);
            }

            filaN.Dequeue(); //remove o primeiro elemento da fila




            //pilhas são diferentes de filas
            Stack<int> pilha = new Stack<int>();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);

            //irá imprimir 3 ... 2.... 1
            foreach (int n in pilha)
            {
                Console.WriteLine(n);
            }
            pilha.Pop(); //remove o elemento do topo, no caso o 3
        }


        public void Dicionario()
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();
            //chave e elemento

            estados["teste"] = "asd";
            estados["wow"] = "asdbbb";
            //padrão assim como qualquer dicionário em qualquer linguagem

            //ou
            estados.Add("chaveAqui", "nomeElementoetc");
            foreach (var item in estados)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            estados.Remove("chaveAqui");
        }
    }
}
