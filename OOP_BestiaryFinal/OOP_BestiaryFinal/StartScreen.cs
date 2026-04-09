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
        List<Ability> abilityList = new List<Ability>();

        public StartScreen()
        {
            InitializeComponent();
        }

        private bool PopulateLists()
        { 
            // If monster list is successfuly loaded, grab it from class
            if (DataManager.LoadMonsterData())
            {
                creatureList = DataManager.GetCreatureList();
            }
            else // If load fails, return false
                return false;

            // Load item data: if it fails, return false
            
             if (DataManager.LoadMundaneItems() && DataManager.LoadMagicItems())
             {
                LootManager.LoadMundaneItemList(DataManager.GetMundaneList());
                LootManager.LoadMagicItemList(DataManager.GetMagicList());
             }
             else
                return false;

             if (DataManager.LoadAbilities())
             {
                abilityList = DataManager.GetAbilityList();
             }
             else
                return false;
             
             // Lists were loaded without issue
            return true;
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PopulateLists())
            {
                MonsterForm frm = new MonsterForm(creatureList, abilityList);
                frm.Show();
                this.Visible = false;
            }
            else
                MessageBox.Show("ERROR: One or more lists failed to load.", "Error: Loading Lists", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

    }
}
