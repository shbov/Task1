using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly Random Random = new();

        static void Main(string[] args)
        {
            var bytes = new List<byte>();
            for (var i = 0; i < 1000; i++)
                bytes.Add((byte) Random.Next(0, 127 + 1));

            try
            {
                File.WriteAllLines("../../../../input.txt", bytes.Select(item => item.ToString()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}