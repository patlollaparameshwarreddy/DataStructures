//-----------------------------------------------------------------------
// <copyright file="CalendarThroughStack.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// this class is used for implementing calendar in stack 
    /// </summary>
    public class CalendarThroughStack
    {
        /// <summary>
        /// Implementing the calendar through stack.
        /// </summary>
        public void ImplementingCalendarThroughStack()
        {
            ////creating the object of stack
            Stack<Queue<int>> stack = new Stack<Queue<int>>();
            ////creating the object of stack to store elements in reverse order
            Stack<Queue<int>> stackReverse = new Stack<Queue<int>>();
            ////creating the object of queue
            Queue<int> queue = new Queue<int>();
            ////creating the object of utility class
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
                ////creating the days array it contains the number of days in a month        
                int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                ////calling the DayOfWeek method for calculating the at which day the date 1st is comming
                int startDate = utility.DayOfWeek(year, month);
                ////this condition is used for checking wheter the given year is a leap year, if it is a leap year we will replace 28 days with 29 days
                if ((month == 2) && (year % 4 == 0))
                {
                    days[2] = 29;
                }

                int date = 01;
                ////this loop is used for storing the dates in to a queue
                for (int i = startDate; i < 7; i++)
                {
                    queue.Enqueue(date);
                    date++;
                }

                stack.Push(queue);
                queue = new Queue<int>();

                while (days[month] >= date)
                {
                    ////this is used for storing the number of day in a week to a queue
                    for (int i = 0; i < 7; i++)
                    {
                        ////this condition is used to check whether the date that we are incrumenting is equal to the number of days in a month
                        if (date <= days[month])
                        {
                            ////adding date in to the queue
                            queue.Enqueue(date);
                            ////incrementing the date values
                            date++;
                        }
                    }
                    ////adding queue in to a stack
                    stack.Push(queue);
                    ////creating in subqueue
                    queue = new Queue<int>();
                }

                Console.WriteLine("sun \tmon \ttue \twed \tthr \tfri \tsat");
                ////this loop is used for printing the spaces before the start date i.e before 1st
                for (int i = 1; i <= startDate; i++)
                {
                    Console.Write("\t");
                }
                
                ////this loop is used to store the elements in correct order in another stack
                while (stack.Count != 0)
                {
                    stackReverse.Push(stack.Pop());
                }

                ////this loop is used for printing the elements in stack 
                while (stackReverse.Count != 0)
                {
                    foreach (var item in stackReverse.Pop())
                    {
                        Console.Write(item + "\t");
                    }

                    Console.WriteLine();
                }
                
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("enter proper month and year");            
            }
        }
    }
}
