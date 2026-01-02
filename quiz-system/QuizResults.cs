using System;

namespace QuizSystem
{
    public class QuizResults
    {
        // Attributes from UML
        public int QuizID { 
            get; 
            set;  
        }
        public DateTime QuizDate { 
        get; 
        set; 
        }
        public int QuestionTotal { 
            get; 
            set; 
     }
        public int Score { 
            get; 
            set; 
               }

        // Default constructor
        public QuizResults()
        {
        }

        // Overloaded constructor matching UML
        public QuizResults(int quizID, DateTime quizDate, int questionTotal, int score)
        {
            QuizID = quizID;
            QuizDate = quizDate;
            QuestionTotal = questionTotal;
            Score = score;
        }
    }
}


