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
    public partial class FormVolunteerChatOverview : Form
    {
        public FormVolunteerChatOverview()
        {
            InitializeComponent();
        }

        private void FormVolunteerChatOverview_Load(object sender, EventArgs e)
        {
            List<ChatLog> chatLogs = GetAllOpenChats();
            foreach (var chatLog in chatLogs)
            {
                
            }
        }

        private List<ChatLog> GetAllOpenChats()
        {
            DatabaseChat dbchat = new DatabaseChat();
            return dbchat.GetAllOpenChats();
        }
    }
}
