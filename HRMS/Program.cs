using System;

namespace HRMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HRMS");
            Console.WriteLine("*****************");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. New Employee Form");
            Console.WriteLine("2. List all employee's");

            var choice = Console.ReadLine();
            switch(choice)
            {
                case "0":
                    Console.WriteLine("Thank you for visiting");
                    return;
              
                case "1":
                    Console.WriteLine("Employee name: ");
                    var empname = Console.ReadLine();
                    //create new instance of employee class
                    Employee emp = new Employee();
                    //pass user provided name to Add method
                    emp.Add(empname);

                    break;
                case "2":
                    break;
                default:
                    break;

            }

        }




            
        
    }
}
