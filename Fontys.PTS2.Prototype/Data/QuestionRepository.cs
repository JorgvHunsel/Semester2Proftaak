using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //hier komen functies te staan die waardes doorgeven aan de context
    }
}
