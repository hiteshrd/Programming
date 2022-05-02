using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.HackerEarth
{
    public class TwoStrings
    {
        public void CheckTwoStrings()
        {
            int testCaseCount = 0;
            List<bool> output = new List<bool>();
            if(int.TryParse(Console.ReadLine(), out testCaseCount))
            {
                for (int j = 0; j < testCaseCount; j++)
                {
                    bool areEqual = true;
                    string[] arrTwoStrings = Console.ReadLine().Split(' ');
                    char[] arrstr1 = arrTwoStrings[0].ToCharArray();
                    char[] arrstr2 = arrTwoStrings[1].ToCharArray();
                    Array.Sort(arrstr1);
                    Array.Sort(arrstr2);
                    for (int i = 0; i < arrstr1.Length; i++)
                    {
                        if (arrstr1[i] != arrstr2[i])
                        {
                            areEqual = false;
                            break;
                        }
                    }
                    output.Add(areEqual);
                }
                output.ForEach(a=> Console.WriteLine(a ? "YES" : "NO"));
            }
        }
    }
}
