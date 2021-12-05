using System;
using System.Collections.Generic;

namespace algorithmsC8
{
    public class CustomHashSet
    {
        public static List<int> fingMissingElements(int[] first, int[] second)
        {
            List<int> missingElements = new List<int>();
            HashSet<int> secondArrayItems = new HashSet<int>();

            foreach (int item in second)
            {
                secondArrayItems.Add(item);
            }

            foreach (int item in first)
            {
                if (!secondArrayItems.Contains(item))
                {
                    missingElements.Add(item);
                }
            }

            return missingElements;
        }
        public static void supposedFx3()
        {
            // HashSet<string> productCodes = new HashSet<string>();
            // productCodes.Add("8F26B");
            // productCodes.Add("0A43P");
            // productCodes.Add("J2H762");

            // productCodes.Contains("48DB9");
            // productCodes.Contains("J2H762");

            fingMissingElements(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 6, 2, 6, 7, 9 }).ForEach(Console.WriteLine);
        }

    }
}