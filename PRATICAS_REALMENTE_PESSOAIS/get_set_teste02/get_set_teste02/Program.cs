using System;

namespace get_set_teste02
{
    public class teste
    {
        private double pesog;
        public double pesok
        {
            get
            {
                return pesog / 1000;
            }
            set
            {
                pesog = value * 1000;
            }
        }
        public void adsa()
        {
            Console.WriteLine(pesog);
            Console.WriteLine(pesok);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            teste a1 = new teste();
            Console.WriteLine("Digite");
            a1.pesok = 100f;
            Console.WriteLine(a1.pesok);
            a1.adsa();
        }
    }
}
