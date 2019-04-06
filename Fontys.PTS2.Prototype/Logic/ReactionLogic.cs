using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data;

namespace Fontys.PTS2.Prototype.Logic
{
    class ReactionLogic
    {
        ReactionRepository reactionRepo = new ReactionRepository();

        // hier komt de verbinding tussen de repos en de view. zie category repository
        public void PostReaction(Reaction reaction)
        {
            reactionRepo.PostReaction(reaction);
        }

        public List<Reaction> GetAllCommentsWithQuestionID(int id) => reactionRepo.GetAllCommentsWithQuestionID(id);

    }
}
