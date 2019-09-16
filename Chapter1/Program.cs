using System;
using System.Linq;


namespace Chapter1
{
    public static class Program
    {

        public static void Main()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (int i in parallelResult)
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}