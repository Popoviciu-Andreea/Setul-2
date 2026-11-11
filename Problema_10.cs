using System;
//10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.
namespace Problema_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(s[i]);
            int nr = 1, max = 1;
            for (int i = 0; i < n - 1; i++)
            {
                if (v[i] == v[i + 1])
                    nr++;
                else
                {
                    if (nr > max)
                        max = nr;
                    nr = 1;

                }
            }
            if (nr > max)
                max = nr;
            Console.WriteLine(max);
        }
    }
}
