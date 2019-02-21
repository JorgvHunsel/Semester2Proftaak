using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fontys.PTS2.Prototype.Classes
{
    class Question
    {
        public enum QuestionStatus { Open, Closed}
        private int QuestionId { get; set; }
        private string Title { get; set; }
        private string Content { get; set; }
        private QuestionStatus Status { get; set; }
        private DateTime Date { get; set; }
        private bool Urgency { get; set; }

        public Question(int questionId, string title, string content, QuestionStatus status, DateTime date, bool urgency)
        {
            QuestionId = questionId;
            Title = title;
            Content = content;
            Status = status;
            Date = date;
            Urgency = urgency;
        }

        public void PostQuestion(Question askedQuestion)
        {

        }
        public void DeleteQuestion(Question unwantedQuestion)
        {

        }

        public void EditQuestion(Question editQuestion)
        {

        }

        public DataTable GetAllQuestions()
        {
            return null;
        }

    }
}
