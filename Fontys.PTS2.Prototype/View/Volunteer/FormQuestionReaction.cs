using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data;

namespace Fontys.PTS2.Prototype.View
{
    public partial class FormQuestionReaction : Form
    {   
        public int QuestionId { get; }
        readonly int _currentUserId = LoginPrototype.CurrentUserId;
        public FormQuestionReaction(int questionId)
        {
            InitializeComponent();
            QuestionId = questionId;
            lblQuestionTitle.Text = QueryQuestion.GetQuestionName(questionId);
            richtbDescription.Text = QueryQuestion.GetQuestionDescription(questionId);
        }

        private void btnPostReaction_Click(object sender, EventArgs e)
        {
            Reaction newReaction = new Reaction(QuestionId, _currentUserId, richtbReaction.Text);
            QueryReaction.PostReaction(newReaction);
        }
    }
}
