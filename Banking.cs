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
            do
            {
                Console.WriteLine("1. Add customer");
                Console.WriteLine("2. View Customers");
                Console.WriteLine("3. perform transaction");
                Console.WriteLine("4. view balance in bank");
                Console.Write("enter your choise: ");
                int option = utility.GetInt();
                switch (option)
                {
                    case 1:
                        utility.AddCustomer();
                        break;
                    case 2:
                        utility.ViewCustomer();
                        break;
                    case 3:
                        utility.PerformTransactions();
                        break;
                    case 4:
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
