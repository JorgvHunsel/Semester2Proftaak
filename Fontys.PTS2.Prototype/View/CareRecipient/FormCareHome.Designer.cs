namespace Fontys.PTS2.Prototype.View.CareRecipient
{
    partial class FormCareHome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnNewQuestion = new System.Windows.Forms.Button();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.btnOpenQuestion = new System.Windows.Forms.Button();
            this.btnClosedQuestion = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnChatOverview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(22, 7);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(165, 46);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welkom";
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewQuestion.Location = new System.Drawing.Point(29, 81);
            this.btnNewQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(518, 65);
            this.btnNewQuestion.TabIndex = 1;
            this.btnNewQuestion.Text = "Nieuwe vraag";
            this.btnNewQuestion.UseVisualStyleBackColor = false;
            this.btnNewQuestion.Click += new System.EventHandler(this.btnNewQuestion_Click);
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(569, 7);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(147, 13);
            this.lblAccountType.TabIndex = 2;
            this.lblAccountType.Text = "Ingelogd als hulpbehoevende";
            // 
            // btnOpenQuestion
            // 
            this.btnOpenQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenQuestion.Location = new System.Drawing.Point(29, 177);
            this.btnOpenQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenQuestion.Name = "btnOpenQuestion";
            this.btnOpenQuestion.Size = new System.Drawing.Size(518, 65);
            this.btnOpenQuestion.TabIndex = 3;
            this.btnOpenQuestion.Text = "Open vraag";
            this.btnOpenQuestion.UseVisualStyleBackColor = false;
            this.btnOpenQuestion.Click += new System.EventHandler(this.btnOpenQuestion_Click);
            // 
            // btnClosedQuestion
            // 
            this.btnClosedQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClosedQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosedQuestion.Location = new System.Drawing.Point(29, 247);
            this.btnClosedQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClosedQuestion.Name = "btnClosedQuestion";
            this.btnClosedQuestion.Size = new System.Drawing.Size(518, 65);
            this.btnClosedQuestion.TabIndex = 4;
            this.btnClosedQuestion.Text = "Gesloten vraag";
            this.btnClosedQuestion.UseVisualStyleBackColor = false;
            this.btnClosedQuestion.Click += new System.EventHandler(this.btnClosedQuestion_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Location = new System.Drawing.Point(29, 348);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(518, 65);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Mijn account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.Location = new System.Drawing.Point(588, 24);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(108, 37);
            this.btnLogOff.TabIndex = 8;
            this.btnLogOff.Text = "Uitloggen";
            this.btnLogOff.UseVisualStyleBackColor = false;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // btnChatOverview
            // 
            this.btnChatOverview.Location = new System.Drawing.Point(612, 218);
            this.btnChatOverview.Name = "btnChatOverview";
            this.btnChatOverview.Size = new System.Drawing.Size(75, 23);
            this.btnChatOverview.TabIndex = 9;
            this.btnChatOverview.Text = "Chat";
            this.btnChatOverview.UseVisualStyleBackColor = true;
            this.btnChatOverview.Click += new System.EventHandler(this.btnChatOverview_Click);
            // 
            // FormCareHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(722, 449);
            this.Controls.Add(this.btnChatOverview);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnClosedQuestion);
            this.Controls.Add(this.btnOpenQuestion);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.btnNewQuestion);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCareHome";
            this.Text = "FormCareHome";
            this.Load += new System.EventHandler(this.FormHomeCareRecipient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnNewQuestion;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Button btnOpenQuestion;
        private System.Windows.Forms.Button btnClosedQuestion;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnChatOverview;
    }
}