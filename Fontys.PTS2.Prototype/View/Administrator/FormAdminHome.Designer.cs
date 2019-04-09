namespace Fontys.PTS2.Prototype.View.Administrator
{
    partial class FormAdminHome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.btnAddProf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccountOverview
            // 
            this.btnAccountOverview.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccountOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountOverview.Location = new System.Drawing.Point(21, 78);
            this.btnAccountOverview.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccountOverview.Name = "btnAccountOverview";
            this.btnAccountOverview.Size = new System.Drawing.Size(443, 46);
            this.btnAccountOverview.TabIndex = 0;
            this.btnAccountOverview.Text = "Accounts beheren";
            this.btnAccountOverview.UseVisualStyleBackColor = false;
            this.btnAccountOverview.Click += new System.EventHandler(this.btnAccountOverview_Click);
            // 
            // btnChatLogOverview
            // 
            this.btnChatLogOverview.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChatLogOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChatLogOverview.Location = new System.Drawing.Point(21, 131);
            this.btnChatLogOverview.Margin = new System.Windows.Forms.Padding(4);
            this.btnChatLogOverview.Name = "btnChatLogOverview";
            this.btnChatLogOverview.Size = new System.Drawing.Size(443, 46);
            this.btnChatLogOverview.TabIndex = 1;
            this.btnChatLogOverview.Text = "Chatlogs inzien";
            this.btnChatLogOverview.UseVisualStyleBackColor = false;
            this.btnChatLogOverview.Click += new System.EventHandler(this.btnChatLogOverview_Click);
            // 
            // btnQuestionOverview
            // 
            this.btnQuestionOverview.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuestionOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionOverview.Location = new System.Drawing.Point(21, 184);
            this.btnQuestionOverview.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuestionOverview.Name = "btnQuestionOverview";
            this.btnQuestionOverview.Size = new System.Drawing.Size(443, 46);
            this.btnQuestionOverview.TabIndex = 2;
            this.btnQuestionOverview.Text = "Hulpvragen inzien";
            this.btnQuestionOverview.UseVisualStyleBackColor = false;
            this.btnQuestionOverview.Click += new System.EventHandler(this.btnQuestionOverview_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblWelcome.Location = new System.Drawing.Point(13, 9);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(184, 48);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welkom!";
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.Location = new System.Drawing.Point(320, 25);
            this.btnLogOff.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(144, 45);
            this.btnLogOff.TabIndex = 17;
            this.btnLogOff.Text = "Uitloggen";
            this.btnLogOff.UseVisualStyleBackColor = false;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(316, 4);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(170, 17);
            this.lblAccountType.TabIndex = 16;
            this.lblAccountType.Text = "Ingelogd als administrator\r\n";
            // 
            // btnAddProf
            // 
            this.btnAddProf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProf.Location = new System.Drawing.Point(21, 238);
            this.btnAddProf.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProf.Name = "btnAddProf";
            this.btnAddProf.Size = new System.Drawing.Size(443, 46);
            this.btnAddProf.TabIndex = 18;
            this.btnAddProf.Text = "Professional toevoegen";
            this.btnAddProf.UseVisualStyleBackColor = false;
            this.btnAddProf.Click += new System.EventHandler(this.btnAddProf_Click);
            // 
            // FormAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 302);
            this.Controls.Add(this.btnAddProf);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnQuestionOverview);
            this.Controls.Add(this.btnChatLogOverview);
            this.Controls.Add(this.btnAccountOverview);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdminHome";
            this.Text = "FormAdminHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccountOverview;
        private System.Windows.Forms.Button btnChatLogOverview;
        private System.Windows.Forms.Button btnQuestionOverview;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Button btnAddProf;
    }
}