using System;
/*8. Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: 
f1 = 0, f2 = 1, f_n = f_(n - 1) + f(n - 2).Exemplu: 0, 1, 1, 2, 3, 5, 8... 
*/
namespace Problema_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           long x= Fibo(n);
            Console.WriteLine($"Al {n}-lea termen din sirul lui Fibonacci este {x}");
        }

         static int Fibo(int n)
        {
            int a = 0, b =1;
            if (n == 3)
                return a + b;
            else
            if (n == 2)
                return b;
            else if (n == 1)
                return a;
            else
            
               return Fibo(n - 1) + Fibo(n - 2);
            

        }
    }
}
