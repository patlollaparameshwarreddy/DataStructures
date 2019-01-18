using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class AddingAnagramPrimeInQueue
    {
        public void AnagramPrimeNumber()
        {
            Utility utility = new Utility();
            Queue queue = new Queue();
            ArrayList primenumbers = utility.ListOfPrimeNumbers();
            for (int i = 0; i < primenumbers.Count; i++)
            {
                ////converting number int to string
                string number1 = primenumbers[i] + string.Empty;
                ////converting string number in to character array
                char[] numberInArray1 = number1.ToCharArray();
                Array.Sort(numberInArray1);
                ////converting character array in to string
                string original1 = new string(numberInArray1);
                for (int j = i + 1; j < primenumbers.Count; j++)
                {
                    ////converting number int to string
                    string number2 = primenumbers[j] + string.Empty;
                    ////converting string number in to character array
                    char[] numberInArray2 = number2.ToCharArray();
                    Array.Sort(numberInArray2);
                    ////converting character array in to string
                    string original2 = new string(numberInArray2);
                    if (original1.Equals(original2))
                    {
                        queue.Enqueue(number1);
                        queue.Enqueue(number2);
                    }
                }
            }

            Console.WriteLine("anagram prime numbers that are in 0 to 1000 are ");
            foreach (string numbers in queue)
            {
                Console.Write(numbers + "\t");
            }
        }
    }
}
