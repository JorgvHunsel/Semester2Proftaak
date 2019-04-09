namespace Fontys.PTS2.Prototype.View.CareRecipient
{
    partial class FormCareQuestionReaction
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
            this.lvQuestionReaction = new System.Windows.Forms.ListView();
            this.SenderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReactionContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeStamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCreateChatlog = new System.Windows.Forms.Button();
            this.QuestionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReactionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SenderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvQuestionReaction
            // 
            this.lvQuestionReaction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SenderName,
            this.ReactionContent,
            this.TimeStamp,
            this.QuestionID,
            this.ReactionID,
            this.SenderID});
            this.lvQuestionReaction.Location = new System.Drawing.Point(12, 58);
            this.lvQuestionReaction.Name = "lvQuestionReaction";
            this.lvQuestionReaction.Size = new System.Drawing.Size(662, 380);
            this.lvQuestionReaction.TabIndex = 0;
            this.lvQuestionReaction.UseCompatibleStateImageBehavior = false;
            this.lvQuestionReaction.View = System.Windows.Forms.View.Details;
            // 
            // SenderName
            // 
            this.SenderName.Text = "Afzender";
            // 
            // ReactionContent
            // 
            this.ReactionContent.Text = "Inhoud";
            this.ReactionContent.Width = 50;
            // 
            // TimeStamp
            // 
            this.TimeStamp.Text = "Tijd van reactie";
            this.TimeStamp.Width = 99;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(11, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(438, 46);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Reacties op hulpvraag: ";
            // 
            // btnCreateChatlog
            // 
            this.btnCreateChatlog.Location = new System.Drawing.Point(680, 366);
            this.btnCreateChatlog.Name = "btnCreateChatlog";
            this.btnCreateChatlog.Size = new System.Drawing.Size(103, 35);
            this.btnCreateChatlog.TabIndex = 3;
            this.btnCreateChatlog.Text = "Maak chat";
            this.btnCreateChatlog.UseVisualStyleBackColor = true;
            this.btnCreateChatlog.Click += new System.EventHandler(this.btnCreateChatlog_Click);
            // 
            // QuestionID
            // 
            this.QuestionID.Text = "QuestionID";
            // 
            // ReactionID
            // 
            this.ReactionID.Text = "ReactionID";
            // 
            // SenderID
            // 
            this.SenderID.Text = "SenderID";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(681, 408);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormCareQuestionReaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreateChatlog);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lvQuestionReaction);
            this.Name = "FormCareQuestionReaction";
            this.Text = "FormReactionQuestionCareRecipient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvQuestionReaction;
        private System.Windows.Forms.ColumnHeader SenderName;
        private System.Windows.Forms.ColumnHeader ReactionContent;
        private System.Windows.Forms.ColumnHeader TimeStamp;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnCreateChatlog;
        private System.Windows.Forms.ColumnHeader QuestionID;
        private System.Windows.Forms.ColumnHeader ReactionID;
        private System.Windows.Forms.ColumnHeader SenderID;
        private System.Windows.Forms.Button btnBack;
    }
}