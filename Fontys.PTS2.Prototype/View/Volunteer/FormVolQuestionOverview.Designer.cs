﻿namespace Fontys.PTS2.Prototype.View
{
    partial class FormVolQuestionOverview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvOpenQuestions = new System.Windows.Forms.ListView();
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUrgency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOpenRequests = new System.Windows.Forms.Label();
            this.btnReactToQuestion = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvOpenQuestions
            // 
            this.lvOpenQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitle,
            this.columnUser,
            this.columnDate,
            this.columnUrgency,
            this.columnCategory,
            this.ID});
            this.lvOpenQuestions.Location = new System.Drawing.Point(16, 71);
            this.lvOpenQuestions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvOpenQuestions.Name = "lvOpenQuestions";
            this.lvOpenQuestions.Size = new System.Drawing.Size(783, 467);
            this.lvOpenQuestions.TabIndex = 0;
            this.lvOpenQuestions.UseCompatibleStateImageBehavior = false;
            this.lvOpenQuestions.View = System.Windows.Forms.View.Details;
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Onderwerp";
            this.columnTitle.Width = 129;
            // 
            // columnUser
            // 
            this.columnUser.Text = "Hulpbehoevende";
            this.columnUser.Width = 133;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Datum";
            this.columnDate.Width = 93;
            // 
            // columnUrgency
            // 
            this.columnUrgency.Text = "Urgentie";
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Categorie";
            this.columnCategory.Width = 103;
            // 
            // ID
            // 
            this.ID.Tag = "ID";
            this.ID.Width = 0;
            // 
            // lblOpenRequests
            // 
            this.lblOpenRequests.AutoSize = true;
            this.lblOpenRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenRequests.Location = new System.Drawing.Point(12, 9);
            this.lblOpenRequests.Name = "lblOpenRequests";
            this.lblOpenRequests.Size = new System.Drawing.Size(857, 58);
            this.lblOpenRequests.TabIndex = 1;
            this.lblOpenRequests.Text = "Vrijwilliger - Openstaande hulpvragen";
            // 
            // btnReactToQuestion
            // 
            this.btnReactToQuestion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReactToQuestion.Location = new System.Drawing.Point(809, 438);
            this.btnReactToQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReactToQuestion.Name = "btnReactToQuestion";
            this.btnReactToQuestion.Size = new System.Drawing.Size(143, 46);
            this.btnReactToQuestion.TabIndex = 4;
            this.btnReactToQuestion.Text = "Reageer";
            this.btnReactToQuestion.UseVisualStyleBackColor = false;
            this.btnReactToQuestion.Click += new System.EventHandler(this.btnReactToQuestion_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(809, 492);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 46);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormVolQuestionOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 554);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReactToQuestion);
            this.Controls.Add(this.lblOpenRequests);
            this.Controls.Add(this.lvOpenQuestions);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormVolQuestionOverview";
            this.Text = "FormVolQuestionOverview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvOpenQuestions;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnUser;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnUrgency;
        private System.Windows.Forms.Label lblOpenRequests;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button btnReactToQuestion;
        private System.Windows.Forms.Button btnBack;
    }
}