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
            char condition;
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
                Console.WriteLine("enter 9 for binary numbers in a stack");
                try
                {
                    caseConodition = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

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
                        calendar.FormationCalanderBasedOnYearAndMonth();
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
                   
                }

                Console.WriteLine("enter y to continue,  enter any key to stop execution");
                condition = Convert.ToChar(Console.ReadLine());
            }
            while (condition == 'y');
        }
    }
}
