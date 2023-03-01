using System;

namespace Constructor_Parameterized
{
    public class empregado
    {
        public int id;
        public String name;
        public float salario;
        public empregado(int i, String n, float s)
        {
            id = i;
            name = n;
            salario = s;
        }
        public void teste()
        {
            Console.WriteLine($"{id} {name} {salario}");
        }
    }
    class testempregado
    {
        static void Main(string[] args)
        {
            empregado e1 = new empregado(201,"Nobita",890000f);
            empregado e2 = new empregado(202,"Jerry",490000f);
            e1.teste();
            e2.teste();
        }
    }
}
