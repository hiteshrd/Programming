using System;
using System.Linq;

namespace BasicProgramming
{
    public class RepeatedString
    {
        public void FindRepeatedString()
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = 0;
            var arr = s.ToCharArray();

            if (n > arr.Length)
            {
                result += arr.LongCount(val => val == 'a');
                result *= n / arr.Length;
                for (int i = 0; i < n%arr.Length; i++)
                {
                    if (arr[i] == 'a')
                    {
                        result++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] == 'a')
                    {
                        result++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}