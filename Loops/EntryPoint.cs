using System;
using System.Threading;

namespace Loops
{
    class EntryPoint
    {
        static void Main()
        {
            // Loops
            // structure of a loop
            // -----------------------
            // keyword (condition)
            //   {
            //   body of the code between the curly braces
            //   is executed as long as the condition is true
            //   }
            // The keyword define what kind of loop you have
            // The condition for the loop
            // Life loop
            // -----------------------
            // keyword (beingAlive)
            // {
            //      breathing
            //      This loop means that as long as you are alive you are breathing
            //      This is the action that needs to be conducted while the condition is still true
            // }
            // With eating the condition is reversed, reverse logic
            // You need a true condition
            // ----------------------
            // keyword (notFull)
            // {
            //      keep eating
            // }
            // -----------------------
            // Watching a lecture
            // keyword (isThereMoreToWatch)
            // {
            //      keep watching
            // }
            // The condition is now false, go and make coffee
            // -------------------------
            // These kinds of loops are called "while loops"
            // While the condition is true, execute the code in the body
            // The keyword is "while"
            // -------------------
            // Control-k-u to remove comments from highlighted text
            // Print the sentance "I am learning about loops" 10 times
            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine("I am learning about loops");
            //    counter++;
            //}

            // Challenge #1
            //// This is one way to do it
            //int inputNumber = 0;
            //while ((inputNumber < 20) || (inputNumber > 30))
            //{
            //    Console.WriteLine("Please input a number in the range 20 to 30: ");
            //    inputNumber = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"Congratulations! {inputNumber} is a valid number!");

            // This is another way to do it
            // This code is handy to keep asking a user for input until he gives you a correct input

            int number = 0;
            int min = 20;
            int max = 30;
            bool numberInRange = false;

            while (!numberInRange)
            {
                Console.Write($"Please input a number in the range {min} to {max}: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= min && number <= max)
                {
                    numberInRange = true;
                }
                else
                {
                    Console.WriteLine($"Please input another number in the range {min} to {max}! Your number is not a valid input!");
                    Thread.Sleep(2000);  // this makes the program pause for 2 seconds (1000 milliseconds = 1 second)
                    Console.Clear();
                }
                Console.WriteLine($"Congratulations! Your number {number} is a valid number!");

            }







        }
    }
}
