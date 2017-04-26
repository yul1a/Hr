using System;

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


    }
}