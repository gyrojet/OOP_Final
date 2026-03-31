using System.Diagnostics;
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
                foreach (Creature creature in creatureList)
                    lstMonsters.Items.Add(creature);

            string n = JsonSerializer.Serialize(creatureList, new JsonSerializerOptions { WriteIndented = true });

            Debug.WriteLine(n);

            // Loot manager goldtest; continue here tommorow
            PopulateTypeList();
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

        private void PopulateTypeList()
        {
            // Fill the combo box with the monster type enum
            cboType.DataSource = Enum.GetValues(typeof(MonsterType));
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
    }
}
