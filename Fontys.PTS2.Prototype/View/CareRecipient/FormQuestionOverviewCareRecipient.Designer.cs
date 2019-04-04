namespace Fontys.PTS2.Prototype.View
{
    partial class FormQuestionOverviewCareRecipient
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
            this.QuestionTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Volunteer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Urgency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOpenRequests = new System.Windows.Forms.Label();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnAskQuestion = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnToUserProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvOpenQuestions
            // 
            this.lvOpenQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.QuestionTitle,
            this.Volunteer,
            this.Date,
            this.Urgency,
            this.Category});
            this.lvOpenQuestions.Location = new System.Drawing.Point(12, 58);
            this.lvOpenQuestions.Name = "lvOpenQuestions";
            this.lvOpenQuestions.Size = new System.Drawing.Size(662, 380);
            this.lvOpenQuestions.TabIndex = 0;
            this.lvOpenQuestions.UseCompatibleStateImageBehavior = false;
            this.lvOpenQuestions.View = System.Windows.Forms.View.Details;
            // 
            // QuestionTitle
            // 
            this.QuestionTitle.Text = "Onderwerp";
            this.QuestionTitle.Width = 80;
            // 
            // Volunteer
            // 
            this.Volunteer.Text = "Vrijwilliger";
            // 
            // Date
            // 
            this.Date.Text = "Datum";
            // 
            // Urgency
            // 
            this.Urgency.Text = "Urgentie";
            // 
            // Category
            // 
            this.Category.Text = "Categorie";
            this.Category.Width = 90;
            // 
            // lblOpenRequests
            // 
            this.lblOpenRequests.AutoSize = true;
            this.lblOpenRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenRequests.Location = new System.Drawing.Point(9, 7);
            this.lblOpenRequests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpenRequests.Name = "lblOpenRequests";
            this.lblOpenRequests.Size = new System.Drawing.Size(799, 46);
            this.lblOpenRequests.TabIndex = 2;
            this.lblOpenRequests.Text = "Hulpbehoevende - Openstaande hulpvragen";
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Location = new System.Drawing.Point(682, 400);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(108, 37);
            this.btnEditQuestion.TabIndex = 4;
            this.btnEditQuestion.Text = "Bewerk vraag";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // btnAskQuestion
            // 
            this.btnAskQuestion.Location = new System.Drawing.Point(682, 356);
            this.btnAskQuestion.Name = "btnAskQuestion";
            this.btnAskQuestion.Size = new System.Drawing.Size(108, 37);
            this.btnAskQuestion.TabIndex = 6;
            this.btnAskQuestion.Text = "Hulpvraag stellen";
            this.btnAskQuestion.UseVisualStyleBackColor = true;
            this.btnAskQuestion.Click += new System.EventHandler(this.btnAskQuestion_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOff.Location = new System.Drawing.Point(679, 58);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(108, 25);
            this.btnLogOff.TabIndex = 7;
            this.btnLogOff.Text = "Uitloggen";
            this.btnLogOff.UseVisualStyleBackColor = false;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // btnToUserProfile
            // 
            this.btnToUserProfile.Location = new System.Drawing.Point(679, 89);
            this.btnToUserProfile.Name = "btnToUserProfile";
            this.btnToUserProfile.Size = new System.Drawing.Size(108, 22);
            this.btnToUserProfile.TabIndex = 8;
            this.btnToUserProfile.Text = "Accountgegevens";
            this.btnToUserProfile.UseVisualStyleBackColor = true;
            this.btnToUserProfile.Click += new System.EventHandler(this.btnToUserProfile_Click);
            // 
            // FormQuestionOverviewCareRecipient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.btnToUserProfile);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnAskQuestion);
            this.Controls.Add(this.btnEditQuestion);
            this.Controls.Add(this.lblOpenRequests);
            this.Controls.Add(this.lvOpenQuestions);
            this.Name = "FormQuestionOverviewCareRecipient";
            this.Text = "Gemeente Eindhoven";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvOpenQuestions;
        private System.Windows.Forms.ColumnHeader QuestionTitle;
        private System.Windows.Forms.ColumnHeader Volunteer;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Urgency;
        private System.Windows.Forms.Label lblOpenRequests;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnAskQuestion;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnToUserProfile;
    }
}