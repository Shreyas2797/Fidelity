using System;

namespace Assignment1
{
    class Program4
    {
         const int max_y = 9999;
         const int min_y = 1000;
        
        static Boolean isValidDate(int year,int month, int day)
        {
            if (year > max_y || year < min_y)
                return false;
            if (month > 12 || month < 1)
                return false;
            if (day > 31 || day < 1)
                return false;

            if (month == 2)
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                    return (day <= 29);
                else
                    return (day <= 28);
            }

            if(month == 4 || month == 6 || month == 9 || month == 11)
            {
                return (day <= 30);
            }
            return true;

        }
        static void Main(string[] args)
        {
            if (isValidDate(2018,13,1))
                Console.WriteLine("Valid Date");
            else
                Console.WriteLine("Invalid Date");
            if (isValidDate(2018,2,29))
                Console.WriteLine("Valid Date");
            else
                Console.WriteLine("Invalid Date");
            if (isValidDate(2016,2,29))
                Console.WriteLine("Valid Date");
            else
                Console.WriteLine("Invalid Date");

        }
    }
}
