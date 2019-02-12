using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicProgramming
{
    public class ShiftLetters
    {
        public void GetminimumSteps()
        {
            var myDic = new Dictionary<char, int>()
            {
                {'a',1},
                {'b',2},
                {'c',3},
                {'d',4},
                {'e',5},
                {'f',6},
                {'g',7},
                {'h',8},
                {'i',9},
                {'j',10},
                {'k',11},
                {'l',12},
                {'m',13},
                {'n',14},
                {'o',15},
                {'p',16},
                {'q',17},
                {'r',18},
                {'s',19},
                {'t',20},
                {'u',21},
                {'v',22},
                {'w',23},
                {'x',24},
                {'y',25},
                {'z',26}
            };
            int myint;
            int moves = 0;
            var arrChar = Console.ReadLine()?.ToCharArray();
            int.TryParse(Console.ReadLine(), out myint);
            if (arrChar != null && arrChar.Length > 0)
            {
                var arrCharDis = arrChar.Distinct().ToArray();
                //var arr = new char[arrChar.Length];
                var lst = new List<int>();
                var lstDiff = new List<int>();
                Array.Sort(arrChar);
                Array.Sort(arrCharDis);
                var lstdistinctchar = arrCharDis.ToList();
                int tempmyint = myint;
                for (var index = arrChar.Length - 1; index >=0; index--)
                {
                    if (tempmyint > 0 && lstdistinctchar.Contains(arrChar[index]))
                    {
                        lstdistinctchar.Remove(arrChar[index]);
                        tempmyint--;
                    }
                    else
                    {
                        lst.Add(myDic[arrChar[index]]);
                    }
                    //if(!arrCharDis.Contains(arrChar[index]))
                }
                
                var arr = lst.ToArray();
                Array.Sort(arr);
                for (int i = 0; i < arr.Length; i++)
                {
                    moves += Math.Abs(arr[i] - arr[0]);
                }
                Console.WriteLine(moves);
            }
        }
    }
}