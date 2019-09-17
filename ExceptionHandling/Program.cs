using System;
namespace ExceptionHandling
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            try
            {
                int i = int.Parse(s);
                if (i == 42) Environment.FailFast("Special number entered");
            }
            finally
            {
                Console.WriteLine("Program complete");
            }
        }
    }
}
