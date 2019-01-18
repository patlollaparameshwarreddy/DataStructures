//-----------------------------------------------------------------------
// <copyright file="BinarySearchTree.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// this class is used to find the number of binary search tress with N nodes
    /// </summary>
    public class BinarySearchTree
    {
        /// <summary>
        /// Numbers the  binary search trees.
        /// </summary>
        public void NumberOfBinarySearchTrees()
        {
            ////creating object of utility class
            Utility utility = new Utility();
            Console.WriteLine("enter number of nodes");
            long nodes = 0;
            try
            {
                ////this is used to take the input from the console
                 nodes = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("enter positive integers");
            }

            ////this is used to store the result that is getting from the method NumberOfBTSwithNnodes
            long numberOfBtsWithNNodes = utility.NumberOfBTSwithNnodes(nodes);
            Console.WriteLine("number of binary search trees that can be formed using " + nodes + " is " + numberOfBtsWithNNodes);
        }
    }
}
