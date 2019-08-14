using COMP123_S2019_FINALTEST_300930050.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
/*
 *STUDENT NAME:Liya cao 
 *STUDENT ID:300930050
 *DESCRIPTION: This is the Character Genertor Form
     */
namespace COMP123_S2019_FINALTEST_300930050.Views
{
    
    public partial class CharacterGeneratorForm : COMP123_S2019_FINALTEST_300930050.Views.MasterForm
    {
        public static Character character = new Character();
        List<string> firstNames = new List<string>();
        List<string> lastNames = new List<string>();
        List<string> inventories = new List<string>();
      
        public CharacterGeneratorForm()
        {
            InitializeComponent();
        }

        public void LoadNames()
        {
            string firstNamespath = "..\\..\\Data\\firstNames.txt";
            string lastNamespath = "..\\..\\Data\\lastNames.txt";

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }
        /// <summary>
        /// This is next button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
                if(MainTabControl.SelectedIndex == MainTabControl.TabPages.Count - 1)
                {
                    this.NextButton.Text = "Generate Character";
                }
            }
            else
            {
              if(this.CharacterTextBox.Text == "")
                {
                    character.characterName = this.firstnamedatalabel.Text + " " + this.Lastnamedatalabel.Text;
                    System.Windows.Forms.MessageBox.Show("Conguratulations!\n You created one character with \n name :" + character.characterName +
                        " \n Strength : " + character.Strenght + " \n Dexterity : " + character.Dexterity
                        + " \n Constitution : " + character.Constitution + " \n Intelligente : " + character.Intelligente
                        + " \n Wisdom : " + character.Wisdom + " \n Charisma : " + character.Charisma
                        + " \n ArmourClass : " + character.ArmourClass + " \n HitPoints : " + character.HitPoints
                        + " \n Inventory : " + character.Inventory[0].ToString() + " \n Class : " + character.Class);
                        

                }

            }
        }

        private void CharacterGeneratorForm_Load(object sender, EventArgs e)
        {
            var firstNameFile = File.ReadAllLines("../../Data/firstNames.txt");
            firstNames = new List<string>(firstNameFile);
            var lastNameFile = File.ReadAllLines("../../Data/lastNames.txt");
            lastNames = new List<string>(lastNameFile);
            var inventoryList = File.ReadAllLines("../../Data/inventory.txt");
            inventories = new List<string>(inventoryList);
            this.inventoryListBox.DataSource = inventories;
            this.characterClassListbox.DataSource = Enum.GetValues(typeof(CharacterClass));
        }

        private void GeneraternameButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string randomFirstName = firstNames[random.Next(firstNames.Count)];
            string randomLastName = lastNames[random.Next(lastNames.Count)];
            this.firstnamedatalabel.Text = randomFirstName;
            this.Lastnamedatalabel.Text = randomLastName;
            this.CharacterTextBox.Text = "";
        }

        private void GeneraterAbilityButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomStrength = random.Next(3,19);
            int randomDexterity = random.Next(3, 19);
            int randomConstitution = random.Next(3, 19);
            int randomIntelligente = random.Next(3, 19);
            int randomWisdom = random.Next(3, 19);
            int randomCharisma = random.Next(3, 19);
            character.Strenght = Convert.ToString(randomStrength);
            character.Dexterity = Convert.ToString(randomDexterity);
            character.Constitution = Convert.ToString(randomConstitution);
            character.Intelligente = Convert.ToString(randomIntelligente);
            character.Wisdom = Convert.ToString(randomWisdom);
            character.Charisma = Convert.ToString(randomCharisma);
            this.StrengthDataLabel.Text = Convert.ToString(randomStrength);
            this.dexteritydatalabel.Text = Convert.ToString(randomDexterity);
            this.Constitutiondatalabel.Text = Convert.ToString(randomConstitution);
            this.intelligencedatalabel.Text = Convert.ToString(randomIntelligente);
            this.wisdomdatalabel.Text = Convert.ToString(randomWisdom);
            this.charismadatalabel.Text = Convert.ToString(randomCharisma);
            int armoryClass = 10;
            int hitpoint = 100;
            character.ArmourClass = armoryClass;
            character.HitPoints = hitpoint;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] itemvalues = Convert.ToString(this.inventoryListBox.SelectedItem).Split(',');
            character.Inventory.Add(new Item(itemvalues[0],float.Parse(itemvalues[1]),Convert.ToInt32(itemvalues[2])));

        }

        private void GenerateInventory_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(7);
            string[] itemvalues = Convert.ToString(inventories[randomNumber]).Split(',');
            character.Inventory.Add(new Item(itemvalues[0], float.Parse(itemvalues[1]), Convert.ToInt32(itemvalues[2])));
            this.inventoryListBox.SelectedIndex = randomNumber;
        }

        private void CharacterClassListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            character.Class = (CharacterClass)this.characterClassListbox.SelectedItem;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(12);
            character.Class = (CharacterClass)randomNumber;
            this.characterClassListbox.SelectedIndex = randomNumber;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowdDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
