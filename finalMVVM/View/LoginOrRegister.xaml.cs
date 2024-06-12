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
    /// Interaction logic for LoginOrRegister.xaml
    /// </summary>
    public partial class LoginOrRegister : Page
    {
        public  SharedViewModel _sharedViewModel;
        
        public LoginOrRegister(SharedViewModel sharedViewModel)
        {
            InitializeComponent();
            _sharedViewModel = sharedViewModel;
        }
        public LoginOrRegister()
        {
            InitializeComponent();
            this._sharedViewModel = new SharedViewModel();
            if (_sharedViewModel.UsersList == null || _sharedViewModel.UsersList.Count == 0)
            {
                _sharedViewModel.UsersList = new List<User>
            {
                    new User { UserId = 0, FirstName = "admin", LastName = "admin", Email = "admin@example.com", Password = "password0", KidFirstName = "0", KidLastName = "0", AgeOfKid = "0" },
                new User { UserId = 1, FirstName = "אביגיל", LastName = "כהן", Email = "abigail@example.com", Password = "password1", KidFirstName = "אליעד", KidLastName = "כהן", AgeOfKid = "5" },
    new User { UserId = 2, FirstName = "משה", LastName = "לוי", Email = "moshe@example.com", Password = "password2", KidFirstName = "נועם", KidLastName = "לוי", AgeOfKid = "5" },
    new User { UserId = 3, FirstName = "שרה", LastName = "גולן", Email = "sarah@example.com", Password = "password3", KidFirstName = "אורי", KidLastName = "גולן", AgeOfKid = "4" },
    new User { UserId = 4, FirstName = "יעקב", LastName = "פרץ", Email = "yaakov@example.com", Password = "password4", KidFirstName = "רחל", KidLastName = "פרץ", AgeOfKid = "6" },
    new User { UserId = 5, FirstName = "רחל", LastName = "מאיר", Email = "rachel@example.com", Password = "password5", KidFirstName = "אדם", KidLastName = "מאיר", AgeOfKid = "7" },
    new User { UserId = 6, FirstName = "דוד", LastName = "גור", Email = "david@example.com", Password = "password6", KidFirstName = "נועה", KidLastName = "גור", AgeOfKid = "3" },
    new User { UserId = 7, FirstName = "מרים", LastName = "זכאי", Email = "miriam@example.com", Password = "password7", KidFirstName = "ליאם", KidLastName = "זכאי", AgeOfKid = "5" },
    new User { UserId = 8, FirstName = "עידו", LastName = "אביטל", Email = "ido@example.com", Password = "password8", KidFirstName = "טל", KidLastName = "אביטל", AgeOfKid = "4" },
    new User { UserId = 9, FirstName = "תמר", LastName = "פלאי", Email = "tamar@example.com", Password = "password9", KidFirstName = "אלמוג", KidLastName = "פלאי", AgeOfKid = "6" },
    new User { UserId = 10, FirstName = "יפה", LastName = "כהן", Email = "yaffa@example.com", Password = "password10", KidFirstName = "אלון", KidLastName = "כהן", AgeOfKid = "9" },
            };
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (NavigationService != null)
            {
                Login login = new Login(_sharedViewModel);
                NavigationService.Navigate(login);

            }
        }

        private void MainFrame_Navigated_1(object sender, NavigationEventArgs e)
        {

        }

        private void SendToRegister_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                Register register = new Register(_sharedViewModel);
                NavigationService.Navigate(register);

            }
        }
    }
}
