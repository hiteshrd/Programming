using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.HackerEarth
{
    public class EasyProblem
    {
        List<int> lstA;
        List<int> lstB;
        public void FindString()
        {
            int tc = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < tc; j++)
            {
                char[] arr = Console.ReadLine().ToCharArray();
                Array.Sort(arr);
                int max = 0, temp = 0;
                char c = '\u0000';
                Dictionary<char, int> mydic = new Dictionary<char, int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (c == arr[i])
                    {
                        temp++;
                        mydic[c] = temp;
                    }
                    else
                    {
                        temp = 1;
                        c = arr[i];
                        mydic.Add(c, temp);
                    }

                    max = temp > max ? temp : max;
                }

                Console.WriteLine(mydic.FirstOrDefault(a => a.Value == max).Key);
            }
        }

        public void Perm()
        {
            int tc = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < tc; j++)
            {
                lstA = new List<int>();
                lstB = new List<int>();
                //int[] abc = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), Convert.ToInt32);
                string[] abc = Console.ReadLine().Split(' ');
                if (abc[1].Length < Convert.ToInt32(abc[0]))
                {
                    abc[1] += new string('0', Convert.ToInt32(abc[0]) - abc[1].Length);
                }
                if (abc[2].Length < Convert.ToInt32(abc[0]))
                {
                    abc[2] += new string('0', Convert.ToInt32(abc[0]) - abc[2].Length);
                }
                char[] A = abc[1].ToCharArray();
                char[] B = abc[2].ToCharArray();
                GetPer(A, ref lstA);
                GetPer(B, ref lstB);
                bool yes = false;
                foreach (var t1 in lstA)
                {
                    yes = lstB.Any(t => t1 + t == Convert.ToInt32(abc[3]));
                    if (yes)
                    {
                        break;
                    }
                }
                Console.WriteLine(yes ? "YES" : "NO");
            }
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void GetPer(char[] list, ref List<int> lst)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x, ref lst);
        }

        private static void GetPer(char[] list, int k, int m, ref List<int> lst)
        {
            if (k == m)
            {
                //Console.Write(list);
                lst.Add(Convert.ToInt32(String.Concat(list)));
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m, ref lst);
                    Swap(ref list[k], ref list[i]);
                }
        }



        //public void Perm()
        //{
        //    int tc = Convert.ToInt32(Console.ReadLine());
        //    for (int j = 0; j < tc; j++)
        //    {
        //        //int[] abc = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), Convert.ToInt32);
        //        string[] abc = Console.ReadLine().Split(' ');
        //        Hashtable htA = new Hashtable();
        //        Hashtable htB = new Hashtable();
        //        //List<int> lstA = new List<int>();
        //        //List<int> lstB = new List<int>();
        //        if (abc[1].Length < Convert.ToInt32(abc[0]))
        //        {
        //            abc[1] += new String('0', Convert.ToInt32(abc[0]) - abc[1].Length);
        //        }
        //        if (abc[2].Length < Convert.ToInt32(abc[0]))
        //        {
        //            abc[2] += new String('0', Convert.ToInt32(abc[0]) - abc[2].Length);
        //        }
        //        char[] A = abc[1].ToCharArray();
        //        char[] B = abc[2].ToCharArray();
        //        GetPer(A, ref htA);
        //        GetPer(B, ref htB);
        //        bool yes = false;
        //        foreach (var t1 in htA.Values)
        //        {
        //            yes = htB.Values.OfType<int>().Any(a => a + Convert.ToInt32(t1) == Convert.ToInt32(abc[3]));
        //            if (yes)
        //            {
        //                break;
        //            }
        //        }
        //        Console.WriteLine(yes ? "YES" : "NO");
        //    }
        //}

        //private static void Swap(ref char a, ref char b)
        //{
        //    if (a == b) return;

        //    a ^= b;
        //    b ^= a;
        //    a ^= b;
        //}

        //public static void GetPer(char[] list, ref Hashtable ht)
        //{
        //    int x = list.Length - 1;
        //    GetPer(list, 0, x, ref ht);
        //}

        //private static void GetPer(char[] list, int k, int m, ref Hashtable ht)
        //{
        //    if (k == m)
        //    {
        //        //Console.Write(list);
        //        //lst.Add(Convert.ToInt32(String.Concat(list)));
        //        int val = Convert.ToInt32(String.Concat(list));
        //        ht.Add(ht.Count + 1, val);
        //    }
        //    else
        //        for (int i = k; i <= m; i++)
        //        {
        //            Swap(ref list[k], ref list[i]);
        //            GetPer(list, k + 1, m, ref ht);
        //            Swap(ref list[k], ref list[i]);
        //        }
        //}

        public void Fibonacci()
        {
            int tc = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < tc; x++)
            {
                long ans = 0;
                int N = Convert.ToInt32(Console.ReadLine());
                long[] arr = Array.ConvertAll<string, long>(Console.ReadLine().Split(' '), Convert.ToInt64);
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        for (int k = 0; k < arr.Length; k++)
                        {
                            ans += GetNthFibonacci_Item(arr[i] + arr[j] - arr[k]) % 1000000007;
                            ans = ans % 1000000007;
                        }
                    }
                }

                Console.WriteLine(ans);
            }
        }

        public static long GetNthFibonacci_Item(long n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            long number = n - 1; //Need to decrement by 1 since we are starting from 0  
            long[] Fib = new long[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (long i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
        }
        public static int GetNthFibonacci_Rec(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
                return GetNthFibonacci_Rec(n - 1) + GetNthFibonacci_Rec(n - 2);
        }
    }
}
