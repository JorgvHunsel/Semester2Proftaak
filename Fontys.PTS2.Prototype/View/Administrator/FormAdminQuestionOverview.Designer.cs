namespace Fontys.PTS2.Prototype.View.Administrator
{
    partial class FormAdminQuestionOverview
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
            this.lvQuestionOverview.Location = new System.Drawing.Point(16, 71);
            this.lvQuestionOverview.Margin = new System.Windows.Forms.Padding(4);
            this.lvQuestionOverview.Name = "lvQuestionOverview";
            this.lvQuestionOverview.Size = new System.Drawing.Size(881, 467);
            this.lvQuestionOverview.TabIndex = 1;
            this.lvQuestionOverview.UseCompatibleStateImageBehavior = false;
            // 
            // FormAdminQuestionOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lvQuestionOverview);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdminQuestionOverview";
            this.Text = "FormAdminQuestionOverview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvQuestionOverview;
    }
}