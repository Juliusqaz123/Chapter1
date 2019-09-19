using System;
using System.IO;

namespace ExceptionHandling
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            OpenAndParse("");
        }

        public static string OpenAndParse(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentNullException("fileName", "FileName is required");

            return File.ReadAllText(fileName);
        }
    }
}
