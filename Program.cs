using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of Celsius in degrees");
            int celsius = int.Parse(Console.ReadLine());

            int kelvin,fahrenheit;
            kelvin = celsius + 273;
            fahrenheit = celsius * 18 / 10 + 32;

            Console.WriteLine("The above amount of celsius in kelvin is " + kelvin);
            Console.WriteLine("The above amount of celsius in fahrenheit is " + fahrenheit);
        }
    }
}
