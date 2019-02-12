using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    /*
 // Sample code to perform I/O:

 name = Console.ReadLine();                  // Reading input from STDIN
 Console.WriteLine("Hi, {0}.", name);        // Writing output to STDOUT

 // Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
 */

    // Write your code here

    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            int retry = 1;
            while (retry == 1)
            {
                //SevenSegmentDisplay sevenSegmentDisplay = new SevenSegmentDisplay();
                //sevenSegmentDisplay.ProcessSevenSegmentDisplay();

                //FindProduct findProduct = new FindProduct();
                //findProduct.FindArrayProduct();

                //PrimeNumber primeNumber = new PrimeNumber();
                //primeNumber.GetPrimeNumberList();

                //SeatingArrangement seatingArrangement = new SeatingArrangement();
                //seatingArrangement.GetSeatNumber();

                //Anagrams anagrams = new Anagrams();
                //anagrams.GetNonAnagramsCount();

                //ClimbingTheLeaderboard climbingTheLeaderboard = new ClimbingTheLeaderboard();
                //climbingTheLeaderboard.GetLeaderboardRank();

                //EqualMultisets equalMultisets = new EqualMultisets();
                //equalMultisets.DetermineMinimumMovesToEqualMultisets();

                //Subarrays subarrays = new Subarrays();
                //subarrays.MaximizeCost();

                //PlusMinus plusMinus = new PlusMinus();
                //plusMinus.FindFractions();

                //ShiftLetters _ShiftLetters = new ShiftLetters();
                //_ShiftLetters.GetminimumSteps();

                //DiagonalDifference _DiagonalDifference = new DiagonalDifference();
                //_DiagonalDifference.FindDiagonalDifference();

                //BirthdayParty _BirthdayParty = new BirthdayParty();
                //_BirthdayParty.FindPacket();

                //Staircase _Staircase = new Staircase();
                //_Staircase.PrintStaircase();
                //SockMerchant _SockMerchant = new SockMerchant();
                //_SockMerchant.FindPairs();

                //CompareTriplets _CompareTriplets = new CompareTriplets();
                //_CompareTriplets.FindRank();

                //RepeatedString _RepeatedString = new RepeatedString();
                //_RepeatedString.FindRepeatedString();

                //BirthdayCakeCandles _BirthdayCakeCandles = new BirthdayCakeCandles();
                //_BirthdayCakeCandles.FindCandles();

                //TimeConversion _TimeConversion = new TimeConversion();
                //_TimeConversion.ConvertTime();

                //FlippingBrackets _FlippingBrackets = new FlippingBrackets();
                //_FlippingBrackets.FindBrackets();
                //AppleOrange _AppleOrange = new AppleOrange();
                //_AppleOrange.FindCount();

                //PalindromicString _PalindromicString = new PalindromicString();
                //_PalindromicString.Check();

                //GradingStudents _GradingStudents = new GradingStudents();
                //_GradingStudents.FindGrades();

                //CountDivisors _CountDivisors = new CountDivisors();
                //_CountDivisors.FindDivisors();

                BlockingCollectionTest _BlockingCollectionTest = new BlockingCollectionTest();
                var task1 = Task.Run(() => { _BlockingCollectionTest.BlockingCollectionAdd(); });
                var task2 = Task.Run(() => { _BlockingCollectionTest.BlockingCollectionRemove(); });

                task1.Wait();
                task2.Wait();

                Console.WriteLine("Want to Retry? Press 1");
                int.TryParse(Convert.ToString(Console.ReadLine()), out retry);
            }
        }
    }
}
