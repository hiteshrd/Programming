using System;
using System.Collections.Generic;

namespace BasicProgramming
{
    public class BirthdayParty
    {
        public void FindPacket()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            List<bool> output = new List<bool>();

            for (int i = 0; i < n; i++)
            {
                int[] arr = new int[2];
                arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                output.Add(arr[1] % arr[0] == 0);
            }

            foreach (var val in output)
            {
                Console.WriteLine(val ? "Yes" : "No");
            }

        }
    }
}