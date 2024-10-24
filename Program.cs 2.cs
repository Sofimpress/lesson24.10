namespace ConsoleApp17
{
using System;
    using System.Collections.Generic;

    namespace Kata
    {
        public class CountUniqueElements
        {
            public static int CountUniqueElementsInList(List<int> numbers)
            {
                if (numbers.Count == 0)
                {
                    return 0;
                }

                int uniqueCount = 1;
                numbers.Sort();

                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] != numbers[i - 1])
                    {
                        uniqueCount++;
                    }
                }

                return uniqueCount;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}