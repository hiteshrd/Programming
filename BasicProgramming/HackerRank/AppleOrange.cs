using System;
using System.Collections.Generic;

namespace BasicProgramming
{
    public class AppleOrange
    {
        public void FindCount()
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
                ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
                ;
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
        // Complete the countApplesAndOranges function below.
        void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            List<int> fruitCount = new List<int>{0,0};
            foreach (var apple in apples)
            {
                fruitCount[0] += apple + a >= s && apple + a <= t ? 1 : 0;
            }
            foreach (var orange in oranges)
            {
                fruitCount[1] += orange + b <= t && orange + b >= s ? 1 : 0;
            }
            fruitCount.ForEach(i => Console.Write("{0}\n", i));

        }
    }
}