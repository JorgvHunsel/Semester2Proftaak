namespace Fontys.PTS2.Prototype.View.CareRecipient
{
    partial class FormHomeCareRecipient
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
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(29, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(206, 58);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welkom";
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewQuestion.Location = new System.Drawing.Point(39, 100);
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(691, 80);
            this.btnNewQuestion.TabIndex = 1;
            this.btnNewQuestion.Text = "Nieuwe vraag";
            this.btnNewQuestion.UseVisualStyleBackColor = false;
            this.btnNewQuestion.Click += new System.EventHandler(this.btnNewQuestion_Click);
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(759, 9);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(194, 17);
            this.lblAccountType.TabIndex = 2;
            this.lblAccountType.Text = "Ingelogd als hulpbehoevende";
            // 
            // btnOpenQuestion
            // 
            this.btnOpenQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenQuestion.Location = new System.Drawing.Point(39, 218);
            this.btnOpenQuestion.Name = "btnOpenQuestion";
            this.btnOpenQuestion.Size = new System.Drawing.Size(691, 80);
            this.btnOpenQuestion.TabIndex = 3;
            this.btnOpenQuestion.Text = "Open vraag";
            this.btnOpenQuestion.UseVisualStyleBackColor = false;
            this.btnOpenQuestion.Click += new System.EventHandler(this.btnOpenQuestion_Click);
            // 
            // btnClosedQuestion
            // 
            this.btnClosedQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClosedQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosedQuestion.Location = new System.Drawing.Point(39, 304);
            this.btnClosedQuestion.Name = "btnClosedQuestion";
            this.btnClosedQuestion.Size = new System.Drawing.Size(691, 80);
            this.btnClosedQuestion.TabIndex = 4;
            this.btnClosedQuestion.Text = "Gesloten vraag";
            this.btnClosedQuestion.UseVisualStyleBackColor = false;
            this.btnClosedQuestion.Click += new System.EventHandler(this.btnClosedQuestion_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Location = new System.Drawing.Point(39, 428);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(691, 80);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Mijn account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.Location = new System.Drawing.Point(784, 29);
            this.btnLogOff.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(144, 45);
            this.btnLogOff.TabIndex = 8;
            this.btnLogOff.Text = "Uitloggen";
            this.btnLogOff.UseVisualStyleBackColor = false;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // FormHomeCareRecipient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(962, 553);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnClosedQuestion);
            this.Controls.Add(this.btnOpenQuestion);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.btnNewQuestion);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FormHomeCareRecipient";
            this.Text = "FormHomeCareRecipient";
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
    }
}