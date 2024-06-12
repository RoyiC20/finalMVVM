using finalMVVM.Model;
using MVVMWithAdd.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalMVVM.ViewModel
{
    class ScoreViewModel
    {
        private SharedViewModel _sharedViewModel;

        public ScoreViewModel(SharedViewModel sharedViewModel)
        {
            _sharedViewModel = sharedViewModel;
        }
        public List<Score> Scores
        {
            get { return _sharedViewModel.ScoreList; }
        }



    }
}
