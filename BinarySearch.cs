using System;

namespace algorithmsC2
{
    public class CustomBinarySearch
    {
        /***************************************************************
        * Binary Search (Assuming data is already sorted)
        * Array.BinarySearch(arr, 3);
        ***************************************************************/
        public static Boolean BinarySearch(int[] inputArray, int item) {
            int min = 0;                                            // Set minimum point
            int max = inputArray.Length - 1;                        // Set maximum point
            while(min <= max) {                                     // Continue searching array until min is >= max
                int mid = (min + max) / 2;                          // Set mid point
                if(item == inputArray[mid]) {                       // Check if the item is in the midddle
                    return true;
                } else if(item < inputArray[mid]) {                 // Check if item is less than middle
                    max = mid - 1;                                  // Set max to middle - 1 and search first half
                } else {
                    min = mid + 1;                                  // Set max to middle + 1 and search second half
                }
            }
            return false;
        }
    }
}