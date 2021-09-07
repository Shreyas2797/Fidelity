using System;

namespace Assignment1.Day02
{
    class DisplayStars
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int num = int.Parse(Console.ReadLine());
            int[][] array = new int[num][];
            for(int i=0;i<num;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
