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

        // Lists of mundane and magical items
        static List<Loot> mundaneItems = new List<Loot>();
        static List<Loot> magicItems = new List<Loot>();

        public static int GetGold(int level, MonsterType type)
        {
            //Store total amount
            int total = 0;

            // Base amount of gold
            int baseAmt = 0;

            // Get base amount based on monster type
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

            // Generate gold
            // Gold amount = ((random, from 1 to base amount) * level) + (random, from 1 to level)
            total = ((rng.Next(1, baseAmt + 1)) * level) + rng.Next(1, level + 1);
            
            // Return the generated total
            return total;
        }

        public static void LoadMundaneItemList(List<Loot> list)
        {
            // Set value of list
            mundaneItems = list;
        }

        public static void LoadMagicItemList(List<Loot> list)
        {
            // Set value of list
            magicItems = list;
        }

        public static List<Loot> GetLootList(int level, MonsterType type)
        {
            // Sorted list
            List<Loot> sortedList = new List<Loot>();
            try
            {
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
                        // If item is magic: get magic list length
                        int length = tempMagicList.Count;

                        // Grab an item randomly
                        Loot newItem = tempMagicList[rng.Next(0, length)];

                        // Add item to list, remove from temp list
                        lootList.Add(newItem);
                        tempMagicList.Remove(newItem);
                    }
                    else
                    {
                        // If item is not magic: get mundane list length
                        int length = tempMundaneList.Count;

                        // Grab an item randomly
                        Loot newItem = tempMundaneList[rng.Next(0, length)];

                        // Add item to list, remove from temp list
                        lootList.Add(newItem);
                        tempMundaneList.Remove(newItem);
                    }
                }

                // Sort list by magical state, then by name
                sortedList = lootList
                                        .OrderByDescending(l => l.IsMagical)
                                        .ThenBy(l => l.Name)
                                        .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Generating Loot List", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

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
            // Stores magic item chance
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

                // Get magic item chance by type

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
            }

            return itemChance;
        }
    }
}
