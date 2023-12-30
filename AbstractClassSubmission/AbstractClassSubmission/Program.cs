using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instantiate the class Employee
            employee.firstName = "Sample"; //set the first name of the Employee to "Sample"
            employee.lastName = "Student"; //set the last name of the Employee to "Student"
            employee.SayName(); //call the method SayName
            Console.ReadLine(); //hold the console open
        }
    }
}
