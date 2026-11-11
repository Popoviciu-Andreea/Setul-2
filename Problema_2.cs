using System;
//2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
namespace Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {   int n = int.Parse(Console.ReadLine());
            string[] v = Console.ReadLine().Split(' ');
            int nrp = 0, nrz = 0, nrn = 0;
            for(int i=0;i<n;i++)
            {
                int x = int.Parse(v[i]);
                if (x > 0)
                    nrp++;
                else
                    if (x < 0)
                    nrn++;
                    else
                    nrz++;
            }
            Console.WriteLine($"Avem {nrp} numere pozitive,{nrn} numere negative si {nrz} numere zero.");

        }
    }
    }

