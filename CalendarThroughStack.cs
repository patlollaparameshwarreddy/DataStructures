using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class CalendarThroughStack
    {
        public void ImplementingCalendarThroughStack()
        {
            Stack stack = new Stack();
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            stack.Push(queue);
            Console.WriteLine(stack.Pop());
        }
    }
}
