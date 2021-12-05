using System;
using System.Collections.Generic;

namespace algorithmsC6
{
    public class CustomStack
    {
        // BUILT IN DATA STRUCTION
        // LIFO => Last In First Out
        public static void supposedFx()
        {
            Stack<string> stack = new Stack<string>();

            Console.WriteLine("Start Main");
            stack.Push("Main");
            Console.WriteLine("Start ResponseBuilder");
            stack.Push("ResponseBuilder");
            Console.WriteLine("Start CallExternalService");
            stack.Push("CallExternalService");
            Console.WriteLine("End" + stack.Pop());
            Console.WriteLine("Start ParseExternalData");
            stack.Push("ParseExternalData");
            Console.WriteLine("End" + stack.Pop());
            Console.WriteLine("End" + stack.Pop());
            Console.WriteLine("End" + stack.Pop());
        }

        public static void printNextGreaterElement(int[] arr)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                int next = arr[i];
                if (stack.Count > 0)
                {
                    int popped = stack.Pop();

                    while (popped < next)
                    {
                        Console.WriteLine(popped + " --> " + next);
                        if (stack.Count == 0) { break; }
                        popped = stack.Pop();
                    }

                    if (popped > next) { stack.Push(popped); }
                }
                stack.Push(next);
            }

            while (stack.Count > 0) { Console.WriteLine(stack.Pop() + " --> " + -1); }
        }

        public static Boolean hasMatchingParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];

                if (current == '(')
                {
                    stack.Push(current);
                    continue;
                }

                if (current == ')')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        public static Boolean hasMatchingParentheses2(string s)
        {
            int matchingSymbolTracker = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];

                if (current == '(')
                {
                    matchingSymbolTracker++;
                    continue;
                }

                if (current == ')')
                {
                    if (matchingSymbolTracker > 0)
                    {
                        matchingSymbolTracker--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return matchingSymbolTracker == 0;
        }
    }
}