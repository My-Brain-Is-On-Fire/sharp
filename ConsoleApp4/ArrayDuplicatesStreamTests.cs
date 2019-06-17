using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeWars
{
    [TestFixture]
    public class DummyTest
    {

        [Test]
        public void DupeCount_ZeroDupe_ReturnsZero()
        {
            int[] onedupe = new int[] { 97, 92, 81, 60 };
            Assert.AreEqual(0, Class1.DupeCounter());
        }

        [Test]
        public void DupeCount_OneDupe_ReturnsOne()
        {
            int[] twodupes = new int[] { 97, 92, 97, 60 };
            Assert.AreEqual(1, Class1.DupeCounter());
        }

        [Test]
        public void DupeCount_DupedDupe_ReturnsFour()
        {
            int[] fivedupes = new int[] { 97, 97, 97, 60, 60 };
            Assert.AreEqual(5, Class1.DupeCounter());
        }

        [Test]
        public void DupeCount_FiveDupe_ReturnsFive()
        {
            int[] fivedupes = new int[] { 97, 92, 81, 60, 92, 81, 60 };
            Assert.AreEqual(5, Class1.DupeCounter());
        }
    }

}