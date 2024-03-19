using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Xml.Linq;
using TowerCore.view_models;

namespace TowerCore
{
    public class PlayerViewData : INotifyPropertyChanged
    {
        private string playerName;
        private string playerClass;
        private int strength;
        private int dexterity;
        private int stamina;
        private int intellect;
        private int focus;
        private int wisdom;
        private int skillpoints;
        private int level;
        private int gold;
        private int pExP;
        private int damageTaken;
        private int magicUsed;
        private PlayerViewData characterData;
        public event PropertyChangedEventHandler PropertyChanged;

        public string PlayerName { get => playerName; set { playerName = value; OnPropertyChanged(nameof(PlayerName)); } }
        public string PlayerClass { get => playerClass; set { playerClass = value; OnPropertyChanged(nameof(PlayerClass)); } }
        public int Strength { get => strength; set { strength = value; OnPropertyChanged(nameof(Strength)); } }
        public int Dexterity { get => dexterity; set { dexterity = value; OnPropertyChanged(nameof(Dexterity)); } }
        public int Stamina { get => stamina; set { stamina = value; OnPropertyChanged(nameof(Stamina)); } }
        public int Intellect { get => intellect; set { intellect = value; OnPropertyChanged(nameof(Intellect)); } }
        public int Focus { get => focus; set { focus = value; OnPropertyChanged(nameof(Focus)); } }
        public int Wisdom { get => wisdom; set { wisdom = value; OnPropertyChanged(nameof(Wisdom)); } }
        public int SkillPoints { get => skillpoints; set { skillpoints = value; OnPropertyChanged(nameof(SkillPoints)); } }
        public int Level { get => level; set { level = value; OnPropertyChanged(nameof(Level)); } }
        public int Gold { get => gold; set { gold = value; OnPropertyChanged(nameof(Gold)); } }
        public int PlayerExP { get => pExP; set { pExP = value; OnPropertyChanged(nameof(PlayerExP)); } }
        public int DamageTaken { get => damageTaken; set { damageTaken = value; OnPropertyChanged(nameof(DamageTaken)); } }
        public int MagicUsed { get => magicUsed; set { magicUsed = value; OnPropertyChanged(nameof(MagicUsed)); } }
        public PlayerViewData CharacterData
        {
            get => characterData;
            set
            {
                characterData = value;
                OnPropertyChanged(nameof(CharacterData));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public PlayerViewData()
        {
         //characterData = new PlayerViewData();
        }
    }
}
