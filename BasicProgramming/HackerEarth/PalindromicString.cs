using System;

namespace BasicProgramming
{
    public class PalindromicString
    {
        public void Check()
        {    //01234
            // abcba

            // abccba
            string str = Console.ReadLine();
            int len = str.Length; 
            bool flag = false;
                for (int i = 0; i < (len / 2) + 1; i++)
                {
                    flag = str[i] == str[len - 1 - i];
                }

            Console.WriteLine(flag ? "YES" : "NO");
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
    }
}