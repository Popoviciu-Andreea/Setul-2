using System;
//6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.
namespace Problema_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[]a = new int[n];
            int i;
            string[] s = Console.ReadLine().Split(' ');

            for ( i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            for ( i=0;i<n-1;i++)
            { if (a[i]>a[i+1])
                {
                    Console.WriteLine("Nu sunt in ordine crescatoare");
                    return;
                }
            }
            Console.WriteLine("Sunt in ordine crescatoare");
        }
    }
}
