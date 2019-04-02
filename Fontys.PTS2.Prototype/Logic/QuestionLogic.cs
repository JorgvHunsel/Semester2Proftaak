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
        QuestionRepository questionRepo = new QuestionRepository();

        public void WriteQuestionToDatabase(Question askedQuestion)
        {
            questionRepo.WriteQuestionToDatabase(askedQuestion);
        }

        public DataTable GetAllOpenQuestions()
        {
            return questionRepo.GetAllOpenQuestions();
        }

        public Question GetSingleQuestion(int questionID)
        {
            return questionRepo.GetSingleQuestion(questionID);
        }

        



        public void EditQuestion(int questionID, string subjectNew, string contentNew, Category category,
            string urgency)
        {
            EditQuestion(questionID, subjectNew, contentNew, category, urgency);
        }
    }
}
