using System;
//1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare.
namespace Problema_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nr = 0, x = 0;
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                    x = x * 10 + Convert.ToInt32(s[i].ToString());
                else
                {
                    if (x % 2 == 0)
                        nr++;

                    x = 0;
                }
            }

            if (x % 2 == 0)
                nr++;

            Console.WriteLine(nr);
        }
    }
}
