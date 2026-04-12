using System.Diagnostics;
using System.Globalization;
using System.Text.Json;

namespace OOP_BestiaryFinal
{
    public partial class MonsterForm : Form
    {
        // Reference to the previous screen
        StartScreen previous;

        // Global creature list
        List<Creature> creatureList;
        List<Ability> abilityList;

        bool madeChanges = false;
        bool closed = false;

        public MonsterForm(List<Creature> chrLst, List<Ability> ablList, StartScreen prev)
        {
            InitializeComponent();

            // Initialize creature list with values from splash screen
            creatureList = new List<Creature>(chrLst);
            abilityList = new List<Ability>(ablList);

            // Set previous reference
            previous = prev;
            // Clear any existing data and fill the list
            ClearMonsterData();
            PopulateList();
        }

        // Initial load: populate monster list and apply random values
        private void PopulateList()
        {
            // If the creature list has values:
            if (creatureList != null)
            {
                // Apply random values
                ApplyRandom();

                // Display list of monsters
                DisplayMonsterList();
            }

            // If ability list is not null
            if (abilityList != null)
            {
                // Display the custom ability list
                DisplayCustomAbilityList();
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

        private void DisplayCustomAbilityList()
        {
            // Clear the list of custom abilities
            lstCreateAbility_List.Items.Clear();

            // Add each ability to the list
            foreach (Ability ability in abilityList)
            {
                lstCreateAbility_List.Items.Add(ability);
            }
        }

        // If a monster has random flagged, apply random hp/ac
        private void ApplyRandom()
        {
            // Apply random ac/hp to monsters with random flagged
            foreach (Creature creature in creatureList)
            {
                // apply random hp/ac to each randomly flagged monster
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

        private void ClearCustomAbilityStats()
        {
            // Empty all labels for custom ability creation
            txtCreateAbility_Name.Text = string.Empty;

            nudCreateAbility_Power.Value = nudCreateAbility_Power.Minimum;
            nudCreateAbility_Cost.Value = nudCreateAbility_Cost.Minimum;

            rtbCreateAbility_Desc.Text = string.Empty;

            cboCreateAbility_DamageType.SelectedIndex = 0;
        }

        private void DisplayCustomAbilityStats(Ability ab)
        {
            // Display all custom ability info
            txtCreateAbility_Name.Text = ab.Name;

            nudCreateAbility_Power.Value = ab.Power;
            nudCreateAbility_Cost.Value = ab.Cost;

            cboCreateAbility_DamageType.SelectedIndex = (int)ab.DamageType;

            rtbCreateAbility_Desc.Text = ab.Description;
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

            // Fill ability damage type cbo
            cboCreateAbility_DamageType.DataSource = Enum.GetValues(typeof(DamageType));

            // Fill sorting cbos
            cboMonsterSort.DataSource = Enum.GetValues(typeof(MonsterSortTypes));
            cboSortLoot.DataSource = Enum.GetValues(typeof(LootSortTypes));
            cboSortAbilities.DataSource = Enum.GetValues(typeof(AbilitySortTypes));
            cboCreateAbility_SortTypes.DataSource = Enum.GetValues(typeof(AbilitySortTypes));
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
            // If a new monster was made, a new ability was made, or an existing ability was changed: prompt user to save!
            if (madeChanges)
            {
                // Message for messagebox
                string msg = "You have made changes.\n\nWould you like to save your data?";
                // Display choice to user
                DialogResult willUserSave = MessageBox.Show(msg, "Please save your data!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                // If user choses to save
                if (willUserSave == DialogResult.Yes)
                {
                    // Attempt to save data
                    if (DataManager.SaveMonsterData(creatureList) && DataManager.SaveCustomAbilityData(abilityList))
                    {
                        // If successful, display a message and exit
                        MessageBox.Show("Data saved successfuly. Have a nice day! :D", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        previous.CloseMe();
                    }
                    else // If saving fails, cancel closing
                    {
                        MessageBox.Show("Saving canceled!", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                }
                else if (willUserSave == DialogResult.No)
                {
                    // Close the previous form
                    previous.CloseMe();
                }
                else if (willUserSave == DialogResult.Cancel)
                {
                    // Cancel the closing sequence
                    e.Cancel = true;
                }
            }
            else // If no changes were made, no need to save!
                previous.CloseMe();
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

            try
            {
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
                    if (cboType.SelectedItem is MonsterType type)
                    {
                        // Get manual level/type
                        int level = (int)nudLevel.Value;
                      
                        // Generate a list of loot using level/type
                        monsterLoot = LootManager.GetLootList(level, type);

                        // Display loot list
                        DisplayLootList(monsterLoot);
                    }
                    else
                        MessageBox.Show("The Monster Type you have selected is invalid!", "Error: Getting Loot", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                // There was an error:
                MessageBox.Show(ex.Message, "Error: Getting Loot", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                    //grpCreateMonsterAbilities.Enabled = false;
                    nudCreate_MinionMin.Enabled = true;
                    nudCreate_MinionMax.Enabled = true;
                }
                else // Otherwise, enable the ability group
                {
                    //grpCreateMonsterAbilities.Enabled = true;
                    nudCreate_MinionMin.Enabled = false;
                    nudCreate_MinionMax.Enabled = false;
                }
            }
            else
                return;
        }

        private void btnCreate_CreateMonster_Click(object sender, EventArgs e)
        {
            try
            {
                // Get enums from cbos
                if (cboCreate_Type.SelectedItem is MonsterType monsterType &&
                    cboCreate_Resists.SelectedItem is DamageType monsterResists &&
                    cboCreate_Class.SelectedItem is Classification monsterClass)
                {
                    // Check if there was an error
                    bool wasError = false;

                    // Get monster's statistics
                    bool isRandom = chkGenerateACHP.Checked;
                    int monsterHP = 0;
                    int monsterAC = 0;

                    //Get all properties 
                    string monsterName = txtCreate_Name.Text;
                    string monsterDesc = rtbCreate_Desc.Text;
                    int monsterLevel = (int)nudCreate_Level.Value;

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

                            // If there are no duplicates
                            if (!CheckMonsterListForDuplicates(myMinion))
                            {
                                // Add to list and display
                                creatureList.Add(myMinion);

                                // Changes were made
                                madeChanges = true;

                                // Display monster list
                                DisplayMonsterList();
                            }
                            else
                            {
                                // Display message
                                MessageBox.Show($"Monsters must have different names, levels, types, resistances and classes!", "Error: Duplicate Monster", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                wasError = true;
                            }
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

                            // If there are no duplicates
                            if (!CheckMonsterListForDuplicates(myMinion))
                            {
                                // Add to list and display
                                creatureList.Add(myMinion);

                                // Changes were made
                                madeChanges = true;

                                // Display monster list
                                DisplayMonsterList();
                            }
                            else
                            {
                                // Display message
                                MessageBox.Show($"Monsters must have different names, levels, types, resistances and classes!", "Error: Duplicate Monster", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                wasError = true;
                            }
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

                                        // Check for duplicates
                                        if (!CheckMonsterListForDuplicates(myElite))
                                        {
                                            // Add to list and display
                                            creatureList.Add(myElite);

                                            // Changes were made...
                                            madeChanges = true;
                                            // Display list
                                            DisplayMonsterList();
                                        }
                                        else
                                        {
                                            // Display Error
                                            MessageBox.Show($"Monsters must have different names, levels, types, resistances and classes!", "Error: Duplicate Monster", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            wasError = true;
                                        }
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

                                        // Check for duplicates
                                        if (!CheckMonsterListForDuplicates(myElite))
                                        {
                                            // Add to list and display
                                            creatureList.Add(myElite);
                                            // Changes were made
                                            madeChanges = true;
                                            // Display list
                                            DisplayMonsterList();
                                        }
                                        else
                                        {
                                            // Display error
                                            MessageBox.Show($"Monsters must have different names, levels, types, resistances and classes!", "Error: Duplicate Monster", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            wasError = true;
                                        }
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

                            //// If a world boss already exists
                            if (worldBoss is not null)
                            {
                                // Display error
                                MessageBox.Show("There may only be one world boss!", "Error: World Boss Already Exists!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }

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

                            // Check for duplicates
                            if (!CheckMonsterListForDuplicates(newWorldBoss))
                            {
                                // Add to list and display
                                creatureList.Add(newWorldBoss);

                                // Confirm changes were made
                                madeChanges = true;

                                // Display list of monsters
                                DisplayMonsterList();
                            }
                            else
                            {
                                // Display error message
                                MessageBox.Show($"Monsters must have different names, levels, types, resistances and classes!", "Error: Duplicate Monster", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                wasError = true;
                            }
                        }
                    }
                    if (!wasError) // Display success message
                        MessageBox.Show("Monster Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // One or more enums were invalid!
                    MessageBox.Show("Type, Classification or Resistance is invalid!", "Error: Creating monster", MessageBoxButtons.OK, MessageBoxIcon.Information);

               

            }
            catch (Exception ex)
            {
                // Display an error
                MessageBox.Show(ex.Message, "Error: Creating Monster", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private bool CheckMonsterListForDuplicates(Creature creatureToCheck)
        {
            // Tells us if creature is a duplicate
            bool isDuplicate = false;

            // Check each creature in list
            foreach (Creature c in creatureList)
            {
                // If creatures match, it is a duplicate!
                if (c == creatureToCheck)
                    isDuplicate = true;
            }

            // Return status
            return isDuplicate;
        }

        private void CreateAbility()
        {
            try
            {   
                //if the enum is valid
                if (cboCreateAbility_DamageType.SelectedItem is DamageType abilityDT)
                {
                    // Check if an error ocurrs
                    bool wasError = false;

                    // Get ability details
                    string abilityName = txtCreateAbility_Name.Text;
                    int abilityCost = (int)nudCreateAbility_Cost.Value;
                    int abilityPower = (int)nudCreateAbility_Power.Value;
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

                        // Before adding to list, we check to see if a simmilar ability already exists in the list.

                        // If ability is not a duplicate:
                        if (!CheckAbilityListForDuplicates(newAbility))
                        {
                            // Add ability to list
                            abilityList.Add(newAbility);
                            // Changes were made
                            madeChanges = true;

                            //Display list
                            DisplayCustomAbilityList();
                        }
                        else
                        {// Otherwise display an error.
                            MessageBox.Show($"Abilities must have different names, costs, powers and damage types.", "Error: Duplicate Ability", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            wasError = true;
                        }

                        // Display success message
                        if (!wasError)
                            MessageBox.Show($"Ability {newAbility.Name} was created successfuly.", "New Ability Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // error!!!
                        MessageBox.Show("One or more properties of your ability are invalid.", "Error: Creating Ability", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else // If cbo has invlaid input
                    MessageBox.Show("Damage Type is Invalid!", "Error: Creating Ability", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Creating Ability", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private bool CheckAbilityListForDuplicates(Ability abilityToCheck)
        {
            // Tells us if an item is a duplicte
            bool isDuplicate = false;

            // Check each ability in the list:
            foreach (Ability a in abilityList)
            {
                // If the abilities match, there is a duplicate!
                if (a == abilityToCheck)
                    isDuplicate = true;
            }

            // Return status
            return isDuplicate;
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
            // If list is not empty
            if (creatureList.Count > 0)
            {
                // Sort list of creatures
                if (cboMonsterSort.SelectedItem is MonsterSortTypes mst)
                    SortCreatures(mst);
                else
                    MessageBox.Show("Sort type is invalid!", "Error: Sorting Creatures", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else // Display error
                MessageBox.Show("Collection is empty.", "Error: Sorting Creatures", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnSortLoot_Click(object sender, EventArgs e)
        {
            // If list is not empty
            if (lstItems.Items.Count > 0)
            {
                // Sort list of loot
                if (cboSortLoot.SelectedItem is LootSortTypes lst)
                    SortLoot(lst);
                else
                    MessageBox.Show("Sort type is invalid!", "Error: Sorting Loot", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else // Display error
                MessageBox.Show("Collection is empty.", "Error: Sorting Loot", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnSortAbilities_Click(object sender, EventArgs e)
        {
            // If list is not empty
            if (lstAbilities.Items.Count > 0)
            {
                // Sort list of abilities
                if (cboSortAbilities.SelectedItem is AbilitySortTypes ast)
                    SortAbilities(ast);
                else
                    MessageBox.Show("Sort type is invalid!", "Error: Sorting Abilities", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else // display error
                MessageBox.Show("Collection is empty.", "Error: Sorting Abilities", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void SortCreatures(MonsterSortTypes sortType)
        {
            try
            {   // Sort based on sort type
                switch (sortType)
                {
                    // Sort by class (minion, elite, world boss)
                    case MonsterSortTypes.Class:
                        creatureList = creatureList
                                       .OrderBy(c => c.MonsterClass)
                                       .ThenBy(c => c.Name)
                                       .ToList();
                        DisplayMonsterList();

                        break;
                    // Sort by monster type (animal, alien, etc)
                    case MonsterSortTypes.Type:
                        creatureList = creatureList
                                       .OrderBy(c => c.MonsterType)
                                       .ThenBy(c => c.Name)
                                       .ToList();
                        DisplayMonsterList();
                        break;
                    // Sort by  level
                    case MonsterSortTypes.Level:
                        creatureList = creatureList
                                       .OrderBy(c => c.Level)
                                       .ThenBy(c => c.Name)
                                       .ToList();
                        DisplayMonsterList();
                        break;
                    // Sort by hp
                    case MonsterSortTypes.HP:
                        creatureList = creatureList
                                       .OrderBy(c => c.CurrentHealth)
                                       .ThenBy(c => c.Name)
                                       .ToList();
                        DisplayMonsterList();
                        break;
                    // Sort by AC
                    case MonsterSortTypes.AC:
                        creatureList = creatureList
                                       .OrderBy(c => c.AC)
                                       .ThenBy(c => c.Name)
                                       .ToList();
                        DisplayMonsterList();
                        break;
                    // Sort by name
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
                // Display error message
                MessageBox.Show(ex.Message, "ERROR: Monster Sorting", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void SortLoot(LootSortTypes sortType)
        {
            // Store a sorted list of loot
            List<Loot> lootList;
            try
            {
                // Sort based on sort type
                switch (sortType)
                {
                    // Sort by item name
                    case LootSortTypes.Name:
                        lootList = lstItems.Items.OfType<Loot>()
                                   .OrderBy(l => l.Name)
                                   .ToList();

                        DisplayLootList(lootList);
                        break;

                    // Sort by whether or not an item is magic
                    case LootSortTypes.IsMagic:
                        lootList = lstItems.Items.OfType<Loot>()
                                   .OrderByDescending(l => l.IsMagical)
                                   .ThenBy(l => l.Name)
                                   .ToList();

                        DisplayLootList(lootList);
                        break;
                    // Sort by item value
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
            {   // Display error
                MessageBox.Show(ex.Message, "ERROR: Loot Sorting", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void SortAbilities(AbilitySortTypes sortType)
        {
            // Store a list of sorted abilities
            List<Ability> abilityList;
            try
            {
                // Sort based on sort type
                switch (sortType)
                {
                    // Sort by power
                    case AbilitySortTypes.Power:
                        abilityList = lstAbilities.Items.OfType<Ability>()
                                      .OrderBy(a => a.Power)
                                      .ThenBy(a => a.Name)
                                      .ToList();

                        DisplayAbilityList(abilityList);
                        break;
                    // Sort by cost
                    case AbilitySortTypes.Cost:
                        abilityList = lstAbilities.Items.OfType<Ability>()
                                      .OrderBy(a => a.Cost)
                                      .ThenBy(a => a.Name)
                                      .ToList();

                        DisplayAbilityList(abilityList);
                        break;
                    // Sort by ability damage type
                    case AbilitySortTypes.Type:
                        abilityList = lstAbilities.Items.OfType<Ability>()
                                      .OrderBy(a => a.DamageType)
                                      .ThenBy(a => a.Name)
                                      .ToList();

                        DisplayAbilityList(abilityList);
                        break;
                    // Sort by item name
                    case AbilitySortTypes.Name:
                        abilityList = lstAbilities.Items.OfType<Ability>()
                                      .OrderBy(a => a.Name)
                                      .ToList();

                        DisplayAbilityList(abilityList);
                        break;
                }
            }
            catch (Exception ex)
            {   // Display error
                MessageBox.Show(ex.Message, "ERROR: Creature Sorting", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void SortCustomAbilities(AbilitySortTypes sortType)
        {
            try
            {   // Sort based on sort type
                switch (sortType)
                {
                    // Sort by power level
                    case AbilitySortTypes.Power:
                        abilityList = abilityList
                                            .OrderBy(a => a.Power)
                                            .ThenBy(a => a.Name)
                                            .ToList();

                        DisplayCustomAbilityList();
                        break;
                    // Sort by ability cost
                    case AbilitySortTypes.Cost:
                        abilityList = abilityList
                                            .OrderBy(a => a.Cost)
                                            .ThenBy(a => a.Name)
                                            .ToList();

                        DisplayCustomAbilityList();
                        break;
                    // Sort by damage type
                    case AbilitySortTypes.Type:
                        abilityList = abilityList
                                            .OrderBy(a => a.DamageType)
                                            .ThenBy(a => a.Name)
                                            .ToList();

                        DisplayCustomAbilityList();
                        break;
                    // Sort by name
                    case AbilitySortTypes.Name:
                        abilityList = abilityList
                                            .OrderBy(a => a.Name)
                                            .ToList();

                        DisplayCustomAbilityList();
                        break;
                }
            }
            catch (Exception ex)
            {   // Display error
                MessageBox.Show(ex.Message, "ERROR: Creature Sorting", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCreateAbility_SaveAbility_Click(object sender, EventArgs e)
        {
            // If an ability is selected
            if (lstCreateAbility_List.SelectedIndex != -1)
            {
                // Prompt user to save
                DialogResult save = MessageBox.Show("Would you like to overwrite the values of the currently selected ability?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Overwrite ability
                if (save == DialogResult.Yes)
                {
                    // Check to see if description and name are not null
                    if (string.IsNullOrWhiteSpace(txtCreateAbility_Name.Text) || string.IsNullOrWhiteSpace(rtbCreateAbility_Desc.Text))
                    {
                        MessageBox.Show("Name and Description cannot be empty!", "ERROR: Editing Ability", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    // If the name and description are valid save your changes
                    SaveCustomAbilityChanges();
                }
            }
            else // Display message
                MessageBox.Show("You need to select an item before saving!", "ERROR: Editing Ability", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void lstCreateAbility_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If selected item is an ability
            if (lstCreateAbility_List.SelectedItem is Ability ab)
            {
                // Clear the ability stats and display new abilities
                ClearCustomAbilityStats();
                DisplayCustomAbilityStats(ab);
            }
        }

        private void SaveCustomAbilityChanges()
        {
            try
            {
                // If the selected ability and damage type is valid
                if (lstCreateAbility_List.SelectedItem is Ability && cboCreateAbility_DamageType.SelectedItem is DamageType damageType)
                {
                    // Access ability in list, change properties using controls
                    // Name and description are checked before fucntion call...
                    abilityList[lstCreateAbility_List.SelectedIndex].Name = txtCreateAbility_Name.Text;
                    abilityList[lstCreateAbility_List.SelectedIndex].Description = rtbCreateAbility_Desc.Text;

                    // Set cost/power
                    abilityList[lstCreateAbility_List.SelectedIndex].Power = (int)nudCreateAbility_Power.Value;
                    abilityList[lstCreateAbility_List.SelectedIndex].Cost = (int)nudCreateAbility_Cost.Value;

                    // Set damage type
                    abilityList[lstCreateAbility_List.SelectedIndex].DamageType = damageType;

                    // Update custom ability list to reflect changes
                    DisplayCustomAbilityList();

                    // Changes were made...
                    madeChanges = true;

                    MessageBox.Show("Ability successfuly overwritten!", "Successfuly Updated Ability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                // Display error
                MessageBox.Show(ex.Message, "ERROR: Saving Ability", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCreateAbility_SortAbilities_Click(object sender, EventArgs e)
        {
            // If list is not empty
            if (abilityList.Count > 0)
            {
                // Sort by ability types
                if (cboCreateAbility_SortTypes.SelectedItem is AbilitySortTypes ast)
                    SortCustomAbilities(ast);
                else
                    MessageBox.Show("Sort type is invalid!", "Error: Sorting Custom Abilities", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else // Display error message
                MessageBox.Show("Collection is empty.", "Error: Sorting Custom Abilities", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
