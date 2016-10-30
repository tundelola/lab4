using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcFactorial
{
    //This Program Calculates the factorial of a number input by the user
    public class Program
    {
        static void Main(string[] args)
        {

            int num = 0;

            while (num >= 0)
            {

                Console.WriteLine("Welcome to the Factorial Calculator!");
            
                Console.WriteLine("Please Enter an interger number greater than 0 but less than 10");//Gets user's input
                num = int.Parse(Console.ReadLine());//Reads Users input


                long output = calcFactorial(num);//Fuction call to calculate factorial of numbers input by the users
                Console.WriteLine("The Factorial of Number = " + output); //output the factorial of user's input

                Console.WriteLine("Do you want to continue? ");
                string userInput = Console.ReadLine();//confirm whether users wants to continue and reads the input
                if (userInput == "No")
                {
                    break;

                }
            }
           
        }
        // Method calculates the factorial of user's input
        public static long calcFactorial(int num)
        {
            long result = 1;
            for (long i = 1; i <= num; i++)
            {
                result = result * i;

            }
            return result;

        }
    }

}




