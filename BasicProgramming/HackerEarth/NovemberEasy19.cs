using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.HackerEarth
{
    public class NovemberEasy19
    {
        public void ExchangingMoney()
        {
            int[] NQ = Array.ConvertAll(Console.ReadLine().Split(' '), a => Convert.ToInt32(a));
            long[] A = Array.ConvertAll(Console.ReadLine().Split(' '), a => Convert.ToInt64(a));
            Array.Sort(A);
            for (int i = 0; i < NQ[1]; i++)
            {
                long p = Convert.ToInt64(Console.ReadLine());
                
            }
        }
        public void DeterminingNumbers()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), a => Convert.ToInt32(a));
            Dictionary<int, bool> myDic = new Dictionary<int, bool>();
            foreach (var item in arr)
            {
                if(myDic.TryGetValue(item, out bool val))
                {
                    myDic[item] = true;
                    myDic.Keys.Where(a => myDic[a] > 0);
                }
                else
                {
                    myDic[item] = false;
                }
            }
            myDic.Where(a => a.Value == false).Select(a => a.Key).ToList().ForEach(a => Console.Write("{0} ", a));
            Console.WriteLine();
        }
    }
}
