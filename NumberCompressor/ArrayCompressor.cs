using System;
using System.Collections.Generic;

namespace NumberCompressor
{
    public static class ArrayCompressor
    {
        public static int[] CompressNumbers(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            if (numbers.Length == 0)
            {
                return Array.Empty<int>();
            }

            List<int> result = new List<int>();
            result.Add(numbers[0]);

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1])
                {
                    result.Add(numbers[i]);
                }
            }

            return result.ToArray();
        }
    }
}