using finalMVVM.Model;
using System.Collections.Generic;

namespace MVVMWithAdd.ViewModel
{
    public class SharedViewModel
    {
        private List<User> _usersList;

        public SharedViewModel()
        {
            _usersList = new List<User>();
        }

        public List<User> UsersList
        {
            get { return _usersList; }
            set { _usersList = value; }
        }

       

        public bool IsEmailInList(string email)
        {
            foreach (User user in this._usersList)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }
            return false;

        }

        public User returnUser(string email)
        {
            foreach (User user in this._usersList)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }




    }
}
