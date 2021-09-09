using System;
namespace Assignment1.Day04
{
    class PracticalSession
    {
        static void Main(string[] args)
        {
            //-------first program------

            //Console.WriteLine("My name is Shreyas");
            //Console.WriteLine("I am from Bangalore");
            //Console.WriteLine("I am a trainee working in Fidelity");


            //--------Second program(getting data from user)--

            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your address");
            //string address = Console.ReadLine();
            //Console.WriteLine("Enter your Qualification");
            //string qualification = Console.ReadLine();
            //Console.WriteLine($"The user name is {name} from {address} with a qualification of {qualification}");


            //----Third Program(DataTypes and conversion)---

            //Console.WriteLine("Enter the Principal amount");
            //int principle = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the term");
            //double term = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the rate of interest");
            //double rate = double.Parse(Console.ReadLine());

            //double interest = principle * term * rate;
            //int SimpleInterest = Convert.ToInt32(interest);
            //Console.WriteLine($"interest is {interest}");
            //Console.WriteLine($"SimpleInterest is {SimpleInterest}");


            //----Fourth Program(DateTime conversion)------
            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your DateOFBirth in mm/dd/yyyy");
            //DateTime dob =DateTime.Parse( Console.ReadLine());
            //int age = DateTime.Now.Year - dob.Year;
            //Console.WriteLine($"The name of the user is {name} and his age is {age}");


            //-----Fifth Program(Using TryParse)---------
            int age;
            RETRY:
            Console.WriteLine("Enter the Age");
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine($"U R supposed to enter a whole number ranging from {int.MinValue} and {int.MaxValue}");
                goto RETRY;
            }
            Console.WriteLine($"The age is {age}");

        }
    }
}
