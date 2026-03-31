using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OOP_BestiaryFinal
{
    public static class DataManager
    {
        // Manages the loading and saving of data in JSON format
        /*
         * Things I will need:
         * - A path to the monster file
         * - A path to the treasure file
         * If there's only the two files, it's easier to just have them be seperate properties
         * 
         * Methods:
         *      - Save monster data: takes in monster list, serializes and saves
         *      - Load monster data: reads data from file, deserializes it and sends it back
         */

        // public static string MonsterSavePath { get; } = @"C:\Users\lisal\OneDrive\Michael's\GitHub\OOP_Final\OOP_BestiaryFinal\monsters.json";

        public static string MonsterSavePath { get; } = @"DataFiles\monsters.json";
        public static string MundaneItemSavePath { get; } = @"DataFiles\mundaneItems.json";
        public static string MagicItemSavePath { get; } = @"DataFiles\magicItems.json";

        // Properties to storelists: If load functions are successful, data can be pulled from here
        private static List<Loot> mundaneItems = new List<Loot>();
        private static List<Loot> magicItems = new List<Loot>();
        private static List<Creature> creatures = new List<Creature>();

        
        public static void SaveMonsterData(List<Creature> creatureList)
        {
            throw new NotImplementedException();
        }

        public static bool LoadMonsterData()
        {
            // Current Idea: Load data and check for errors
            // If no errors occur, load
            bool wasLoadSuccessful;   // Check if load was successful

            try
            {
                // Get contents from monster save path
                string jsonFile = File.ReadAllText(MonsterSavePath);

                // Deserialize json as creature list
                creatures = JsonSerializer.Deserialize<List<Creature>>(jsonFile);

                // No errors; deserialization was successful. Send true
                wasLoadSuccessful = true;
            }
            catch (Exception e)
            {
                // Error: display error and send false
                MessageBox.Show(e.Message, "Error: Loading Monster File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                wasLoadSuccessful = false;
            }

            // Return results
            return wasLoadSuccessful;
        }

        public static bool LoadMundaneItems()
        {
            bool wasLoadSuccessful;

            try
            {
                string jsonFile = File.ReadAllText(MundaneItemSavePath);

                mundaneItems = JsonSerializer.Deserialize<List<Loot>>(jsonFile);

                wasLoadSuccessful = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error: Loading Mundane Item File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                wasLoadSuccessful = false;
            }

            return wasLoadSuccessful;
        }

        public static bool LoadMagicItems()
        {
            bool wasLoadSuccessful;

            try
            {
                string jsonFile = File.ReadAllText(MagicItemSavePath);

                magicItems = JsonSerializer.Deserialize<List<Loot>>(jsonFile);

                wasLoadSuccessful = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error: Loading Mundane Item File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                wasLoadSuccessful = false;
            }

            return wasLoadSuccessful;
        }

        // Return converted creature list
        public static List<Creature> GetCreatureList()
        {
           return creatures;
        }

        public static List<Loot> GetMundaneList()
        {
            return mundaneItems;
        }

        public static List<Loot> GetMagicList()
        {
            return magicItems;
        }
    }
}
