using System;
using System.Linq;


namespace Chapter1
{
    public static class Program
    {

        public static void Main()
        {
            var numbers = Enumerable.Range(0, 20);

            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0);

            parallelResult.ForAll(e => Console.WriteLine(e));
        }
    }
}