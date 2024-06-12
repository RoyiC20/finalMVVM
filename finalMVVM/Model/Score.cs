using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalMVVM.Model
{
    public class Score : INotifyPropertyChanged
    {


        private int highestScore;
        private int lastScore;
        private string userEmail;

        public int HighestScore
        {
            get
            {
                return highestScore;
            }
            set
            {
                highestScore = value;
                OnPropertyChanged("HighestScore");
            }
        }


        public int LastScore
        {
            get
            {
                return lastScore;
            }
            set
            {
                lastScore = value;
                OnPropertyChanged("LastScore");
            }
        }



        public String UserEmail
        {
            get
            {
                return userEmail;
            }
            set
            {
                userEmail = value;
                OnPropertyChanged("UserEmail");
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
