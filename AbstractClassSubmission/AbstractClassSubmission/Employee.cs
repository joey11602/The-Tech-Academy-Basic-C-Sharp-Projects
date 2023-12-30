using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Employee : Person
    {
        public  override void SayName() //implement and override the abstract void method called SayName from the base class Person
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); //write to console
        }
    }
}
