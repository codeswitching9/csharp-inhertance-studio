using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public abstract class Question
    {
        public string QuestionText { get; set; }
        public List<int> CorrectAnswer { get; set; }
        public List<string> PossibleAnswers { get; set; }
        public static int PointValue;
        public Question (string question, List<int> answer, List<string> possibleAnswers)
        {
            QuestionText = question;
            CorrectAnswer = answer;
            PossibleAnswers = possibleAnswers;
        }

        // method to display questions
        public abstract void DisplayQuestion();

        // method to display possible answer choices
       // public abstract void DisplayChoices();

        // method to display answers
        public abstract void GetAnswer();
    }
}
