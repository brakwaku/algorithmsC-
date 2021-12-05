namespace algorithmsC4
{
    public class CustomLinearSearch
    {
        /***************************************************************
        * Linear Search
        *    int[] arr = {1, 2, 4, 5, 6, 8};
        *    int item = Array.Find(arr, element => element == 3);
        *    int[] items = Array.FindAll(arr, element => element >= 5);
        *    Array.ForEach(items, Console.WriteLine);
        ***************************************************************/
        public static int? LinearSearch(int[] input, int n) { //Add ? to return type to be able to return null
            foreach(int current in input) {
                if(n == current) {
                    return n;
                }
            }
            return null;
        }
    }
}