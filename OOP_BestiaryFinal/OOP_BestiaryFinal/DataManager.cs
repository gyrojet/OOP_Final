using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
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
        
        // Paths to monster, item and ability lists
        public static string MonsterSavePath { get; } = @"..\..\..\DataFiles\monsters.json";
        public static string MundaneItemSavePath { get; } = @"..\..\..\DataFiles\mundaneItems.json";
        public static string MagicItemSavePath { get; } = @"..\..\..\DataFiles\magicItems.json";
        public static string AbilityListSavePath { get; } = @"..\..\..\DataFiles\abilities.json";

        // Properties to store lists: If load functions are successful, data can be pulled from here
        private static List<Loot> mundaneItems = new List<Loot>();
        private static List<Loot> magicItems = new List<Loot>();
        private static List<Creature> creatures = new List<Creature>();
        private static List<Ability> abilities = new List<Ability>();

        
        public static bool SaveMonsterData(List<Creature> creatureList)
        {
            // Check if save was successful
            bool wasSaveSuccessful = true;

            try
            {
                // Serialize Object
                string serializedList = JsonSerializer.Serialize(creatureList, new JsonSerializerOptions { WriteIndented = true });
                Debug.WriteLine(serializedList);

                // If the monster file exists
                if (File.Exists(MonsterSavePath))
                {
                    // Use stream writer to write data
                    using (StreamWriter sw = new StreamWriter(MonsterSavePath, false))
                    {
                        // Split contents into array
                        string[] brokenContents = serializedList.Split("\r\n");

                        // Write each line to path
                        foreach (string line in brokenContents)
                            sw.WriteLine(line);

                        // Close stream writter
                        sw.Close();
                    }
                }
                else
                {
                    // Display error message
                    MessageBox.Show("The file you are attempting to save to does not exist.", "Error: Saving Monster List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    wasSaveSuccessful = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Saving Monster List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return wasSaveSuccessful;
        }

        public static bool SaveCustomAbilityData(List<Ability> abilityList)
        {
            //MessageBox.Show("Saving Ability Data...");
            bool wasSaveSuccessful = true;

            try
            {
                // Serialize Object
                string serializedList = JsonSerializer.Serialize(abilityList, new JsonSerializerOptions { WriteIndented = true });
                Debug.WriteLine(serializedList);

                if (File.Exists(AbilityListSavePath))
                {
                    using (StreamWriter sw = new StreamWriter(AbilityListSavePath, false))
                    {
                        Debug.WriteLine(AbilityListSavePath);

                        string[] brokenContents = serializedList.Split("\r\n");

                        foreach (string line in brokenContents)
                            sw.WriteLine(line);

                        //File.WriteAllText(AbilityListSavePath, serializedList);

                        sw.Close();
                    }
                    Debug.WriteLine(File.ReadAllText(AbilityListSavePath));
                }
                else
                {
                    MessageBox.Show("The file you are attempting to save to does not exist.", "Error: Saving Monster List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    wasSaveSuccessful = false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error: Saving Ability List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                wasSaveSuccessful = false;
            }

            return wasSaveSuccessful;
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

        public static bool LoadAbilities()
        {
            bool wasLoadSuccessful;

            try
            {
                string jsonFile = File.ReadAllText(AbilityListSavePath);

                abilities = JsonSerializer.Deserialize<List<Ability>>(jsonFile);

                wasLoadSuccessful = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error: Loading Ability File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        public static List<Ability> GetAbilityList()
        {
            return abilities;
        }
    }
}
