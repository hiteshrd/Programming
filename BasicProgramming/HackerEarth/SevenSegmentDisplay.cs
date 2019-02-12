using System;
using System.Linq;
using System.Collections.Generic;
namespace BasicProgramming
{
    public class SevenSegmentDisplay
    {
        public void ProcessSevenSegmentDisplay()
        {
            Dictionary<short, short> myDic = new Dictionary<short, short>()
            {
                {0,6 },{1,2},{2,5}, {3,5}, {4, 4},{5,5}, {6, 6}, {7,3}, {8, 7}, {9,6}
            };
            List<string> lstOutput = new List<string>();
            short countTestCase = Convert.ToInt16(Console.ReadLine());
            for (short i = 0; i < countTestCase; i++)
            {
                string number = Console.ReadLine();
                short lstOutputMatchsticks = 0;
                if (!String.IsNullOrEmpty(number))
                {
                    for (short j = 0; j < number.Length; j++)
                    {
                        if (myDic.TryGetValue(Convert.ToInt16(number.Substring(j,1)), out short myval))
                            lstOutputMatchsticks += myval;
                    }
                    if (lstOutputMatchsticks % 2 == 0)
                    {
                        //number of matchsticks is even.
                        lstOutput.Add(new String('1', lstOutputMatchsticks / 2));
                    }
                    else
                    {
                        //number of matchsticks is old.
                        lstOutput.Add("7" + new String('1', (lstOutputMatchsticks / 2) - 1));
                    }
                }
            }
            lstOutput.ForEach(i => Console.Write("{0}\n", i));
        }
        
    }
}