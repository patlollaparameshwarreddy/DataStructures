using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class PrimeNumbersIn2DArray
    {
        public void PrimeNumbers()
        {

            Utility utility = new Utility();
            ArrayList primeNumbers = utility.ListOfPrimeNumbers();
            int p = 0;
            int number1 = 0;
            int number2 = 100;
            if (number2 < 1000)
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 0; j <= 25; j++)
                    {
                        try
                        {
                            if (((int)primeNumbers[p] > number1) && ((int)primeNumbers[p] < number2))
                            {
                                Console.Write(primeNumbers[p] + "\t");
                                p++;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    Console.WriteLine();
                    number1 = number1 + 100;
                    number2 = number2 + 100;
                }
            }
            else
            {
                Console.WriteLine("printed all prime numbers");
            }
            Console.WriteLine(p + "value");
            

        }
    }
}
