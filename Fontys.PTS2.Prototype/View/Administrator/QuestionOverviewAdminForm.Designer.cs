namespace Fontys.PTS2.Prototype.View.Administrator
{
    partial class QuestionOverviewAdminForm
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
            this.lvQuestionOverview = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvQuestionOverview
            // 
            this.lvQuestionOverview.Location = new System.Drawing.Point(12, 58);
            this.lvQuestionOverview.Name = "lvQuestionOverview";
            this.lvQuestionOverview.Size = new System.Drawing.Size(662, 380);
            this.lvQuestionOverview.TabIndex = 1;
            this.lvQuestionOverview.UseCompatibleStateImageBehavior = false;
            // 
            // QuestionOverviewAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvQuestionOverview);
            this.Name = "QuestionOverviewAdminForm";
            this.Text = "QuestionOverviewAdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvQuestionOverview;
    }
}