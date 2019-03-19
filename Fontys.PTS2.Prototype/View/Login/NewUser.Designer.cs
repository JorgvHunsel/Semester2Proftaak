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
            this.typeVolunteer.Text = "Volunteer";
            this.typeVolunteer.UseVisualStyleBackColor = true;
            // 
            // typeCareRecipient
            // 
            this.typeCareRecipient.AutoSize = true;
            this.typeCareRecipient.Location = new System.Drawing.Point(6, 42);
            this.typeCareRecipient.Name = "typeCareRecipient";
            this.typeCareRecipient.Size = new System.Drawing.Size(95, 17);
            this.typeCareRecipient.TabIndex = 1;
            this.typeCareRecipient.TabStop = true;
            this.typeCareRecipient.Text = "Care Recipient";
            this.typeCareRecipient.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typeCareRecipient);
            this.groupBox1.Controls.Add(this.typeVolunteer);
            this.groupBox1.Location = new System.Drawing.Point(62, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewUser";
            this.Text = "rad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton typeVolunteer;
        private System.Windows.Forms.RadioButton typeCareRecipient;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}