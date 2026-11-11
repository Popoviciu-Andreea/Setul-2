using System;
//3. Calculati suma si produsul numerelor de la 1 la n.
namespace Problema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            long produs = 1;
            for(int i=1;i<=n;i++)
            { suma += i;
                produs *= i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la n este:{suma},iar produsul numerelor de la 1 la n este :{produs}");
        }
    }
}
