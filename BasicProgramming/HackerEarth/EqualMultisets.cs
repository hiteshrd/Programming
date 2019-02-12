using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicProgramming
{
    public class EqualMultisets
    {
        public void DetermineMinimumMovesToEqualMultisets()
        {

            int arraySize;
            long movesCount = 0;
            long modNumber = Convert.ToInt64(Math.Pow(10, 9) + 7);
            int.TryParse(Console.ReadLine(), out arraySize);
            //string[] arrA = Console.ReadLine()?.Split(' ');
            //string[] arrB = Console.ReadLine()?.Split(' ');
            string strA = Console.ReadLine();
            string strB = Console.ReadLine();
            if (!string.IsNullOrEmpty(strA) && !string.IsNullOrEmpty(strB))
            {
                long[] arrA = Array.ConvertAll<string, long>(strA.Split(' '), Convert.ToInt64);
                long[] arrB = Array.ConvertAll<string, long>(strB.Split(' '), Convert.ToInt64);
                if (arraySize == arrA.Length && arraySize == arrB.Length)
                {
                    Array.Sort(arrA);
                    Array.Sort(arrB);
                    for (int i = 0; i < arraySize; i++)
                    {
                        movesCount += Math.Abs(arrA[i] - arrB[i]);
                        movesCount = movesCount % modNumber;
                    }
                }
            }
            Console.WriteLine(movesCount % modNumber);
        }
    }
}


 //Old Code
        
 //           int arraySize;
 //           long movesCount = 0;
 //           long modNumber = Convert.ToInt64(Math.Pow(10, 9) + 7);
 //           int.TryParse(Console.ReadLine(), out arraySize);
 //           //string[] arrA = Console.ReadLine()?.Split(' ');
 //           //string[] arrB = Console.ReadLine()?.Split(' ');
 //           string strA = Console.ReadLine();
 //           string strB = Console.ReadLine();
 //           if (!string.IsNullOrEmpty(strA) && !string.IsNullOrEmpty(strB))
 //           {
 //               long[] arrA = Array.ConvertAll<string, long>(strA.Split(' '), Convert.ToInt64);
 //               long[] arrB = Array.ConvertAll<string, long>(strB.Split(' '), Convert.ToInt64);
 //               if (arraySize == arrA.Length && arraySize == arrB.Length)
 //               {
 //                   Array.Sort(arrA);
 //                   Array.Sort(arrB);
 //                   for (int i = 0; i < arraySize; i++)
 //                   {
 //                       movesCount += Math.Abs(arrA[i] - arrB[i]);
 //                       movesCount = movesCount % modNumber;
 //                   }
 //               }
 //           }
 //           Console.WriteLine(movesCount % modNumber);

