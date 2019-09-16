using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {

        public static void Main()
        {
            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(1000);
            });
        }
    }
}