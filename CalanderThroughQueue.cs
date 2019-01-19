//-----------------------------------------------------------------------
// <copyright file="CalanderThroughQueue.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;

    /// <summary>
    /// this class is used for implementing the queue using the stack
    /// </summary>
    public class CalanderThroughQueue
    {
        /// <summary>
        /// this method is used for adding elements to queue
        /// </summary>
        public void CalanderInQueue()
        {
            ////creating the object of a queue
            Queue mainQueue = new Queue();
            ////creating the object of a queue
            Queue subQueue = new Queue();
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
                    subQueue.Enqueue(date);
                    date++;
                }
                ////this is used for sotoring the sub queue in to a main queue that is created at starting of the program
                mainQueue.Enqueue(subQueue);
                ////creating new sub quequ
                subQueue = new Queue();
                ////this loop will continue untill the days in a month is equal to the days that we are storing in to the queue
                while (days[month] >= date)
                {
                    ////this is used for storing the number of day in a week to a queue
                    for (int i = 0; i < 7; i++)
                    {
                        ////this condition is used to check whether the date that we are incrumenting is equal to the number of days in a month
                        if (date <= days[month])
                        {
                            ////adding date in to the queue
                            subQueue.Enqueue(date);
                            ////incrementing the date values
                            date++;
                        }
                    }
                    ////adding subqueue in to a main queue
                    mainQueue.Enqueue(subQueue);
                    ////creating in subqueue
                    subQueue = new Queue();
                }

                Console.WriteLine("sun \tmon \ttue \twed \tthr \tfri \tsat");
                ////this loop is used for printing the spaces before the start date i.e before 1st
                for (int i = 1; i <= startDate; i++)
                {
                    Console.Write("\t");
                }
                ////this loop is used for checking whether the queue is empty are not
                while (mainQueue.Count != 0)
                {
                    ////dequeue the queue
                    Queue queue = (Queue)mainQueue.Dequeue();
                    ////this for loop is used to print the values in a queue
                    foreach (int obj in queue)
                    {
                        Console.Write(obj + "\t");
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
