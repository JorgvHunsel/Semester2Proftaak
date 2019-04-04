namespace Fontys.PTS2.Prototype.View
{
    partial class FormUserProfile
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
            this.lblPaswordValidation = new System.Windows.Forms.Label();
            this.tbPassValidation = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cboxSex = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.tbDateOfBirth = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPaswordValidation
            // 
            this.lblPaswordValidation.AutoSize = true;
            this.lblPaswordValidation.Location = new System.Drawing.Point(34, 456);
            this.lblPaswordValidation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaswordValidation.Name = "lblPaswordValidation";
            this.lblPaswordValidation.Size = new System.Drawing.Size(144, 17);
            this.lblPaswordValidation.TabIndex = 45;
            this.lblPaswordValidation.Text = "Herhaal Wachtwoord:";
            this.lblPaswordValidation.Visible = false;
            // 
            // tbPassValidation
            // 
            this.tbPassValidation.Location = new System.Drawing.Point(190, 452);
            this.tbPassValidation.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassValidation.Name = "tbPassValidation";
            this.tbPassValidation.Size = new System.Drawing.Size(132, 22);
            this.tbPassValidation.TabIndex = 44;
            this.tbPassValidation.Visible = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(190, 415);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(132, 22);
            this.tbPassword.TabIndex = 43;
            this.tbPassword.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(34, 419);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 17);
            this.lblPassword.TabIndex = 42;
            this.lblPassword.Text = "Wachtwoord:";
            this.lblPassword.Visible = false;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(794, 579);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(147, 62);
            this.btnEditUser.TabIndex = 41;
            this.btnEditUser.Text = "Gegevens aanpassen";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(190, 194);
            this.dateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(265, 22);
            this.dateOfBirth.TabIndex = 40;
            this.dateOfBirth.Visible = false;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(190, 378);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4);
            this.tbCity.Name = "tbCity";
            this.tbCity.ReadOnly = true;
            this.tbCity.Size = new System.Drawing.Size(132, 22);
            this.tbCity.TabIndex = 39;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(190, 341);
            this.tbPostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbPostalCode.MaxLength = 6;
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.ReadOnly = true;
            this.tbPostalCode.Size = new System.Drawing.Size(132, 22);
            this.tbPostalCode.TabIndex = 38;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(190, 304);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(132, 22);
            this.tbAddress.TabIndex = 37;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(190, 268);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(132, 22);
            this.tbEmail.TabIndex = 36;
            // 
            // cboxSex
            // 
            this.cboxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSex.FormattingEnabled = true;
            this.cboxSex.Location = new System.Drawing.Point(190, 231);
            this.cboxSex.Margin = new System.Windows.Forms.Padding(4);
            this.cboxSex.Name = "cboxSex";
            this.cboxSex.Size = new System.Drawing.Size(132, 24);
            this.cboxSex.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 382);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Woonplaats:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 345);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Postcode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Geslacht:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Geboortedatum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Achternaam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Voornaam:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(190, 157);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(132, 22);
            this.tbLastName.TabIndex = 26;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(190, 120);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(132, 22);
            this.tbFirstName.TabIndex = 25;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 58);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Text = "Welkom";
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(191, 232);
            this.tbSex.Margin = new System.Windows.Forms.Padding(4);
            this.tbSex.Name = "tbSex";
            this.tbSex.ReadOnly = true;
            this.tbSex.Size = new System.Drawing.Size(132, 22);
            this.tbSex.TabIndex = 47;
            // 
            // tbDateOfBirth
            // 
            this.tbDateOfBirth.Location = new System.Drawing.Point(190, 194);
            this.tbDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.tbDateOfBirth.Name = "tbDateOfBirth";
            this.tbDateOfBirth.ReadOnly = true;
            this.tbDateOfBirth.Size = new System.Drawing.Size(132, 22);
            this.tbDateOfBirth.TabIndex = 48;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(949, 579);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 62);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(39, 579);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 62);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1109, 654);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbDateOfBirth);
            this.Controls.Add(this.tbSex);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPaswordValidation);
            this.Controls.Add(this.tbPassValidation);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbPostalCode);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.cboxSex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Name = "FormUserProfile";
            this.Text = "FormUserProfile";
            this.Load += new System.EventHandler(this.FormUserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaswordValidation;
        private System.Windows.Forms.TextBox tbPassValidation;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cboxSex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.TextBox tbDateOfBirth;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
    }
}