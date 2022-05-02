using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.Codility
{
    public class SampleTest
    {
        public void MsSampleTest()
        {
            Console.WriteLine("Starting Sample Test Execution");
            Console.WriteLine("input array");
            string arr = Console.ReadLine();
            int[] A = Array.ConvertAll<string, int>(arr.Split(' '), Convert.ToInt32);
            Array.Sort(A);
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int output = 1;
            bool found = false;
            Array.Sort(A);
            while (!found)
            {
                //for (int i= 0; i< A.Length; i++)
                //{

                // }
                if (!A.Contains(output))
                {
                    found = true;
                    break;
                }
                output++;
            }
            Console.Write("Answer {0}}", output);

        }
        public void Iteration()
        {
            Console.WriteLine("input number");
            string arr = Console.ReadLine();
            int N = Convert.ToInt32(arr);
            string binaryNo = Convert.ToString(N, 2);
            string[] arrBinary = binaryNo.Split('1');
            int binaryGap = 0;
            int i = binaryNo.StartsWith("1") ? 0 : 1;
            int len = binaryNo.EndsWith("1") ? arrBinary.Length : arrBinary.Length - 1;
            for (i = 0; i < len && arrBinary.Length > 2; i++)
            {
                int val = arrBinary[i].Length;
                if (binaryGap < val)
                    binaryGap = val;
            }
            Console.WriteLine(binaryGap);
        }

        /// <summary>
        /// A non-empty array A consisting of N integers is given. The consecutive elements of array A represent consecutive cars on a road.

        //        Array A contains only 0s and/or 1s:

        //0 represents a car traveling east,
        //1 represents a car traveling west.
        //The goal is to count passing cars.We say that a pair of cars (P, Q), where 0 ≤ P<Q<N, is passing when P is traveling to the east and Q is traveling to the west.

        //For example, consider array A such that:

        //  A[0] = 0
        //  A[1] = 1
        //  A[2] = 0
        //  A[3] = 1
        //  A[4] = 1
        //We have five pairs of passing cars: (0, 1), (0, 3), (0, 4), (2, 3), (2, 4).

        //Write a function:

        //class Solution { public int solution(int[] A); }

        //        that, given a non-empty array A of N integers, returns the number of pairs of passing cars.

        //        The function should return −1 if the number of pairs of passing cars exceeds 1,000,000,000.

        //For example, given:

        //  A[0] = 0
        //  A[1] = 1
        //  A[2] = 0
        //  A[3] = 1
        //  A[4] = 1
        //the function should return 5, as explained above.

        //Write an efficient algorithm for the following assumptions:

        //N is an integer within the range[1..100, 000];
        //        each element of array A is an integer that can have one of the following values: 0, 1.
        /// </summary>
        public void PassingCars()
        {
            int[] A;
            int output = 0;
            int pairCount = 0;
            int totalOnes = A.Where(a => a == 1).Count();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    //int[] temp = 
                    pairCount += totalOnes;
                    if (pairCount > 1000000000)
                    {
                        output = - 1;
                    }
                }
                else
                {
                    totalOnes--;
                }
            }
            output = pairCount;
        }

        /// <summary>
        /// An array A consisting of N integers is given. The dominator of array A is the value that occurs in more than half of the elements of A.

        //        For example, consider array A such that

        // A[0] = 3    A[1] = 4    A[2] =  3
        // A[3] = 2    A[4] = 3    A[5] = -1
        // A[6] = 3    A[7] = 3
        //The dominator of A is 3 because it occurs in 5 out of 8 elements of A(namely in those with indices 0, 2, 4, 6 and 7) and 5 is more than a half of 8.

        //Write a function

        //class Solution { public int solution(int[] A); }

        //        that, given an array A consisting of N integers, returns index of any element of array A in which the dominator of A occurs.The function should return −1 if array A does not have a dominator.

        //        For example, given array A such that

        //         A[0] = 3    A[1] = 4    A[2] = 3
        
        //         A[3] = 2    A[4] = 3    A[5] = -1
        
        //         A[6] = 3    A[7] = 3
        //        the function may return 0, 2, 4, 6 or 7, as explained above.


        //        Write an efficient algorithm for the following assumptions:


        //        N is an integer within the range[0..100, 000];
        //        each element of array A is an integer within the range[−2, 147, 483, 648..2, 147, 483, 647].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Domintor(int[] A)
        {
                // write your code in C# 6.0 with .NET 4.5 (Mono)
                int N = A.Length;
                int[] dist = A.Distinct().ToArray();
                int mid = A.Length / 2;
                int num = 0;
                for (int i = 0; i < dist.Length; i++)
                {
                    if (A.Where(a => a == dist[i]).Count() > mid)
                    {
                        num = dist[i];
                        break;
                    }
                }
                if (num == 0)
                    return -1;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == num)
                        return i;
                }
                return -1;

    }
    }
}
