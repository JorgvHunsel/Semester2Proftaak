namespace Fontys.PTS2.Prototype.View.Administrator
{
    partial class AdminForm
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
            this.btnAccountOverview = new System.Windows.Forms.Button();
            this.btnChatLogOverview = new System.Windows.Forms.Button();
            this.btnQuestionOverview = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAccountOverview
            // 
            this.btnAccountOverview.Location = new System.Drawing.Point(102, 67);
            this.btnAccountOverview.Name = "btnAccountOverview";
            this.btnAccountOverview.Size = new System.Drawing.Size(146, 37);
            this.btnAccountOverview.TabIndex = 0;
            this.btnAccountOverview.Text = "Accounts beheren";
            this.btnAccountOverview.UseVisualStyleBackColor = true;
            this.btnAccountOverview.Click += new System.EventHandler(this.btnAccountOverview_Click);
            // 
            // btnChatLogOverview
            // 
            this.btnChatLogOverview.Location = new System.Drawing.Point(102, 110);
            this.btnChatLogOverview.Name = "btnChatLogOverview";
            this.btnChatLogOverview.Size = new System.Drawing.Size(146, 37);
            this.btnChatLogOverview.TabIndex = 1;
            this.btnChatLogOverview.Text = "Chatlogs inzien";
            this.btnChatLogOverview.UseVisualStyleBackColor = true;
            this.btnChatLogOverview.Click += new System.EventHandler(this.btnChatLogOverview_Click);
            // 
            // btnQuestionOverview
            // 
            this.btnQuestionOverview.Location = new System.Drawing.Point(102, 153);
            this.btnQuestionOverview.Name = "btnQuestionOverview";
            this.btnQuestionOverview.Size = new System.Drawing.Size(146, 37);
            this.btnQuestionOverview.TabIndex = 2;
            this.btnQuestionOverview.Text = "Hulpvragen inzien";
            this.btnQuestionOverview.UseVisualStyleBackColor = true;
            this.btnQuestionOverview.Click += new System.EventHandler(this.btnQuestionOverview_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(102, 196);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(146, 37);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Uitloggen";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblWelcome.Location = new System.Drawing.Point(99, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(149, 39);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welkom!";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 262);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnQuestionOverview);
            this.Controls.Add(this.btnChatLogOverview);
            this.Controls.Add(this.btnAccountOverview);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccountOverview;
        private System.Windows.Forms.Button btnChatLogOverview;
        private System.Windows.Forms.Button btnQuestionOverview;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
    }
}