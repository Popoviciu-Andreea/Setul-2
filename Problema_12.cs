using System;
/*12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. 
Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. 
pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.
*/
namespace Problema_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int nr = 0;

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
                v[i] = int.Parse(s[i]);

            for (int i = 0; i < n; i++)
            {
                if (v[i] != 0 && (i == 0 || v[i - 1] == 0))
                    nr++;
            }

            Console.WriteLine(nr);
        }
    }
}
