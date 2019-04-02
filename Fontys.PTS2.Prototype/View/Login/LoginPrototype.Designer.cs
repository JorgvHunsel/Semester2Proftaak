namespace Fontys.PTS2.Prototype.View
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
            this.EpicVictoryRoyale = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.linklblNewAccount = new System.Windows.Forms.LinkLabel();
            this.EpicVictoryRoyale.SuspendLayout();
            this.SuspendLayout();
            // 
            // EpicVictoryRoyale
            // 
            this.EpicVictoryRoyale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EpicVictoryRoyale.Controls.Add(this.tbPassword);
            this.EpicVictoryRoyale.Controls.Add(this.tboxEmail);
            this.EpicVictoryRoyale.Controls.Add(this.label1);
            this.EpicVictoryRoyale.Controls.Add(this.lblEmail);
            this.EpicVictoryRoyale.Controls.Add(this.btnLogin);
            this.EpicVictoryRoyale.Location = new System.Drawing.Point(10, 75);
            this.EpicVictoryRoyale.Name = "EpicVictoryRoyale";
            this.EpicVictoryRoyale.Size = new System.Drawing.Size(254, 138);
            this.EpicVictoryRoyale.TabIndex = 0;
            this.EpicVictoryRoyale.TabStop = false;
            this.EpicVictoryRoyale.Text = "Login";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(89, 65);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(159, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // tboxEmail
            // 
            this.tboxEmail.Location = new System.Drawing.Point(89, 36);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(159, 20);
            this.tboxEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wachtwoord:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(5, 39);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Emailadress:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(173, 102);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
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
            this.lblWelcome.Location = new System.Drawing.Point(9, 7);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(165, 46);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welkom";
            // 
            // linklblNewAccount
            // 
            this.linklblNewAccount.AutoSize = true;
            this.linklblNewAccount.Location = new System.Drawing.Point(12, 223);
            this.linklblNewAccount.Name = "linklblNewAccount";
            this.linklblNewAccount.Size = new System.Drawing.Size(80, 13);
            this.linklblNewAccount.TabIndex = 5;
            this.linklblNewAccount.TabStop = true;
            this.linklblNewAccount.Text = "Nieuw Account";
            this.linklblNewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblNewAccount_LinkClicked);
            // 
            // LoginPrototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(280, 245);
            this.Controls.Add(this.linklblNewAccount);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.EpicVictoryRoyale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(298, 291);
            this.Name = "LoginPrototype";
            this.Text = "Login";
            this.EpicVictoryRoyale.ResumeLayout(false);
            this.EpicVictoryRoyale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox EpicVictoryRoyale;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linklblNewAccount;
    }
}