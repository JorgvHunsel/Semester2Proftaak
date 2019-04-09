namespace Fontys.PTS2.Prototype.View.Administrator
{
    partial class FormAdminAccountOverview
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
            this.lvUserOverview = new System.Windows.Forms.ListView();
            this.AccountID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PostalCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBlockUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvUserOverview
            // 
            this.lvUserOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AccountID,
            this.AccountType,
            this.FirstName,
            this.LastName,
            this.BirthDate,
            this.Gender,
            this.Email,
            this.Address,
            this.PostalCode,
            this.City,
            this.Status});
            this.lvUserOverview.Location = new System.Drawing.Point(16, 71);
            this.lvUserOverview.Margin = new System.Windows.Forms.Padding(4);
            this.lvUserOverview.Name = "lvUserOverview";
            this.lvUserOverview.Size = new System.Drawing.Size(906, 467);
            this.lvUserOverview.TabIndex = 0;
            this.lvUserOverview.UseCompatibleStateImageBehavior = false;
            this.lvUserOverview.View = System.Windows.Forms.View.Details;
            // 
            // AccountID
            // 
            this.AccountID.Text = "ID";
            this.AccountID.Width = 26;
            // 
            // AccountType
            // 
            this.AccountType.Text = "Type Account";
            this.AccountType.Width = 82;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Voornaam";
            this.FirstName.Width = 65;
            // 
            // LastName
            // 
            this.LastName.Text = "Achternaam";
            // 
            // BirthDate
            // 
            this.BirthDate.Text = "Geboortedatum";
            // 
            // Gender
            // 
            this.Gender.Text = "Geslacht";
            // 
            // Email
            // 
            this.Email.Text = "EmailAdres";
            this.Email.Width = 70;
            // 
            // Address
            // 
            this.Address.Text = "Adres";
            // 
            // PostalCode
            // 
            this.PostalCode.Text = "Postcode";
            // 
            // City
            // 
            this.City.Text = "Woonplaats";
            this.City.Width = 96;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 58);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Gebruiker overzicht";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(930, 496);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 45);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBlockUser
            // 
            this.btnBlockUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBlockUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockUser.Location = new System.Drawing.Point(930, 443);
            this.btnBlockUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlockUser.Name = "btnBlockUser";
            this.btnBlockUser.Size = new System.Drawing.Size(144, 45);
            this.btnBlockUser.TabIndex = 17;
            this.btnBlockUser.Text = "Block / unblock";
            this.btnBlockUser.UseVisualStyleBackColor = false;
            this.btnBlockUser.Click += new System.EventHandler(this.btnBlockUser_Click);
            // 
            // FormAdminAccountOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1087, 554);
            this.Controls.Add(this.btnBlockUser);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvUserOverview);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdminAccountOverview";
            this.Text = "FormAdminAccountOverview";
            this.Load += new System.EventHandler(this.AccountOverviewAdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvUserOverview;
        private System.Windows.Forms.ColumnHeader AccountID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader AccountType;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader BirthDate;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader PostalCode;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button btnBlockUser;
    }
}