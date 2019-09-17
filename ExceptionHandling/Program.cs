using System;
namespace ExceptionHandling
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();

                try
                {
                    int i = int.Parse(s);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You need to enter a value");
                }

                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a valid number. Please try again", s);
                }
            }
        }
    }
}
