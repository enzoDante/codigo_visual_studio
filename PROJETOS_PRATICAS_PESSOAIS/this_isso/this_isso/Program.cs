using System;

namespace this_isso
{
    public class outro
    {
        public int id;
        public string nome;
        public float salario;
        public outro(int id, string nome, float salario)
        {
            this.id = id;
            this.nome = nome;
            this.salario = salario;
        }
        public void olha()
        {
            Console.WriteLine($"{id} {nome} {salario}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            outro e1 = new outro(101,"Sonoo",890000f);
            outro e2 = new outro(102,"Mahesh",490000f);
            e1.olha();
            e2.olha();
        }
    }
}
