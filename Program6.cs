using System;

namespace Assignment1
{
    class Program6
    {
        public void sortThreeNumbers(int a, int b, int c)
        {
            if ((a <= b) && (a <= c))
            {
                if(b<=c)
                    Console.WriteLine(a + "\t" + b + "\t" + c);
                else
                    Console.WriteLine(a + "\t" + c + "\t" + b);
            }
            else if((b <= a) && (b <= c))
            {
                if (a <= c)
                    Console.WriteLine(b + "\t" + a + "\t" + c);
                else
                    Console.WriteLine(b + "\t" + c + "\t" + a);
            }
            else
            {
                if (a <= b)
                    Console.WriteLine(c + "\t" + a + "\t" + b);
                else
                    Console.WriteLine(c + "\t" + b + "\t" + a);
            }

        }
        static void Main(string[] args)
        {
            Program6 p = new Program6();
            p.sortThreeNumbers(3, 5, 8);
            p.sortThreeNumbers(10,2,7);
            p.sortThreeNumbers(4,10,1);

        }
    }
}
