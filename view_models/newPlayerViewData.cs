using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerCore
{
    public class newPlayerViewData : INotifyPropertyChanged
    {
        private string playerName;
        private string className;
        private int playerHealth;
        private int playerHealthMax;
        private int playerMagic;
        private int playerMagicMax;
        private int strength;
        private int dexterity;
        private int stamina;
        private int intellect;
        private int focus;
        private int wisdom;
        private int skillpoints;
        private int playerExp;
        private int playerExpMax;
        private CharacterClass characterClass;
        public newPlayerViewData playerCharacter;

        public event PropertyChangedEventHandler PropertyChanged;
        public string ClassName { get => className; set { className = value; OnPropertyChanged(nameof(ClassName)); } }
        public string PlayerName { get => playerName; set { playerName = value; OnPropertyChanged(nameof(PlayerName)); } }
        public int PlayerHealth { get => playerHealth; set { playerHealth = value; OnPropertyChanged(nameof(PlayerHealth)); } }
        public int PlayerHealthMax { get => playerHealthMax; set { playerHealthMax = value; OnPropertyChanged(nameof(PlayerHealthMax)); } }
        public int PlayerMagic { get => playerMagic; set { playerMagic = value; OnPropertyChanged(nameof(PlayerMagic)); } }
        public int PlayerMagicMax { get => playerMagicMax; set { playerMagicMax = value; OnPropertyChanged(nameof(PlayerMagicMax)); } }
        public int Strength { get => strength; set { strength = value; OnPropertyChanged(nameof(Strength)); } }
        public int Dexterity { get => dexterity; set { dexterity = value; OnPropertyChanged(nameof(Dexterity)); } }
        public int Stamina { get => stamina; set { stamina = value; OnPropertyChanged(nameof(Stamina)); } }
        public int Intellect { get => intellect; set { intellect = value; OnPropertyChanged(nameof(Intellect)); } }
        public int Focus { get => focus; set { focus = value; OnPropertyChanged(nameof(Focus)); } }
        public int Wisdom { get => wisdom; set { wisdom = value; OnPropertyChanged(nameof(Wisdom)); } }
        public int SkillPoints { get => skillpoints; set { skillpoints = value; OnPropertyChanged(nameof(SkillPoints)); } }
        public int ExP { get => playerExp; set { playerExp = value; OnPropertyChanged(nameof(ExP)); } }
        public int ExPMax { get => playerExpMax; set { playerExpMax = value; OnPropertyChanged(nameof(ExPMax)); } }
        public CharacterClass CharacterClass
        {
            get => characterClass;
            set
            {
                characterClass = value;
                var baseStats = CharacterClassStats.GetBaseStats(characterClass);
                ClassName = baseStats.Name;
                Strength = baseStats.Strength;
                Dexterity = baseStats.Dexterity;
                Stamina = baseStats.Stamina;
                Intellect = baseStats.Intellect;
                Focus = baseStats.Focus;
                Wisdom = baseStats.Wisdom;
                PlayerHealth = 100 + (baseStats.Stamina * 2);
                PlayerHealthMax = PlayerHealth;
                PlayerMagic = 100 + (baseStats.Wisdom * 3);
                PlayerMagicMax = PlayerMagic;
                SkillPoints = baseStats.SkillPoints;
                OnPropertyChanged(nameof(CharacterClass));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public newPlayerViewData()
        {
            CharacterClass = CharacterClass.Warrior;
        }
    }
}
