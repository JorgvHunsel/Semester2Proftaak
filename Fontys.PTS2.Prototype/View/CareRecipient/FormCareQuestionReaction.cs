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
using Fontys.PTS2.Prototype.Logic;

namespace Fontys.PTS2.Prototype.View.CareRecipient
{
    public partial class FormCareQuestionReaction : Form
    {
        private int _questionID;

        public FormCareQuestionReaction(int questionID)
        {
            InitializeComponent();
            _questionID = questionID;
            List<ListViewItem> items = ReactionLogic.LoadReactionsToList(ReactionLogic.GetAllCommentsWithQuestionID(_questionID));

            foreach (ListViewItem item in items)
            {
                lvQuestionReaction.Items.Add(item);
            }
        }
    }
}
