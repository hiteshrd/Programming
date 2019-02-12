using System;
using System.Globalization;

namespace BasicProgramming
{
    public class TimeConversion
    {
        public void ConvertTime()
        {
            string s = Console.ReadLine();
            DateTime dateTime = DateTime.ParseExact(s,
                "hh:mm:sstt", CultureInfo.InvariantCulture);
            Console.WriteLine(dateTime.ToString(@"HH:mm:ss"));
            //s = Convert s.ToString()
        }
    }
}