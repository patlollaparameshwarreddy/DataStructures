//-----------------------------------------------------------------------
// <copyright file="PalindromeChecker.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;

    /// <summary>
    /// this class is used for checking for palindrome
    /// </summary>
    public class PalindromeChecker
    {
        /// <summary>
        /// Checking the palindrome.
        /// </summary>
        public void CheckingPalindrome()
        {
            ////creating queue object
            Queue firstQueue = new Queue();
            Queue secondQueue = new Queue();
            Console.WriteLine("enter string for checking for palindrome");
            ////taking string from the console
            string word = Console.ReadLine();
            int condition = 0;
            ////converting the string in to character array
            char[] convertingWordsToCharacter = word.ToCharArray();
            ////finding the length of character array
            int lengthOfCharArray = convertingWordsToCharacter.Length;
            ////storing the characters in character array to first queue 
            for (int i = 0; i < lengthOfCharArray; i++)
            {
                firstQueue.Enqueue(convertingWordsToCharacter[i]);
            }
            ////storing the charactes in reverse order to a second queue
            for (int i = lengthOfCharArray - 1; i >= 0; i--)
            {
                secondQueue.Enqueue(convertingWordsToCharacter[i]);
            }

            ////this condition is used to check whether the queues are empty or not
            while ((firstQueue.Count != 0) && (secondQueue.Count != 0))
            {
                ////this condition is used to check whether the two values from the queue is equal of not
                if ((char)firstQueue.Dequeue() != (char)secondQueue.Dequeue())
                {
                    condition++;
                }
            }
           
            ////if the value of the condition is incremented than it is not a palindrome
            if (condition > 0)
            {
                Console.WriteLine("FALSE");
            }
            else
            {
                Console.WriteLine("TRUE");
            }
        }
    }
}
