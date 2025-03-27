using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos_Especificos_DIO
{
    internal class LERARQUIVO
    {

        public void lerArquivo()
        {
            try
            {
                String[] linhas = File.ReadAllLines("caminho/arquivo");
                foreach (string line in linhas)
                {
                    Console.WriteLine(line);
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("wow");
            }
        }
    }
}
