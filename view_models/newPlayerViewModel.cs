using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TowerCore.functions;
using TowerCore;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Printing;

namespace TowerCore.view_models
{
    public class newPlayerViewModel : INotifyPropertyChanged
    {
        private newPlayerViewData playerCharacter = new newPlayerViewData();
        private PlayerViewData characterData = new PlayerViewData();
        public newPlayerViewData PlayerCharacter
        {
            get => playerCharacter;
            set
            {
                playerCharacter = value;
                OnPropertyChanged(nameof(PlayerCharacter));
            }
        }

        public ICommand ResetCharacterCommand { get; private set; }
        public ICommand CreateCharacterCommand { get; private set; }
        public ICommand AddStrengthCommand { get; private set; }
        public ICommand AddDexterityCommand { get; private set; }
        public ICommand AddStaminaCommand { get; private set; }
        public ICommand AddIntellectCommand { get; private set; }
        public ICommand AddFocusCommand { get; private set; }
        public ICommand AddWisdomCommand { get; private set; }



        public newPlayerViewModel()
        {
            playerCharacter = new newPlayerViewData();
            ResetCharacterCommand = new RelayCommand(o => resetCharacter(), o => true);
            CreateCharacterCommand = new RelayCommand(o => CreateCharacter(), o => true);
            AddStrengthCommand = new RelayCommand(o => addStrength(), o => true);
            AddDexterityCommand = new RelayCommand(o => addDexterity(), o => true);
            AddStaminaCommand = new RelayCommand(o => addStamina(), o => true);
            AddIntellectCommand = new RelayCommand(o => addIntellect(), o => true);
            AddFocusCommand = new RelayCommand(o => addFocus(), o => true);
            AddWisdomCommand = new RelayCommand(o => addWisdom(), o => true);

        }
        private void resetCharacter()
        {
        createCharacter resetData = new createCharacter();
            resetData.classListBox.SelectedIndex = 0;
        }
        private void CreateCharacter()
        {
            MainWindow main = new MainWindow();
            characterData.PlayerName = Convert.ToString(playerCharacter.PlayerName);
            characterData.PlayerClass = Convert.ToString(playerCharacter.ClassName);
            characterData.Strength = playerCharacter.Strength;
            characterData.Dexterity = playerCharacter.Dexterity;
            characterData.Stamina = playerCharacter.Stamina;
            characterData.Intellect = playerCharacter.Intellect;
            characterData.Focus = playerCharacter.Focus;
            characterData.Wisdom = playerCharacter.Wisdom;
            MessageBox.Show($"{characterData.PlayerName}, {characterData.PlayerClass}, {characterData.Strength}, {characterData.Dexterity}, {characterData.Stamina}, {characterData.Intellect}, {characterData.Focus}, {characterData.Wisdom}, ");
            characterData = new PlayerViewData();
            main.Show();
        }
        private void addStrength()
        {

            if (playerCharacter.SkillPoints > 0)
            {
             playerCharacter.SkillPoints = playerCharacter.SkillPoints - 1;
             playerCharacter.Strength += 1;
            }
           else
            {
                MessageBox.Show($"Not enough skill points: '{playerCharacter.SkillPoints}' To reset switch Class.");
            }
        }
        private void addDexterity()
        {

            if (playerCharacter.SkillPoints > 0)
            {
                playerCharacter.SkillPoints = playerCharacter.SkillPoints - 1;
                playerCharacter.Dexterity += 1;
            }
            else
            {
                MessageBox.Show($"Not enough skill points: '{playerCharacter.SkillPoints}' To reset switch Class.");
            }
        }
        private void addStamina()
        {

            if (playerCharacter.SkillPoints > 0)
            {
                playerCharacter.SkillPoints = playerCharacter.SkillPoints - 1;
                playerCharacter.Stamina += 1;
                playerCharacter.PlayerHealth = 100 + (playerCharacter.Stamina * 2);
                playerCharacter.PlayerHealthMax = playerCharacter.PlayerHealth;
            }
            else
            {
                MessageBox.Show($"Not enough skill points: '{playerCharacter.SkillPoints}' To reset switch Class.");
            }
        }
        private void addIntellect()
        {

            if (playerCharacter.SkillPoints > 0)
            {
                playerCharacter.SkillPoints = playerCharacter.SkillPoints - 1;
                playerCharacter.Intellect += 1;
            }
            else
            {
                MessageBox.Show($"Not enough skill points: '{playerCharacter.SkillPoints}' To reset switch Class.");
            }
        }
        private void addFocus()
        {

            if (playerCharacter.SkillPoints > 0)
            {
                playerCharacter.SkillPoints = playerCharacter.SkillPoints - 1;
                playerCharacter.Focus += 1;
            }
            else
            {
                MessageBox.Show($"Not enough skill points: '{playerCharacter.SkillPoints}' To reset switch Class.");
            }
        }
        private void addWisdom()
        {

            if (playerCharacter.SkillPoints > 0)
            {
                playerCharacter.SkillPoints = playerCharacter.SkillPoints - 1;
                playerCharacter.Wisdom += 1;
                playerCharacter.PlayerMagic = 100 + (playerCharacter.Wisdom * 3);
                playerCharacter.PlayerMagicMax = playerCharacter.PlayerMagic;
            }
            else
            {
                MessageBox.Show($"Not enough skill points: '{playerCharacter.SkillPoints}' To reset switch Class.");
            }
        }
        public List<CharacterClass> AvailableClasses { get; } = new List<CharacterClass>
        {
            CharacterClass.Warrior,
            CharacterClass.Mage,
            CharacterClass.Paladin,
            CharacterClass.Rogue,
            CharacterClass.Priest,
            CharacterClass.Shaman,
            CharacterClass.Druid
        };

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
