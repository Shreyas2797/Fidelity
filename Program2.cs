using System;

namespace Assignment1
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine(num+" * "+i+" = "+(num*i));
                i++;
            }
        }
    }
}
