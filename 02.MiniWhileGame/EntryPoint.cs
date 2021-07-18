using System;
class EntryPoint
{
    static void Main()
    {
        int mageHealth = 100;
        int warriorHealth = 100;
        bool someoneIsStillAlive = true;
        Random damage = new Random();
        int takeAHit = damage.Next(0, 15);
        string warriorName = "Frank";
        string mageName = "Stanley";



        while (someoneIsStillAlive)
        {
            takeAHit = damage.Next(0, 15);
            mageHealth -= takeAHit;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{mageName} takes a hit for {takeAHit} damage! He has {mageHealth} health left.");


            takeAHit = damage.Next(0, 15);
            warriorHealth -= takeAHit;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"{warriorName} is hit for {takeAHit} damage.  He has {warriorHealth} health left.");
            
            if ((warriorHealth <= 0) || (mageHealth <= 0))
            {
                someoneIsStillAlive = false;
            }
        }
        Console.ForegroundColor= ConsoleColor.Green;
        if (warriorHealth <= 0)
        {
            Console.WriteLine($"{warriorName} has fallen.  Mage {mageName} is victorious!");
        }
        else
        {
            Console.WriteLine($"{mageName} has fallen.  Warrior {warriorName} is victorious!");
        }
        Console.ResetColor();
    }
}