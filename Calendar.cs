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
            if ((month == 2) && (year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                days[1] = 29;
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
            Console.WriteLine("sun mon tue wed thr fri sat  ");
            for (int i = 0; i < calander.GetLength(1); i++)
            {
                Console.Write(" " + calander[0, i] + "  ");
            }
            Console.WriteLine();
            for (int i = 1; i < calander.GetLength(0); i++)
            {
                for (int j = 0; j < calander.GetLength(1); j++)
                {
                    if (calander[i, j] <= 9)
                    {
                        Console.Write(" " + calander[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write(calander[i, j] + "  ");
                    }
                }
                Console.WriteLine();
            }
        }

       
    }
}
