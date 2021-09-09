using System;
using Assignment1.Day02;
namespace Assignment1.Day03
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public DateTime EmpDOB { get; set; }
    }
    
    class EmployeeData
    {
        private const int size = 2;
        private static Employee[] empp = new Employee[size];

        static void Main(string[] args)
        {
            for (int i = 0; i < size; i++)
            {
                addEmployee();
            }

            showEmployee();
        }
        private static void addEmployee()
        {
            var id = MyConsole.GetNumber("Enter the Employee ID");
            var name = MyConsole.GetString("Enter the Employee Name");
            var address = MyConsole.GetString("Enter the Employee Address");
            var dob = MyConsole.GetDate("Enter the Employee DOB");

            //Console.WriteLine("Enter the DOB as dd/mm/yyyy only");
            //var dob = Console.ReadLine();

            for (int i = 0; i < size ; i++)
            {
                if(empp[i] == null)
                {
                    empp[i] = new Employee
                    {
                        EmpID = id, 
                        EmpName = name, 
                        EmpAddress = address, 
                        EmpDOB = dob                       
                    };
                    break;
                } 
            }
        }

        static void showEmployee()
        {
            Console.WriteLine("The details of the Employee is:");
            foreach (var item in empp)
            {
                if(item != null)
                    Console.WriteLine($" Emp-ID - {item.EmpID} \n Name - {item.EmpName} \n Address - {item.EmpAddress}\n DOB - {item.EmpDOB} \n -------------------------------");

            }

        }
        
    }
}
