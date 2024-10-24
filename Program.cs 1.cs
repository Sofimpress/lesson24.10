namespace ConsoleApp16
{
using System;
using System.Collections.Generic;

namespace Kata
    {
        public class FindNearestGreaterElement
        {
            public static int[] FindNearestGreaterElements(int[] array)
            {
                if (array.Length == 0)
                {
                    return new int[0];
                }

                int[] result = new int[array.Length];
                Stack<int> indexStack = new Stack<int>();
                indexStack.Push(0);

                for (int i = 1; i < array.Length; i++)
                {
                    while (indexStack.Count > 0 && array[i] > array[indexStack.Peek()])
                    {
                        result[indexStack.Peek()] = array[i];
                        indexStack.Pop();
                    }

                    indexStack.Push(i);
                }

                while (indexStack.Count > 0)
                {
                    result[indexStack.Peek()] = -1;
                    indexStack.Pop();
                }

                return result;
            }
        }
    }
}
