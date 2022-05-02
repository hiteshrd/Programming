using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.TechGig
{
    public class CodeGladiators
    {
        public void WinOrLose()
        {
            var tc = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {
                var playersVillainsCount = Convert.ToInt32(Console.ReadLine());
                int[] strengthsVillains = Array.ConvertAll<string, int>(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                int[] energyPlayers = Array.ConvertAll<string, int>(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                Array.Sort(strengthsVillains);
                Array.Sort(energyPlayers);
                bool win = true;
                for (int j = 0; j < playersVillainsCount; j++)
                {
                    win = energyPlayers[j] > strengthsVillains[j];
                    if(!win)
                        break;
                }
                Console.WriteLine(win? "WIN": "LOSE");
            }
        }

        public void NeighboursNewYearParty()
        {
            var tc = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {
                var ticketCount = Convert.ToInt32(Console.ReadLine());
                int[] ticketNumbers = Array.ConvertAll<string, int>(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                List<int> numbers1 = new List<int>();
                List<int> numbers2 = new List<int>();
                for (int j = 0; j < ticketCount; j++)
                {
                    if (ticketNumbers[j] <= 0) continue;
                    if (j % 2 == 0)
                    {
                        numbers1.Add(ticketNumbers[j]);
                    }
                    else
                    {
                        numbers2.Add(ticketNumbers[j]);
                    }
                }
                numbers1.Sort();
                numbers2.Sort();
                long sum1 = numbers1.Sum();
                long sum2 = numbers2.Sum();
                bool num1 = true;
                if (sum2 == sum1)
                {
                    for (int j = 0; j < numbers1.Count; j++)
                    {
                        if (numbers2.Count <= numbers1.Count && j >= numbers2.Count) continue;
                        num1 = numbers1[j] == numbers2[j];
                        if (num1) continue;
                        num1 = numbers1[j] > numbers2[j];
                        break;
                    }

                    if (num1)
                        numbers1.ForEach(a => Console.Write("{0}", a));
                    else
                        numbers2.ForEach(a => Console.Write("{0}", a));
                }
                else if(sum1 > sum2)
                {
                    numbers1.ForEach(a => Console.Write("{0}", a));
                }
                else
                {
                    numbers2.ForEach(a => Console.Write("{0}", a));
                }
                Console.Write("\n");
            }
        }

        public void GetSubStrings()
        {
            string[] source = new string[] { "dog", "cat", "mouse" };
            for (int i = 0; i < Math.Pow(2, source.Length); i++)
            {
                string[] combination = new string[source.Length];
                for (int j = 0; j < source.Length; j++)
                {
                    if ((i & (1 << (source.Length - j - 1))) != 0)
                    {
                        combination[j] = source[j];
                    }
                }
                Console.WriteLine("[{0}, {1}, {2}]", combination[0], combination[1], combination[2]);
            }
        }
    }
}
