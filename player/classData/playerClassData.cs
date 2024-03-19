using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace TowerCore
    {
        public enum CharacterClass
        {
            Warrior,
            Mage,
            Paladin,
            Rogue,
            Priest,
            Shaman,
            Druid
        }
    public static class CharacterClassStats
    {
        public static ( string Name, int Strength, int Dexterity, int Stamina, int Intellect, int Focus, int Wisdom, int SkillPoints) GetBaseStats(CharacterClass characterClass)
        {
            return characterClass switch
            {
                CharacterClass.Warrior => ("Warror", 17, 13, 12, 10, 10, 13, 15),
                CharacterClass.Mage => ("Mage", 10, 10, 13, 17, 13, 12, 15),
                CharacterClass.Paladin => ("Paladin", 14, 13, 11, 12, 12, 12, 15),
                CharacterClass.Rogue => ("Rogue", 13, 17, 12, 10, 10, 13, 15),
                CharacterClass.Priest => ("Priest", 10, 10, 10, 10, 10, 10, 15),
                CharacterClass.Shaman => ("Shaman", 10, 10, 10, 10, 10, 10, 15),
                CharacterClass.Druid => ("Druid", 10, 10, 10, 10, 10, 10, 15),
                _ => ("NULL", 10, 10, 10, 10, 10, 10, 15),
            };
        }
    }
}

