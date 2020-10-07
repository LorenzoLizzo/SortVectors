using System;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vett = new int[10] { 1, -1, -5, -2, 4, -6, 7, 8, 9, -10 };
            for (int i = 0; i < vett.Length; i++)
            {
                Console.WriteLine(vett[i]);
            }
            Console.ReadKey();
        }
    }
}
