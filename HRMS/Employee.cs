using System;
using System.Collections.Generic;
using System.Text;

namespace HRMS
{
    enum Role
    {
        Administrator,
        ProjectManager,
        SDET,
        STE
    }
    //Employee class has all the details about employee
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string EmailId { get; set; }
        public int Phone { get; set; }
        public Role EmpRole { get; set; }
        public decimal Salary { get; set; }
        public DateTime Joiningdate { get; set; } 

        //Add employee
        public void Add(string name)
        {
            Employee employee = new Employee();
            employee.Name = name;
            Console.WriteLine("new employee added : " + employee.Name);
            //save this info to Database
        }
    }

}

   
