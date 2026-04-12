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
    // The start form: used to load data
    public partial class StartScreen : Form
    {
        //Creature and ability lists to be sent forward
        List<Creature> creatureList = new List<Creature>();
        List<Ability> abilityList = new List<Ability>();

        public StartScreen()
        {
            InitializeComponent();
        }

        // Loads data lists from the data manager to be sent to the monster form
        private bool PopulateLists()
        {
            try
            {
                // If monster list is successfuly loaded, grab it from class
                if (DataManager.LoadMonsterData())
                {
                    // Grab monster list from data manager
                    creatureList = DataManager.GetCreatureList();
                }
                else // If load fails, return false
                    return false;

                // Load item data: if it fails, return false
                if (DataManager.LoadMundaneItems() && DataManager.LoadMagicItems())
                {
                    // Grab and load item lists from data manager
                    LootManager.LoadMundaneItemList(DataManager.GetMundaneList());
                    LootManager.LoadMagicItemList(DataManager.GetMagicList());
                }
                else // Load failed, return false
                    return false;

                // Load ability list: if it fails, return false
                if (DataManager.LoadAbilities())
                {
                    // Grab ability list from data manager
                    abilityList = DataManager.GetAbilityList();
                }
                else // Load failed, return false
                    return false;

                // Lists were loaded without issue
                return true;
            }
            catch (Exception ex) 
            {
                // If an error occurs in this block:
                MessageBox.Show(ex.Message, "Error: Loading Lists", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {   // Attempt to load lists of data
            if (PopulateLists())
            {
                // Create the main form, pass the lists forward
                MonsterForm frm = new MonsterForm(creatureList, abilityList, this);
                frm.Show(); // Show the new form
                this.Visible = false; // Hide splash screen
            }
            else // If there was an error loading the lists:
                MessageBox.Show("ERROR: One or more lists failed to load.", "Error: Loading Lists", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }


        public void CloseMe()
        {
            // Close this form to end the program
            this.Close();
        }
    }
}
