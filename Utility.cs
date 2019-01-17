//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;
    

    /// <summary>
    /// this class is used for writing the logics
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Files for taking input of unordered list.
        /// </summary>
        /// <returns>the path of a folder</returns>
        public string FileForTakingInputOfUnorderedList()
        {
            string path = @"C:\Users\Admin\Desktop\UnOrderedList.txt";
            return path;
        }

        /// <summary>
        /// Results the file of unordered list.
        /// </summary>
        /// <returns>this will return the path of a folder</returns>
        public string ResultFileOfUnorderedList()
        {
            string path = @"C: \Users\Admin\Desktop\result.txt";
            return path;
        }

        /// <summary>
        /// Files for taking input of ordered list.
        /// </summary>
        /// <returns>this will return the path of a folder</returns>
        public string FileForTakingInputOfOrderedList()
        {
            string path = @"C:\Users\Admin\Desktop\OrderedList.txt";
            return path;
        }

        /// <summary>
        /// Results the file of ordered list.
        /// </summary>
        /// <returns>this will return the path of folder</returns>
        public string ResultFileOfOrderedList()
        {
            string path = @"C:\Users\Admin\Desktop\OrderedListResult.txt";
            return path;
        }

        public int DayOfWeek(int year, int month)
        {
            string[] week = { "Sunday", "monday", "tuesday", "wednesday", "thrusday", "friday", "saturday" };
            int y = year;
            int m = month;
            int d = 1;
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + (12 * ((14 - m) / 12)) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;
            return d0;
        }
        public int GetInt()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }


        public ArrayList ListOfPrimeNumbers()
        {
            ArrayList storePrimeNumbers = new ArrayList();
            ////this loop is used for taking the numbes from 1 to given range
            for (int i = 1; i <= 1000; i++)
            {
                int count = 0;
                ////this loop is used for dividing the i by the j up to given range
                for (int j = 1; j <= 1000; j++)
                {
                    if ((i % j) == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    storePrimeNumbers.Add(i);
                }
            }

            return storePrimeNumbers;
        }

        Queue queue = new Queue();
        public void AddCustomer()
        {
            Console.WriteLine("enter customer name");
            string customeraName = Console.ReadLine();
            queue.Enqueue(customeraName);
        }
        public void 
    }
}
