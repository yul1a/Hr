using System;
using System.Linq;

namespace Hr
{
    public class LonelyInteger {
        //https://www.hackerrank.com/challenges/lonely-integer
        public static int FindUniqueInteger(int[] numbers)
        {
            var cache = new int[101];

            foreach (var t in numbers)
                cache[t]++;

            for (var i = 0; i < cache.Length; i++)
                if (cache[i] == 1)
                    return i;
            throw new InvalidOperationException();
        }
        
        public static int FindUniqueIntegerXOR(int[] numbers)
        {
            return numbers.Aggregate(0, (current, number) => number ^ current);
        }


    }
}