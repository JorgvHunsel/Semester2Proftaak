using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data;

namespace Fontys.PTS2.Prototype.Logic
{
    public class QuestionLogic
    {
         static QuestionRepository questionRepo = new QuestionRepository();

        public static void WriteQuestionToDatabase(Question askedQuestion)
        {
            questionRepo.WriteQuestionToDatabase(askedQuestion);
        }

        public static DataTable GetAllOpenQuestions()
        {
            return questionRepo.GetAllOpenQuestions();
        }

        public  static DataTable GetAllOpenQuestionCareRecipientID(int careRecipientID) =>
            questionRepo.GetAllOpenQuestionsCareRecipientID(careRecipientID);

        public static Question GetSingleQuestion(int questionID)
        {
            return questionRepo.GetSingleQuestion(questionID);
        }

        public static void EditQuestion(int questionID, string subjectNew, string contentNew, Category category, string urgency)
        {
            EditQuestion(questionID, subjectNew, contentNew, category, urgency);
        }
    }
}
