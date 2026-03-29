using OOP_BestiaryFinal;
namespace BestiaryTest
{
    [TestClass]
    public sealed class BestiaryTests
    {
        [TestMethod]
        public void TestHP()
        {
            Minion n = new Minion("Name", "d", 3, 12, -45, MonsterType.Alien, DamageType.Acid);

            int expectedHP = 0;
            int actualHP = n.CurrentHealth;

            Assert.AreEqual(expectedHP, actualHP);
        }
    }
}
