using System;

namespace mais_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //pode atribuir de várias formas p matrizes
            int[,] ma = new int[3, 3] { { 1,2,3}, { 4,5,6}, { 7,8,9} };
            int[,] ma2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] ma3 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //pode atribuir de várias formas p vetores
            int[] arr = new int[5] { 10, 20, 30, 40, 50};
            int[] arr2 = new int[] { 10, 20, 30, 40};
            int[] arr3 = { 10, 20, 30, 40, 50, 60};

            int[] a = new int[5];
            a[0] = 10; a[2] = 20; a[4] = 30;
            for(int x = 0; x< a.Length; x++)
            {
                Console.WriteLine(a[x]);
            }
        }
    }
}
