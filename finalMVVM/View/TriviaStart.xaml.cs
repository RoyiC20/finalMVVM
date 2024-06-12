using finalMVVM.Model;
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
    /// Interaction logic for TriviaStart.xaml
    /// </summary>
    public partial class TriviaStart : Page
    {
        private SharedViewModel _sharedViewModel;
        private string category;
        public TriviaStart(SharedViewModel sharedViewModel)
        {
            InitializeComponent();
            _sharedViewModel = sharedViewModel;
        }

        

        private void StartLearning_Click(object sender, RoutedEventArgs e)
        {

            TriviaList triviaList = new TriviaList(_sharedViewModel);
            //NavigationService.Navigate(triviaList);

            
            TriviaGame triviaGame = new TriviaGame(_sharedViewModel, _sharedViewModel.getQuestions(this.category));
            NavigationService.Navigate(triviaGame);



        }

        private void classComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            startLearning.IsEnabled = true;
            this.category = (comboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
        }

        private void nameOfAnswerer_TextChanged(object sender, TextChangedEventArgs e)
        {

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
