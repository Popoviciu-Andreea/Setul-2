using System;
/*15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua 
monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de 
n numere. Sa se determine daca este bitonica.  */

namespace Problema_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
           bool x = false,y=true;

            for (int i = 0; i < n - 1; i++)
            {
                if (v[i] > v[i + 1])
                     x= true;

                else if (v[i] < v[i + 1] && x == true)
                   y= false;
            }
            if (y)
                Console.WriteLine($"Secventa este  bitonica.");
            else
                Console.WriteLine($"Secventa nu este bitonica.");



        }
    }
}
