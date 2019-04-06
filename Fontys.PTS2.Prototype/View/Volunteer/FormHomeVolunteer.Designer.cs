namespace Fontys.PTS2.Prototype.View.Volunteer
{
    partial class FormHomeVolunteer
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
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnOpenQuestion = new System.Windows.Forms.Button();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.btnOpenQuestions = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.Location = new System.Drawing.Point(806, 31);
            this.btnLogOff.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(144, 45);
            this.btnLogOff.TabIndex = 15;
            this.btnLogOff.Text = "Uitloggen";
            this.btnLogOff.UseVisualStyleBackColor = false;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Location = new System.Drawing.Point(28, 335);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(691, 80);
            this.btnAccount.TabIndex = 14;
            this.btnAccount.Text = "Mijn account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnOpenQuestion
            // 
            this.btnOpenQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenQuestion.Location = new System.Drawing.Point(28, 220);
            this.btnOpenQuestion.Name = "btnOpenQuestion";
            this.btnOpenQuestion.Size = new System.Drawing.Size(691, 80);
            this.btnOpenQuestion.TabIndex = 12;
            this.btnOpenQuestion.Text = "Chat overzicht";
            this.btnOpenQuestion.UseVisualStyleBackColor = false;
            this.btnOpenQuestion.Click += new System.EventHandler(this.btnOpenQuestion_Click);
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(802, 10);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(148, 17);
            this.lblAccountType.TabIndex = 11;
            this.lblAccountType.Text = "Ingelogd als vrijwilliger";
            // 
            // btnOpenQuestions
            // 
            this.btnOpenQuestions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenQuestions.Location = new System.Drawing.Point(28, 102);
            this.btnOpenQuestions.Name = "btnOpenQuestions";
            this.btnOpenQuestions.Size = new System.Drawing.Size(691, 80);
            this.btnOpenQuestions.TabIndex = 10;
            this.btnOpenQuestions.Text = "Open hulpvragen";
            this.btnOpenQuestions.UseVisualStyleBackColor = false;
            this.btnOpenQuestions.Click += new System.EventHandler(this.btnOpenQuestions_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(18, 11);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(206, 58);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welkom";
            // 
            // FormHomeVolunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(962, 435);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnOpenQuestion);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.btnOpenQuestions);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FormHomeVolunteer";
            this.Text = "FormHomeVolunteer";
            this.Load += new System.EventHandler(this.FormHomeVolunteer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnOpenQuestion;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Button btnOpenQuestions;
        private System.Windows.Forms.Label lblWelcome;
    }
}