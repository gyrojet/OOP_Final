using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_BestiaryFinal
{
    public partial class StartScreen : Form
    {
        List<Creature> creatureList = new List<Creature>();

        public StartScreen()
        {
            InitializeComponent();
        }

        private void PopulateCreatureList()
        {

            //System can't deserialize abstract classes: investigate!

            //Creature m1 = new Minion("Goblin Goon",
            //    "A pittiful goon.\nDoes paltry damage when it isn't groveling.",
            //    1,
            //    MonsterType.Humanoid,
            //    DamageType.None
            //    );

            //Creature m2 = new Elite(
            //        "Goblin Big-Boss",
            //        "Bigger and tougher than his underlings, this goblin is particuarily cantankerous.\nDon't let him poke you!",
            //        4,
            //        new Ability
            //        (
            //                "Pokin' Stick",
            //                "Wait. This is just a rusty nail!\nHas a chance to give you tetanus.",
            //                5,
            //                2,
            //                DamageType.Physical
            //        ),
            //        MonsterType.Humanoid,
            //        DamageType.Physical
            //    );

            //Creature m3 = new WorldBoss(
            //        "Test Boss",
            //        "What do you want me to say? It's a test.",
            //        17,
            //        new List<Ability>
            //        {
            //            new Ability
            //            (
            //                "Rock Pounder",
            //                "A mighty slam that can smash through solid rock.",
            //                100,
            //                50,
            //                DamageType.Sonic
            //            ),
            //            new Ability
            //            (
            //                "Fire Breath",
            //                "Breathe a gout of flame.",
            //                75,
            //                25,
            //                DamageType.Fire
            //            )
            //        },
            //        MonsterType.Alien,
            //        DamageType.Acid
            //    );

            //creatureList.Add(m1);
            //creatureList.Add(m2);
            //creatureList.Add(m3);

            //string json = JsonSerializer.Serialize(creatureList, new JsonSerializerOptions { WriteIndented = true });
            //Debug.WriteLine(json);

            //Attempt number 2: Defining discriminator types!
            string jsonTest = @"[
              {
                ""$type"": ""minion"",
                ""Name"": ""Goblin Goon"",
                ""Description"": ""A pittiful goon.\nDoes paltry damage when it isn\u0027t groveling."",
                ""Level"": 1,
                ""AC"": 10,
                ""CurrentHealth"": 3,
                ""MonsterType"": 5,
                ""Resists"": 7,
                ""_name"": ""Goblin Goon"",
                ""_description"": ""A pittiful goon.\nDoes paltry damage when it isn\u0027t groveling."",
                ""_level"": 1,
                ""_armorClass"": 10,
                ""_maxHealth"": 3,
                ""_monsterType"": 5,
                ""_resists"": 7
              },
              {
                ""$type"": ""elite"",
                ""Ability"": {
                  ""Name"": ""Pokin\u0027 Stick"",
                  ""Description"": ""Wait. This is just a rusty nail!\nHas a chance to give you tetanus."",
                  ""Power"": 5,
                  ""Cost"": 2,
                  ""DamageType"": 5
                },
                ""Name"": ""Goblin Big-Boss"",
                ""Description"": ""Bigger and tougher than his underlings, this goblin is particuarily cantankerous.\nDon\u0027t let him poke you!"",
                ""Level"": 4,
                ""AC"": 12,
                ""CurrentHealth"": 17,
                ""MonsterType"": 5,
                ""Resists"": 5,
                ""_name"": ""Goblin Big-Boss"",
                ""_description"": ""Bigger and tougher than his underlings, this goblin is particuarily cantankerous.\nDon\u0027t let him poke you!"",
                ""_level"": 4,
                ""_armorClass"": 12,
                ""_maxHealth"": 17,
                ""_monsterType"": 5,
                ""_resists"": 5
              },
              {
                ""$type"": ""worldBoss"",
                ""AbilityList"": [
                  {
                    ""Name"": ""Rock Pounder"",
                    ""Description"": ""A mighty slam that can smash through solid rock."",
                    ""Power"": 100,
                    ""Cost"": 50,
                    ""DamageType"": 6
                  },
                  {
                    ""Name"": ""Fire Breath"",
                    ""Description"": ""Breathe a gout of flame."",
                    ""Power"": 75,
                    ""Cost"": 25,
                    ""DamageType"": 2
                  }
                ],
                ""Name"": ""Test Boss"",
                ""Description"": ""What do you want me to say? It\u0027s a test."",
                ""Level"": 17,
                ""AC"": 18,
                ""CurrentHealth"": 67,
                ""MonsterType"": 1,
                ""Resists"": 0,
                ""_name"": ""Test Boss"",
                ""_description"": ""What do you want me to say? It\u0027s a test."",
                ""_level"": 17,
                ""_armorClass"": 18,
                ""_maxHealth"": 67,
                ""_monsterType"": 1,
                ""_resists"": 0
              }
            ]";

            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions() { WriteIndented = true };
            creatureList = JsonSerializer.Deserialize<List<Creature>>(jsonTest);

            Debug.WriteLine("DESERIALIZED");
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get monsters from json file, add to global list
            PopulateCreatureList();

            // Initialize new main form with list
            MonsterForm frm = new MonsterForm(creatureList);
            frm.Show();
            this.Visible = false;
        }

        private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
