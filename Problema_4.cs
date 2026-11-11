using System;
/*4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. 
Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla 
in secventa raspunsul va fi -1.
*/
namespace Problema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a=int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == a)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
                Console.WriteLine(-1);
            
        }
    }
}
