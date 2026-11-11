using System;
/*9. Sa se determine daca o secventa de n numere este monotona. Secventa monotona = 
secventa monoton crescatoare sau monoton descrescatoare. */
namespace Problema_9
{
    internal class Program
    {
        static void Main(string[] args)
        {int n=int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] s =Console.ReadLine().Split(' ');
            int nr = 0,nr1=0;
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(s[i]);
            for(int i=0;i<n-1;i++)
            {
                if (a[i] > a[i + 1])
                    nr++;
                else
                    if (a[i] < a[i + 1])
                    nr1++;
            }
            if (nr == n - 1||nr1==n-1)
                Console.WriteLine($"Secventa este monotona");
           else
                Console.WriteLine("Secventa nu este monotona");
            Console.ReadKey();
        }
    }
}
