using System;
using System.Text;              // For the StringBuilder class

namespace algorithmsC3
{
    public class CustomReverseString
    {
        // Option 1
        public static String ReverseString(string input) {
            if(String.IsNullOrEmpty(input)) { return input; }

            StringBuilder reversed = new StringBuilder(input.Length);

            for(int i = input.Length - 1; i >= 0; i--) {
                reversed.Append(input[i]);
            }
            return reversed.ToString();
        }

        // Option 2
        public static String ReverseString2(string input) {
            if(String.IsNullOrEmpty(input)) { return input; }
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

        // Option 3
        public static String ReverseEachWord(string input) {
            if(String.IsNullOrEmpty(input)) { return input; }

            StringBuilder result = new StringBuilder();
            String[] arr = input.Split(" ");

            for(int i = 0; i < arr.Length; i++) {
                result.Append(ReverseString(arr[i]));
                if(i != arr.Length - 1) {
                    result.Append(" ");
                }
            }
            return result.ToString();
        }
    }
}