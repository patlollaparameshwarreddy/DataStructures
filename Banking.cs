using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Banking
    {
        public void BankingCashCounter()
        {
            Utility utility = new Utility();
            Queue queue = new Queue();
            int amountInBank = 10000;

            Console.WriteLine("enter number of people to add in to bank");
            int numberOfPeople = utility.GetInt();
            Console.WriteLine("enter names");
            for (int i = 0; i < numberOfPeople; i++)
            {
                string name = Console.ReadLine();
                queue.Enqueue(name);
            }
            
            for (int i = 0; i < numberOfPeople; i++)
            {
                char startAndStopCondition = 'y';
                string CustomerName = (string)queue.Dequeue();
                do
                {
                    Console.WriteLine(CustomerName + " select your option");
                    Console.WriteLine("enter 1 for deposit");
                    Console.WriteLine("enter 2 for withdraw");
                    int option = utility.GetInt();
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("enter amount to deposite");
                            int depositeRupess = utility.GetInt();
                            if (depositeRupess > 0)
                            {
                                amountInBank = amountInBank + depositeRupess;
                                Console.WriteLine("amount deposited " + depositeRupess);
                            }
                            else
                            {
                                Console.WriteLine("entered invalid amount");
                            }
                            break;
                        case 2:
                            Console.WriteLine("enter amount to withdraw");
                            int withdrawRupess = utility.GetInt();
                            if (withdrawRupess > 0)
                            {
                                if (withdrawRupess > amountInBank)
                                {
                                    Console.WriteLine("no cash");
                                    Console.WriteLine("enter amount less than " + amountInBank);
                                }
                                else
                                {
                                    amountInBank = amountInBank - withdrawRupess;
                                    Console.WriteLine("amount withdrawed " + withdrawRupess);
                                }
                            }
                            else
                            {
                                Console.WriteLine("entered invalid amount");
                            }
                            break;
                         }
                    Console.WriteLine(CustomerName + " do you want to continue");
                    Console.WriteLine("enter y to continue");
                    Console.WriteLine("enter any key to stop");
                    startAndStopCondition = Convert.ToChar(Console.ReadLine());
                }
                while (startAndStopCondition == 'y');
          
            }
        }
    }
}
