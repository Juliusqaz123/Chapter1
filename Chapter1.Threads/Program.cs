﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Chapter1.Threads
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}
