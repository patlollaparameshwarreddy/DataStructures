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
        /// The queue object is created
        /// </summary>
        public Queue queue = new Queue();

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
        public string FileForOrderedList()
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

        /// <summary>
        /// Days the of week.
        /// </summary>
        /// <param name="year">The year</param>
        /// <param name="month">The month</param>
        /// <returns> return the day </returns>
        public int DayOfWeek(int year, int month)
        {
            string[] week = { "Sunday", "monday", "tuesday", "wednesday", "thrusday", "friday", "saturday" };
            int y = year;
            int m = month;
            int d = 1;
            int y0 = y - ((14 - m) / 12);
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + (12 * ((14 - m) / 12)) - 2;
            int d0 = (d + x + (31 * m0 / 12)) % 7;
            return d0;
        }

        /// <summary>
        /// Gets the integer.
        /// </summary>
        /// <returns>returns the integer value</returns>
        public int GetInt()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        /// <summary>
        /// Lists the of prime numbers.
        /// </summary>
        /// <returns> returns the prime numbers </returns>
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

        /// <summary>
        /// Adds the customer.
        /// </summary>
        public void AddCustomer()
        {
            Console.WriteLine("enter customer name");
            string customeraName = Console.ReadLine();
            this.queue.Enqueue(customeraName);
        }

        /// <summary>
        /// Views the customer.
        /// </summary>
        public void ViewCustomer()
        {
            ////this condition is used to check whether the queue is empty or not
            if (this.queue.Count != 0)
            {
                Console.WriteLine("the  customers in a quequ are: ");
                ////this loop is used for printing the values in the quequ
                foreach (string customers in this.queue)
                {
                    Console.WriteLine(customers);
                }
            }
            else
            {
                Console.WriteLine("no customers in the quequ");
            }
        }

        /// <summary>
        /// The amount in bank
        /// </summary>
        private int amountInBank = 10000;

        /// <summary>
        /// Performs the transactions.
        /// </summary>
        public void PerformTransactions()
        {
            ////this condition is used to check whether the queue is empty or not
            if (this.queue.Count != 0)
            {
                Console.WriteLine(this.queue.Dequeue() + " continue your transaction");
                Console.WriteLine("enter 1 for credit");
                Console.WriteLine("enter 2 for withdraw");
                ////this variable is used to store the choise of the customer
                int option = this.GetInt();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("enter amount to deposite");
                        int depositeRupess = this.GetInt();
                        ////this condition is used to whether the depoit money is greater than zero
                        if (depositeRupess > 0)
                        {
                            this.amountInBank = this.amountInBank + depositeRupess;
                            Console.WriteLine("amount deposited " + depositeRupess);
                        }
                        else
                        {
                            Console.WriteLine("entered invalid amount");
                        }

                        break;
                    case 2:
                        Console.WriteLine("enter amount to withdraw");
                        int withdrawRupess = this.GetInt();
                        ////this condition is used to whether the depoit money is greater than zero
                        if (withdrawRupess > 0)
                        {
                            ////this condition is used to check whether the withdrawRupess is greater than amountInBank
                            if (withdrawRupess > this.amountInBank)
                            {
                                Console.WriteLine("no cash");
                                ////this condition is uesd to check whether the bank consists of money or not
                                if (this.amountInBank > 0)
                                {
                                    Console.WriteLine("enter amount less than " + this.amountInBank);
                                }
                            }
                            else
                            {
                                this.amountInBank = this.amountInBank - withdrawRupess;
                                Console.WriteLine("amount withdrawed " + withdrawRupess);
                            }
                        }
                        else
                        {
                            Console.WriteLine("entered invalid amount");
                        }

                        break;
                }
            }
            else
            {
                Console.WriteLine("no customers in the quequ");
            }
        }

        /// <summary>
        /// Views the balance.
        /// </summary>
        public void ViewBalance()
        {
            Console.WriteLine("balance with bank " + this.amountInBank);
        }

        /// <summary>
        /// Number of binary search tree with nodes.
        /// </summary>
        /// <param name="nodes">The nodes.</param>
        /// <returns>returns the numbers of binary search tree </returns>
        public long NumberOfBTSwithNnodes(long nodes)
        {
            long numberOfBTS = this.FactorialOfANumber(2 * nodes) / (this.FactorialOfANumber(nodes + 1) * this.FactorialOfANumber(nodes));
            return numberOfBTS;
        }

        /// <summary>
        /// Factorial of a number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>it returns the factorial </returns>
        public long FactorialOfANumber(long number)
        {
            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}
