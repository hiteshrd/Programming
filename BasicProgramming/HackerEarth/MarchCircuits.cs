using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.HackerEarth
{
    public class MarchCircuits
    {
        public void DoesItDivide()
        {
            var tc = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {
                var N = Convert.ToInt64(Console.ReadLine());
                long prod = 1, sum = 0, tempSum;
                bool divisble = false;
                long j = 1;
                while (j <= N)
                {
                    sum += j;
                    j++;
                }

                tempSum = sum;
                List<long> divisors = new List<long>();
                //divisors = Factor(sum);
                //if()
                //while (sum % 2 == 0)
                //{
                //    n /= 2;
                //}

                //// n must be odd at this point. So we can 
                //// skip one element (Note i = i +2) 
                //for (long i = 3; i <= Math.Sqrt(n); i += 2)
                //{
                //    // While i divides n, print i and divide n 
                //    while (n % i == 0)
                //    {
                //        lst.Add(i);
                //        n /= i;
                //    }
                //}

                //// This condition is to handle the case whien 
                //// n is a prime number greater than 2 
                //if (n > 2)
                //    lst.Add(n);
                //j = 1;
                while (j <= N && divisors.Count > 0)
                {
                    if (divisors.Contains(j))
                    {
                        divisors.Remove(j);
                        if(divisors.Count == 0)
                            break;
                    }
                    j++;
                }
                Console.WriteLine(divisors.Count <= 0 ? "YES" : "NO");
            }
        }
        public List<long> Factor(long number)
        {
            List<long> factors = new List<long>();
            int max = (int)Math.Sqrt(number);  //round down
            for (long factor = 1; factor <= max; ++factor)
            { //test from 1 to the square root, or the int below it, inclusive.
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor)
                    { // Don't add the square root twice!  Thanks Jon
                        factors.Add(number / factor);
                    }
                }
            }
            return factors;
        }
        public List<long> primeFactors(long n)
        {
            List<long> lst = new List<long>();
            // Print the number of 2s that divide n 
            while (n % 2 == 0)
            {
                lst.Add(2);
                n /= 2;
            }

            // n must be odd at this point. So we can 
            // skip one element (Note i = i +2) 
            for (long i = 3; i <= Math.Sqrt(n); i += 2)
            {
                // While i divides n, print i and divide n 
                while (n % i == 0)
                {
                    lst.Add(i);
                    n /= i;
                }
            }

            // This condition is to handle the case whien 
            // n is a prime number greater than 2 
            if (n > 2)
                lst.Add(n);
            return lst;
        }
    }
}
