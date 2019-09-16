using System;
using System.Linq;


namespace Chapter1
{
    public static class Program
    {

        public static void Main()
        {
            var numbers = Enumerable.Range(0, 20);

            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0).AsSequential();

            foreach (int i in parallelResult.Take(5))
                Console.WriteLine(i);

        }
    }
}