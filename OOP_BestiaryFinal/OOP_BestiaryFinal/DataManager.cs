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

        public static string MonsterSavePath { get; } = @"DataFiles\monsters.json";

        public static string ItemSavePath { get; } = ConfigurationManager.AppSettings.Get("LootPath")!;
        
        public static void SaveMonsterData(List<Creature> creatureList)
        {
            throw new NotImplementedException();
        }

        public static List<Creature> LoadMonsterData()
        {
            string jsonFile = File.ReadAllText(MonsterSavePath);

            List<Creature> creatures = JsonSerializer.Deserialize<List<Creature>>(jsonFile);

            return creatures;

            //string jsonTest = @"[
            //  {
            //    ""$type"": ""minion"",
            //    ""Name"": ""Goblin Goon"",
            //    ""Description"": ""A pittiful goon.\nDoes paltry damage when it isn\u0027t groveling."",
            //    ""Level"": 1,
            //    ""AC"": 10,
            //    ""CurrentHealth"": 3,
            //    ""MonsterType"": 5,
            //    ""Resists"": 7,
            //    ""_name"": ""Goblin Goon"",
            //    ""_description"": ""A pittiful goon.\nDoes paltry damage when it isn\u0027t groveling."",
            //    ""_level"": 1,
            //    ""_armorClass"": 10,
            //    ""_maxHealth"": 3,
            //    ""_monsterType"": 5,
            //    ""_resists"": 7
            //  },
            //  {
            //    ""$type"": ""elite"",
            //    ""Ability"": {
            //      ""Name"": ""Pokin\u0027 Stick"",
            //      ""Description"": ""Wait. This is just a rusty nail!\nHas a chance to give you tetanus."",
            //      ""Power"": 5,
            //      ""Cost"": 2,
            //      ""DamageType"": 5
            //    },
            //    ""Name"": ""Goblin Big-Boss"",
            //    ""Description"": ""Bigger and tougher than his underlings, this goblin is particuarily cantankerous.\nDon\u0027t let him poke you!"",
            //    ""Level"": 4,
            //    ""AC"": 12,
            //    ""CurrentHealth"": 17,
            //    ""MonsterType"": 5,
            //    ""Resists"": 5,
            //    ""_name"": ""Goblin Big-Boss"",
            //    ""_description"": ""Bigger and tougher than his underlings, this goblin is particuarily cantankerous.\nDon\u0027t let him poke you!"",
            //    ""_level"": 4,
            //    ""_armorClass"": 12,
            //    ""_maxHealth"": 17,
            //    ""_monsterType"": 5,
            //    ""_resists"": 5
            //  },
            //  {
            //    ""$type"": ""worldBoss"",
            //    ""AbilityList"": [
            //      {
            //        ""Name"": ""Rock Pounder"",
            //        ""Description"": ""A mighty slam that can smash through solid rock."",
            //        ""Power"": 100,
            //        ""Cost"": 50,
            //        ""DamageType"": 6
            //      },
            //      {
            //        ""Name"": ""Fire Breath"",
            //        ""Description"": ""Breathe a gout of flame."",
            //        ""Power"": 75,
            //        ""Cost"": 25,
            //        ""DamageType"": 2
            //      }
            //    ],
            //    ""Name"": ""Test Boss"",
            //    ""Description"": ""What do you want me to say? It\u0027s a test."",
            //    ""Level"": 17,
            //    ""AC"": 18,
            //    ""CurrentHealth"": 67,
            //    ""MonsterType"": 1,
            //    ""Resists"": 0,
            //    ""_name"": ""Test Boss"",
            //    ""_description"": ""What do you want me to say? It\u0027s a test."",
            //    ""_level"": 17,
            //    ""_armorClass"": 18,
            //    ""_maxHealth"": 67,
            //    ""_monsterType"": 1,
            //    ""_resists"": 0
            //  }
            //]";

            //JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions() { WriteIndented = true };
            //List<Creature> creatureList = JsonSerializer.Deserialize<List<Creature>>(jsonTest);

            //return creatureList;
        }
    }
}
