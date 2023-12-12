using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number."); // this line writes to the console
            double userNum1; // this line declares a double variable
            while (!double.TryParse(Console.ReadLine(), out userNum1)) // this while loop continues as long as the result is true. by using the 'not' logic
            // the parsing must succeed to get a false result and move past it. Until then, the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number."); //gives the user an error message
            }
            double product = userNum1 * 50; //assigns variable 'product' to the users number * 50
            Console.WriteLine(product); // writes to the console the variable 'product'

            Console.WriteLine("Enter a number."); // this line writes to the console
            double userNum2; // this line declares a double variable
            while (!double.TryParse(Console.ReadLine(), out userNum2)) // this while loop continues as long as the result is true. by using the 'not' logic
            // the parsing must succeed to get a false result and move past it. Until then, the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number."); //gives the user an error message
            }
            double sum = userNum2 + 25; //assigns variable 'sum' to the users number + 25
            Console.WriteLine(sum); // writes to the console the variable 'sum'

            Console.WriteLine("enter a number."); // this line writes to the console
            double userNum3; // this line declares a double variable
            while (!double.TryParse(Console.ReadLine(), out userNum3)) // this while loop continues as long as the result is true. by using the 'not' logic
            // the parsing must succeed to get a false result and move past it. Until then, the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number."); //gives the user an error message
            }
            double quotient = userNum3 / 12.5; //assigns variable 'quotient' to the users number / 12.5
            Console.WriteLine(quotient); // writes to the console the variable 'quotient'

            Console.WriteLine("enter a number."); // this line writes to the console
            double userNum4; // this line declares a double variable
            while (!double.TryParse(Console.ReadLine(), out userNum4)) // this while loop continues as long as the result is true. by using the 'not' logic
            // the parsing must succeed to get a false result and move past it. Until then, the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number."); //gives the user an error message
            }
            bool value = userNum4 > 50; //assigns variable 'value' to the users number > 50
            Console.WriteLine(value); // writes to the console the variable 'value'

            Console.WriteLine("enter a number."); // this line writes to the console
            double userNum5; // this line declares a double variable
            while (!double.TryParse(Console.ReadLine(), out userNum5)) // this while loop continues as long as the result is true. by using the 'not' logic
            // the parsing must succeed to get a false result and move past it. Until then, the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number."); //gives the user an error message
            }
            double modulus = userNum5 % 7; //assigns variable 'modulus' to the users number % 7
            Console.WriteLine(modulus); // writes to the console the variable 'modulus'

            Console.ReadLine();
        }
    }
}
