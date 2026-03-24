using System.Diagnostics;

namespace OOP_BestiaryFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TESTS: REMOVE LATER
            //Creature myCreature1 = new Creature(
            //        "MyBeast",
            //        "This is a monster yo",
            //        6,
            //        MonsterType.Animal
            //    );
            //Debug.WriteLine(myCreature1.ToString());

            //Creature myCreature2 = new Creature(
            //        "MyBeast 2",
            //        "This is ANOTHER monster yo",
            //        13,
            //        20,
            //        100,
            //        MonsterType.Animal
            //    );
            //Debug.WriteLine(myCreature2.ToString());
            Ability myMove = new Ability("Planet Buster", "A terrifying flying suplex that relies on the earth's gravity.", 1500, 45, DamageType.Force);
            Debug.WriteLine(myMove.Describe());
        }
    }
}
