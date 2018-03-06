using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class UniqueInOrder
    {
        public static IEnumerable<T> UniqueIdInOrder<T>(IEnumerable<T> iterable)
        {
            var checkBuffer = new HashSet<T>();

            bool isUnique = iterable.Distinct().Count() == iterable.Count();
            if (!isUnique)
            {
           
                foreach (var t in iterable)
                {
                    if (checkBuffer.Add(t))
                    {
                        continue;
                    }
                }
            }
            return checkBuffer;
        }
    }

    public class UniqueInOrderTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("", UniqueInOrder.UniqueIdInOrder(""));
            Assert.AreEqual("ABCDAB", UniqueInOrder.UniqueIdInOrder("AAAABBBCCDAABBB"));
        }
    }
}
