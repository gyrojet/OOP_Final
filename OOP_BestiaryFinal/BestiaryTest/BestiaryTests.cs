using OOP_BestiaryFinal;
using System;
namespace BestiaryTest
{
    // A test class for checking property validation for creatures, abilities, and the loot manager
    [TestClass]
    public sealed class BestiaryTests
    {
        [TestMethod]
        public void TestHP()
        {
            // Check hp validation: Should make itself 1
            Minion myMinion = new Minion();
            myMinion.CurrentHealth = -67;

            int expected = 1;
            int actual = myMinion.CurrentHealth;

            Assert.AreEqual( expected, actual );
        }
        [TestMethod]
        public void TestAC()
        {
            // Check AC validation: Should make itself 10
            Minion m = new Minion();
            m.AC = 5;

            int expected = 10;
            int actual = m.AC;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLevelLow()
        {
            // Check level validation: Should make itself 1
            Minion m = new Minion();

            m.Level = -20;

            int expected = 1;
            int actual = m.Level;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLevelHigh()
        {
            // Test high level validation: Should be reduced to 20
            Minion m = new Minion();

            m.Level = 50;

            int expected = 20;
            int actual = m.Level;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinionMinAppear()
        {
            // Test validation for MinAppear: should never be below 1
            Minion m = new Minion();

            m.MinAppearing = -22;

            int expected = 1;
            int actual = m.MinAppearing;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinionMaxAppear()
        {
            // Test validation for MaxAppear: should never be less than MinAppear
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
            // Test validation for Power: should never be above 2000
            Ability a = new Ability();

            a.Power = 3000;

            int expected = 2000;
            int actual = a.Power;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAbilityMinPow()
        {
            // Test validation for Power: should never be below 0
            Ability a = new Ability();

            a.Power = -9000;

            int expected = 0;
            int actual = a.Power;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestItemCount()
        {
            // Test validation for item count: A level of 20 should produce a count of 6 items
            int expected = 6;
            int actual = LootManager.GetItemCount(20);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestItemChance()
        {
            // Test validation for magic item chance: a dragon should have a 25% chance of a magic item
            MonsterType type = MonsterType.Dragon;

            int expected = 25;
            int actual = LootManager.GetMagicItemChance(type);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGoldGeneration()
        {
            // Test validation for an item: value should never be below 0
            Loot l = new Loot();
            l.Value = -255;

            int expected = 0;
            int actual = l.Value;

            Assert.AreEqual(expected, actual);
        }
    }
}
