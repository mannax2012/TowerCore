using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerCore;

namespace TowerCore.view_models
{
    public class mainMenuViewModel : INotifyPropertyChanged
    {
        private PlayerViewData characterData = new PlayerViewData();
        public event PropertyChangedEventHandler PropertyChanged;

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
        public mainMenuViewModel()
        {
            CharacterData = new PlayerViewData();
        }
    }

}
