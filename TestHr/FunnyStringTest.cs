using System;
using System.Collections.Generic;
using Hr;
using NUnit.Framework;

namespace TestHr
{
    public class FunnyStringTest
    {
        [Test]
        public void Simple()
        {
            Assert.That(FunnyString.Decide(2,new List<string>{"acxz","bcxz"}), Is.EquivalentTo(new [] {"Funny", "Not Funny"}));
        }

        [Test]
        public void Null()
        {
            Assert.That(FunnyString.Decide(0, new List<string>()), Is.Empty);
        }
    }
}