using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos_Especificos_DIO
{
    class teste
    {
        public String nome { get; set; }
        public int idade { get; set; }
    }
    internal class UsandoPacoteNewtonSoftJson
    {
        public teste t1;
        public teste t2;
        public UsandoPacoteNewtonSoftJson() 
        {
            t1 = new teste();
            t1.nome = "carlos";
            t1.idade = 51;
        }
        public void serializar()
        {
            //converte um objeto para um arquivo, nesse caso em json
            String serializado = JsonConvert.SerializeObject(t1);
            Console.WriteLine(serializado); //{"nome":"carlos","idade":51}
            File.WriteAllText("Arquivos/testars.json", serializado); //cria o arquivo json com a string serializada

        }
        public void listasTestes()
        {
            List<teste> lista = new List<teste>();
            t1 = new teste();
            t1.nome = "carlos";
            t1.idade = 51;
            lista.Add(t1);
            t2 = new teste();
            t2.nome = "outro nome";
            t2.idade = 21;
            lista.Add(t2);

            String serie = JsonConvert.SerializeObject(lista, Formatting.Indented);
            Console.WriteLine(serie);
            
        }
    }
    
}
