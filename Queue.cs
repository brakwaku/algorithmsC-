using System;
using System.Collections.Generic;

namespace algorithmsC5
{
    public class CustomQueue
    {
        // BUILT IN DATA STRUCTION
        // FIFO => First In First Out
        public static void supposedFx()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(8);
            queue.Enqueue(20);
            queue.Enqueue(23);

            int removedItem = queue.Dequeue();
            Console.WriteLine(removedItem);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());

            int current;
            while (queue.TryDequeue(out current))
            {
                Console.WriteLine(current);
            }
        }

        // Print binary number representations from 1 to the number.
        public static void printBinary(int n)
        {
            if (n <= 0)
            {
                return;
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            for(int i = 0; i < n; i++)
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);
                queue.Enqueue(current * 10);
                queue.Enqueue(current * 10 + 1);
            }

            Console.WriteLine();
        }


    }
}