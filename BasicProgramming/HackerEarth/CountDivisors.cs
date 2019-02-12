using System;

namespace BasicProgramming
{
    public class CountDivisors
    {
        public void FindDivisors()
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            int output = 0;
            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                output += i % numbers[2] == 0 ? 1 : 0;
            }

            Console.WriteLine(output);
        }
    }
}