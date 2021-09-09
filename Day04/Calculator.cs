using System;
using Assignment1.Day02;

namespace Assignment1.Day04
{
    class Calculator
    {

        // 1. Calculator program using simple switch case in a main function only
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the first number");
        //    int number1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter the second number");
        //    int number2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Calculator");
        //    Console.WriteLine(" 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division");
        //    switch (int.Parse(Console.ReadLine()))
        //    {
        //        case 1:
        //            Console.WriteLine(number1 + number2);
        //            break;

        //        case 2: Console.WriteLine(number1 - number2);
        //            break;
        //        case 3:
        //            Console.WriteLine(number1 * number2);
        //            break;

        //        case 4:
        //            if(number2 != 0)
        //                Console.WriteLine(number1 / number2);
        //            else
        //                Console.WriteLine("Can't Divide by 0");
        //            break;
        //        default:
        //            break;
        //    }
        //}

        static void Main(string[] args)
        {
            int number1 = MyConsole.GetNumber("Enter the first number");            
            int number2 = MyConsole.GetNumber("Enter the second number");
            Console.WriteLine("Calculator");
            Console.WriteLine(" 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Addition(number1,number2);                   
                    break;
                case 2:
                    Subtraction(number1, number2);
                    break;
                case 3:
                    Multiplication(number1, number2);
                    break;
                case 4:
                    Division(number1, number2);
                    break;
                default:
                    break;
            }
        }

        private static void Division(int num1, int num2)
        {
            if (num2 != 0)
                Console.WriteLine(num1 / num2);
            else
                Console.WriteLine("Can't Divide by 0");
        }

        private static void Multiplication(int num1, int num2)
        {
            Console.WriteLine(num1 * num2 ); 
        }

        private static void Subtraction(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        private static void Addition( int num1, int num2)
        {
            Console.WriteLine(num1 + num2); 
        }
    }
}
