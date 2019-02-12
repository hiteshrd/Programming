using System;
using System.Collections.Generic;

namespace BasicProgramming
{
    public class GradingStudents
    {
        public void FindGrades()
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int[n];
            List<int> result = new List<int>();

            for (int gradesItr = 0; gradesItr < n; gradesItr++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine());
                //grades[gradesItr] = gradesItem;
                result.Add(gradesItem < 38 || gradesItem % 5 <= 3 ? gradesItem : gradesItem - gradesItem % 5 + 5);
            }
            result.ForEach(i => Console.Write("{0}\n", i));

        }
    }
}