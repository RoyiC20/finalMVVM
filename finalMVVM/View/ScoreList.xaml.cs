using finalMVVM.Model;
using finalMVVM.ViewModel;
using MVVMWithAdd.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace finalMVVM.View
{
    /// <summary>
    /// Interaction logic for ScoreList.xaml
    /// </summary>
    public partial class ScoreList : Page
    {
        private SharedViewModel _sharedViewModel;
        private ScoreViewModel _scoreViewModel;

        public ScoreList(SharedViewModel sharedViewModel)
        {
            InitializeComponent();

            _sharedViewModel = sharedViewModel;
            _scoreViewModel = new ScoreViewModel(sharedViewModel);
            DataContext = _scoreViewModel;

        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                LoginOrRegister loginOrRegister = new LoginOrRegister(_sharedViewModel);
                NavigationService.Navigate(loginOrRegister);
            }
        }

        private void ScoreGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
