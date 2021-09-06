using System;

namespace Assignment1
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 real numbers");
            int [] a = new int[10];
            int pos_sum = 0, neg_sum = 0;
            int x = 0, y = 0;
            for(int i = 0;i < 10;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());              
            }
            for(int j=0;j<10;j++)
            {
                if(a[j]>=0)
                {
                    pos_sum += a[j];
                    x++;
                }
            }
            Console.WriteLine("average of positive number = "+ (pos_sum/x));
            for (int k = 0; k < 10; k++)
            {
                if (a[k] < 0)
                {
                    neg_sum += a[k];
                    y++;
                }
            }
            Console.WriteLine("average of positive number = " + (neg_sum / y));
        }
    }
}
