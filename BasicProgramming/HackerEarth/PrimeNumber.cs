using System;
using System.Text;

namespace BasicProgramming
{
    public class PrimeNumber
    {
        public void GetPrimeNumberList()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 2; i < number; i++)
            {
                if (IsPrime(i))
                {
                    sb.Append(i + " ");
                }
            }

            Console.WriteLine(sb.ToString().Trim());

        }

        private bool IsPrime(int number)
        {
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

            for (int i = 2; i <= limit; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}