//-----------------------------------------------------------------------
// <copyright file="BalancedParentheses.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;

    /// <summary>
    /// this class is used to check equal number of parentheses in an Arithmetic expression
    /// </summary>
    public class BalancedParentheses
    {
        /// <summary>
        /// Checking the balanced parentheses.
        /// </summary>
        public void CheckingBalancedParentheses()
        {
            try
            {
                ////the stack object is created here
                Stack stack = new Stack();
                Console.WriteLine("enter the Arithmetic Expression");
                ////this string variable is used to store the arithematic expression
                string arithmeticExpression = Console.ReadLine();
                ////this loop is used to check each and every character in a string
                for (int index = 0; index <= arithmeticExpression.Length - 1; index++)
                {
                    ////if condtion is used to check whether the given character is matching the ')'
                    if (arithmeticExpression[index] == '(')
                    {
                        stack.Push(arithmeticExpression[index]);
                    }
                    else if (arithmeticExpression[index] == ')')
                    {
                        stack.Pop();
                    }
                }

                ////this condition is used to check whether the stack is empty or not
                if (stack.Count == 0)
                {
                    Console.WriteLine("Arithmetic Expression is balanced");
                }
                else
                {
                    Console.WriteLine("Arithmetic Expression is not balanced");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("invalid arithematic expression");
                this.CheckingBalancedParentheses();
            }
        }
    }
}
