using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace BasicProgramming
{
    public class ClimbingTheLeaderboard
    {
        public void GetLeaderboardRank()
        {
            List<int> lstOutput = new List<int>();

            int scoresCount = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
                ;
            int aliceCount = Convert.ToInt32(Console.ReadLine());

            int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
                ;
            lstOutput = ClimbingLeaderboard(scores, alice);
            lstOutput.ForEach(i => Console.Write("{0}\n", i));
        }
        // Complete the climbingLeaderboard function below.
        int[] ClimbingLeaderboardAlt(int[] scores, int[] alice)
        {
            int[] aliceRanks = null;
            //TODO:Remove duplicates
            foreach (var aliceRank in alice)
            {
                Array.Resize(ref scores, scores.Length + 1);
                scores.SetValue(aliceRank, scores.Length + 1);
                Array.Sort(scores);
                //TODO:Remove duplicates
                //TODO: Search aliceRank in array 'scores' and add the index + 1 in aliceRanks.
            }
            return aliceRanks;
        }
        // Complete the climbingLeaderboard function below.
        List<int> ClimbingLeaderboard(int[] scores, int[] alice)
        {
            List<int> aliceRanks = new List<int>();
            Array.Sort(scores);//, (a,b) => b.CompareTo(a));
            scores = scores.Distinct().ToArray();
            foreach (var aliceScore in alice)
            {
                //Array.Resize(ref scores, scores.Length + 1);
                //scores.SetValue(aliceScore, scores.Length - 1);
                int aliceRank = Array.BinarySearch(scores, aliceScore);
                if (aliceRank >= -1)
                {
                    aliceRanks.Add(scores.Length - aliceRank);
                }
                else if (aliceRank == -(scores.Length + 1))
                {
                    aliceRanks.Add(1);
                }
                else
                {
                    aliceRanks.Add(scores.Length + aliceRank +2);
                }
            }
            return aliceRanks;
        }
    }
}