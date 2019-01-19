//-----------------------------------------------------------------------
// <copyright file="Calendar.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// this class is used for creating the calendar
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// Formation of the calendar based on year and month.
        /// </summary>
        public void FormationCalendarBasedOnYearAndMonth()
        {
            ////creating the object of a utility class  
            Utility utility = new Utility();
            int year = 0;
            int month = 0;
            try
            {
                Console.WriteLine("enter year");
                ////taking the input of a year from user
                 year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter month");
                ////taking the input month from the user
                 month = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("enter proper year and month");
            }
            
            if (month >= 1 && month <= 12 && year >= 1000 && year <= 9999)
            {      
                ////creating array to store dates in to an array
                int[,] calander = new int[6, 7];
                ////creating the array that stores the names of a months 
                string[] months = { string.Empty, "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                ////storing the day of a month in to an array
                int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                ////calling the DayOfWeek method for calculating the at which day the date 1st is comming
                int startDate = utility.DayOfWeek(year, month);
                ////this condition is used for checking wheter the given year is a leap year, if it is a leap year we will replace 28 days with 29 days
                if ((month == 2) && (year % 4 == 0))
                {
                    days[2] = 29;
                }

                int date = 01;
                ////this loop is used for storing the dates in to the 1st row 
                for (int i = startDate; i < calander.GetLength(1); i++)
                {
                    calander[0, i] = date;
                    date++;
                }
                ////this loop is used for storing the dates in to a remaining rows and columns
                for (int i = 1; i < calander.GetLength(0); i++)
                {
                    for (int j = 0; j < calander.GetLength(1); j++)
                    {
                        ////this condition is used for checking whether the dates are upto the dates in a month
                        if (date <= days[month])
                        {
                            calander[i, j] = date++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine(months[month] + " " + year);
                Console.WriteLine("sun \tmon \ttue \twed \tthr \tfri \tsat");
                ////this loop is used for printing the dates in a first row
                for (int i = 0; i < calander.GetLength(1); i++)
                {
                    if (calander[0, i] > 0)
                    {
                        Console.Write(calander[0, i] + "\t");
                    }
                    else
                    {
                        Console.Write(" " + "\t");
                    }
                }

                Console.WriteLine();
                ////this loop is used for printing the elements in a remaining rows
                for (int i = 1; i < calander.GetLength(0); i++)
                {
                    ////this loop is used for printing the columns in a row
                    for (int j = 0; j < calander.GetLength(1); j++)
                    {
                        if (calander[i, j] > 0)
                        {
                            Console.Write(calander[i, j] + "\t");
                        }
                        else
                        {
                            Console.Write(" " + "\t");
                        }
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("enter proper month and year");
            }
        }      
    }
}
