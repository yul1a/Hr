using System;

namespace Hr
{
    public class SuperReducedString
    {
        //https://www.hackerrank.com/challenges/reduced-string
        public static void Reduce()
        {
            var input = Console.ReadLine();

            var output1 = Reduce(input);

            Console.WriteLine(output1);
        }

        public static string Reduce(string input)
        {
            var output1 = input == null ? "" : input;
            var i = 0;
            var y = 1;
            while (output1.Length > y)
            {
                if (output1[i] == output1[y])
                {
                    var start = i > 0 ? output1.Substring(0, i) : "";
                    var end = output1.Substring(y + 1, output1.Length - start.Length - 2);
                    output1 = start + end;
                    i = 0; //todo more intelligent
                    y = 1;
                }
                else
                {
                    i++;
                    y++;
                }
            }
            return output1.Length > 0 ? output1 : "Empty String";
        }
    }
}