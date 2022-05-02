using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace BasicProgramming
{
    public class PalindromicString
    {
        public void Check()
        {    //01234
            // abcba

            // abccba
            string str = Console.ReadLine();

            Console.WriteLine(IsPalindrome(str) ? "YES" : "NO");
            //string str = Console.ReadLine();
            //int len = str.Length;
            //for (int i = 0; i < (len / 2) + 1; i++)
            //{
            //    if (i == len / 2)
            //    {
            //        Console.WriteLine("YES");
            //        break;
            //    }
            //    else if (str[i] == str[len - i - 1])
            //    {
            //        //Do Nothing
            //    }
            //    else
            //    {
            //        Console.WriteLine("NO");
            //        break;
            //    }
            //}
        }
        public bool IsPalindrome(string str)
        {
            //int len = str.Length;
            //bool flag = false;

            //for (int i = 0; i < (len / 2) + 1; i++)
            //{
            //    flag = str[i] == str[len - 1 - i];
            //    if (!flag)
            //        break;
            //}
            //return flag;
            string first = str.Substring(0, str.Length / 2);
            char[] arr = str.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }

        public void DeterminePalindromes()
        {
            int[] palindromeCount = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), Convert.ToInt32);
            Dictionary<long, string> myDic = new Dictionary<long, string>();
            Dictionary<long, int> myDicPa = new Dictionary<long, int>();
            List<int> lstoutput = new List<int>();
            long output = 0;
            //OrderedDictionary mydic = new OrderedDictionary();
            for (long i = 0; i < palindromeCount[0]; i++)
            {
                myDic.Add(i, Console.ReadLine());
                myDicPa.Add(i, IsPalindrome(myDic[i]) ? 1 :0);
            }
            for (int i = 0; i < palindromeCount[1]; i++)
            {
                string[] operations = Console.ReadLine().Split(' ');
                long indexA = Convert.ToInt64(operations[1]) ^ output;
                long indexB = Convert.ToInt64(operations[2]) ^ output;
                output = 0;
                switch (operations[0])
                {
                    case "1":
                        myDic[indexA - 1] += myDic[indexB - 1];
                        myDic[indexB - 1] = null;
                        myDicPa[indexA - 1] = IsPalindrome(myDic[indexA - 1]) ? 1 :0;
                        myDicPa[indexB - 1] = 0;
                        break;
                    case "2":
                        if (myDic[indexA - 1].Length - indexB > -1)
                        {
                            myDic[indexA - 1] = myDic[indexA - 1].Insert(Convert.ToInt32(indexB) - 1, operations[3].ToString());
                            myDicPa[indexA - 1] = IsPalindrome(myDic[indexA - 1]) ? 1: 0;
                        }
                        else if(myDic[indexA - 1].Length - indexB == -1)
                        {
                            myDic[indexA - 1] += operations[3].ToString();
                            myDicPa[indexA - 1] = IsPalindrome(myDic[indexA - 1]) ? 1 : 0;
                        }
                        break;
                    default:
                        break;
                }
                myDicPa.Sum(a => output += a.Value);
                Console.WriteLine(output);
                //lstoutput.Add(output);
            }
            lstoutput.ForEach(a=>Console.Write("{0}\n", a));
        }
        
        public void PalindromeEverywhere()
        {
            String a = Console.ReadLine();
            char[] b = Console.ReadLine().ToCharArray();

            int n = a.Length - 1;
            int m = b.Length - 1;
            int[] maxPsa = new int[n + 1];
            int[] maxPsb = new int[m + 1];
            int ans = 1;
            localPalin(maxPsa, ref ans, a, n);
            Array.Reverse(b);
            localPalin(maxPsb, ref ans, b, m);
            a += new String(b);
            int[,] lcp = new int[n + m + 3, n + m + 3];
            for (int j = n + m + 1; j >= 0; j--)
            {
                for (int i = j; i >= 0; i--)
                {
                    if (a[i] == a[j])
                    {
                        lcp[i, j] = lcp[i + 1, j + 1] + 1;
                    }
                }
            }
            for (int j = n + m + 1; j > n; j--)
            {
                for (int i = n; i >= 0; i--)
                {
                    if (i + lcp[i, j] > n)
                    {
                        int cur = 2 * (n - i + 1);
                        if (j + lcp[i, j] > n + m + 1)
                        {
                            ans = Max(ans, cur);
                        }
                        else
                        {
                            ans = Max(ans, cur + maxPsb[j - n - 1 + lcp[i, j]]);
                        }
                    }
                    else
                    {
                        int cur = 2 * lcp[i, j];
                        if (j + lcp[i, j] > n + m + 1)
                        {
                            ans = Max(ans, cur + maxPsa[i + lcp[i, j]]);
                        }
                        else
                        {
                            ans = Max(ans, cur + Max(maxPsa[i + lcp[i, j]], maxPsb[j - n - 1 + lcp[i, j]]));
                        }
                    }
                }
            }

            Console.WriteLine(ans);
        }
        void localPalin(int[] dp, ref int ans, String a, int n)
        {
            localPalin(dp, ref ans, a.ToCharArray(), n);
        }

        void localPalin(int[] dp, ref int ans, char[] a, int n)
        {
            bool[,] isPal = new bool[n + 3, n + 3];
            for (int j = 0; j <= n; j++)
            {
                isPal[j + 1, j + 1] = isPal[j + 2, j + 1] = true;
                for (int i = j - 1; i >= 0; i--)
                {
                    isPal[i + 1, j + 1] = a[i] == a[j] && isPal[i + 2, j];
                    if (isPal[i + 1, j + 1])
                    {
                        ans = Max(ans, j - i + 1);
                    }
                }
            }

            for (int i = 1; i <= n + 1; i++)
            {
                for (int j = i; j <= n + 1; j++)
                {
                    if (isPal[i, j])
                    {
                        dp[i - 1] = Max(dp[i - 1], j - i + 1);
                    }
                }
            }

        }


        int Max(params int[] data)
        {
            return data.ToArray().Max();
        }

        int Min(params int[] data)
        {
            return data.ToArray().Min();
        }
    }
}