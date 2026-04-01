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
        // Seed a new rng
        static Random rng = new Random();

        static List<Loot> mundaneItems = new List<Loot>();
        static List<Loot> magicItems = new List<Loot>();

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

        public static void LoadMundaneItemList(List<Loot> list)
        {
            mundaneItems = list;
        }

        public static void LoadMagicItemList(List<Loot> list)
        {
            magicItems = list;
        }

        // Gets a list of items based on level
        // In an early stage
        public static List<Loot> GetLootList(int level, MonsterType type)
        {
            /*
             *  Loot gen plans:
             *  
             *  - Make a deep copy of the mundane and magic item lists
             *  - Get the number of items a monster has (1 + [level/4])
             *  - Get monster's magic item chance using their type
             *  
             *  - run through a for loop for all needed items
             *      - Roll a number from 1-100
             *      - If the number is equal to or less than the magic item chance, add a random magic item to the list
             *      - Otherwise, add a mundane item to the list
             *      - Remove the added item from the temporary mundane/magic list to avoid duplicates
             *      
             *  - Once everything has been added, return the list
             */

            // Create temp lootlist
            List<Loot> lootList = new List<Loot>();

            // Create temp lists for mundane, magic items
            List<Loot> tempMundaneList = new List<Loot>();
            List<Loot> tempMagicList = new List<Loot>();

            // Get number of items to retrieve
            int itemCount = GetItemCount(level);

            // Get percentage of a magic item appearing
            int magicItemChance = GetMagicItemChance(type);

            // Populate temporary lists with cloned items from mundane, magic lists
            foreach (Loot item in mundaneItems)
                tempMundaneList.Add((Loot)item.Clone());

            foreach (Loot item in magicItems)
                tempMagicList.Add((Loot)item.Clone());

            // For each item that is required:
            for (int i = 0; i < itemCount; i++)
            {
                // Roll a chance for a magic item
                int result = rng.Next(0, 101);

                // If result is less than or equal to percentage:
                if (result <= magicItemChance)
                {
                    // Get magic item from temp list
                    int length = tempMagicList.Count;
                    Loot newItem = tempMagicList[rng.Next(0, length)];

                    // Add item to list
                    lootList.Add(newItem);
                    tempMagicList.Remove(newItem);
                }
                else
                {
                    int length = tempMundaneList.Count;
                    Loot newItem = tempMundaneList[rng.Next(0, length)];

                    lootList.Add(newItem);
                    tempMundaneList.Remove(newItem);
                }
            }
            
            // Sort list by magical state, then by name
            List<Loot> sortedList = lootList
                                    .OrderByDescending(l => l.IsMagical)
                                    .ThenBy(l => l.Name)
                                    .ToList();

            // Send back sorted list of loot
            return sortedList;
        }

        public static int GetItemCount(int level)
        {
            // The number of items a monster drops is equal to 1 + (level / 5), up to a max of 6 items at level 20
            int itemCount = (1 + (level / 4));
            return itemCount;
        }

        public static int GetMagicItemChance(MonsterType type)
        {
            int itemChance = 0;

            switch (type)
            {
                /* magic item chances:
                 * Alien: 20%
                 * Animal: 5%
                 * Construct: 15%
                 * Demon: 20%
                 * Dragon: 25%
                 * Humanoid: 15%
                 * Ooze: 5%
                 * Undead: 10%
                 */

                case MonsterType.Dragon:
                    itemChance = 25;
                    break;

                case MonsterType.Alien:
                case MonsterType.Demon:
                    itemChance = 20;
                    break;

                case MonsterType.Construct:
                case MonsterType.Humanoid:
                    itemChance = 15;
                    break;

                case MonsterType.Undead:
                    itemChance = 10;
                    break;

                case MonsterType.Animal:
                case MonsterType.Ooze:
                    itemChance = 5;
                    break;

                default:
                    throw new Exception("Invalid Monster Type");
            }

            return itemChance;
        }
    }
}
