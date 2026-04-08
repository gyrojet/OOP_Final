using System.Diagnostics;
using System.Globalization;
using System.Text.Json;

namespace OOP_BestiaryFinal
{
    public partial class MonsterForm : Form
    {
        // Global creature list
        List<Creature> creatureList;
        public MonsterForm(List<Creature> chrLst)
        {
            InitializeComponent();

            // Initialize creature list with values from splash screen
            creatureList = new List<Creature>(chrLst);
            // Clear any existing data and fill the list
            ClearMonsterData();
            PopulateList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Initial load: populate monster list and apply random values
        private void PopulateList()
        {
            // Display a banner message (MAY BE REMOVED?)
            DisplayBannerMessage("Welcome!");

            // If the creature list has values:
            if (creatureList != null)
            {
                // Apply random values
                ApplyRandom();

                // Display list of monsters
                DisplayMonsterList();
            }

            // Set comboboxes to values of enums
            PopulateComboBoxes();
        }

        // Refresh the monster list
        private void DisplayMonsterList()
        {
            // Empty the list
            lstMonsters.Items.Clear();

            // Fill the listboc with monsters
            foreach (Creature creature in creatureList)
            {
                lstMonsters.Items.Add(creature);
            }
        }

        // If a monster has random flagged, apply random hp/ac
        private void ApplyRandom()
        {
            // Apply random ac/hp to monsters with random flagged
            foreach (Creature creature in creatureList)
            {
                if (creature.Randomize)
                    creature.ApplyRandomGen();
            }
        }

        // How to display user data:
        // Get monster
        // Determine type
        // Set controls acordingly
        private void lstMonsters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check to see if something is selected; if not, return
            if (lstMonsters.SelectedIndex == -1)
                return;

            // If the creature is a Creature: display its data
            if (lstMonsters.SelectedItem is Creature c)
                DisplayMonsterData(c);
            else
                Debug.WriteLine("Wrong datatype");

        }

        // Grab the monster's data, display data based on type
        private void DisplayMonsterData(Creature monster)
        {
            // Empty the monster and ability labels
            ClearMonsterData();
            ClearAbilityData();
            // Initialize monster name to a black color
            lblName.ForeColor = Color.Black;

            // monster is a Creature: display vital data
            lblName.Text = monster.Name;
            lblLevel.Text = monster.Level.ToString();
            lblAC.Text = monster.AC.ToString();
            lblHP.Text = monster.CurrentHealth.ToString();
            lblType.Text = monster.MonsterType.ToString();

            // Show monster's description
            rtbDescArea.Text = monster.Describe();

            // If monster is specificaly an elite or world boss, display aditional info
            if (monster is Elite || monster is WorldBoss)
            {
                // enable ability group
                grpAbilities.Enabled = true;
                // Populate ability list with a monster's abilities
                FillAbilityList(monster);
            }
            else // Monster does not have abilities:
            {
                grpAbilities.Enabled = false;
            }

            // If monster has random flag, set a red name
            if (monster.Randomize)
                lblName.ForeColor = Color.Red;
        }

        // Empty the monster detail labels
        private void ClearMonsterData()
        {
            // clear monster info
            lblName.Text = string.Empty;
            lblLevel.Text = string.Empty;
            lblAC.Text = string.Empty;
            lblHP.Text = string.Empty;
            lblType.Text = string.Empty;

            // Clear monster/ability descriptions
            rtbDescArea.Text = string.Empty;
        }

        // Fill the ability list with a monster's abilities
        private void FillAbilityList(object monster)
        {
            // Empty the ability list and empty the stat labels
            //ClearAbilityData();

            // If monster is an Elite
            if (monster is Elite e)
            {
                // Convert ability into a list
                List<Ability> abilities = new List<Ability>() { e.Ability };

                // Display all abilities
                DisplayAbilityList(abilities);
            } // If monster is a world boss, they have a list!
            else if (monster is WorldBoss wb)
            {
                // Get list
                List<Ability> abilities = wb.AbilityList;

                // Display list of abilities
                DisplayAbilityList(abilities);
            }

            // Select first ability
            lstAbilities.SelectedIndex = 0;
        }

