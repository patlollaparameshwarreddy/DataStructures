//-----------------------------------------------------------------------
// <copyright file="MainClass.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// this class is use to execute all other classes
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                MainClass.Menu();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
        }

        /// <summary>
        /// this method is used for creating the object of all classes
        /// </summary>
        public static void Menu()
        {
            string condition;
            int caseConodition = 0;
            do
            {
                Console.WriteLine("enter 1 for UnOrdered List");
                Console.WriteLine("enter 2 for balanced parantheses");
                Console.WriteLine("enter 3 for ordereed list");
                Console.WriteLine("enter 4 for printing calander");
                Console.WriteLine("enter 5 for banking cash counter");
                Console.WriteLine("enter 6 for prime numbers in 2D array");
                Console.WriteLine("enter 7 for checking palindrome of a string");
                Console.WriteLine("enter 8 for binary search tree");
                Console.WriteLine("enter 9 for anagrams of prime numbers in a stack");
                Console.WriteLine("enter 10 for anagrams of prime numbers in a queue");
                Console.WriteLine("enter 11 for calander using quequ");
                Console.WriteLine("enter 12 for calander through stack");
                Console.WriteLine("enter 13 for Hashing Function");
                Console.WriteLine("enter 14 for prime numbers that are not anagra and anagram");
                caseConodition = Convert.ToInt32(Console.ReadLine());
                switch (caseConodition)
                {
                    case 1:
                        UnOrderedList list = new UnOrderedList();
                        list.AddingOrRemovingWordFromFile();
                        break;
                    case 2:
                        BalancedParentheses balanced = new BalancedParentheses();
                        balanced.CheckingBalancedParentheses();
                        break;
                    case 3:
                        OrderedList orderedList = new OrderedList();
                        orderedList.AddingAndRemovingNumberFromFile();
                        break;
                    case 4:
                        Calendar calendar = new Calendar();
                        calendar.FormationCalendarBasedOnYearAndMonth();
                        break;
                    case 5:
                        Banking banking = new Banking();
                        banking.BankingCashCounter();
                        break;
                    case 6:
                        PrimeNumbersIn2DArray primeNumbersIn2D = new PrimeNumbersIn2DArray();
                        primeNumbersIn2D.PrimeNumbers();
                        break;
                    case 7:
                        PalindromeChecker palindromeChecker = new PalindromeChecker();
                        palindromeChecker.CheckingPalindrome();
                        break;
                    case 8:
                        BinarySearchTree binarySearchTree = new BinarySearchTree();
                        binarySearchTree.NumberOfBinarySearchTrees();
                        break;
                    case 9:
                        AddingPrimeNumbersAnagramInAStack anagramInAStack = new AddingPrimeNumbersAnagramInAStack();
                        anagramInAStack.PrimeNumbersAnagramInAStack();
                        break;
                    case 10:
                        AddingAnagramPrimeInQueue anagramPrimeInQueue = new AddingAnagramPrimeInQueue();
                        anagramPrimeInQueue.AnagramPrimeNumber();
                        break;
                    case 11:
                        CalanderThroughQueue calanderThroughQueue = new CalanderThroughQueue();
                        calanderThroughQueue.CalanderInQueue();
                        break;
                    case 12:
                        CalendarThroughStack calendarThroughStack = new CalendarThroughStack();
                        calendarThroughStack.ImplementingCalendarThroughStack();
                        break;
                    case 13:
                        HashingFunction hashing = new HashingFunction();
                        hashing.StoringAndRetrievingNumbers();
                        break;
                    case 14:
                        PrimeNumbersAndAnagrams primeNumbersAndAnagrams = new PrimeNumbersAndAnagrams();
                        primeNumbersAndAnagrams.AnagramAndPrime();
                        break;
                }

                Console.WriteLine("Enter Y to continue OR any key to stop");

                condition = Console.ReadLine();
            }
            while (condition.Equals("y") || condition.Equals("Y"));
        }
    }            
}
