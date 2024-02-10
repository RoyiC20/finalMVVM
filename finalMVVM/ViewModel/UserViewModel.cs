using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using finalMVVM.Model;
using MVVMWithAdd.ViewModel;

namespace finalMVVM.ViewModel
{
    class UserViewModel
    {
        private SharedViewModel _sharedViewModel;

        public UserViewModel(SharedViewModel sharedViewModel)
        {
            _sharedViewModel = sharedViewModel;
        }
        public List<User> Users
        {
            get { return _sharedViewModel.UsersList; }
        }

    }
}
