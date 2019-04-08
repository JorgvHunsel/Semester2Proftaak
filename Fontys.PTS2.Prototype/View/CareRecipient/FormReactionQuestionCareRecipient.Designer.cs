namespace Fontys.PTS2.Prototype.View.CareRecipient
{
    partial class FormReactionQuestionCareRecipient
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
            this.SuspendLayout();
            // 
            // lvQuestionReaction
            // 
            this.lvQuestionReaction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SenderName,
            this.ReactionContent,
            this.TimeStamp});
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
            // FormReactionQuestionCareRecipient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.lvQuestionReaction);
            this.Name = "FormReactionQuestionCareRecipient";
            this.Text = "FormReactionQuestionCareRecipient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvQuestionReaction;
        private System.Windows.Forms.ColumnHeader SenderName;
        private System.Windows.Forms.ColumnHeader ReactionContent;
        private System.Windows.Forms.ColumnHeader TimeStamp;
    }
}