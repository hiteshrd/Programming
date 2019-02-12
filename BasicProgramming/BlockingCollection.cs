using System;
using System.Collections.Concurrent;

namespace BasicProgramming
{
    public class BlockingCollectionTest
    {
        BlockingCollection<int> bc = new BlockingCollection<int>();
        public void BlockingCollectionAdd()
        {
            for (int j = 0; j < 2000; j++)
            {
                Console.WriteLine($"Adding - {j}");
                bc.Add(j);
            }
        }
        public void BlockingCollectionRemove()
        {
            while (true)
            {
                var test = 0;
                var success = bc.TryTake(out test, 5000);
                if (success)
                {
                    Console.WriteLine($"Reading - {test}");
                }
                else
                {
                    break;
                }
            }

            //foreach (var val in bc.GetConsumingEnumerable())
            //{
            //    Console.WriteLine($"Reading - {val}");
            //}
        }
    }
}