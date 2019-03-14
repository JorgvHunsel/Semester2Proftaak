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
            this.SuspendLayout();
            // 
            // lblQuestionTitle
            // 
            this.lblQuestionTitle.AutoSize = true;
            this.lblQuestionTitle.Location = new System.Drawing.Point(12, 73);
            this.lblQuestionTitle.Name = "lblQuestionTitle";
            this.lblQuestionTitle.Size = new System.Drawing.Size(0, 13);
            this.lblQuestionTitle.TabIndex = 0;
            // 
            // FormQuestionReaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuestionTitle);
            this.Name = "FormQuestionReaction";
            this.Text = "FormQuestionReaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionTitle;
    }
}