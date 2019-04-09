namespace Fontys.PTS2.Prototype.View
{
    partial class FormQuestionReaction
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
            this.lblQuestionTitle = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.richtbDescription = new System.Windows.Forms.RichTextBox();
            this.richtbReaction = new System.Windows.Forms.RichTextBox();
            this.lblReactionField = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnPostReaction = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestionTitle
            // 
            this.lblQuestionTitle.AutoSize = true;
            this.lblQuestionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionTitle.Location = new System.Drawing.Point(202, 22);
            this.lblQuestionTitle.Name = "lblQuestionTitle";
            this.lblQuestionTitle.Size = new System.Drawing.Size(0, 25);
            this.lblQuestionTitle.TabIndex = 0;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(13, 13);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(184, 37);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Onderwerp:";
            // 
            // richtbDescription
            // 
            this.richtbDescription.Location = new System.Drawing.Point(12, 169);
            this.richtbDescription.Name = "richtbDescription";
            this.richtbDescription.ReadOnly = true;
            this.richtbDescription.Size = new System.Drawing.Size(353, 269);
            this.richtbDescription.TabIndex = 2;
            this.richtbDescription.Text = "";
            // 
            // richtbReaction
            // 
            this.richtbReaction.Location = new System.Drawing.Point(483, 169);
            this.richtbReaction.Name = "richtbReaction";
            this.richtbReaction.Size = new System.Drawing.Size(336, 269);
            this.richtbReaction.TabIndex = 3;
            this.richtbReaction.Text = "";
            // 
            // lblReactionField
            // 
            this.lblReactionField.AutoSize = true;
            this.lblReactionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReactionField.Location = new System.Drawing.Point(478, 122);
            this.lblReactionField.Name = "lblReactionField";
            this.lblReactionField.Size = new System.Drawing.Size(224, 25);
            this.lblReactionField.TabIndex = 4;
            this.lblReactionField.Text = "Schrijf hier uw reactie:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 131);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(129, 25);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Beschrijving";
            // 
            // btnPostReaction
            // 
            this.btnPostReaction.Location = new System.Drawing.Point(824, 338);
            this.btnPostReaction.Name = "btnPostReaction";
            this.btnPostReaction.Size = new System.Drawing.Size(143, 46);
            this.btnPostReaction.TabIndex = 6;
            this.btnPostReaction.Text = "Plaats reactie";
            this.btnPostReaction.UseVisualStyleBackColor = true;
            this.btnPostReaction.Click += new System.EventHandler(this.btnPostReaction_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(824, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormQuestionReaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPostReaction);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblReactionField);
            this.Controls.Add(this.richtbReaction);
            this.Controls.Add(this.richtbDescription);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuestionTitle);
            this.Name = "FormQuestionReaction";
            this.Text = "FormQuestionReaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionTitle;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RichTextBox richtbDescription;
        private System.Windows.Forms.RichTextBox richtbReaction;
        private System.Windows.Forms.Label lblReactionField;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnPostReaction;
        private System.Windows.Forms.Button btnCancel;
    }
}