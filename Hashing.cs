//-----------------------------------------------------------------------
// <copyright file="HashingFunction.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Hashing class store the array on the basis of their mod
    /// </summary>
    public class HashingFunction
    {
        /// <summary>
        /// The array3
        /// </summary>
        private int[] array3;

        /// <summary>
        /// The filename
        /// </summary>
        private string filename = Utility.HashingFunctionFile();

        /// <summary>
        /// Storing and retrieving numbers.
        /// </summary>
        public void StoringAndRetrievingNumbers()
        {
            int choice = 0;
            do
            {
                try
                {
                    string string1 = System.IO.File.ReadAllText(this.filename);
                    string[] array = string1.Split(' ');
                    int[] array1 = new int[array.Length];
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i]);
                        int result;
                        if (int.TryParse(array[i], out result))
                        {
                            if (result != 0)
                            {
                                array1[i] = result;
                            }
                        }
                    }

                    Console.WriteLine("Elements in array1");
                    for (int i = 0; i < array1.Length; i++)
                    {
                        Console.WriteLine(array1[i]);
                    }

                    Dictionary<int, LinkedList<int>> hash = this.AddingHash(array1);
                    Console.WriteLine("Enter the number to search");
                    int key = Convert.ToInt32(Console.ReadLine());
                    this.Searchhash(key, array1);
                    Console.WriteLine("Press 1 to continue otherwise press any key to exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.IO.FileNotFoundException ex)
                {
                    Console.Write(ex.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (choice == 1);
        }

        /// <summary>
        /// This method is used to search number.
        /// </summary>
        /// <param name="key">integer key</param>
        /// <param name="array1">integer array</param>
        private void Searchhash(int key, int[] array1)
        {
            bool flag = false;
            for (int j = 0; j < array1.Length; j++)
            {
                if (key == array1[j])
                {
                    this.array3 = new int[array1.Length - 1];
                    for (int i = 0; i < this.array3.Length; i++)
                    {
                        if (array1[i] == key)
                        {
                            flag = true;
                            continue;
                        }

                        if (flag)
                        {
                            this.array3[i] = array1[i + 1];
                        }
                        else
                        {
                            this.array3[i] = array1[i];
                        }
                    }
                }

                if (!flag)
                {
                    this.array3 = new int[array1.Length + 1];
                    int k = 0;
                    for (; k < array1.Length; k++)
                    {
                        this.array3[k] = array1[k];
                    }

                    this.array3[k] = key;
                }
            }

            this.AddingHash(this.array3);
            string string1 = string.Empty;
            for (int i = 0; i < this.array3.Length; i++)
            {
                string1 += this.array3[i] + " ";
            }

            try
            {
                string1 = string1.TrimEnd(string1[string1.Length - 1]);
                File.WriteAllText(this.filename, string1);
            }
            catch (FileNotFoundException ex)
            {
                Console.Write(ex.ToString());
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Adding into the hash.
        /// </summary>
        /// <param name="array1">The array1.</param>
        /// <returns>Dictionary of integer and linked list</returns>
        private Dictionary<int, LinkedList<int>> AddingHash(int[] array1)
        {
            Dictionary<int, LinkedList<int>> hash = new Dictionary<int, LinkedList<int>>();
            LinkedList<int> linkedlist = null;
            for (int j = 0; j <= 10; j++)
            {
                hash.Add(j, new LinkedList<int>());
            }

            for (int k = 0; k < array1.Length; k++)
            {
                int key = array1[k] % 11;
                foreach (KeyValuePair<int, LinkedList<int>> item in hash)
                {
                    if (item.Key == key)
                    {
                        linkedlist = item.Value;
                        linkedlist.AddFirst(array1[k]);
                    }
                }
            }

            foreach (KeyValuePair<int, LinkedList<int>> item in hash)
            {
                LinkedList<int> linkedlist1 = new LinkedList<int>();
                linkedlist1 = linkedlist;
                linkedlist1 = item.Value;
                Console.WriteLine("key " + item.Key);
                Console.Write("Value: ");
                foreach (int number in linkedlist1)
                {
                    if (number != 0)
                    {
                        Console.Write(number + " ");
                    }
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine();
            return hash;
        }
    }
}