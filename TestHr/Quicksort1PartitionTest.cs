using System;
using Hr;
using NUnit.Framework;

namespace TestHr
{
    public class Quicksort1PartitionTest
    {
        [Test]
        public void Simple()
        {
            Assert.That(Quicksort1Partition.Partition(new int[] {4, 5, 3, 7, 2}), Is.EquivalentTo(new int[] {3, 2, 4, 5, 7}));
        }

        [Test]
        public void Null()
        {
            Assert.That(Quicksort1Partition.Partition(null), Is.EqualTo(new int[]{}));
        }
    }
}