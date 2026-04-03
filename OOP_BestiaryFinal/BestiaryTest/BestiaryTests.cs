using OOP_BestiaryFinal;
namespace BestiaryTest
{
    [TestClass]
    public sealed class BestiaryTests
    {
        [TestMethod]
        public void TestHP()
        {
            ////Minion n = new Minion("Name", "d", 3, 12, -45, MonsterType.Alien, DamageType.Acid,);

            //int expectedHP = 0;
            //int actualHP = n.CurrentHealth;

            //Assert.AreEqual(expectedHP, actualHP);
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
            MonsterType type = MonsterType.Alien;

            int expected = 20;
            int actual = LootManager.GetMagicItemChance(type);

            Assert.AreEqual(expected, actual);
        }
    }
}
