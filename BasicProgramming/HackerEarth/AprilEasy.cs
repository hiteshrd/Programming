using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.HackerEarth
{
    public class AprilEasy
    {
        public void OneStringNoTrouble()
        {
            string str = Console.ReadLine();
            //Hashtable ht = new Hashtable();
            int len = 0;

            for (int length = str.Length; length >= 1; length--)
            {
                // Be careful with the end index.
                for (int start = 0; start <= str.Length - length && len < length; start++)
                {
                    var val = str.ToCharArray(start, length);
                    //ht.Add(ht.Count + 1, val);
                    int templen = 1;
                    for (int i = 0; i < val.Length - 1 && val[i] != val[i + 1]; i++)
                    {
                        templen++;
                    }

                    if (templen > len)
                        len = templen;
                }
            }
            Console.WriteLine(len);
        }

        public void TheDice()
        {
            int[] arr = Array.ConvertAll<string, int>(String.Join(" ", Console.ReadLine().Select(c => c)).Split(), Convert.ToInt32);
            int girls = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1 && arr[i] == 6)
                    girls = -1;
                girls += arr[i] != 6 ? 1 : 0;
            }
            Console.WriteLine(girls);
        }
    }
}
