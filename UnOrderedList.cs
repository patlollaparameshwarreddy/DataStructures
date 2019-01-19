//-----------------------------------------------------------------------
// <copyright file="UnOrderedList.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    /// <summary>
    /// this class is used for searching an element in a file
    /// </summary>
    public class UnOrderedList
    {
        /// <summary>
        /// this method is used for searching a word in a file if the word is present it will remove from the file else it will add to file
        /// </summary>
        public void AddingOrRemovingWordFromFile()
        {
            Utility utility = new Utility();
            ////creating the object of linked list
            LinkedList<string> linkedList = new LinkedList<string>();
            ////System.IO.File.ReadAllText is used to read the content from the file and it will store int text
            string text = System.IO.File.ReadAllText(utility.FileForTakingInputOfUnorderedList());
            ////the string is splited in to the array string by using split method
            string[] words = text.Split(new char[] { ' ' });
            ////storing the elements from string array to linked list
            Console.WriteLine("linked list ");
            ////this loop is used to take each and every word in an array
            foreach (string values in words)
            {
                linkedList.AddLast(values);
            }
            ////this loop is used to print the elements in an linked list
            foreach (string values in linkedList)
            {
                Console.WriteLine(values);
            }

            Console.WriteLine("enter word to search");
            ////the variable is used to stor the search element given by the user
            string searchWord = Console.ReadLine();
            ////this condition is used to check whether the given word is present in the list are not
            if (Regex.IsMatch(searchWord.Replace(" ", string.Empty), @"^[a-zA-Z]+$"))
            {
                if (linkedList.Contains(searchWord))
                {
                    Console.WriteLine("search element contain in the list it is removed from the list");
                    linkedList.Remove(searchWord);
                }
                else
                {
                    Console.WriteLine("search element does not  contain in the list so it is added to list");
                    linkedList.AddLast(searchWord.Replace(" ", string.Empty));
                }
            }
            else
            {
                Console.WriteLine("Only letter are accepted");
            }

            ////this loop is used to print elements that are present in the array list after adding or deleting the element
            foreach (string values in linkedList)
            {
                Console.WriteLine(values);
            }
            ////string.Join this is used to convert the string array in to string
            string resultString = string.Join(" ", linkedList);
            ////Stream Writer is used to write the string in the result string variable to the file 
            using (StreamWriter streamWriter = new StreamWriter(utility.ResultFileOfUnorderedList()))
            {
                streamWriter.WriteLine(resultString + " ");
            }

            Console.WriteLine("press enter to continue");
            Console.ReadLine();
        }
    }
}
