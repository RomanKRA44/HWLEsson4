using System;
using System.Linq;

namespace HWLEsson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Sum());
        }
    }
}
