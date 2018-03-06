using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    public class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            Dictionary<char, char> allowedChars = new Dictionary<char, char>() {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' },
                { '<', '>' }
            };

            int count = 0;

            if (input.Length >= 0 && input.Length <= 100)
            {
                foreach (var chr in input)
                {
                    if (allowedChars.ContainsKey(chr) || allowedChars.ContainsValue(chr))
                    {
                        if (chr == '(' || chr == '[' || chr == '{' || chr == '<') count++;
                        if (chr == ')' || chr == ']' || chr == '}' || chr == '>') count--;
                        if (count < 0) return false;
                    }
                }

                if (count == 0) return true;
            }

            return false;
        }
    }

    [TestClass]
    public class ValidParentheseTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, Parentheses.ValidParentheses("<>"));
            Assert.AreEqual(false, Parentheses.ValidParentheses("<>()[]<){}]]](()){{"));
            Assert.AreEqual(true, Parentheses.ValidParentheses("()"));
            Assert.AreEqual(false, Parentheses.ValidParentheses(")(((("));
            Assert.AreEqual(false, Parentheses.ValidParentheses(")(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((()(((("));
        }
    }
}
