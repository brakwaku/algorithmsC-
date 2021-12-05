using System;
using System.Collections.Generic;

namespace algorithmsCSharp
{
    /***************************************************************
        * LINKEDLIST
        * LinkedList<string> listy = new LinkedList<string>();
        *    
        *    listy.AddLast("Mike");              // Add data to back => AddLast  Add data to front => AddFirst
        *    listy.AddLast("Kate");
        *    listy.AddLast("Jake");
        *    listy.AddLast("Myck");
        *    listy.AddLast("Ben");
        *
        *    Console.WriteLine(listy.Contains("Jake"));
        *    Console.WriteLine(listy.Count);
        *
        *    listy.RemoveFirst();
        *
        *    foreach(string item in listy) {
        *        Console.Write(item + "->");
        *    }
        ***************************************************************/

    // class CustomLinkedList {
    //     Node head;

    //     public class Node {
    //         public int data;
    //         public Node next;

    //         public Node(int d) { data = d; }
    //     }

    // }
    public class CustomLinkedList
    {
        public Node head;           // Added "public" to make it accessible in the other class file

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d) { data = d; }
        }

        public void displayContent()
        {
            Node current = head;

            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }
        }

        public Boolean hasCycle()
        {
            HashSet<Node> nodes = new HashSet<Node>();

            Node current = head;
            while (current != null)
            {
                if (nodes.Contains(current))
                {
                    return true;
                }
                else
                {
                    nodes.Add(current);
                }

                current = current.next;
            }
            return false;
        }

        public void deleteBackHalf()
        {
            // Do this check to avoid error of trying to get next property of prev.
            if (head == null || head.next == null) { head = null; }

            Node slow = head;
            Node fast = head;
            Node prev = null;

            while (fast != null && fast.next != null)
            {
                prev = slow;                // Will be used to get node before middle node
                slow = slow.next;           // Increment this by 1
                fast = fast.next.next;      // Increment this twice as much || If fast is at last Node, slow is in middle of list
            }

            prev.next = null;
        }

        public void deleteKthNodeFromEnd(int k)
        {
            // Do this check to avoid error of trying to get next property of prev.
            if (head == null || k == 0) { return; }

            // [a, b, c, d]
            // k = 2
            Node first = head;
            Node second = head;

            for (int i = 0; i < k; i++)
            {
                second = second.next;
                if (second.next == null)
                {
                    // k >= Length of list
                    if (i == k - 1)
                    {
                        head = head.next;
                    }
                    return;
                }
            }

            // After incrementation:
            // second = c
            // This is the second node from the head of the list

            while (second.next != null)
            {
                first = first.next;
                second = second.next;
            }
            // To find the kth node from the end of the list, increament both trackers at the same time
            // until second tracker reaches the last element.In this case, its a single iteration.

            // first = b
            // second = d

            // The element we want to remove is "c". With the trckers, it is first.next
            // [a, b, c, d]
            // k = 2
            // Remove "c" by skipping over it

            first.next = first.next.next;
        }

        public static void supposedFx3()
        {
            CustomLinkedList noCycleLinkedList = new CustomLinkedList();
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);
            Node fifthNode = new Node(7);
        }
    }
}