using System;
using System.Threading;

namespace Chapter1
{
    public static class Program
    {
        [ThreadStatic]
        private static int field;

        public static int Field { get => field; set => field = value; }

        public static void Main()
        {

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    Field++;
                    Console.WriteLine("Thead A: {0}", Field);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    Field++;
                    Console.WriteLine("Thread B: {0}", Field);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}