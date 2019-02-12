using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace BasicProgramming
{
    public class FlippingBrackets
    {
        public void FindBrackets()
        {
            //List<char> lstbrackets = new List<char>();
            //lstbrackets.AddRange(Convert.ToString(Console.ReadLine()));
            char[] bracket = Console.ReadLine().ToCharArray();
            Dictionary<int, char> myDic = new Dictionary<int, char>();
            for (int i = 0; i < bracket.Length; i++)
            {
                myDic.Add(i, bracket[i]);
            }
            int count = Convert.ToInt32(Console.ReadLine());
            List<int> output = new List<int>();
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                int index = Convert.ToInt32(input.Substring(2)) - 1;
                switch (input[0])
                {
                    case 'C':
                        myDic[index] = myDic[index] == '(' ? ')' : '(';
                        break;
                    case 'Q':
                        int Lbracket = myDic.Skip(index-1).Count(a=>a.Value == '('), Rbracket = myDic.Skip(index - 1).Count(a => a.Value == ')');
                        output.Add(Lbracket <= Rbracket ? Lbracket * 2 : 0);
                        break;
                }
            }
            output.ForEach(i => Console.Write("{0}\n", i));

        }
    }
}