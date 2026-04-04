using System.Diagnostics;
using System.Globalization;
using System.Text.Json;

namespace OOP_BestiaryFinal
{
    public partial class MonsterForm : Form
    {
        List<Creature> creatureList;
        public MonsterForm(List<Creature> chrLst)
        {
            InitializeComponent();

            creatureList = new List<Creature>(chrLst);
            ClearMonsterData();
            PopulateList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void PopulateList()
        {
            DisplayBannerMessage("Welcome!");

            // These are all tests that will be dealt with later
            if (creatureList != null)
                DisplayMonsterList();

            PopulateComboBoxes();
        }

        private void DisplayMonsterList()
        {
            lstMonsters.Items.Clear();

            foreach (Creature creature in creatureList)
            {
                if (creature.Randomize)
                    creature.ApplyRandomGen();

                lstMonsters.Items.Add(creature);
            }
        }

        // How to display user data:
        // Get monster
        // Determine type
        // Set controls acordingly
        private void lstMonsters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Grab item, pass into function

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
            ClearMonsterData();
            ClearAbilityData();
            lblName.ForeColor = Color.Black;

            // monster is a Creature: display vital data
            lblName.Text = monster.Name;
            lblLevel.Text = monster.Level.ToString();
            lblAC.Text = monster.AC.ToString();
            lblHP.Text = monster.CurrentHealth.ToString();
            lblType.Text = monster.MonsterType.ToString();

            rtbDescArea.Text = monster.Describe();

            // If monster is specificaly an elite or world boss, display aditional info

            if (monster is Elite || monster is WorldBoss)
            {
                grpAbilities.Enabled = true;
                FillAbilityList(monster);
            }
            else
            {
                grpAbilities.Enabled = false;
            }

            if (monster.Randomize)
                lblName.ForeColor = Color.Red;
        }

        private void ClearMonsterData()
        {
            lblName.Text = string.Empty;
            lblLevel.Text = string.Empty;
            lblAC.Text = string.Empty;
            lblHP.Text = string.Empty;
            lblType.Text = string.Empty;

            rtbDescArea.Text = string.Empty;
            lstAbilities.Items.Clear();
            rtbAbilityDesc.Text = string.Empty;

            //grpMonsterDetails.Enabled = false;
        }

        private void FillAbilityList(object monster)
        {
            ClearAbilityData();

            if (monster is Elite e)
            {
                lstAbilities.Items.Add(e.Ability);
            }
            else if (monster is WorldBoss wb)
            {
                List<Ability> abilities = wb.AbilityList;

                foreach (Ability ability in abilities)
                {
                    lstAbilities.Items.Add(ability);
                }
            }

            lstAbilities.SelectedIndex = 0;
        }

        private void ClearAbilityData()
        {
            lstAbilities.Items.Clear();
            ClearAbilityStats();
        }

        private void ClearAbilityStats()
        {
            rtbAbilityDesc.Text = string.Empty;

            lblAbilityCost.Text = string.Empty;
            lblAbilityType.Text = string.Empty;
            lblAbilityPower.Text = string.Empty;
        }

        private void DisplayAbilityStats(Ability ab)
        {
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
            ClearLootList();
            ClearLootData();

            GetMonsterGold();
            GetMonsterLootList();
        }

        private void ClearLootList()
        {
            lstItems.Items.Clear();
        }

        private void ClearLootData()
        {
            rtbLootDescription.Text = string.Empty;
        }

        private void GetMonsterGold()
        {
            // Use current monster's stats
            if (chkUseCurrentMonster.Checked)
            {
                if (lstMonsters.SelectedIndex == -1)
                    return;

                // If the creature is a Creature: display its data
                if (lstMonsters.SelectedItem is Creature c)
                {
                    int gold = LootManager.GetGold(c.Level, c.MonsterType);

                    lblGoldCount.Text = gold.ToString();
                }
            }
            else // Use custom stats
            {
                if (cboType.SelectedIndex == -1)
                    return;

                int level = (int)nudLevel.Value;
                MonsterType type = (MonsterType)cboType.SelectedItem;

                int gold = LootManager.GetGold(level, type);
                lblGoldCount.Text = gold.ToString();
            }
        }

