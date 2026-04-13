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
                    // If the file does not exist
                    MessageBox.Show("The file you are attempting to save to does not exist.", "Error: Saving Monster List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    wasSaveSuccessful = false;
                }
            }
            catch (Exception ex)
            {   // Error message
                MessageBox.Show(ex.Message, "Error: Saving Monster List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Return status of loading
            return wasSaveSuccessful;
        }

        public static bool SaveCustomAbilityData(List<Ability> abilityList)
        {
            // Were we successful?
            bool wasSaveSuccessful = true;

            try
            {
                // Serialize Object
                string serializedList = JsonSerializer.Serialize(abilityList, new JsonSerializerOptions { WriteIndented = true });

                // If the ability file exists
                if (File.Exists(AbilityListSavePath))
                {
                    //Use stream writer to write to file
                    using (StreamWriter sw = new StreamWriter(AbilityListSavePath, false))
                    {
                        // Break serialized object into a string array
                        string[] brokenContents = serializedList.Split("\r\n");

                        // Write each line to the file
                        foreach (string line in brokenContents)
                            sw.WriteLine(line);

                        // Close SW
                        sw.Close();
                    }
                }
                else
                {   // If the file does not exist
                    MessageBox.Show("The file you are attempting to save to does not exist.", "Error: Saving Monster List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    wasSaveSuccessful = false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error: Saving Ability List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                wasSaveSuccessful = false;
            }

            // Return loading status
            return wasSaveSuccessful;
        }

        public static bool LoadMonsterData()
        {
           
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
            // Was the load successful?
            bool wasLoadSuccessful;

            try
            {
                // Load the contents of the item file
                string jsonFile = File.ReadAllText(MundaneItemSavePath);

                // Deserialize it
                mundaneItems = JsonSerializer.Deserialize<List<Loot>>(jsonFile);

                // Load was successful
                wasLoadSuccessful = true;
            }
            catch (Exception e)
            {
                // Display an error messsage, set as false
                MessageBox.Show(e.Message, "Error: Loading Mundane Item File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                wasLoadSuccessful = false;
            }
            
            // Return results
            return wasLoadSuccessful;
        }

        public static bool LoadMagicItems()
        {
            // Were we successful?
            bool wasLoadSuccessful;

            try
            {
                // Load data from file
                string jsonFile = File.ReadAllText(MagicItemSavePath);

                // Deserialize it
                magicItems = JsonSerializer.Deserialize<List<Loot>>(jsonFile);

                // Success!
                wasLoadSuccessful = true;
            }
            catch (Exception e)
            {
                // There was an error: set as false
                MessageBox.Show(e.Message, "Error: Loading Magic Item File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                wasLoadSuccessful = false;
            }

            // Return results
            return wasLoadSuccessful;
        }

        public static bool LoadAbilities()
        {
            // Were we successful?
            bool wasLoadSuccessful;

            try
            {
                // Load data from file
                string jsonFile = File.ReadAllText(AbilityListSavePath);

                // Deserialize it
                abilities = JsonSerializer.Deserialize<List<Ability>>(jsonFile);

                // Success!
                wasLoadSuccessful = true;
            }
            catch (Exception e)
            {
                // There was an error: set as false
                MessageBox.Show(e.Message, "Error: Loading Ability File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                wasLoadSuccessful = false;
            }

            // Return results
            return wasLoadSuccessful;
        }

        // Return converted creature list
        public static List<Creature> GetCreatureList()
        {
            // Return creature list
           return creatures;
        }

        // Return converted mundane item list
        public static List<Loot> GetMundaneList()
        {
            // Return mundane item list
            return mundaneItems;
        }

        // Return converted magic item list
        public static List<Loot> GetMagicList()
        {
            // Return magic item list
            return magicItems;
        }
        // Return converted Ability list
        public static List<Ability> GetAbilityList()
        {
            // Return ability list
            return abilities;
        }
    }
}
