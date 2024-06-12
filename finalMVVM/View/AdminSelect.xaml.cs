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
    /// Interaction logic for AdminSelect.xaml
    /// </summary>
    public partial class AdminSelect : Page
    {

        public SharedViewModel _sharedViewModel;
        public AdminSelect(SharedViewModel sharedViewModel)
        {
            _sharedViewModel = sharedViewModel;
            InitializeComponent();
        }



        private void QuestionsAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                TriviaList triviaList = new TriviaList(_sharedViewModel);
                NavigationService.Navigate(triviaList);
            }
        }

        private void ScoresAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                ScoreList scoreList = new ScoreList(_sharedViewModel);
                NavigationService.Navigate(scoreList);
            }
        }

        private void PlayersAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                Main main = new Main(_sharedViewModel);
                NavigationService.Navigate(main);
            }
        }


        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                LoginOrRegister loginOrRegister = new LoginOrRegister(_sharedViewModel);
                NavigationService.Navigate(loginOrRegister);
            }
        }
    }
}
