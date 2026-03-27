using System.Diagnostics;

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
            if (creatureList != null)
                foreach (Creature creature in creatureList)
                    lstMonsters.Items.Add(creature);
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

            if (lstMonsters.SelectedItem is Creature c)
                DisplayMonsterData(c);
            else
                Debug.WriteLine("Wrond datatype");

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

            // Ifmonster is specificaly an elite or world boss, display aditional info

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

        private void grpAbilities_Enter(object sender, EventArgs e)
        {

        }

        private void lstAbilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAbilities.SelectedIndex == -1)
                return;

            // Check to see if object is an ability, then fill in the data
            ClearAbilityStats();
            if (lstAbilities.SelectedItem is Ability ab)
            {
                lblAbilityCost.Text = ab.Cost.ToString();
                lblAbilityPower.Text = ab.Power.ToString();
                lblAbilityType.Text = ab.DamageType.ToString();

                rtbAbilityDesc.Text = ab.Describe();
            }
        }

        private void MonsterForm_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void MonsterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save Json one last time before closing
            // DataManager.SaveData(creatureList);
            Application.Exit();
        }
    }
}
