using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    public class GoodVsEvil
    {
        public enum GoodSideRules
        {
            Hobbits = 1,
            Men = 2,
            Elves = 3,
            Dwarves = 3,
            Eagles = 4,
            Wizards = 10
        }

        public enum EvilSideRules
        {
            Orcs = 1,
            Men = 2,
            Wargs = 2,
            Goblins = 2,
            UrukHai = 3,
            Trolls = 5,
            Wizards = 10
        }

        public static string GoodVSEvil(string good, string evil)
        {
            string[] glist = good.Split(' ');
            string[] elist = evil.Split(' ');

            int goodArmyForces = GoodVsEvil.CalculateForces<GoodSideRules>(glist);
            int evilArmyForces = GoodVsEvil.CalculateForces<EvilSideRules>(elist);

            return GoodVsEvil.Result(goodArmyForces, evilArmyForces);
        }

        public static int CalculateForces<T>(string[] armyValues)
        {
            int i = 0;
            int totalForces = 0;
            foreach (T raceValue in Enum.GetValues(typeof(T)))
            {
                totalForces += Convert.ToInt32(raceValue) * int.Parse(armyValues[i]);
                ++i;
            }
            return totalForces;
        }

        public static string Result(int gSideCount, int eSideCount)
        {                           
            if (gSideCount < eSideCount)
            {
                return "Battle Result: Evil eradicates all trace of Good";
            }
            else if (gSideCount > eSideCount)
            {
                return "Battle Result: Good triumphs over Evil";
            }
            else
            {
                return "Battle Result: No victor on this battle field";
            }
        }
    }

    [TestClass]
    public class GoodVsEvilTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Battle Result: Good triumphs over Evil", GoodVsEvil.GoodVSEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0"));
            Assert.AreEqual("Battle Result: Evil eradicates all trace of Good", GoodVsEvil.GoodVSEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1"));
            Assert.AreEqual("Battle Result: No victor on this battle field", GoodVsEvil.GoodVSEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0"));
            Assert.AreEqual("Battle Result: No victor on this battle field", GoodVsEvil.GoodVSEvil("1 0 0 0 1 0", "0 0 0 0 0 1 0"));
        } 
    }
}
