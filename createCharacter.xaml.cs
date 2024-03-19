using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TowerCore.view_models;

namespace TowerCore
{
    /// <summary>
    /// Interaction logic for createCharacter.xaml
    /// </summary>
    public partial class createCharacter : Window
    {
        public createCharacter()
        {
            InitializeComponent();
            DataContext = new newPlayerViewModel();
        }

        public void classList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }
    }
}
