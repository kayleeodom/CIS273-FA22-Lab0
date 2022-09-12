namespace MergeArrays
{

    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            /* create an empty list
            for loop for both array (foreach)
                    for num in array eppend to the empty list
                        then convert back to array*/
            //return new int[10];
            List<int> combinedlist = new List<int>();

            foreach (int number in array1)
            {
                combinedlist.Add(number);
                combinedlist.Sort();
            //return combinedlist.ToArray();
            }

            foreach (int number in array2)
            {
                combinedlist.Add(number);
                combinedlist.Sort();
            //return combinedlist.ToArray();
            }

            int[] combinedArray = combinedlist.ToArray();
            return combinedArray;
        }
    }

}