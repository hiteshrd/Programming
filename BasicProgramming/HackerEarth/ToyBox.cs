using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.HackerEarth
{
    public class ToyBox
    {
        public void CalculateToyBox()
        {
            int[] toybox = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), Convert.ToInt32);
            Dictionary<int, int> myDic = new Dictionary<int, int>();
            int output = 0;
            for (int i = 0; i < toybox[0]; i++)
            {
                int[] toys = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), Convert.ToInt32);
                int price = 0;
                if (myDic.TryGetValue(toys[1], out price))
                {
                    output += toys[0] > price ? toys[0] - price : 0;
                    myDic[toys[1]] = toys[0];
                }
                else
                {
                    myDic.Add(toys[1], toys[0]);
                    output += toys[0];
                }

            }
            Console.WriteLine(output);
        }
    }
}
