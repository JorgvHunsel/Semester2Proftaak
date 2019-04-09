using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data.Contexts;

namespace Fontys.PTS2.Prototype.Data
{
    public class QuestionRepository
    {
        private IQuestionContext context;

        public QuestionRepository()
        {
            this.context = new QuestionContextSQL();
        }

        public QuestionRepository(IQuestionContext context)
        {
            this.context = context;
        }

        public void WriteQuestionToDatabase(Question askedQuestion) => context.WriteQuestionToDatabase(askedQuestion);
        public DataTable GetAllOpenQuestions() => context.GetAllOpenQuestions();

        public List<Question> GetAllOpenQuestionsCareRecipientID(int careRecipientID) =>
            context.GetAllOpenQuestionsCareRecipientID(careRecipientID);

        public Question GetSingleQuestion(int questionID) => context.GetSingleQuestion(questionID);
    }
}
