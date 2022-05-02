using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.HackerEarth
{
    public class OperationsOnArray
    {
        public void FindOperationsOnArray()
        {
            Hashtable ht = new Hashtable();
            int arrSize = Convert.ToInt32(Console.ReadLine());
            int midIndex = (arrSize / 2) + 1;
            long output = 0;
            long[] arr = Array.ConvertAll<string, long>(Console.ReadLine().Split(' '), Convert.ToInt64);
            //Array.Sort((arr));
//            arr.Min()
            output = arr.Sum() - arr.Min() * arrSize;
            //for (int i = 0; i < arrSize-1; i++)
            //{
            //    output += Math.Abs(arr[i+1] - arr[i]);
            //}
            Console.WriteLine(output);
        }
    }
}
