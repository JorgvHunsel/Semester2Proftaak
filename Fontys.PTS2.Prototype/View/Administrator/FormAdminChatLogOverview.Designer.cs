namespace Fontys.PTS2.Prototype.View.Administrator
{
    partial class FormAdminChatLogOverview
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
            this.lvChatLogOverview = new System.Windows.Forms.ListView();
            this.LbChatOverView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lvChatLogOverview
            // 
            this.lvChatLogOverview.Location = new System.Drawing.Point(21, 72);
            this.lvChatLogOverview.Name = "lvChatLogOverview";
            this.lvChatLogOverview.Size = new System.Drawing.Size(662, 380);
            this.lvChatLogOverview.TabIndex = 0;
            this.lvChatLogOverview.UseCompatibleStateImageBehavior = false;
            // 
            // LbChatOverView
            // 
            this.LbChatOverView.FormattingEnabled = true;
            this.LbChatOverView.Location = new System.Drawing.Point(21, 72);
            this.LbChatOverView.Name = "LbChatOverView";
            this.LbChatOverView.Size = new System.Drawing.Size(662, 381);
            this.LbChatOverView.TabIndex = 1;
            // 
            // ChatLogOverviewAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.LbChatOverView);
            this.Controls.Add(this.lvChatLogOverview);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdminChatLogOverview";
            this.Text = "FormAdminChatLogOverview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvChatLogOverview;
        private System.Windows.Forms.ListBox LbChatOverView;
    }
}