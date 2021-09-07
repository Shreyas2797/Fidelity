using System;

namespace Assignment1.Day02
{
    class TeamMembers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of your Team");
            int size =  int.Parse(Console.ReadLine());
            string[] team = new string[size];
            for(int i=0;i<size;i++)
            {
                Console.WriteLine($"Enter the member {1} name");
                team[i] = Console.ReadLine();
            }
            Console.WriteLine("The Team Members are");
            foreach (var item in team)
            {
                Console.WriteLine(item);
            }
        }
    }
}
