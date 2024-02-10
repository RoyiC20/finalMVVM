using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalMVVM.Model
{
    public class User : INotifyPropertyChanged
    {
        private int userId;
        private string firstName;
        private string lastName;
        private string kidFirstName;
        private string kidLastName;
        private string ageOfKid;
        private string password;
        private string email;

        public int UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
                OnPropertyChanged("UserId");
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string KidFirstName
        {
            get
            {
                return kidFirstName;
            }
            set
            {
                kidFirstName = value;
                OnPropertyChanged("kidFirstName");
            }
        }

        public string KidLastName
        {
            get
            {
                return kidLastName;
            }
            set
            {
                kidLastName = value;
                OnPropertyChanged("kidLastName");
            }
        }

        public string AgeOfKid
        {
            get
            {
                return ageOfKid;
            }
            set
            {
                ageOfKid = value;
                OnPropertyChanged("ageOfKid");
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged("email");
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("password");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
