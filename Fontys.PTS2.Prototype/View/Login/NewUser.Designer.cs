namespace Fontys.PTS2.Prototype.View.Login
{
    partial class NewUser
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
            this.typeVolunteer = new System.Windows.Forms.RadioButton();
            this.typeCareRecipient = new System.Windows.Forms.RadioButton();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeVolunteer
            // 
            this.typeVolunteer.AutoSize = true;
            this.typeVolunteer.Location = new System.Drawing.Point(6, 19);
            this.typeVolunteer.Name = "typeVolunteer";
            this.typeVolunteer.Size = new System.Drawing.Size(70, 17);
            this.typeVolunteer.TabIndex = 0;
            this.typeVolunteer.TabStop = true;
            this.typeVolunteer.Text = "Vrijwilliger";
            this.typeVolunteer.UseVisualStyleBackColor = true;
            // 
            // typeCareRecipient
            // 
            this.typeCareRecipient.AutoSize = true;
            this.typeCareRecipient.Location = new System.Drawing.Point(6, 35);
            this.typeCareRecipient.Name = "typeCareRecipient";
            this.typeCareRecipient.Size = new System.Drawing.Size(107, 17);
            this.typeCareRecipient.TabIndex = 1;
            this.typeCareRecipient.TabStop = true;
            this.typeCareRecipient.Text = "Hulpbehoevende";
            this.typeCareRecipient.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typeCareRecipient);
            this.groupBox1.Controls.Add(this.typeVolunteer);
            this.groupBox1.Location = new System.Drawing.Point(30, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kies uw accounttype:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(105, 35);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(105, 65);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Voornaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Achternaam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Geboortedatum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sekse:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Postcode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Woonplaats:";
            // 
            // cboxSex
            // 
            this.cboxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSex.FormattingEnabled = true;
            this.cboxSex.Location = new System.Drawing.Point(105, 125);
            this.cboxSex.Name = "cboxSex";
            this.cboxSex.Size = new System.Drawing.Size(100, 21);
            this.cboxSex.TabIndex = 13;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(105, 155);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 14;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(105, 185);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 15;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(105, 215);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(100, 20);
            this.tbPostalCode.TabIndex = 16;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(105, 245);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 17;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(105, 95);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirth.TabIndex = 18;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(145, 350);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(110, 50);
            this.btnAddUser.TabIndex = 19;
            this.btnAddUser.Text = "Maak Account aan!";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 417);
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
            this.Name = "NewUser";
            this.Text = "Gemeente Eindhoven";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton typeVolunteer;
        private System.Windows.Forms.RadioButton typeCareRecipient;
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
    }
}