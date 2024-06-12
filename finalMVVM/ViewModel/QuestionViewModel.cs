using finalMVVM.Model;
using MVVMWithAdd.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalMVVM.ViewModel
{
    class QuestionViewModel
    {
        private SharedViewModel _sharedViewModel;

        public QuestionViewModel(SharedViewModel sharedViewModel)
        {
            _sharedViewModel = sharedViewModel;
        }
        public List<Question> Questions
        {
            get { return _sharedViewModel.QuestionList; }
        }



    }
}
