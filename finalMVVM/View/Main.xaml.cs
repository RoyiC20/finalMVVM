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
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {

        private UserViewModel _userViewModel;
        private SharedViewModel _sharedViewModel;

        public Main(SharedViewModel sharedViewModel)
        {
            InitializeComponent();
            _userViewModel = new UserViewModel(sharedViewModel);
            DataContext = _userViewModel;
            _sharedViewModel = sharedViewModel;
        }


        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtUserId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UserGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
