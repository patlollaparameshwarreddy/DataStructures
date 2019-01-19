//-----------------------------------------------------------------------
// <copyright file="Banking.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// this class is used for maintaining details of a bank
    /// </summary>
    public class Banking
    {
        /// <summary>
        /// Banking the cash counter.
        /// </summary>
        public void BankingCashCounter()
        {
            Utility utility = new Utility();
            do
            {
                Console.WriteLine("1. Add customer");
                Console.WriteLine("2. View Customers");
                Console.WriteLine("3. perform transaction");
                Console.WriteLine("4. view balance in bank");
                Console.Write("enter your choise: ");
                ////this variable is used to take user option
                int option = utility.GetInt();
                switch (option)
                {
                    case 1:
                        ////in this case it will go to the add customer method in utility
                        utility.AddCustomer();
                        break;
                    case 2:
                        ////in this case it will go to the view customer method in utility
                        utility.ViewCustomer();
                        break;
                    case 3:
                        ////in this case it will go to the perform transaction method in utility
                        utility.PerformTransactions();
                        break;
                    case 4:
                        ////in this case it will go to the view balance method in utility
                        utility.ViewBalance();
                        break;
                    default:
                        {
                            Console.WriteLine("enter valid option");
                            break;
                        }
                }
            }
            while (true);
        }
    }
}
