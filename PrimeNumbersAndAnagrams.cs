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
            ////creating the object of utility class
            Utility utility = new Utility();
            ////getting the prime numbers list from the utility class
            ArrayList primeNumbers = utility.ListOfPrimeNumbers();
            ////declaring the 2d array
            int[,] primeNumbersInArray = new int[10, 25];
            ////this variable is used for storing the index value of the arraylist
            int startingIndexOfArrayList = 0;
            ////this is the lower range number i.e 0
            int range1 = 0;
            ////this is the higer range number i.e 100
            int range2 = 100;
            ////this loop is used for taking the number of rows
            for (int i = 0; i < 10; i++)
            {
                ////this loop is used for taking the number of columns
                for (int j = 0; j <= primeNumbersInArray.GetLength(1); j++)
                {
                    try
                    {
                        if (startingIndexOfArrayList < primeNumbers.Count && ((int)primeNumbers[startingIndexOfArrayList] > range1) && ((int)primeNumbers[startingIndexOfArrayList] <= range2))
                        {
                            primeNumbersInArray[i, j] = (int)primeNumbers[startingIndexOfArrayList];
                            startingIndexOfArrayList++;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                ////incrementing the ranges by 100
                range1 = range1 + 100;
                range2 = range2 + 100;
            }

            ////this condition is used for printing the 2d array that contain prime numbers
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < primeNumbersInArray.GetLength(1); j++)
                {
                    try
                    {
                        ////this condition is used for not printing the default value 0 insted of it will print space
                        if (primeNumbersInArray[i, j] > 0)
                        {
                            Console.Write(primeNumbersInArray[i, j] + "\t");
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}