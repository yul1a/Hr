using System;
using System.Collections.Generic;
using System.Linq;

namespace Hr
{
    public class FunnyString
    {
        //https://www.hackerrank.com/challenges/funny-string
        public static void DecideFunnyOrNot()
        {
            var len = int.Parse(Console.ReadLine());
            var inputArray = new List<string>();
            for (int m = 0; m < len; m++)
            {
                inputArray.Add(Console.ReadLine());
            }

            var answers = Decide(len, inputArray);
            foreach (var answer in answers)
                Console.WriteLine(answer);
        }

        public static List<string> Decide(int len, List<string> inputArray)
        {
            var answers =new List<string>();
            for (var i = 0; i < len; i++)
            {
                var s = inputArray[i];
                if (s == Environment.NewLine)
                    continue;

                var r = s.Reverse().ToArray();
                for (int j = 1; j < s.Length; j++)
                {
                    if (j + 1 >= s.Length)
                    {
                        answers.Add("Funny");
                    }
                    else if (Math.Abs((int) s[j] - (int) s[j - 1]) != Math.Abs((int) r[j] - (int) r[j - 1]))
                    {
                        answers.Add("Not Funny");
                        j = s.Length;
                    }
                }
            }
            return answers;
        }
    }
}