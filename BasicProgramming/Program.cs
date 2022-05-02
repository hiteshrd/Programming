using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using BasicProgramming.TechGig;

namespace BasicProgramming
{
    using BasicProgramming.Codility;
    using BasicProgramming.HackerEarth;
    using BasicProgramming.HackerRank;
    using BasicProgramming.Practise;
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
                SampleTest _sampleTest = new SampleTest();
                _sampleTest.MsSampleTest();

                //Sorting _Sorting = new Sorting();
                //_Sorting.InsertionSort();
                //NovemberEasy19 _NovemberEasy19 = new NovemberEasy19();
                //_NovemberEasy19.DeterminingNumbers();
                //SeptemberCircuits _SeptemberCircuits = new SeptemberCircuits();
                //_SeptemberCircuits.GoingOffice();
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
                ////_PalindromicString.Check();
                //_PalindromicString.DeterminePalindromes();

                //GradingStudents _GradingStudents = new GradingStudents();
                //_GradingStudents.FindGrades();

                //CountDivisors _CountDivisors = new CountDivisors();
                //_CountDivisors.FindDivisors();

                //BlockingCollectionTest _BlockingCollectionTest = new BlockingCollectionTest();
                //var task1 = Task.Run(() => { _BlockingCollectionTest.BlockingCollectionAdd(); });
                //var task2 = Task.Run(() => { _BlockingCollectionTest.BlockingCollectionRemove(); });

                //task1.Wait();
                //task2.Wait();

                //TwoStrings _TwoStrings = new TwoStrings();
                //_TwoStrings.CheckTwoStrings();

                //Kangaroo _Kangaroo = new Kangaroo();
                //_Kangaroo.CheckKangaroos();

                //ToyBox _ToyBox = new ToyBox();
                //_ToyBox.CalculateToyBox();

                //SecureString ss = new SecureString();
                //var s = ss.ConvertToUnsecureString();

                //Console.WriteLine(s);

                //OperationsOnArray _OperationsOnArray = new OperationsOnArray();
                //_OperationsOnArray.FindOperationsOnArray();

                //LostNumbers _LostNumbers = new LostNumbers();
                //_LostNumbers.FindLostNumbers();
                //MojtabaArrayArpaQueries _MojtabaArrayArpaQueries = new MojtabaArrayArpaQueries();
                //_MojtabaArrayArpaQueries.DOPermutations();

                //EasyProblem ep = new EasyProblem();
                //ep.Fibonacci();

                //MarchCircuits mc = new MarchCircuits();
                //mc.DoesItDivide();

                //AprilEasy ae = new AprilEasy();
                //ae.OneStringNoTrouble();

                //AprilCircuits ac = new AprilCircuits();
                //ac.GridPhrase();

                //CodeGladiators cg = new CodeGladiators();
                //cg.NeighboursNewYearParty();

                //PalindromicString ps = new PalindromicString();
                //ps.PalindromeEverywhere();

                //MayEasy me = new MayEasy();
                //me.GoodNumbers();
                //IClass1 i = new Class1();
                //i.fun();

                Console.WriteLine("Want to Retry? Press 1");
                int.TryParse(Convert.ToString(Console.ReadLine()), out retry);
            }
        }
    }
    public static class SecureStringExtension
    {
        /// <summary>
        /// The convert to unsecure string.
        /// </summary>
        /// <param name="secureSensitiveData">
        /// The secure sensitive data.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when we feel like it.
        /// </exception>
        public static string ConvertToUnsecureString(this SecureString secureSensitiveData)
        {
            if (secureSensitiveData == null)
                throw new ArgumentNullException("secureSensitiveData");

            var unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureSensitiveData);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
