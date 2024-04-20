using System;//setup// using the system library for console functions


namespace FizzBuzz//setup for projects encapsulating my code with in the namespace project.
{
    public class Program// made program public for accessability
    {
        public static void Main(string[] args)// made static so I can call more conviently.
        {
            Fizz();//calling in Main to practice for larger projects with classes.



        }
        public static string Fizz()// made method static for call efficiency.
        {
            Console.WriteLine("Input a number to play fizzbuzz");//skip
            //considered a user input rather then just a return.

            //*****int number = value; |||| for non user input********

            int number = int.Parse(Console.ReadLine());//skip
            //parsed a string return to an int for int calculations

            if (number % 3 == 0 && number % 5 == 0)//if divisible by 3 AND 5
            {// used 3 and 5 first so if its not divisible by either or one, 
            //it will start to execute the other if statements
            // if if a number was divisble by both 3 and 5, it would execute the 
            //other if statements first before this one, if i had the other if statements first.

                Console.WriteLine("fizzbuzz");///****skip no user input
                return "fizzbuzz"; // divisible by both 3 and 5

            }
            if (number % 3 == 0)//if divisible by 3 with no remainder
            {
                Console.WriteLine("fizz");//*** skip if no user input
                return "fizz";//is divisible by 3
            }
            if (number % 5 == 0)//if divisible by 5 with no remainder
            {
                Console.WriteLine("buzz");//*** skip if no user input
                return "buzz";//is divisible by 5
            }
            else
            {
                Console.WriteLine("Not a good number");//***skip user input
                return Fizz();// what if the number isn't divisible by either???
            }
        }
    }
}