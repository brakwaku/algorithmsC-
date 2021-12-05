using System.Collections;

namespace algorithmsC1
{
    public class CustomReverseArray
    {
        /***************************************************************
        * Reverse Arrays
        ***************************************************************/
        public static int[] ReverseArray(int[] arr1)
        {
            ArrayList result = new ArrayList();

            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                result.Add(arr1[i]);
            }
            return (int[])result.ToArray(typeof(int));
        }

        public static int[] ReverseArray2(int[] arr1)
        {
            int[] reversed = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                reversed[i] = arr1[arr1.Length - i - 1];
            }
            return reversed;
        }

        public static int[] ReverseInPlace(int[] input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                // Swap index(i) with index(input.Length - i - 1)
                int temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
            return input;
        }

        public static void RotateInPlaceLeft(int[] input)
        {
            int temp = input[0];
            for (int i = 0; i < input.Length - 1; i++)
            {
                input[i] = input[i + 1];
            }

            input[input.Length - 1] = temp;
        }

        public static void RotateInPlaceLeftNTimes(int[] input, int d)
        {
            int counter = 0;
            for(int j= 0; j< d; j++) // ! Could be optimized to perform beteer (Time complexity)
            {
                int temp = input[0];
                for (int i = 0; i < input.Length - 1; i++)
                {
                    input[i] = input[i + 1];
                }

                input[input.Length - 1] = temp;
                counter++;
            }
        }

        static void RotateInPlaceRight(int[] input)
        {
            int temp = input[input.Length - 1];
            for (int i = input.Length - 1; i > 0; i--)
            {
                input[i] = input[i - 1];
            }

            input[0] = temp;
        }
    }
}