        private void ClearAbilityData()
        {
            // Clear list
            lstAbilities.Items.Clear();

            // Empty ability labels
            ClearAbilityStats();
        }

        private void ClearAbilityStats()
        {
            // Empty all ability info labels
            rtbAbilityDesc.Text = string.Empty;

            lblAbilityCost.Text = string.Empty;
            lblAbilityType.Text = string.Empty;
            lblAbilityPower.Text = string.Empty;
        }

        private void DisplayAbilityList(List<Ability> abilities)
        {
            // Clear ability list, NOT labels!
            lstAbilities.Items.Clear();

            // Fill list with abilities
            foreach (Ability ability in abilities)
            {
                lstAbilities.Items.Add(ability);
            }
        }

        private void DisplayAbilityStats(Ability ab)
        {
            // Set values of labels
            lblAbilityCost.Text = ab.Cost.ToString();
            lblAbilityPower.Text = ab.Power.ToString();
            lblAbilityType.Text = ab.DamageType.ToString();

            rtbAbilityDesc.Text = ab.Describe();
        }

        private void PopulateComboBoxes()
        {
            // Fill the combo box with the monster type enum
            cboType.DataSource = Enum.GetValues(typeof(MonsterType));
            cboCreate_Type.DataSource = Enum.GetValues(typeof(MonsterType));
            cboCreate_Class.DataSource = Enum.GetValues(typeof(Classification));
            cboCreate_Resists.DataSource = Enum.GetValues(typeof(DamageType));

            cboCreateAbility_DamageType.DataSource = Enum.GetValues(typeof(DamageType));

            cboMonsterSort.DataSource = Enum.GetValues(typeof(MonsterSortTypes));
            cboSortLoot.DataSource = Enum.GetValues(typeof(LootSortTypes));
            cboSortAbilities.DataSource = Enum.GetValues(typeof(AbilitySortTypes));
        }


        private void DisplayBannerMessage(string msg)
        {   // Display a message at the bottom of the screen
            lblMessenger.Text = msg;
        }

        private void lstAbilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If nothing is selected,
            if (lstAbilities.SelectedIndex == -1)
                return;

            // Check to see if object is an ability, then fill in the data
            ClearAbilityStats();
            if (lstAbilities.SelectedItem is Ability ab)
                DisplayAbilityStats(ab);
        }



