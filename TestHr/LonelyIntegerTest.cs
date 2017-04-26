using System;
using NUnit.Framework;
using Hr;

namespace TestHr
{
    public class LonelyIntegerTest
    {
        [Test]
        public void Simple()
        {
            Assert.That(LonelyInteger.FindUniqueInteger(new [] {1,1,2}), Is.EqualTo(2));
            Assert.That(LonelyInteger.FindUniqueInteger(new [] {0,0,1,2,1}), Is.EqualTo(2));
        }

        [Test]
        public void Empty()
        {
            Assert.Throws<InvalidOperationException>(() => LonelyInteger.FindUniqueInteger(new int [] {}));
        }


    }
}