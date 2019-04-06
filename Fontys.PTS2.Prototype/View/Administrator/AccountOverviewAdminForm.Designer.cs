namespace Fontys.PTS2.Prototype.View.Administrator
{
    partial class AccountOverviewAdminForm
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
            this.lvAccountOverview = new System.Windows.Forms.ListView();
            this.AccountID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvAccountOverview
            // 
            this.lvAccountOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AccountID,
            this.FirstName,
            this.Email,
            this.AccountType,
            this.Rating,
            this.AccountStatus});
            this.lvAccountOverview.Location = new System.Drawing.Point(16, 71);
            this.lvAccountOverview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvAccountOverview.Name = "lvAccountOverview";
            this.lvAccountOverview.Size = new System.Drawing.Size(881, 467);
            this.lvAccountOverview.TabIndex = 0;
            this.lvAccountOverview.UseCompatibleStateImageBehavior = false;
            this.lvAccountOverview.View = System.Windows.Forms.View.Details;
            // 
            // AccountID
            // 
            this.AccountID.Text = "ID";
            this.AccountID.Width = 26;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Voornaam";
            this.FirstName.Width = 65;
            // 
            // Email
            // 
            this.Email.Text = "EmailAdres";
            this.Email.Width = 70;
            // 
            // AccountType
            // 
            this.AccountType.Text = "Type Account";
            this.AccountType.Width = 82;
            // 
            // Rating
            // 
            this.Rating.Text = "Beoordeling";
            this.Rating.Width = 71;
            // 
            // AccountStatus
            // 
            this.AccountStatus.Text = "Status";
            this.AccountStatus.Width = 48;
            // 
            // AccountOverviewAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1061, 554);
            this.Controls.Add(this.lvAccountOverview);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccountOverviewAdminForm";
            this.Text = "AccountOverviewAdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAccountOverview;
        private System.Windows.Forms.ColumnHeader AccountID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader AccountType;
        private System.Windows.Forms.ColumnHeader AccountStatus;
        private System.Windows.Forms.ColumnHeader Rating;
    }
}