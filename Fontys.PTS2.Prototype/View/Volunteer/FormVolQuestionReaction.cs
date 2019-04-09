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
using Fontys.PTS2.Prototype.Logic;

namespace Fontys.PTS2.Prototype.View
{
    public partial class FormQuestionReaction : Form
    {   

        private Question _question;

        public FormQuestionReaction(Question question)
        {
            InitializeComponent();
            _question = question;
            lblQuestionTitle.Text = _question.Title;
            richtbDescription.Text = _question.Content;
        }

        private void btnPostReaction_Click(object sender, EventArgs e)
        {
            ReactionLogic logic = new ReactionLogic();
            Reaction newReaction = new Reaction(_question.QuestionId, FormLogin.currentUser.UserId, richtbReaction.Text, FormLogin.currentUser.FirstName + " " + FormLogin.currentUser.LastName);
            logic.PostReaction(newReaction);

            MessageBox.Show("Reactie verstuurd");

            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
