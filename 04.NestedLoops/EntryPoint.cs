using System;

class EntryPoint
{
    static void Main()
    {
        //// Nested loops
        //// used for more complicated operations or for multi-diminsional arrays
        //// This is how a multi-diminsional array index might look
        //// Or maybe a table of data, like date and temperature for each day
        //for (int i = 0; i < 10; i++)
        //{
        //    for (int j = 0; j < 10; j++)
        //    {
        //        Console.Write($"index[{i}][{j}] ");
        //    }
        //    Console.WriteLine();
        //}


        // Nested loop Challenge #1
        // Display the month, the day of the month and the day of the week

        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        int daysinMonth = 31;
        int daysOfWeek = 0;

        for (int currentMonth = 0; currentMonth < months.Length; currentMonth++)
        {
            Console.WriteLine($"Month: {months[currentMonth]} ");
            for (int currentDay = 1; currentDay <= daysinMonth; currentDay++)
            {
                Console.WriteLine($"   {currentDay} {days[daysOfWeek]}");

                daysOfWeek++;
                if (daysOfWeek == 7)
                {
                    daysOfWeek = 0;
                }
                if (currentMonth == 1 && currentDay == 28)
                {
                    break;
                }
                if ((currentMonth == 3 || currentMonth == 5 || currentMonth == 8 || currentMonth == 10 ) && currentDay == 30)
                {
                    break;
                }

            }


            // Below is the first way I did it
            // Use longMonthDates for months with 31 days
            //int dayCounter = 0;
            //if (item == "January" || item == "March" || item == "May" || item == "July" || item == "August" || item == "October" || item == "December")
            //{
            //    for (int i = 0; i < 31; i++)
            //    {
            //        Console.WriteLine($"{i+1} {week[dayCounter]}");
            //        dayCounter++;
            //        if (dayCounter >= 7)
            //        {
            //            dayCounter = 0;
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //// Use febMonthDates if the month is February
            //else if (item == "February")
            //{
            //    for (int j = 0; j < 28; j++)
            //    {
            //        Console.WriteLine($"{j+1} {week[dayCounter]}");
            //        dayCounter++;
            //        if (dayCounter >= 7)
            //        {
            //            dayCounter = 0;
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //// Use shortMonthDates for everything else
            //else
            //{
            //    for (int k = 0; k < 30; k++)
            //    {
            //        Console.WriteLine($"{k+1} {week[dayCounter]}");
            //        dayCounter++;
            //        if (dayCounter >= 7)
            //        {
            //            dayCounter = 0;
            //        }
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
