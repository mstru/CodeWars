using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class TakeTenMinuteWalk
    {
        public static bool IsValidWalk(string[] walk)
        {
            return CalculateWalk(walk);
        }

        public static bool CalculateWalk(string[] walk)
        {
            for (int i = 0; i <= walk.Length - 1; ++i)
            {
                if (walk[i] == GetNext(walk, i) || walk.Length != 10)
                {
                    return false;
                }
            }

            return true;
        }

        private static string GetNext(IList<string> items, int i)
        {
            if (String.IsNullOrWhiteSpace(items[i]))
                return items[0];

            var index = items.IndexOf(items[i]);
            if (index == -1)
                return items[0];

            return (index + 1 == items.Count) ? items[0] : items[index + 1];
        }
    }

    [TestClass]
    public class TakeTenMinuteWalkTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(false, TakeTenMinuteWalk.IsValidWalk(new string[] { "w" }), "should return false");
            Assert.AreEqual(true, TakeTenMinuteWalk.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return true");
            Assert.AreEqual(false, TakeTenMinuteWalk.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), "should return false");
            Assert.AreEqual(false, TakeTenMinuteWalk.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
        }
    }
}
