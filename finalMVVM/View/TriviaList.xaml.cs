using finalMVVM.Model;
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
    /// Interaction logic for TriviaList.xaml
    /// </summary>
    public partial class TriviaList : Page
    {
        private SharedViewModel _sharedViewModel;
        private QuestionViewModel _questionViewModel;
        public TriviaList(SharedViewModel sharedViewModel)
        {
            InitializeComponent();

            _sharedViewModel = sharedViewModel;
            _questionViewModel = new QuestionViewModel(sharedViewModel);
            DataContext = _questionViewModel;


            if (_sharedViewModel.QuestionList == null || _sharedViewModel.QuestionList.Count == 0)
            {
                _sharedViewModel.QuestionList = new List<Question>
            {
        new Question { aQuestion = "What is 5 multiplied by 6?", Category = "Math", CorrectAnswer = "30", Answer2 = "25", Answer3 = "40", Answer4 = "35" },
new Question { aQuestion = "What is the square root of 64?", Category = "Math", CorrectAnswer = "8", Answer2 = "6", Answer3 = "10", Answer4 = "12" },
new Question { aQuestion = "What is 10 divided by 2?", Category = "Math", CorrectAnswer = "5", Answer2 = "4", Answer3 = "6", Answer4 = "3" },
new Question { aQuestion = "What is the value of pi (π) rounded to two decimal places?", Category = "Math", CorrectAnswer = "3.14", Answer2 = "3.12", Answer3 = "3.16", Answer4 = "3.10" },
new Question { aQuestion = "What is 3 squared?", Category = "Math", CorrectAnswer = "9", Answer2 = "6", Answer3 = "12", Answer4 = "15" },
new Question { aQuestion = "What is 15 subtracted from 20?", Category = "Math", CorrectAnswer = "5", Answer2 = "3", Answer3 = "10", Answer4 = "8" },
new Question { aQuestion = "What is 2 plus 3 multiplied by 4?", Category = "Math", CorrectAnswer = "20", Answer2 = "12", Answer3 = "16", Answer4 = "10" },
new Question { aQuestion = "What is the next number in the sequence: 2, 4, 6, 8, ?", Category = "Math", CorrectAnswer = "10", Answer2 = "12", Answer3 = "14", Answer4 = "16" },
new Question { aQuestion = "What is 50% of 100?", Category = "Math", CorrectAnswer = "50", Answer2 = "40", Answer3 = "60", Answer4 = "45" },
new Question { aQuestion = "What is the sum of all angles in a triangle?", Category = "Math", CorrectAnswer = "180 degrees", Answer2 = "150 degrees", Answer3 = "200 degrees", Answer4 = "120 degrees" },
new Question { aQuestion = "What is the fastest land animal?", Category = "Animals", CorrectAnswer = "Cheetah", Answer2 = "Lion", Answer3 = "Gazelle", Answer4 = "Leopard" },
new Question { aQuestion = "What is the only mammal capable of sustained flight?", Category = "Animals", CorrectAnswer = "Bat", Answer2 = "Bird", Answer3 = "Pterosaur", Answer4 = "Butterfly" },
new Question { aQuestion = "Which animal is known as the 'King of the Jungle'?", Category = "Animals", CorrectAnswer = "Lion", Answer2 = "Tiger", Answer3 = "Leopard", Answer4 = "Jaguar" },
new Question { aQuestion = "What is the largest mammal in the world?", Category = "Animals", CorrectAnswer = "Blue Whale", Answer2 = "Elephant", Answer3 = "Giraffe", Answer4 = "Hippopotamus" },
new Question { aQuestion = "Which animal has the longest neck?", Category = "Animals", CorrectAnswer = "Giraffe", Answer2 = "Elephant", Answer3 = "Kangaroo", Answer4 = "Zebra" },
new Question { aQuestion = "What is a group of lions called?", Category = "Animals", CorrectAnswer = "Pride", Answer2 = "Herd", Answer3 = "Flock", Answer4 = "Pack" },
new Question { aQuestion = "Which animal is known for its black and white stripes?", Category = "Animals", CorrectAnswer = "Zebra", Answer2 = "Tiger", Answer3 = "Giraffe", Answer4 = "Leopard" },
new Question { aQuestion = "What is the largest living bird?", Category = "Animals", CorrectAnswer = "Ostrich", Answer2 = "Eagle", Answer3 = "Emu", Answer4 = "Albatross" },
new Question { aQuestion = "Which animal can change its color to match its surroundings?", Category = "Animals", CorrectAnswer = "Chameleon", Answer2 = "Octopus", Answer3 = "Cuttlefish", Answer4 = "Squid" },
new Question { aQuestion = "What is the only animal with four knees?", Category = "Animals", CorrectAnswer = "Elephant", Answer2 = "Horse", Answer3 = "Giraffe", Answer4 = "Kangaroo" },
new Question { aQuestion = "What is the capital of France?", Category = "GeneralKnowledge", CorrectAnswer = "Paris", Answer2 = "London", Answer3 = "Berlin", Answer4 = "Rome" },
new Question { aQuestion = "Which planet is known as the Red Planet?", Category = "GeneralKnowledge", CorrectAnswer = "Mars", Answer2 = "Venus", Answer3 = "Mercury", Answer4 = "Jupiter" },
new Question { aQuestion = "Who wrote 'Romeo and Juliet'?", Category = "GeneralKnowledge", CorrectAnswer = "William Shakespeare", Answer2 = "Jane Austen", Answer3 = "Charles Dickens", Answer4 = "Mark Twain" },
new Question { aQuestion = "What is the largest ocean on Earth?", Category = "GeneralKnowledge", CorrectAnswer = "Pacific Ocean", Answer2 = "Atlantic Ocean", Answer3 = "Indian Ocean", Answer4 = "Arctic Ocean" },
new Question { aQuestion = "What is the main ingredient in guacamole?", Category = "GeneralKnowledge", CorrectAnswer = "Avocado", Answer2 = "Tomato", Answer3 = "Onion", Answer4 = "Lemon" },
new Question { aQuestion = "Which country is known as the Land of the Rising Sun?", Category = "GeneralKnowledge", CorrectAnswer = "Japan", Answer2 = "China", Answer3 = "South Korea", Answer4 = "Vietnam" },
new Question { aQuestion = "What is the name of the tallest mammal?", Category = "GeneralKnowledge", CorrectAnswer = "Giraffe", Answer2 = "Elephant", Answer3 = "Kangaroo", Answer4 = "Horse" },
new Question { aQuestion = "Who painted the Mona Lisa?", Category = "GeneralKnowledge", CorrectAnswer = "Leonardo da Vinci", Answer2 = "Pablo Picasso", Answer3 = "Vincent van Gogh", Answer4 = "Michelangelo" },
new Question { aQuestion = "Which is the largest organ in the human body?", Category = "GeneralKnowledge", CorrectAnswer = "Skin", Answer2 = "Heart", Answer3 = "Liver", Answer4 = "Brain" },
new Question { aQuestion = "What is the currency of Japan?", Category = "GeneralKnowledge", CorrectAnswer = "Yen", Answer2 = "Dollar", Answer3 = "Euro", Answer4 = "Pound" }
    };
            }
        }

        private void QuestionsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Add your selection changed logic here
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
