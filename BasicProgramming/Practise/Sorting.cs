using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.Practise
{
    public class Sorting
    {
        public void InsertionSort()
        {
            Console.WriteLine("****************************Insertion Sort****************************");
            Console.WriteLine("Input Array Length");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Array separator");
            char sep = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Input Array values to be sorted");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(sep), a => Convert.ToInt32(a));
            for(int i = 1; i<N; i++)
            {
                if (arr[i] >= arr[i - 1])
                    continue;
                int j = i - 1;
                int temp = arr[i];
                arr[i] = arr[j];
                while (j >0 && temp < arr[j-1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = temp;
            }
            arr.ToList().ForEach(a => Console.Write("{0} ", a));
        }
    }
}
