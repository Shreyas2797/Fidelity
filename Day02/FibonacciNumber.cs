using System;

namespace Assignment1.Day02
{
    class FibonacciNumber
    {
        static int fibonacci(int index)
        {
            int fibo1 = 0;
            int fibo2 = 1;
            int fibo=0;
            if (index == 1)
                return fibo1;
            else if (index == 2)
                return fibo2;
            else
            {
                for (int i = 2; i <= index; i++)
                {
                    fibo1 = fibo2;
                    fibo2 = fibo;
                    fibo =fibo1+fibo2;

                }
                return fibo;
            }          
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the index of the fibonacci number you want");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Fibonacci number at index {x} is {fibonacci(x)}");
        }
    }
}
