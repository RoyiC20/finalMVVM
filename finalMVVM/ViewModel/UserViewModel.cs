using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using finalMVVM.Model;

namespace finalMVVM.ViewModel
{
    class UserViewModel
    {
        private List<User> _UsersList;

        public UserViewModel()
        {
            _UsersList = new List<User>
            {
                new User { UserId = 1, FirstName = "אביגיל", LastName = "כהן", City = "תל אביב", State = "TA", Country = "ישראל" },
                new User { UserId = 2, FirstName = "משה", LastName = "לוי", City = "ירושלים", State = "JM", Country = "ישראל" },
                new User { UserId = 3, FirstName = "שרה", LastName = "גולן", City = "חיפה", State = "HA", Country = "ישראל" },
                new User { UserId = 4, FirstName = "יעקב", LastName = "פרץ", City = "באר שבע", State = "BS", Country = "ישראל" },
                new User { UserId = 5, FirstName = "רחל", LastName = "מאיר", City = "אשדוד", State = "ASD", Country = "ישראל" },
                new User { UserId = 6, FirstName = "דוד", LastName = "גור", City = "נתניה", State = "NT", Country = "ישראל" },
                new User { UserId = 7, FirstName = "מרים", LastName = "זכאי", City = "עפולה", State = "AF", Country = "ישראל" },
                new User { UserId = 8, FirstName = "עידו", LastName = "אביטל", City = "אילת", State = "IL", Country = "ישראל" },
                new User { UserId = 9, FirstName = "תמר", LastName = "פלאי", City = "טבריה", State = "TB", Country = "ישראל" },
                new User { UserId = 10, FirstName = "יפה", LastName = "כהן", City = "קריית שמונה", State = "KS", Country = "ישראל" },
            };
        }

        public List<User> Users
        {
            get { return _UsersList; }
            set { _UsersList = value; }
        }

    }
}
