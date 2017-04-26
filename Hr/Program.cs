using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hr
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //SuperReducedString.Reduce();
            //FunnyString.DecideFunnyOrNot();
            Quicksort1Partition.Partition();
        }
    }

    public class Quicksort1Partition
    {
        public static void Partition()
        {
            var count = Console.ReadLine();
            var stringNumbers = Console.ReadLine();
            var result = Partition(stringNumbers.Split(' ').Select(int.Parse).ToArray());
            var strings = string.Join(" ", result.Select(x => x.ToString()));
            Console.WriteLine(strings);
        }

        public static int[] Partition(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return new int[]{};
            var p = arr[0];
            var left = new List<int>();
            var equals = new List<int>();
            var right = new List<int>();

            equals.Add(p);
            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] < p)
                    left.Add(arr[i]);
                else if (arr[i] > p)
                    right.Add(arr[i]);
                else
                    equals.Add(arr[i]);
            }
            return left.Concat(equals).Concat(right).ToArray();

        }
    }
}