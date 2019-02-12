using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicProgramming
{
    public class CompareTriplets
    {
        public void FindRank()
        {

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = new List<int>();
            result.Add(0);
            result.Add(0);
            if (a.Count == b.Count)
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] > b[i])
                    {
                        result[0]++;
                    }
                    else if (a[i] < b[i])
                    {
                        result[1]++;
                    }
                }
            }
            result.ForEach(i => Console.Write("{0}\t", i));
        }
    }
}