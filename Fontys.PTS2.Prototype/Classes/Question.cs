using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fontys.PTS2.Prototype.Classes
{
    public class Question
    {
        public enum QuestionStatus { Open, Closed}
        private int QuestionId { get; set; }
        private string Title { get; set; }
        private string Content { get; set; }
        private QuestionStatus Status { get; set; }
        private DateTime Date { get; set; }
        private string Urgency { get; set; }
        private string Category { get; set; }

        public Question(string title, string content, QuestionStatus status, DateTime date, string urgency, string category)
        {
            Title = title;
            Content = content;
            Status = status;
            Date = date;
            Urgency = urgency;
            Category = category;
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

        public override string ToString()
        {
            return $" '{Status}', '{Title}', '{Content}', '{Date.ToShortDateString()}', '{Urgency}' ";
        }
    }
}
