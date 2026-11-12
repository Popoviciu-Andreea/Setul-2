using System;
//11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.
namespace Problema_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] s = Console.ReadLine().Split(' ');
            for(int i=0;i<n;i++)
                a[i]=int.Parse(s[i]);
            long sum = 0;
            int ogl;
            for(int i=0;i<n;i++)
            {
                ogl = 0;
                if (a[i] <=9)
                    sum = sum + a[i];
                else
                {
                    while (a[i] > 0)
                    {
                        ogl = ogl * 10 + a[i] % 10;
                        a[i] = a[i] / 10;
                    }
                    sum = sum + ogl;
                }

            }
            Console.WriteLine($"Suma inverselor este :{sum}");
        }
    }
}
