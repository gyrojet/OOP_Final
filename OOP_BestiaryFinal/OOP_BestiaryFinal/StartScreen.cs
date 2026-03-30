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
            creatureList = DataManager.LoadMonsterData();
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
