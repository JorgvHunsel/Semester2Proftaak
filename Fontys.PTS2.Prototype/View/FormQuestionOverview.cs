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
    public partial class FormQuestionOverview : Form
    {
        readonly Form _formQuestion;

        public FormQuestionOverview()
        {
            InitializeComponent();
            LoadQuestionsToList();
        }

        public FormQuestionOverview(Form form)
        {
            InitializeComponent();
            LoadQuestionsToList();
            _formQuestion = form;
        }

        public void LoadQuestionsToList()
        {
            Database db = new Database();
            DataTable dt = new DataTable();

            dt = db.GetAllOpenQuestions();

            //Adding each row into listview with foreach + for loop
            foreach (DataRow row in dt.Rows)
            {
                //Standard adding item, only add the primary key as main item
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    //each item that follow the primary key will be added as sub item
                    item.SubItems.Add(row[i].ToString());
                }
                lvOpenQuestions.Items.Add(item);
            }
        }

        // Re-open Create Question
        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
             Form form = new Form();
             this.Hide();
             _formQuestion.Show();
        }

        // Edit Question
        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            int selectedRow = lvOpenQuestions.SelectedItems[0].Index;
            int selectedId = Convert.ToInt32(lvOpenQuestions.Items[selectedRow].SubItems[5]);
        }
    }
}
