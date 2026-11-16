using System;
/*14. O <secventa monotona rotita> este o secventa de numere monotona sau poate fi 
transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de 
n numere este o secventa monotona rotita. */

namespace Problema_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int nr = 0,nr1=0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < n - 1; i++)
            {
                if (v[i] > v[i + 1])
                    nr++;
                else
                    if (v[i] < v[i + 1])
                    nr1++;

            }
            if (v[n - 1] > v[0])
                nr++;
            if (v[n - 1] < v[0])
                nr1++;
            if (nr <= 1||nr1<=1)
                Console.WriteLine($"Secventa este  monotona rotita");
            else
                Console.WriteLine($"Secventa nu este monotona rotita");



        }
    }
}
