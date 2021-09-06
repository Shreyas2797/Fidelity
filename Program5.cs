using System;

namespace Assignment1
{
    class Program5
    {
        static Boolean isPrimeNumber(int num)
        {
            for(int i=2;i<=num/2;i++)
            {
                if (num % i == 0)
                    return false;
                   
            }
            return true;
        }
        static void Main(string[] args)
        {
            if(isPrimeNumber(9))
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not a Prime");
            if(isPrimeNumber(7))
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not a Prime");
            if(isPrimeNumber(56))
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not a Prime");

        }
    }
}
