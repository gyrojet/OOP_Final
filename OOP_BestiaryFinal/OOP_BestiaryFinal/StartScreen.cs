using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            Creature m1 = new Minion("Goblin Goon",
                "A pittiful goon.\nDoes paltry damage when it isn't groveling.",
                1,
                MonsterType.Humanoid,
                DamageType.None
                );

            Creature m2 = new Elite(
                    "Goblin Big-Boss",
                    "Bigger and tougher than his underlings, this goblin is particuarily cantankerous.\nDon't let him poke you!",
                    4,
                    new Ability
                    (
                            "Pokin' Stick",
                            "Wait. This is just a rusty nail!\nHas a chance to give you tetanus.",
                            5,
                            2,
                            DamageType.Physical
                    ),
                    MonsterType.Humanoid,
                    DamageType.Physical
                );

            Creature m3 = new WorldBoss(
                    "Test Boss",
                    "What do you want me to say? It's a test.",
                    17,
                    new List<Ability>
                    {
                        new Ability
                        (
                            "Rock Pounder",
                            "A mighty slam that can smash through solid rock.",
                            100,
                            50,
                            DamageType.Sonic
                        ),
                        new Ability
                        (
                            "Fire Breath",
                            "Breathe a gout of flame.",
                            75,
                            25,
                            DamageType.Fire
                        )
                    },
                    MonsterType.Alien,
                    DamageType.Acid
                );

            creatureList.Add(m1);
            creatureList.Add(m2);
            creatureList.Add(m3);
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
