using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        ////Challenge #1
        //int mageHealth = 100;
        //int warriorHealth = 100;
        //bool someoneIsStillAlive = true;
        //Random damage = new Random();
        //int takeAHit = damage.Next(0, 15);
        //string warriorName = "Frank";
        //string mageName = "Stanley";



        //while (someoneIsStillAlive)
        //{
        //    takeAHit = damage.Next(0, 15);
        //    mageHealth -= takeAHit;
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine($"{mageName} takes a hit for {takeAHit} damage! He has {mageHealth} health left.");


        //    takeAHit = damage.Next(0, 15);
        //    warriorHealth -= takeAHit;
        //    Console.ForegroundColor = ConsoleColor.Blue;

        //    Console.WriteLine($"{warriorName} is hit for {takeAHit} damage.  He has {warriorHealth} health left.");

        //    if ((warriorHealth <= 0) || (mageHealth <= 0))
        //    {
        //        someoneIsStillAlive = false;
        //    }
        //}
        //Console.ForegroundColor= ConsoleColor.Green;
        //if (warriorHealth <= 0)
        //{
        //    Console.WriteLine($"{warriorName} has fallen.  Mage {mageName} is victorious!");
        //}
        //else
        //{
        //    Console.WriteLine($"{mageName} has fallen.  Warrior {warriorName} is victorious!");
        //}
        //Console.ResetColor();

        // Challenge #2
        // Accept input in range 20 - 30
        // Give feedback if out of range or in range
        // clear screen and ask again

        //int number = 0;
        //int min = 20;
        //int max = 30;
        //bool inRange = false;  // Use the ! "not" operator to make the while statement run, don't flip the logic to "notinrange = true;" - it's confusing

        //while (!inRange)
        //{
        //    Console.WriteLine($"Please input a number between {min} and {max}");
        //    number = Convert.ToInt32(Console.ReadLine());
        //    if ((number >= min) && (number <= max))  // use the true side of it, don't flip it to check a false value
        //    {
        //        inRange = true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("That is not a valid number!");
        //        Thread.Sleep(2000);
        //        Console.Clear();
        //    }
        //}
        //Console.WriteLine($"Congratulations! {number} is a valid number!");


        //// Challenge #3
        //// Mini while game
        //string mageName = "Mage Henry";
        //string warriorName = "Warrior Sally";


        //int mageHealth = 99;
        //int warriorHealth = 99;
        //int damage = 0;

        //// Random is the type.  It creates a random number generator.
        //// I used 'hit' but a common name is rng for "random number generator."
        //Random hit = new Random();

        //bool gameOver = false;
        //string message2 = " Character Health ";

        //string separator2 = new string('=', message2.Length);

        //while (!gameOver)  // Keep the logic of the "game over" concept as true or false, just use the ! "not" operator to express it for the loop
        //{
        //    Console.ResetColor();
        //    Console.Clear();

        //    // Mage strikes first
        //    Console.ForegroundColor = ConsoleColor.Blue;
        //    damage = hit.Next(0, 15);
        //    warriorHealth -= damage;
        //    if (warriorHealth <= 0)
        //    {
        //        warriorHealth = 0;
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine($"{warriorName} has been struck down!  {mageName} is victorious!!");
        //        gameOver = true;  // Even though this is true, the condition on the while loop is based on the opposite "while game is not over do this..."
        //    }
        //    else if (mageHealth > 0)
        //    {
        //    Console.WriteLine($"{mageName} attacks {warriorName} for {damage}");
        //    }

        //    // Warrior strikes back
        //    Console.ForegroundColor = ConsoleColor.Cyan;

        //    damage = hit.Next(0, 15);
        //    mageHealth -= damage;
        //    if (mageHealth <= 0)
        //    {
        //        mageHealth = 0;
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine($"{mageName} has been struck down!  {warriorName} is victorious!!");
        //        gameOver = true;
        //    }
        //    else if (warriorHealth > 0)
        //    {
        //        Console.WriteLine($"{warriorName} attacks {mageName} for {damage}");
        //    }

        //    Console.ResetColor();
        //    Console.WriteLine($"\n{message2}{message2,20}");
        //    Console.WriteLine($"{separator2}{separator2,20}");
        //    Console.WriteLine($" {mageHealth} <-{mageName}{warriorHealth,6} <-{warriorName}");
        //    Thread.Sleep(2000);

        //}
        //Console.ResetColor();



        // Comparison
        // while loop
        // the condition is checked first so the code never executes
        int firstNumber = 11;
        int endNumber = 10;
        while (firstNumber <= endNumber)
        {
            Console.WriteLine(firstNumber);
            firstNumber++;
        }
        Console.WriteLine();

        // do while loop
        // the condition is checked after the code runs, so it always runs at least once
        firstNumber = 11;
        endNumber = 10;
        do
        {
            Console.WriteLine(firstNumber);
            firstNumber++;
        } while (firstNumber <= endNumber);


    }
}