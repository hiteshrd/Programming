using System;

namespace BasicProgramming.HackerEarth
{
    public class SeptemberCircuits
    {
        public void GoingOffice()
        {
            long distance = Convert.ToInt64(Console.ReadLine());
            long[] onlineTaxi = Array.ConvertAll(Console.ReadLine().Split(' '), a => Convert.ToInt64(a));
            long[] classicTaxi = Array.ConvertAll(Console.ReadLine().Split(' '), a => Convert.ToInt64(a));
            long onlineTaxiFare = 0, classicTaxiFare = 0;
            onlineTaxiFare = onlineTaxi[1] > distance ? onlineTaxi[0]: onlineTaxi[0] + ((distance - onlineTaxi[1]) * onlineTaxi[2]);
            classicTaxiFare = classicTaxi[1] + ((distance / classicTaxi[0]) * classicTaxi[2]) + classicTaxi[3] * distance;
            Console.WriteLine(onlineTaxiFare <= classicTaxiFare ? "Online Taxi" : "Classic Taxi");
        }
    }
}
