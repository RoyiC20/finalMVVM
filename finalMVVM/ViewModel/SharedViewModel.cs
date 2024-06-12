using finalMVVM.Model;
using System.Collections.Generic;

namespace MVVMWithAdd.ViewModel
{
    public class SharedViewModel
    {
        private List<User> _usersList;
        private List<Question> _mathQuestions;
        private List<Score> _scoreList;
        private string loggedInUserEmail;
        public SharedViewModel()
        {
            _usersList = new List<User>();
            _mathQuestions = new List<Question>();
            _scoreList = new List<Score>();
        }

        public List<User> UsersList
        {
            get { return _usersList; }
            set { _usersList = value; }
        }

        public List<Question> QuestionList
        {
            get { return _mathQuestions; }
            set { _mathQuestions = value; }
        }

        public List<Score> ScoreList
        {
            get { return _scoreList; }
            set { _scoreList = value; }
        }


        public void setLoggedInUserEmail(string email)
        {
            this.loggedInUserEmail = email;
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


        public Score returnScore()
        {
            foreach (Score score in this._scoreList)
            {
                if (score.UserEmail == loggedInUserEmail)
                {
                    return score;
                }
            }
            // if here, we did not find score, adding one
            Score newScore = new Score { UserEmail = loggedInUserEmail, LastScore = 0, HighestScore = 0 };
            this._scoreList.Add(newScore);
            return newScore;
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

        public List<Question> getQuestions(string category)
        {
            List<Question> list = new List<Question>();
            for (int i=0; i<this.QuestionList.Count; i++)
            {
                if (category == this.QuestionList[i].Category)
                {
                    list.Add(this.QuestionList[i]);
                }
            }
            return list;
        }




    }
}
