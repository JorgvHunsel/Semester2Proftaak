namespace Fontys.PTS2.Prototype.View.Login
{
    partial class FormCreateAccount
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
            this.rbtnVolunteer = new System.Windows.Forms.RadioButton();
            this.rbtnCareRecipient = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxSex = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPassValidation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnVolunteer
            // 
            this.rbtnVolunteer.AutoSize = true;
            this.rbtnVolunteer.Location = new System.Drawing.Point(8, 23);
            this.rbtnVolunteer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnVolunteer.Name = "rbtnVolunteer";
            this.rbtnVolunteer.Size = new System.Drawing.Size(91, 21);
            this.rbtnVolunteer.TabIndex = 0;
            this.rbtnVolunteer.TabStop = true;
            this.rbtnVolunteer.Text = "Vrijwilliger";
            this.rbtnVolunteer.UseVisualStyleBackColor = true;
            // 
            // rbtnCareRecipient
            // 
            this.rbtnCareRecipient.AutoSize = true;
            this.rbtnCareRecipient.Checked = true;
            this.rbtnCareRecipient.Location = new System.Drawing.Point(8, 43);
            this.rbtnCareRecipient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnCareRecipient.Name = "rbtnCareRecipient";
            this.rbtnCareRecipient.Size = new System.Drawing.Size(137, 21);
            this.rbtnCareRecipient.TabIndex = 1;
            this.rbtnCareRecipient.TabStop = true;
            this.rbtnCareRecipient.Text = "Hulpbehoevende";
            this.rbtnCareRecipient.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCareRecipient);
            this.groupBox1.Controls.Add(this.rbtnVolunteer);
            this.groupBox1.Location = new System.Drawing.Point(16, 448);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(308, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kies uw accounttype:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(192, 84);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(132, 22);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(192, 121);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(132, 22);
            this.tbLastName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Voornaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Achternaam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Geboortedatum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sekse:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 308);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Postcode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 345);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Woonplaats:";
            // 
            // cboxSex
            // 
            this.cboxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSex.FormattingEnabled = true;
            this.cboxSex.Location = new System.Drawing.Point(192, 195);
            this.cboxSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxSex.Name = "cboxSex";
            this.cboxSex.Size = new System.Drawing.Size(132, 24);
            this.cboxSex.TabIndex = 13;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(192, 232);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(132, 22);
            this.tbEmail.TabIndex = 14;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(192, 268);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(132, 22);
            this.tbAddress.TabIndex = 15;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(192, 305);
            this.tbPostalCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPostalCode.MaxLength = 6;
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(132, 22);
            this.tbPostalCode.TabIndex = 16;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(192, 342);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(132, 22);
            this.tbCity.TabIndex = 17;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(192, 158);
            this.dateOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(238, 22);
            this.dateOfBirth.TabIndex = 18;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUser.Location = new System.Drawing.Point(399, 452);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(147, 62);
            this.btnAddUser.TabIndex = 19;
            this.btnAddUser.Text = "Maak Account aan!";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 382);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Wachtwoord:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(192, 379);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(132, 22);
            this.tbPassword.TabIndex = 21;
            // 
            // tbPassValidation
            // 
            this.tbPassValidation.Location = new System.Drawing.Point(192, 416);
            this.tbPassValidation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassValidation.Name = "tbPassValidation";
            this.tbPassValidation.Size = new System.Drawing.Size(132, 22);
            this.tbPassValidation.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 416);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Herhaal Wachtwoord:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(14, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(454, 58);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Account aanmaken";
            // 
            // FormCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(559, 544);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPassValidation);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddUser);
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
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCreateAccount";
            this.Text = "Gemeente Eindhoven";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnVolunteer;
        private System.Windows.Forms.RadioButton rbtnCareRecipient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxSex;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPassValidation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTitle;
    }
}