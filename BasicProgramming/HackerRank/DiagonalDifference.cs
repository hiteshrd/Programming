using System;

namespace BasicProgramming
{
    public class DiagonalDifference
    {
        public void FindDiagonalDifference()
        {


            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int diagonalSumLR = 0, diagonalSumRL = 0;
            for (var index = 0; index < arr.Length; index++)
            {
                diagonalSumLR += arr[index][index];
                diagonalSumRL += arr[index][arr.Length - index - 1];
            }

            Console.WriteLine(Math.Abs(diagonalSumLR - diagonalSumRL));
        }
    }
}