using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fontys.PTS2.Prototype.Data;

namespace Fontys.PTS2.Prototype.View
{
    public partial class FormQuestionReaction : Form
    {      
        public FormQuestionReaction(int questionId)
        {
            InitializeComponent();
            lblQuestionTitle.Text = QueryQuestion.GetQuestionName(questionId);
        }
    }
}
