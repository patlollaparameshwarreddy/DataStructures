using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class CalanderThroughQueue
    {
        public void CalanderInQueue()
        {
            Queue mainQueue = new Queue();
            Queue subQueue = new Queue();
            Utility utility = new Utility();
            Console.WriteLine("enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter month");
            int month = Convert.ToInt32(Console.ReadLine());
            int[,] calander = new int[6, 7];
            string[] months = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int startDate = utility.DayOfWeek(year, month);
            if ((month == 2) && (year % 4 == 0))
            {
                days[2] = 29;
            }
            int date = 01;
            //Console.WriteLine(startDate);
            for (int i = startDate; i < 7; i++)
            {
                subQueue.Enqueue(date);
                date++;
            }
            mainQueue.Enqueue(subQueue);
            subQueue = new Queue();
            for (int i = 0; i < 7; i++)
            {
                subQueue.Enqueue(date);
                date++;
            }
            foreach(int values in subQueue)
            {
                Console.WriteLine(values);
            }
            mainQueue.Enqueue(subQueue);
            Console.WriteLine(mainQueue.Count +"ffghfg");
            for (int j = 0; j <= mainQueue.Count; j++)
            {
                Queue obj = (Queue)mainQueue.Dequeue();
                foreach (int values in obj)
                {
                    Console.WriteLine(values);
                }


            }
        }
    }
}
