using System;
using System.Linq;

namespace BasicProgramming
{
    public class Subarrays
    {
        public void MaximizeCost()
        {
            double output = 1;
            int arraySize = Convert.ToInt32(Console.ReadLine());
            var arrayValues = Console.ReadLine();
            if (arrayValues != null)
            {
                long[] arr = Array.ConvertAll<string, long>(arrayValues.Split(' '), Convert.ToInt64);
                long[] arrSorted = arr;
                Array.Sort(arrSorted);
                int index = Array.BinarySearch(arr, arr[0]);
                if (index < 0)
                {
                    index = Math.Abs(index + 2);
                }
                //Array.ForEach(arr, delegate (int i) { output += i; });
                for (int counter = index; counter < arr.Length; counter++)

                    output += arr[counter];


                Console.WriteLine(output + " 1");
            }
        }
    }
}