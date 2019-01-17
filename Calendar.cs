using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Calendar
    {
        public void FormationCalanderBasedOnYearAndMonth()
        {
            Utility utility = new Utility();
            Console.WriteLine("enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter month");
            int month = Convert.ToInt32(Console.ReadLine());
            int[,] calander = new int[6, 7];
            string[] months = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int StartDate = utility.DayOfWeek(year, month);
            if ((month == 2) && (year % 4 == 0))
            {
                days[2] = 29;
            }
            int date = 01;
            for (int i = StartDate; i < calander.GetLength(1); i++)
            {
                calander[0, i] = date;
                date++;
            }
            for (int i = 1; i < calander.GetLength(0); i++)
            {
                for (int j = 0; j < calander.GetLength(1); j++)
                {
                    if (date <= days[month])
                    {
                        calander[i, j] = date++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(months[month] + " " + year);
            Console.WriteLine("sun \tmon \ttue \twed \tthr \tfri \tsat");
            for (int i = 0; i < calander.GetLength(1); i++)
            {
                if (calander[0, i] > 0)
                {
                    Console.Write(calander[0, i] + "\t");
                }
                else
                {
                    Console.Write(" " + "\t");
                }
            }
            Console.WriteLine();
            for (int i = 1; i < calander.GetLength(0); i++)
            {
                for (int j = 0; j < calander.GetLength(1); j++)
                {
                    if (calander[i, j] > 0)
                    {
                        Console.Write(calander[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write(" " + "\t");
                    }
                }
                Console.WriteLine();
            }
        }

       
    }
}
