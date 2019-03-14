namespace Fontys.PTS2.Prototype.View
{
    partial class FormVolunteerChatOverview
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameCareRecipient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uw chats";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCareRecipient,
            this.Subject,
            this.Time});
            this.listView1.Location = new System.Drawing.Point(125, 100);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(736, 298);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // nameCareRecipient
            // 
            this.nameCareRecipient.Text = "Naam hulpbehoevende";
            this.nameCareRecipient.Width = 250;
            // 
            // Subject
            // 
            this.Subject.Text = "Onderwerp";
            this.Subject.Width = 334;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 133;
            // 
            // btnOpenChat
            // 
            this.btnOpenChat.Location = new System.Drawing.Point(125, 404);
            this.btnOpenChat.Name = "btnOpenChat";
            this.btnOpenChat.Size = new System.Drawing.Size(158, 72);
            this.btnOpenChat.TabIndex = 2;
            this.btnOpenChat.Text = "Open chat";
            this.btnOpenChat.UseVisualStyleBackColor = true;
            // 
            // FormVolunteerChatOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnOpenChat);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "FormVolunteerChatOverview";
            this.Text = "FormVolunteerChatOverview";
            this.Load += new System.EventHandler(this.FormVolunteerChatOverview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nameCareRecipient;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Button btnOpenChat;
    }
}