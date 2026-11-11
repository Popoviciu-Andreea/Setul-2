using System;
//7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.
namespace Problema_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] s=Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(s[i]);
            int min = v[0], max = v[0];
            for (int i=1;i<n;i++)
            {
                if (v[i] < min)
                    min = v[i];
                else
                    if (max < v[i])
                    max = v[i];
                
            }
            Console.WriteLine($"Cea mai mare valoare din secventa este:{max},iar cea mai mica valoare este {min}");
        }
    }
}
