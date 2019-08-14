using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *STUDENT NAME:Liya cao
 *STUDENT ID:300930050
 *DESCRIPTION: this is the Character class used in character creation
 *             This is also the Data container for the application
     */
namespace COMP123_S2019_FINALTEST_300930050.Object
{
    public class Character
    {
        //Character Abilities
        public string Strenght { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligente { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }


        //Secondary Abilities
       public int ArmourClass { get; set; }
       public int HitPoints { get; set; }

        //Character Class
        public CharacterClass Class { get; set; }
        public int Level { get; set; }

        //Equipment

        //Constructor
        public Character()
        {
            this.Inventory = new List<Item>();
        }

        public string characterName { get; set; }
        public List<Item> Inventory;
    }
}
