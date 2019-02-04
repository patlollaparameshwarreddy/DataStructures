//-----------------------------------------------------------------------
// <copyright file="PrimeNumbersAndAnagrams.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;

    /// <summary>
    /// this class is used to store the prime numbers and anagrams in 2d array
    /// </summary>
    public class PrimeNumbersAndAnagrams
    {
        /// <summary>
        /// this method is used for getting the prime numbers and storing in 2d array
        /// </summary>
        public void AnagramAndPrime()
        {
            try
            {               
                int anagramIndex = 0;
                int notAnagramIndex = 0;
                int anagramCount = 0;
                int notAAnagramCount = 0;
                ////creating the object of utility class
                Utility utility = new Utility();
                ////calling the ListOfPrimeNumbers method from the utility class from there we will get the prime numbers in to an array list
                ArrayList primenumbers = utility.ListOfPrimeNumbers();
                string[] anagrams = new string[primenumbers.Count];
                string[] notAnagram = new string[primenumbers.Count];
                ////this for loop is used for taking one by one element from the array list
                for (int i = 0; i < primenumbers.Count; i++)
                {
                    ////converting number int to string
                    string number1 = primenumbers[i] + string.Empty;
                    ////converting string number in to character array
                    char[] numberInArray1 = number1.ToCharArray();
                    Array.Sort(numberInArray1);
                    ////converting character array in to string
                    string original1 = new string(numberInArray1);
                    bool found = true;
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
                            found = false;
                            anagrams[anagramIndex++] = number1;
                            anagrams[anagramIndex++] = number2;
                            anagramCount = anagramCount + 2;
                            
                        }
                    }

                    ////this condition is used to check whether the number is a anagram or not
                    if (found)
                    {
                        notAnagram[notAnagramIndex++] = number1;
                        notAAnagramCount++;
                    }
                }     
                
                ////this loop is used for printing the numbers that are anagrams
                for (int i = 0; i <= anagramCount; i++)
                {
                    Console.Write(anagrams[i] + "\t");
                }

                ////this loop is used for printing the numbers that are not anagrams
                for (int i = 0; i <= notAAnagramCount; i++)
                {
                    Console.Write(notAnagram[i] + "\t");
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}