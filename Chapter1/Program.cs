using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {

        public static void Main()
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);

            int result;
            if (queue.TryDequeue(out result))
                Console.WriteLine("Dequeud: {0}", result);
        }

    }
}