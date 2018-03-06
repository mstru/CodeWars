using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class SimplePigLatin
    {
        public static string PigIt1(string str)
        {
            string text = null;

            int i = 0;
            foreach (var value in str.Split())
            {
                var builder = new StringBuilder();
                StringBuilder build = builder.Append(string.Format("{0}{1}ay", value.Substring(1), value.First()));

                if (i != 0)
                    text += " " + builder;
                else
                    text += builder.ToString();

                i++;
            }

            return text;
        }

        public static string PigIt2(string str)
        {
            return String.Join(" ", str.Trim().Split(' ').Select(c => String.Concat(c.Remove(0, 1), c[0], "ay")));
        }
    }

    [TestClass]
    public class SimplePigLatinTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("gtpay qauay psday ktcay nmway neway duay", SimplePigLatin.PigIt2("pgt uqa dps ckt wnm wne ud"));
            Assert.AreEqual("igPay atinlay siay oolcay", SimplePigLatin.PigIt2("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", SimplePigLatin.PigIt2("This is my string"));
        }
    }
}
