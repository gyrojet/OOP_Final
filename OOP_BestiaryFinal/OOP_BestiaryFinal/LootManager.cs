using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Diagnostics;

namespace OOP_BestiaryFinal
{
    // The loot manager is used to generate loot based on a monster's type and level.
    // Loot includes money, returned as an int, or Items, returned as Loot objects.
    // Loot is generated from a loot list, which consists of a list of loot items. Some items are generic, while some
    // can only be obtained from particular creature types.
    public static class LootManager
    {
        // Loot lists: 1 generic, 24 items
        // Magic item list, 16 items
        // A generated item has a 1/6 chance of being magic.
        
        // Seed a new rng
        static Random rng = new Random();

        static List<Loot> mundaneItems = new List<Loot>();
        static List<Loot> magicItems = new List<Loot>();

        public static void LoadItemLists()
        {
            /*
             * mundaneItems = DataManager.LoadMundaneItemList();
             * magicItems = DataManager.LoadMagicItemList();
             */
        }

        public static int GetGold(int level, MonsterType type)
        {
            int total = 0;
            int baseAmt = 0;

            switch (type)
            {
                case MonsterType.Animal:
                case MonsterType.Ooze:
                    baseAmt = 4;
                    break;

                case MonsterType.Undead:
                case MonsterType.Humanoid:
                    baseAmt = 6;
                    break;

                case MonsterType.Alien:
                case MonsterType.Construct:
                    baseAmt = 8;
                    break;

                case MonsterType.Demon:
                case MonsterType.Dragon:
                    baseAmt = 12;
                    break;
            }

            total = ((rng.Next(1, baseAmt + 1)) * level) + rng.Next(1, level + 1);
            Debug.WriteLine($"level: {level} type: {type.ToString()} total: {total} base amt: {baseAmt}");
            return total;
        }

        public static void LoadMundaneItemList()
        {

        }

        public static void LoadMagicItemList()
        {

        }

        // Gets a list of items based on level
        // In an early stage
        public static List<Loot> GetLootList(int level)
        {
            List<Loot> lootList = new List<Loot>()
            {
                new Loot(
                        "Dirt Clump",
                        "Exactly what it says.",
                        -5,
                        false
                    ),
                new Loot(
                        "+1 Mace",
                        "Enhanced with offensive magic.",
                        20,
                        true
                    )
            };
            Debug.WriteLine(JsonSerializer.Serialize(lootList, new JsonSerializerOptions { WriteIndented = true }));

            return lootList;
        }
    }
}
