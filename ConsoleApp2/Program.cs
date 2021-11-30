using System;
using System.IO;
using System.Linq;
using Seminar;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();
            var b = "0123456789".ToList();
            var c = "abcdefghijklmnopqrstuvwxyz".ToList();

            SymbolChain[] array =
            {
                new LimitedSymbolChain('A', 'Z'),
                new LimitedSymbolChain('0', '9'),
                new LimitedSymbolChain('a', 'z')
            };

            var str = Array.Empty<string>();
            try
            {
                str = File.ReadAllLines("../../../../input.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            var count = 0;
            foreach (var item in str)
            {
                if (!int.TryParse(item, out var currentItem)) throw new ArgumentException();

                if (a.Contains((char) currentItem))
                {
                    array[0].AddToChain((char) currentItem);
                }
                else if (b.Contains((char) currentItem))
                {
                    array[1].AddToChain((char) currentItem);
                }
                else if (c.Contains((char) currentItem))
                {
                    array[2].AddToChain((char) currentItem);
                }
                else
                {
                    count += 1;
                }
            }

            Console.WriteLine($@"a: {array[0]}, items: {array[0].GetChainLength}
b: {array[1]}, items: {array[1].GetChainLength}
c: {array[2]}, items: {array[2].GetChainLength}

non-founded: {count}");
        }
    }
}