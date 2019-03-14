using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fontys.PTS2.Prototype.Classes
{
    class Reaction
    {
       public int ReactionId { get; set; }
       public int QuestionId { get; set; }
       public int SenderId { get; set; }
       public string Description { get; set; }

       public Reaction(int questionId, int senderId, string description)
       {
           QuestionId = questionId;
           SenderId = senderId;
           Description = description;
       }

       public override string ToString()
       {
           return $" '{QuestionId}', '{SenderId}', '{Description}' ";
       }
    }
}
