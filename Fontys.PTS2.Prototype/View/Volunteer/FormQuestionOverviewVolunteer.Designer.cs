namespace Fontys.PTS2.Prototype.View
{
    partial class FormQuestionOverview
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
            this.btnLogOff = new System.Windows.Forms.Button();
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
            this.lvOpenQuestions.Location = new System.Drawing.Point(12, 58);
            this.lvOpenQuestions.Name = "lvOpenQuestions";
            this.lvOpenQuestions.Size = new System.Drawing.Size(588, 380);
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
            this.lblOpenRequests.Location = new System.Drawing.Point(9, 7);
            this.lblOpenRequests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpenRequests.Name = "lblOpenRequests";
            this.lblOpenRequests.Size = new System.Drawing.Size(680, 46);
            this.lblOpenRequests.TabIndex = 1;
            this.lblOpenRequests.Text = "Vrijwilliger - Openstaande hulpvragen";
            // 
            // btnReactToQuestion
            // 
            this.btnReactToQuestion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReactToQuestion.Location = new System.Drawing.Point(605, 400);
            this.btnReactToQuestion.Name = "btnReactToQuestion";
            this.btnReactToQuestion.Size = new System.Drawing.Size(107, 37);
            this.btnReactToQuestion.TabIndex = 4;
            this.btnReactToQuestion.Text = "Reageer";
            this.btnReactToQuestion.UseVisualStyleBackColor = false;
            this.btnReactToQuestion.Click += new System.EventHandler(this.btnReactToQuestion_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOff.Location = new System.Drawing.Point(605, 58);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(107, 25);
            this.btnLogOff.TabIndex = 5;
            this.btnLogOff.Text = "Uitloggen";
            this.btnLogOff.UseVisualStyleBackColor = false;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // FormQuestionOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnReactToQuestion);
            this.Controls.Add(this.lblOpenRequests);
            this.Controls.Add(this.lvOpenQuestions);
            this.Name = "FormQuestionOverview";
            this.Text = "FormQuestionOverview";
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
        private System.Windows.Forms.Button btnLogOff;
    }
}