using System;

namespace Assignment1.Day02
{
    class SumOfPrime
    {
        public int SumOfPrimes(int from, int to)
        {
            int sum = 0;
            for(int i = from; i < to; i++)
            {
                if (isPrimeNumber(i))
                    sum += i;
            }
            return sum;
            
        }
        static Boolean isPrimeNumber(int num)
        {
            if (num == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                        return false;

                }
            }
            
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the starting range");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the starting range");
            int end = int.Parse(Console.ReadLine());
            SumOfPrime s = new SumOfPrime();
            int total = s.SumOfPrimes(start, end);
            Console.WriteLine($"The sum of Prime numbers between {start} and {end} is {total}");

        }
    }
}
