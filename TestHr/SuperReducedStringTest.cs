using System;
using Hr;
using NUnit.Framework;

namespace TestHr
{
    public class SuperReducedStringTest
    {
        [Test]
        public void Simple()
        {
            Assert.That(SuperReducedString.Reduce("baab"), Is.EqualTo("Empty String"));
            Assert.That(SuperReducedString.Reduce("aaabccddd"), Is.EqualTo("abd"));
        }

        [Test]
        public void Null()
        {
            Assert.That(SuperReducedString.Reduce(null), Is.EqualTo("Empty String"));
        }
    }
}