namespace QuizSystem
{
       public class QuizFeedback
    {
        public int QuizID { 
            get; 
            set; 
            }
        public int CategoryID { 
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
        public string GeneralFeedback { 
            get; 
            set; 
            }

        public QuizFeedback()
        {
        }

        public QuizFeedback(int quizID, int categoryID, int questionTotal, int score, string generalFeedback)
        {
            QuizID = quizID;
            CategoryID = categoryID;
            QuestionTotal = questionTotal;
            Score = score;
            GeneralFeedback = generalFeedback;
        }
    }
}


