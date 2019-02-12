using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicProgramming
{
    public class Anagrams
    {
        public void GetNonAnagramsCount()
        {
            List<int> lstOutput = new List<int>();
            var countTestCase = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < countTestCase; i++)
            {
                string str1 = "gsadasfdashdasdkjgadhjdyjhasfdasgd";
                string str2 = "ajdfaghfsdasgdfagsdhgasdfasfdahd";
                var strB1 = new StringBuilder(str1);
                var strB2 = new StringBuilder(str2);
                Char[] number1 = str1.ToCharArray();
                Char[] number2 = str2.ToCharArray();
                if (number1 != null && number2 != null)
                {
                    var myDic1 = new Dictionary<int, char>();
                    var myDic2 = new Dictionary<int, char>();
                    for (int index = 0; index < number1.Length; index++)
                    {
                        if (strB2.ToString().Contains(number1[index]))
                        {
                            strB2.Remove(strB2.ToString().IndexOf(number1[index]), 1);
                            strB1.Remove(strB1.ToString().IndexOf(number1[index]), 1);
                        }
                    }
                    lstOutput.Add(strB1.Length + strB2.Length);
                }
            }
            lstOutput.ForEach(i => Console.Write("{0}\n", i));
            /* Old Code
             
            List<int> lstOutput = new List<int>();
            var countTestCase = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < countTestCase; i++)
            {
                Char[] number1 = Console.ReadLine()?.ToCharArray();
                Char[] number2 = Console.ReadLine()?.ToCharArray();
                if (number1 != null && number2 != null)
                {
                    var myDic1 = new Dictionary<int, char>();
                    var myDic2 = new Dictionary<int, char>();
                    for (int index = 0; index < number1.Length; index++)
                    {
                        myDic1.Add(index, number1[index]);
                    }
                    for (int index = 0; index < number2.Length; index++)
                    {
                        myDic2.Add(index, number2[index]);
                    }
                    lstOutput.Add(number1.Length + number2.Length - 2 * myDic1.Intersect(myDic2).Count());
                }
            }

            lstOutput.ForEach(i => Console.Write("{0}\n", i));
             */
        }
    }
}