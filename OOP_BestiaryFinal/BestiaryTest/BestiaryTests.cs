using OOP_BestiaryFinal;
using System;
namespace BestiaryTest
{
    [TestClass]
    public sealed class BestiaryTests
    {
        [TestMethod]
        public void TestHP()
        {
            Minion myMinion = new Minion();
            myMinion.CurrentHealth = -67;

            int expected = 1;
            int actual = myMinion.CurrentHealth;

            Assert.AreEqual( expected, actual );
        }
        [TestMethod]
        public void TestAC()
        {
            Minion m = new Minion();
            m.AC = 5;

            int expected = 10;
            int actual = m.AC;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLevelLow()
        {
            Minion m = new Minion();

            m.Level = -20;

            int expected = 1;
            int actual = m.Level;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLevelHigh()
        {
            Minion m = new Minion();

            m.Level = 50;

            int expected = 20;
            int actual = m.Level;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinionMinAppear()
        {
            Minion m = new Minion();

            m.MinAppearing = -22;

            int expected = 1;
            int actual = m.MinAppearing;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinionMaxAppear()
        {
            Minion m = new Minion();

            m.MinAppearing = 10;
            m.MaxAppearing = 2;

            int expected = 10;
            int actual = m.MaxAppearing;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAbilityMaxPow()
        {
            Ability a = new Ability();

            a.Power = 3000;

            int expected = 2000;
            int actual = a.Power;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAbilityMinPow()
        {
            Ability a = new Ability();

            a.Power = -9000;

            int expected = 0;
            int actual = a.Power;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestItemCount()
        {
            int expected = 6;
            int actual = LootManager.GetItemCount(20);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestItemChance()
        {
            MonsterType type = MonsterType.Dragon;

            int expected = 25;
            int actual = LootManager.GetMagicItemChance(type);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestItemGeneration()
        {
            Loot l = new Loot();
            l.Value = -255;

            int expected = 0;
            int actual = l.Value;

            Assert.AreEqual(expected, actual);
        }
    }
}
