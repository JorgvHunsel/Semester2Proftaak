namespace Fontys.PTS2.Prototype.View.Administrator
{
    partial class ChatLogOverviewAdminForm
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
            this.SuspendLayout();
            // 
            // lvChatLogOverview
            // 
            this.lvChatLogOverview.Location = new System.Drawing.Point(12, 58);
            this.lvChatLogOverview.Name = "lvChatLogOverview";
            this.lvChatLogOverview.Size = new System.Drawing.Size(662, 380);
            this.lvChatLogOverview.TabIndex = 0;
            this.lvChatLogOverview.UseCompatibleStateImageBehavior = false;
            // 
            // ChatLogOverviewAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.lvChatLogOverview);
            this.Name = "ChatLogOverviewAdminForm";
            this.Text = "ChatLogOverviewAdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvChatLogOverview;
    }
}