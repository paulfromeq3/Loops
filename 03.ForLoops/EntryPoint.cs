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

        /////////////////////////////////////////////////
        //// More "for" loop practice
        //// Interacting with an array

        //string menu = "1. Add new Item" +
        //    "\n2. Edit Item" +
        //    "\n3. Remove Item" +
        //    "\n4. View all Items" +
        //    "\n5. Exit\n";

        //string[] items = new string[10];  // This is the array that we'll work with.  It will have 10 items.
        //items[0] = "apple";
        //items[1] = "orange";
        ////string[] tempArray = new string[10];  // Assign this in Case 3. This array is used to resort the items[] array to take out the null values


        //string fruit = null;
        //bool exit = false;
        //int selectedItem = 0;

        //Console.WriteLine(menu);
        //while (!exit)
        //{
        //    Console.Write("Your choice:  ");
        //    int userChoice = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine();

        //    // NOTE:  For each case below, I highlighted and hit control-r-m to extract a method from the code
        //    // This is the first time I've created a method in C#, and first time using the shortcut
        //    // So far, it seems to work ok
        //    // I simply selected everything in between "case" and "break" 

        //    switch (userChoice)
        //    {
        //        case 1:
        //            fruit = AddAnItem(items, fruit);
        //            break;

        //        case 2:
        //            selectedItem = EditAnItem(items, ref fruit);
        //            break;

        //        case 3:
        //            selectedItem = RemoveItem(items);
        //            break;

        //        case 4:
        //            ViewAllItems(items);
        //            break;

        //        case 5:
        //            exit = WantToExit();
        //            break;

        //        default:
        //            Console.WriteLine("Unrecognized option. Please choose a menu item between 1 and 5");
        //            break;
        //    }
        //    Console.Clear();
        //    Console.WriteLine(menu);

        //}

        /////////////////////////////
        // The foreach loop
        // - for loops are derivatives of the while loop
        // - foreach loops are derivatives of the for loop
        // - the foreach loop is specifically designed to work on collections of data = including arrays

        // display the contents of this array with a for loop
        int[] array = { 1, 2, 3, 4, 5, 6, 7 };
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        // now display the same contents with a foreach loop
        // foreach works a little different than the for loop
        // With a for loop, you can manipulate the index and skip items.  Index is used like a counter. And you don't have to use it on collections. 
        // With a foreach loop, you can't do that.  You go through each item in the array. You can only use it on collections.
        // "foreach" element of the collection, "foreach" element of the array...
        Console.WriteLine();
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }




    }

    ////////////////////////////////////////////////////////////////////
    // The following are methods created for "Interacting with an array" loop practice
    //private static string AddAnItem(string[] items, string fruit)
    //{
    //    // Add an item
    //    // First, iterate through the array to find the next available index
    //    for (int i = 0; i < items.Length; i++)
    //    {
    //        if (items[i] == null)  // null means there's nothing there in that index position
    //        {
    //            Console.WriteLine("Enter the name of a fruit:  ");
    //            fruit = Console.ReadLine();
    //            items[i] = fruit;
    //            break;
    //        }
    //    }

    //    return fruit;
    //}

    //private static int EditAnItem(string[] items, ref string fruit)
    //{
    //    int selectedItem;
    //    // Edit an item
    //    for (int i = 0; i < items.Length; i++)
    //    {
    //        if (items[i] != null)
    //        {
    //            Console.WriteLine($"{i + 1}.  {items[i]}");

    //        }
    //    }
    //    Console.WriteLine();
    //    Console.Write("Which item number do you want to edit? # ");
    //    selectedItem = Convert.ToInt32(Console.ReadLine());

    //    if ((selectedItem - 1 >= 0) && (selectedItem < items.Length) && (items[selectedItem - 1] != null))
    //    {
    //        Console.Write("Please enter a new fruit to substitute for ");
    //        Console.ForegroundColor = ConsoleColor.Red;
    //        Console.Write($"{items[selectedItem - 1]}");
    //        Console.ResetColor();
    //        Console.Write(" : ");
    //        fruit = Console.ReadLine();
    //        items[selectedItem - 1] = fruit;
    //    }
    //    else
    //    {
    //        Console.WriteLine("Selection is invalid");
    //    }

    //    Console.Write("\nPress enter to continue: ");
    //    Console.ReadLine();
    //    return selectedItem;
    //}

    //private static bool WantToExit()
    //{
    //    bool exit;
    //    // Exit
    //    Console.WriteLine("You chose to exit");
    //    exit = true;
    //    return exit;
    //}

    //private static void ViewAllItems(string[] items)
    //{
    //    // View all current items
    //    // But don't show the null items of the array
    //    for (int i = 0; i < items.Length; i++)
    //    {
    //        if (items[i] != null)
    //        {
    //            Console.WriteLine($"{i + 1}. {items[i]}");
    //        }
    //    }
    //    Console.Write("\nPress enter to continue");
    //    Console.ReadLine();
    //}

    //private static int RemoveItem(string[] items)
    //{
    //    // Remove an item
    //    int selectedItem = 0;
    //    for (int i = 0; i < items.Length; i++)
    //    {
    //        if (items[i] != null)
    //        {
    //            Console.WriteLine($"{i + 1}. {items[i]}");
    //        }
    //    }

    //    Console.Write("Enter the index number to remove an item: ");
    //    selectedItem = Convert.ToInt32(Console.ReadLine());
    //    if ((selectedItem - 1 >= 0) && (selectedItem <= items.Length) && (items[selectedItem - 1] != null))
    //    {
    //        items[selectedItem - 1] = null;
    //        string[] tempArray = new string[10];
    //        int simpleCounter = 0;
    //        for (int j = 0; j < items.Length; j++)
    //        {
    //            if (items[j] != null)
    //            {
    //                tempArray[simpleCounter] = items[j];
    //                simpleCounter++;
    //            }
    //        }
    //        //// This is one method to copy the temporary array back to the main array
    //        //for (int j = 0; j < tempArray.Length; j++)
    //        //{
    //        //    items[j] = tempArray[j];
    //        //}

    //        // This is another method to copy one array to another
    //        Array.Copy(tempArray, items, tempArray.Length);

    //    }
    //    else
    //    {
    //        Console.WriteLine("Selection is invalid");
    //    }
    //    Console.Write("\nPress enter to continue");
    //    Console.ReadLine();
    //    return selectedItem;
    //}
}