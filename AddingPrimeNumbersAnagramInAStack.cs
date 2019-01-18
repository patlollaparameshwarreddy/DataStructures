using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class AddingPrimeNumbersAnagramInAStack
    {
        public void PrimeNumbersAnagramInAStack()
        {
            Utility utility = new Utility();
            Stack stack = new Stack();
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
                        stack.Push(number1);
                        stack.Push(number2);
                    }
                }
            }

            Console.WriteLine("anagram prime numbers that are in 0 to 1000 are ");
            foreach (string numbers in stack)
            {
                Console.Write(numbers + "\t");
            }
        }
    }
}