        private void MonsterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save Json one last time before closing
            // DataManager.SaveData(creatureList);
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Enable or disable loot gen grouping
            if (chkUseCurrentMonster.Checked)
            {
                cboType.Enabled = false;
                nudLevel.Enabled = false;
            }
            else
            {
                cboType.Enabled = true;
                nudLevel.Enabled = true;
            }
        }

        private void btnGetLoot_Click(object sender, EventArgs e)
        {
            /*
             *  PROCESS:
             *  If checked, get data from selected monster, if one is selected
             *  otherwise, use NUD and combo box
             */

            // Empty the loot list and loot labels
            ClearLootList();
            ClearLootData();

            // Get the monster's gold value, then get the loot list
            GetMonsterGold();
            GetMonsterLootList();
        }

        private void ClearLootList()
        {
            // Clear loot list
            lstItems.Items.Clear();
        }

        private void ClearLootData()
        {
            // Empty description textbox
            rtbLootDescription.Text = string.Empty;
        }

        private void GetMonsterGold()
        {
            // Use current monster's stats
            if (chkUseCurrentMonster.Checked)
            {
                // Return if nothing is selected
                if (lstMonsters.SelectedIndex == -1)
                    return;

                // If the creature is a Creature: display its data
                if (lstMonsters.SelectedItem is Creature c)
                {
                    // Get gold value w/ monster's level/type
                    int gold = LootManager.GetGold(c.Level, c.MonsterType);

                    // Display
                    lblGoldCount.Text = gold.ToString();
                }
            }
            else // Use custom stats
            {
                // return if nothing is selected
                if (cboType.SelectedIndex == -1)
                    return;

                // Get manual level and monster type
                int level = (int)nudLevel.Value;
                MonsterType type = (MonsterType)cboType.SelectedItem;

                // Get gold value with manual level/type
                int gold = LootManager.GetGold(level, type);

                // Display
                lblGoldCount.Text = gold.ToString();
            }
        }

        private void GetMonsterLootList()
        {
            // Declare a list to store the loot
            List<Loot> monsterLoot = new List<Loot>();

            // If we decide to use the currently selected monster
            if (chkUseCurrentMonster.Checked)
            {
                // If nothing is selected, return
                if (lstMonsters.SelectedIndex == -1)
                    return;

                // If the creature is a Creature: ( :0 ) display its data
                if (lstMonsters.SelectedItem is Creature c)
                {
                    //Get loot list using monster's level and type
                    monsterLoot = LootManager.GetLootList(c.Level, c.MonsterType);

                    // Display list of loot
                    DisplayLootList(monsterLoot);
                }
            }
            else // Use custom stats
            {
                // Get manual level/type
                int level = (int)nudLevel.Value;
                MonsterType type = (MonsterType)cboType.SelectedItem;

                // Generate a list of loot using level/type
                monsterLoot = LootManager.GetLootList(level, type);

                // Display loot list
                DisplayLootList(monsterLoot);
            }
        }

        private void DisplayLootList(List<Loot> list)
        {
            // Clear out the loot list
            ClearLootList();

            // Add each loot item to the list
            foreach (Loot l in list)
                lstItems.Items.Add(l);
        }

        private void DisplayLootDetails()
        {
            // If nothing is selected, return
            if (lstItems.SelectedIndex == -1)
                return;

            // If item is loot, display its description
            if (lstItems.SelectedItem is Loot loot)
            {
                //Get description
                rtbLootDescription.Text = loot.Describe();
            }
        }

        
        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear loot list
            ClearLootData();

            // Display info about loot item
            DisplayLootDetails();
        }

        private void chkGenerateACHP_CheckedChanged(object sender, EventArgs e)
        {
            // If you decide to randomly generate a monster's ac/hp, disable the controls
            if (chkGenerateACHP.Checked)
            {
                nudCreate_AC.Enabled = false;
                nudCreate_HP.Enabled = false;
            }
            else
            {
                nudCreate_AC.Enabled = true;
                nudCreate_HP.Enabled = true;
            }
        }

        private void btnCreate_ClearTop_Click(object sender, EventArgs e)
        {
            // Clear all controls on the top panel
            txtCreate_Name.Text = string.Empty;
            rtbCreate_Desc.Text = string.Empty;

            // Set NUDs
            nudCreate_AC.Value = nudCreate_AC.Minimum;
            nudCreate_HP.Value = nudCreate_HP.Minimum;
            nudCreate_Level.Value = nudCreate_Level.Minimum;
            nudCreate_MinionMin.Value = nudCreate_MinionMin.Minimum;
            nudCreate_MinionMax.Value = nudCreate_MinionMax.Minimum;

            // Uncheck random generation
            chkGenerateACHP.Checked = false;

            // Reset combo boxes
            cboCreate_Resists.SelectedIndex = 0;
            cboCreate_Type.SelectedIndex = 0;
        }

        private void cboCreate_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If combobox selection is a monster class
            if (cboCreate_Class.SelectedItem is Classification c)
            {
                // If monster is a minion, disable ability group
                if (c == Classification.Minion)
                {
                    grpCreateMonsterAbilities.Enabled = false;
                    nudCreate_MinionMin.Enabled = true;
                    nudCreate_MinionMax.Enabled = true;
                }
                else // Otherwise, enable the ability group
                {
                    grpCreateMonsterAbilities.Enabled = true;
                    nudCreate_MinionMin.Enabled = false;
                    nudCreate_MinionMax.Enabled = false;
                }
            }
            else
                return;
        }

        private void btnCreate_CreateMonster_Click(object sender, EventArgs e)
        {
            /*
             * Create Monsters,Pass One:
             * - Get all required information:
             *      - Name
             *      - Description
             *      - Type
             *      - Level
             *      - Resistances
             *      - Monster Class
             *      - Randomize
             *      
             *  Step by step:
             *  - get universal attributes (attributes of creature class)
             *  - keep not of Randomize (If true, use alternate constructor
             *  - get class specific attributes(minion's min-max appearing, 
             */
            try
            {
                // Get monster's statistics
                bool isRandom = chkGenerateACHP.Checked;
                int monsterHP = 0;
                int monsterAC = 0;

                //Get all properties 
                string monsterName = txtCreate_Name.Text;
                string monsterDesc = rtbCreate_Desc.Text;
                MonsterType monsterType = (MonsterType)cboCreate_Type.SelectedItem;
                int monsterLevel = (int)nudCreate_Level.Value;
                DamageType monsterResists = (DamageType)cboCreate_Resists.SelectedItem;
                Classification monsterClass = (Classification)cboCreate_Class.SelectedItem;

                // If name or description are null:
                if (string.IsNullOrWhiteSpace(monsterName) ||
                    string.IsNullOrWhiteSpace(monsterDesc))
                {
                    // Display an error and return
                    MessageBox.Show("Name or description cannot be null!", "Error: Abilities", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                // If monster is a minion:
                if (monsterClass == Classification.Minion)
                {
                    // Get max/min number of monsters
                    int monsterMin = (int)nudCreate_MinionMin.Value;
                    int monsterMax = (int)nudCreate_MinionMax.Value;

                    // If monster's hp/ac is not random
                    if (!isRandom)
                    {
                        // Get fixed values
                        monsterHP = (int)nudCreate_HP.Value;
                        monsterAC = (int)nudCreate_AC.Value;

                        // Create a minion with fixed values
                        Minion myMinion = new Minion(
                                monsterName,
                                monsterDesc,
                                monsterLevel,
                                monsterAC,
                                monsterHP,
                                monsterClass,
                                monsterType,
                                monsterResists,
                                isRandom,
                                monsterMin,
                                monsterMax
                            );

                        // Add to list and display
                        creatureList.Add(myMinion);
                        DisplayMonsterList();
                    }
                    else
                    {
                        // Create minion w/o set hp/ac
                        Minion myMinion = new Minion(
                                monsterName,
                                monsterDesc,
                                monsterLevel,
                                monsterClass,
                                monsterType,
                                monsterResists,
                                isRandom,
                                monsterMin,
                                monsterMax
                            );

                        // Add to list and display
                        creatureList.Add(myMinion);
                        DisplayMonsterList();
                    }
                }
                else// Create a monster with ABILITIES
                {
                    // Ability list must have at least one ability!
                    if (lstCreateAbility_List.Items.Count <= 0)
                    {
                        MessageBox.Show("Please create 1 or more abilities.", "Error: Abilities", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    // If monster is an elite
                    if (monsterClass == Classification.Elite)
                    {
                        // Check to see if an ability is selected
                        if (lstCreateAbility_List.SelectedIndex == -1)
                        {
                            MessageBox.Show("Please select an ability from the list.", "Error: No Ability selected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                        else
                        {
                            // If the selected ability is valid
                            if (lstCreateAbility_List.SelectedItem is Ability newAbility)
                            {
                                // If monster's hp/ac is not random
                                if (!isRandom)
                                {
                                    // Get fixed hp/ac
                                    monsterHP = (int)nudCreate_HP.Value;
                                    monsterAC = (int)nudCreate_AC.Value;

                                    // Create elite with fixed hp/ac
                                    Elite myElite = new Elite(
                                            monsterName,
                                            monsterDesc,
                                            monsterLevel,
                                            newAbility,
                                            monsterAC,
                                            monsterHP,
                                            monsterClass,
                                            monsterType,
                                            monsterResists,
                                            isRandom
                                        );

                                    // Add to list and display
                                    creatureList.Add(myElite);
                                    DisplayMonsterList();
                                }
                                else
                                {
                                    // Create elite with randomized hp/ac
                                    Elite myElite = new Elite(
                                            monsterName,
                                            monsterDesc,
                                            monsterLevel,
                                            newAbility,
                                            monsterClass,
                                            monsterType,
                                            monsterResists,
                                            isRandom
                                        );

                                    // Add to list and display
                                    creatureList.Add(myElite);
                                    DisplayMonsterList();

                                }
                            }
                        }
                    }
                    else if (monsterClass == Classification.WorldBoss) // If you're making a world boss:
                    {
                        // Get world boss from list, if one exists
                        var worldBoss = creatureList
                                        .Where(c => c.MonsterClass == Classification.WorldBoss)
                                        .FirstOrDefault();

                        /* 
                            DEMO TIME!!!!!
                         */
                        
                        //// If a world boss already exists
                        //if (worldBoss != null)
                        //{
                        //    MessageBox.Show("There may only be one world boss!", "Error: World Boss Already Exists!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //    return;
                        //}

                        // Declare a boss
                        WorldBoss newWorldBoss;

                        // If monster's hp/ac is not random
                        if (!isRandom)
                        {
                            // Get fixed hp/ac
                            monsterHP = (int)nudCreate_HP.Value;
                            monsterAC = (int)nudCreate_AC.Value;

                            // Create boss w/ fixed hp/ac
                            newWorldBoss = new WorldBoss(
                                    monsterName,
                                    monsterDesc,
                                    monsterLevel,
                                    new List<Ability>(),
                                    monsterAC,
                                    monsterHP,
                                    monsterClass,
                                    monsterType,
                                    monsterResists,
                                    isRandom
                                );
                        }
                        else
                        {
                            // Create boss with random values
                            newWorldBoss = new WorldBoss(
                                    monsterName,
                                    monsterDesc,
                                    monsterLevel,
                                    new List<Ability>(),
                                    monsterClass,
                                    monsterType,
                                    monsterResists,
                                    isRandom
                                );
                        }

                        // For each ability in the list, add it to the boss!
                        foreach (var item in lstCreateAbility_List.Items)
                        {
                            // If the ability is valid: add it!
                            if (item is Ability ability)
                            {
                                newWorldBoss += ability;
                            }
                        }

                        // Add to list and display
                        creatureList.Add(newWorldBoss);
                        DisplayMonsterList();
                    }
                }

                // If this runs, then you are successful!
                MessageBox.Show("Monster Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Creating Monster", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void CreateAbility()
        {
            
            // Get ability details
            string abilityName = txtCreateAbility_Name.Text;
            int abilityCost = (int)nudCreateAbility_Cost.Value;
            int abilityPower = (int)nudCreateAbility_Power.Value;
            DamageType abilityDT = (DamageType)cboCreateAbility_DamageType.SelectedItem;
            string abilityDesc = rtbCreateAbility_Desc.Text;

            // If name and description are NOT null
            if (!string.IsNullOrEmpty(abilityName) &&
                !string.IsNullOrEmpty(abilityDesc))
            {
                // Create a new ability
                Ability newAbility = new Ability(
                        abilityName,
                        abilityDesc,
                        abilityPower,
                        abilityCost,
                        abilityDT
                    );

                // Add ability to list
                lstCreateAbility_List.Items.Add(newAbility);
            }
            else
            {
                // error!!!
                MessageBox.Show("One or more properties of your ability are invalid.", "Error: Creating Ability", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCreateControls_ClearList_Click(object sender, EventArgs e)
        {
            // Clear the ability Creation list
            lstCreateAbility_List.Items.Clear();
        }

        private void btnCreateAbility_ClearBottom_Click(object sender, EventArgs e)
        {
            // Clear the ability creation controls
            txtCreateAbility_Name.Text = string.Empty;
            rtbCreateAbility_Desc.Text = string.Empty;

            nudCreateAbility_Cost.Value = nudCreateAbility_Cost.Minimum;
            nudCreateAbility_Power.Value = nudCreateAbility_Power.Minimum;
        }

        private void btnCreateAbility_Create_Click(object sender, EventArgs e)
        {
            // Create the ability...
            CreateAbility();
        }

        private void btnMonsterSort_Click(object sender, EventArgs e)
        {
            // Sort list of creatures
            if (cboMonsterSort.SelectedItem is MonsterSortTypes mst)
                SortCreatures(mst);
        }

        private void btnSortLoot_Click(object sender, EventArgs e)
        {
            // Sort list of loot
            if (cboSortLoot.SelectedItem is LootSortTypes lst)
                SortLoot(lst);
        }

        private void btnSortAbilities_Click(object sender, EventArgs e)
        {
            // Sort list of abilities
            if (cboSortAbilities.SelectedItem is AbilitySortTypes ast)
                SortAbilities(ast);
        }

        private void SortCreatures(MonsterSortTypes sortType)
        {
            try
            {
                switch (sortType)
                {
                    case MonsterSortTypes.Class:
                        creatureList = creatureList
                                       .OrderBy(c => c.MonsterClass)
                                       .ThenBy(c => c.Name)
                                       .ToList();
                        DisplayMonsterList();
                        break;

                    case MonsterSortTypes.Type:
                        creatureList = creatureList
                                       .OrderBy(c => c.MonsterType)
                                       .ThenBy(c => c.Name)
                                       .ToList();
                        DisplayMonsterList();
                        break;

                    case MonsterSortTypes.Level:
                        creatureList = creatureList
                                       .OrderBy(c => c.Level)
                                       .ThenBy(c => c.Name)
                                       .ToList();
                        DisplayMonsterList();
                        break;

                    case MonsterSortTypes.HP:
                        creatureList = creatureList
                                       .OrderBy(c => c.CurrentHealth)
                                       .ThenBy(c => c.Name)
                                       .ToList();
                        DisplayMonsterList();
                        break;

                    case MonsterSortTypes.AC:
                        creatureList = creatureList
                                       .OrderBy(c => c.AC)
                                       .ThenBy(c => c.Name)
                                       .ToList();
                        DisplayMonsterList();
                        break;

                    case MonsterSortTypes.Name:
                        creatureList = creatureList
                                       .OrderBy(c => c.Name)
                                       .ToList();
                        DisplayMonsterList();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR: Monster Sorting", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void SortLoot(LootSortTypes sortType)
        {
            List<Loot> lootList;
            try
            { 
                switch (sortType)
                {
                    case LootSortTypes.Name:
                        lootList = lstItems.Items.OfType<Loot>()
                                   .OrderBy(l => l.Name)
                                   .ToList();

                        DisplayLootList(lootList);
                        break;

                    case LootSortTypes.IsMagic:
                        lootList = lstItems.Items.OfType<Loot>()
                                   .OrderByDescending(l => l.IsMagical)
                                   .ThenBy(l => l.Name)
                                   .ToList();

                        DisplayLootList(lootList);
                        break;

                    case LootSortTypes.Value:
                        lootList = lstItems.Items.OfType<Loot>()
                                   .OrderBy(l => l.Value)
                                   .ThenBy(l => l.Name)
                                   .ToList();

                        DisplayLootList(lootList);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR: Loot Sorting", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void SortAbilities(AbilitySortTypes sortType)
        {
            List<Ability> abilityList;
            try
            {
                switch (sortType)
                {
                    case AbilitySortTypes.Power:
                        abilityList = lstAbilities.Items.OfType<Ability>()
                                      .OrderBy(a => a.Power)
                                      .ThenBy(a => a.Name)
                                      .ToList();

                        DisplayAbilityList(abilityList);
                        break;

                    case AbilitySortTypes.Cost:
                        abilityList = lstAbilities.Items.OfType<Ability>()
                                      .OrderBy(a => a.Cost)
                                      .ThenBy(a => a.Name)
                                      .ToList();

                        DisplayAbilityList(abilityList);
                        break;

                    case AbilitySortTypes.Type:
                        abilityList = lstAbilities.Items.OfType<Ability>()
                                      .OrderBy(a => a.DamageType)
                                      .ThenBy(a => a.Name)
                                      .ToList();

                        DisplayAbilityList(abilityList);
                        break;

                    case AbilitySortTypes.Name:
                        abilityList = lstAbilities.Items.OfType<Ability>()
                                      .OrderBy(a => a.Name)
                                      .ToList();

                        DisplayAbilityList(abilityList);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR: Creature Sorting", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
