using System;
using System.Numerics;
namespace Hello
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            BigInteger a, b;
            a = 0;
            b = 1;
            Console.Write("Enter sequence length: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                BigInteger fib = a;
                a = b;
                b = fib + a;
                Console.WriteLine("Fibonacci sequence : "+fib);
            }
            Console.WriteLine("End of sequence");
            Console.Read();
        }
    }
}