        private void GetMonsterLootList()
        {
            List<Loot> monsterLoot = new List<Loot>();
            if (chkUseCurrentMonster.Checked)
            {
                if (lstMonsters.SelectedIndex == -1)
                    return;

                // If the creature is a Creature: display its data
                if (lstMonsters.SelectedItem is Creature c)
                {
                    monsterLoot = LootManager.GetLootList(c.Level, c.MonsterType);

                    foreach (Loot l in monsterLoot)
                        lstItems.Items.Add(l);
                }

            }
            else // Use custom stats
            {
                int level = (int)nudLevel.Value;
                MonsterType type = (MonsterType)cboType.SelectedItem;

                monsterLoot = LootManager.GetLootList(level, type);

                foreach (Loot l in monsterLoot)
                    lstItems.Items.Add(l);
            }
        }

        private void DisplayLootDetails()
        {
            if (lstItems.SelectedIndex == -1)
                return;

            if (lstItems.SelectedItem is Loot loot)
            {
                rtbLootDescription.Text = loot.Describe();
            }
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearLootData();
            DisplayLootDetails();
        }

        private void chkGenerateACHP_CheckedChanged(object sender, EventArgs e)
        {
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

            chkGenerateACHP.Checked = false;

            cboCreate_Resists.SelectedIndex = 0;
            cboCreate_Type.SelectedIndex = 0;
        }

        private void cboCreate_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCreate_Class.SelectedItem is Classification c)
            {
                if (c == Classification.Minion)
                {
                    grpCreateMonsterAbilities.Enabled = false;
                    nudCreate_MinionMin.Enabled = true;
                    nudCreate_MinionMax.Enabled = true;
                }
                else
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
             *  This is an early pass: here, we assume that 
             *  the monster is a minion
             *  
             *  Step by step:
             *  - get universal attributes (attributes of creature class)
             *  - keep not of Randomize (If true, use alternate constructor
             *  - get class specific attributes(minion's min-max appearing, 
             */

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

            // Grab class specific stuff (only minion for now)

            // Need to check for empty controls

            if (monsterClass == Classification.Minion)
            {
                int monsterMin = (int)nudCreate_MinionMin.Value;
                int monsterMax = (int)nudCreate_MinionMax.Value;

                if (!isRandom)
                {
                    // Create monster with normal construstor
                    monsterHP = (int)nudCreate_HP.Value;
                    monsterAC = (int)nudCreate_AC.Value;

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

                    creatureList.Add(myMinion);
                    DisplayMonsterList();
                }
            }
            else
            {
                if (lstCreateAbility_List.Items.Count <= 0)
                {
                    MessageBox.Show("Please create 1 or more abilities.", "Error: Abilities", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

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
                        if (lstCreateAbility_List.SelectedItem is Ability newAbility)
                        {
                            // Get item, create new elite

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

                                creatureList.Add(myElite);
                                DisplayMonsterList();

                            }
                        }
                    }
                }
                else if (monsterClass == Classification.WorldBoss)
                {
                    // Plan: Create monster, then add each ability one by one

                    // Check to see if a worldboss already exists in the list!!!

                    WorldBoss newWorldBoss;

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

                    foreach (var item in lstCreateAbility_List.Items)
                    {
                        if (item is Ability ability)
                        {
                            newWorldBoss += ability;
                        }
                    }

                    creatureList.Add(newWorldBoss);
                    DisplayMonsterList();
                }
            }
        }

        private void CreateAbility()
        {
            // Create an ability

            string abilityName = txtCreateAbility_Name.Text;
            int abilityCost = (int)nudCreateAbility_Cost.Value;
            int abilityPower = (int)nudCreateAbility_Power.Value;
            DamageType abilityDT = (DamageType)cboCreateAbility_DamageType.SelectedItem;
            string abilityDesc = rtbCreateAbility_Desc.Text;

            if (!string.IsNullOrEmpty(abilityName) &&
                !string.IsNullOrEmpty(abilityDesc))
            {
                Ability newAbility = new Ability(
                        abilityName,
                        abilityDesc,
                        abilityPower,
                        abilityCost,
                        abilityDT
                    );

                lstCreateAbility_List.Items.Add(newAbility);
            }
            else
            {
                MessageBox.Show("One or more properties of your ability are invalid.", "Error: Creating Ability", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCreateControls_ClearList_Click(object sender, EventArgs e)
        {
            lstCreateAbility_List.Items.Clear();
        }

        private void btnCreateAbility_ClearBottom_Click(object sender, EventArgs e)
        {
            txtCreateAbility_Name.Text = string.Empty;
            rtbCreateAbility_Desc.Text = string.Empty;

            nudCreateAbility_Cost.Value = nudCreateAbility_Cost.Minimum;
            nudCreateAbility_Power.Value = nudCreateAbility_Power.Minimum;
        }

        private void btnCreateAbility_Create_Click(object sender, EventArgs e)
        {
            CreateAbility();
        }
    }
}
