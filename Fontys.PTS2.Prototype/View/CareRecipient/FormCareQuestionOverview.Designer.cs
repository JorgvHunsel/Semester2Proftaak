namespace Fontys.PTS2.Prototype.View
{
    partial class FormCareQuestionOverview
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
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Urgency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOpenRequests = new System.Windows.Forms.Label();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.QuestionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvOpenQuestions
            // 
            this.lvOpenQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.QuestionTitle,
            this.Date,
            this.Urgency,
            this.Category,
            this.QuestionID});
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
            this.lblOpenRequests.Size = new System.Drawing.Size(619, 46);
            this.lblOpenRequests.TabIndex = 2;
            this.lblOpenRequests.Text = "Hulpbehoevende - Uw hulpvragen";
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditQuestion.Location = new System.Drawing.Point(679, 357);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(108, 37);
            this.btnEditQuestion.TabIndex = 4;
            this.btnEditQuestion.Text = "Bewerk vraag";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnFormCareEditQuestion_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(679, 400);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 37);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormCareQuestionOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEditQuestion);
            this.Controls.Add(this.lblOpenRequests);
            this.Controls.Add(this.lvOpenQuestions);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCareQuestionOverview";
            this.Text = "Gemeente Eindhoven";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvOpenQuestions;
        private System.Windows.Forms.ColumnHeader QuestionTitle;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Urgency;
        private System.Windows.Forms.Label lblOpenRequests;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColumnHeader QuestionID;
    }
}