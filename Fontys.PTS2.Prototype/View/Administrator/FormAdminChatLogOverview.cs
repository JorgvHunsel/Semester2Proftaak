﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fontys.PTS2.Prototype.View.Administrator
{
    public partial class FormAdminChatLogOverview : Form
    {
        public FormAdminChatLogOverview()
        {
            InitializeComponent();
            LoadListview();
        }

        void LoadListview()
        {
            lbChatLogOverview.Items.Clear();
            //foreach (ChatLog chat in )
            //{
            //    LbChatOverView.Items.Add(chat.VolunteerFirstName);
            //}
        }
    }
}
