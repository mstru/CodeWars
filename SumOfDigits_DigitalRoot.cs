using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    public class SumOfDigits_DigitalRoot
    {
        public static int DigitalRoot(long n)
        {
            int ret = 0;
            foreach (char a in Math.Abs(n).ToString())
            {
                ret += a - '0';
            }

            if (ret > 9)
            {
                ret = DigitalRoot(ret);
            }
            return ret;
        }
    }

    public class SumOfDigits_DigitalRootTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, SumOfDigits_DigitalRoot.DigitalRoot(942));
        }
    }
}
