//-----------------------------------------------------------------------
// <copyright file="OrderedList.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// this class is used to search an element in an file
    /// </summary>
    public class OrderedList
    {
        /// <summary>
        /// this method is used to search and remove an element in an file if search element is exists, otherwise it will add to the file
        /// </summary>
        public void AddingAndRemovingNumberFromFile()
        {
            ////creating the object of utility class
            Utility utility = new Utility();
            ////creating the object of linked list
            LinkedList<int> linkedList = new LinkedList<int>();
            ////System.IO.File.ReadAllText is used to read the elements from the file 
            string numbersInFile = System.IO.File.ReadAllText(utility.FileForTakingInputOfOrderedList());
            ////this string is used to split the string in to string array
            string[] stringFormatenumbers = numbersInFile.Split(' ');
            ////Array.ConvertAll this is used to convert string array in tointeger array
            int[] StringToNumbers = Array.ConvertAll(stringFormatenumbers, int.Parse);
            ////this is used to sort an elements in an array
            Array.Sort(StringToNumbers);
            ////this loop is used to add elements in to an linked list
            foreach (int value in StringToNumbers)
            {
                linkedList.AddLast(value);
            }

            Console.WriteLine("elements in linked list");
            ////this loop is used for printing the values in a list
            foreach (int values in linkedList)
            {
                Console.WriteLine(values);
            }

            Console.WriteLine("enter number to search");
            try
            {
                ////this is used to take the search element from an user
                int searchNumber = Convert.ToInt32(Console.ReadLine());
                ////this condition is used to check whether the given element is present in an list or not
                if (linkedList.Contains(searchNumber))
                {
                    Console.WriteLine("search element contain in the list it is removed from the list");
                    linkedList.Remove(searchNumber);
                }
                else
                {
                    Console.WriteLine("search element does not  contain in the list so it is added to list");
                    linkedList.AddLast(searchNumber);
                }

                ////this loop is used to print elements that are present in the  list after adding or deleting the element
                foreach (int values in linkedList)
                {
                    Console.WriteLine(values);
                }
                ////string.Join this is used to convert the string array in to string
                string resultString = string.Join(" ", linkedList);
                ////Stream Writer is used to write the string in the result string variable to the file 
                using (StreamWriter streamWriter = new StreamWriter(utility.ResultFileOfOrderedList()))
                {
                    streamWriter.WriteLine(resultString + " ");
                }
            }
            catch (System.FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}