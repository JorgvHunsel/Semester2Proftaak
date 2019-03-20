﻿namespace Fontys.PTS2.Prototype.View
{
    partial class LoginPrototype
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPrototype));
            this.cboxUsers = new System.Windows.Forms.ComboBox();
            this.rbtnCareRecipient = new System.Windows.Forms.RadioButton();
            this.rbtnVolunteer = new System.Windows.Forms.RadioButton();
            this.EpicVictoryRoyale = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.EpicVictoryRoyale.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxUsers
            // 
            this.cboxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUsers.FormattingEnabled = true;
            this.cboxUsers.Location = new System.Drawing.Point(40, 50);
            this.cboxUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxUsers.Name = "cboxUsers";
            this.cboxUsers.Size = new System.Drawing.Size(160, 24);
            this.cboxUsers.TabIndex = 0;
            // 
            // rbtnCareRecipient
            // 
            this.rbtnCareRecipient.AutoSize = true;
            this.rbtnCareRecipient.Location = new System.Drawing.Point(40, 98);
            this.rbtnCareRecipient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnCareRecipient.Name = "rbtnCareRecipient";
            this.rbtnCareRecipient.Size = new System.Drawing.Size(137, 21);
            this.rbtnCareRecipient.TabIndex = 1;
            this.rbtnCareRecipient.TabStop = true;
            this.rbtnCareRecipient.Text = "Hulpbehoevende";
            this.rbtnCareRecipient.UseVisualStyleBackColor = true;
            // 
            // rbtnVolunteer
            // 
            this.rbtnVolunteer.AutoSize = true;
            this.rbtnVolunteer.Location = new System.Drawing.Point(40, 126);
            this.rbtnVolunteer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnVolunteer.Name = "rbtnVolunteer";
            this.rbtnVolunteer.Size = new System.Drawing.Size(91, 21);
            this.rbtnVolunteer.TabIndex = 2;
            this.rbtnVolunteer.TabStop = true;
            this.rbtnVolunteer.Text = "Vrijwilliger";
            this.rbtnVolunteer.UseVisualStyleBackColor = true;
            // 
            // EpicVictoryRoyale
            // 
            this.EpicVictoryRoyale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EpicVictoryRoyale.Controls.Add(this.lblUser);
            this.EpicVictoryRoyale.Controls.Add(this.btnLogin);
            this.EpicVictoryRoyale.Controls.Add(this.cboxUsers);
            this.EpicVictoryRoyale.Controls.Add(this.rbtnVolunteer);
            this.EpicVictoryRoyale.Controls.Add(this.rbtnCareRecipient);
            this.EpicVictoryRoyale.Location = new System.Drawing.Point(13, 107);
            this.EpicVictoryRoyale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EpicVictoryRoyale.Name = "EpicVictoryRoyale";
            this.EpicVictoryRoyale.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EpicVictoryRoyale.Size = new System.Drawing.Size(339, 170);
            this.EpicVictoryRoyale.TabIndex = 3;
            this.EpicVictoryRoyale.TabStop = false;
            this.EpicVictoryRoyale.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(231, 126);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(206, 58);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welkom";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(40, 29);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(75, 17);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Gebruiker:";
            // 
            // LoginPrototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 302);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.EpicVictoryRoyale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(392, 349);
            this.Name = "LoginPrototype";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPrototype_Load);
            this.EpicVictoryRoyale.ResumeLayout(false);
            this.EpicVictoryRoyale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxUsers;
        private System.Windows.Forms.RadioButton rbtnCareRecipient;
        private System.Windows.Forms.RadioButton rbtnVolunteer;
        private System.Windows.Forms.GroupBox EpicVictoryRoyale;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUser;
    }
}