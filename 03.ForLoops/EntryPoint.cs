using System;

class EntryPoint
{
    static void Main()
    {
        //// while loop
        //int counter = 0;
        //while (counter < 10)
        //{
        //    counter++;
        //    Console.WriteLine(counter);
        //}
        //Console.WriteLine();

        //// Doing the same thing with a for loop
        //// The indexing variable is usually named i, but it can be anything
        //// The for loop is often used to iterate over arrays
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //// Challenge #1
        //// Create a for loop to iterate over an integer array
        //int[] myfirstArray = { 1,2,3,4,5,6,23,34,45,56,67,78,89,90,7,8,9,10 };

        //// Since the first index of an array is 0, the index variable will start with 0
        //// Using the length of the array as the number of times for the loop works because it doesn't execute the last value of i
        //// So if the length of an array is 10, it will use the indexs 0-9.
        //// Then it will increment the number to 10, which is no longer less than 10, so the loop stops.
        //for (int i = 0; i < myfirstArray.Length; i++)
        //{
        //    // use myfirstArray[i] % 2 == 0 in the condition to get the even numbers inside the array
        //    // use i % 2 == 0 in the condition to get the even numbered index positions of the array
        //    // use i % 3 == 0 to skip every third element in the array
        //    if (i % 3 == 0)
        //    {
        //    Console.WriteLine(myfirstArray[i]);
        //    }
        //}

        //// Just making multiplication tables

        //for (int x = 1; x < 10; x++)
        //{

        //    for (int y = 1; y < 10; y++)
        //    {
        //        string z = new string(' ', 3);
        //        Console.Write(value: $"{x*y}{z}");
        //    }
        //    Console.WriteLine();
        //}


        // More "for" loop practice
        string menu = "1. Add new Item" +
            "\n2. Edit Item" +
            "\n3. Remove Item" +
            "\n4. View all Items" +
            "\n5. Exit\n";

        string[] items = new string[10];  // This is the array that we'll work with.  It will have 10 items.
        items[0] = "apple";
        items[1] = "orange";

        string fruit = null;
        bool exit = false;
        int selectedItem = 0;

        Console.WriteLine(menu);
        while (!exit)
        {
            Console.Write("Your selection (1-5):  ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (userChoice)
            {
                case 1:
                    // Add an item
                    // First, iterate through the array to find the next available index
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (items[i] == null)  // null means there's nothing there in that index position
                        {
                            Console.WriteLine("Enter the name of a fruit:  ");
                            fruit = Console.ReadLine();
                            items[i] = fruit;
                            break;
                        }
                    }
                    break;

                case 2:
                    // Edit an item
                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine($"{i}  {items[i]}");
                    }
                    Console.WriteLine();
                    Console.Write("Which item number do you want to edit? # ");
                    selectedItem = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Edit item #{selectedItem} {items[selectedItem]} to what? -->  ");
                    fruit = Console.ReadLine();
                    items[selectedItem] = fruit;
                    Console.Write("Press enter to continue: ");
                    Console.ReadLine();
                    break;

                case 3:
                    // Remove an item
                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine($"{i} {items[i]}");
                    }
                    Console.Write("Enter the index number to remove an item: ");
                    selectedItem = Convert.ToInt32(Console.ReadLine());
                    items[selectedItem] = null;
                    Console.Write("Press enter to continue");
                    Console.ReadLine();
                    break;

                case 4:
                    // View all current items
                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine($"{i} {items[i]}");
                    }
                    Console.Write("Press enter to continue");
                    Console.ReadLine();
                    break;

                case 5:
                    // Exit
                    Console.WriteLine("You chose to exit");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Unrecognized option. Please choose a menu item between 1 and 5");
                    break;
            }
            Console.Clear();
            Console.WriteLine(menu);

        }

    }
}