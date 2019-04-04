namespace Fontys.PTS2.Prototype.View.Volunteer
{
    partial class FormAppointmentVolunteer
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
            this.btMakeAppointment = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.tbCareRecipientName = new System.Windows.Forms.TextBox();
            this.lbNameCR = new System.Windows.Forms.Label();
            this.lblOpenRequests = new System.Windows.Forms.Label();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btMakeAppointment
            // 
            this.btMakeAppointment.Location = new System.Drawing.Point(391, 150);
            this.btMakeAppointment.Name = "btMakeAppointment";
            this.btMakeAppointment.Size = new System.Drawing.Size(102, 38);
            this.btMakeAppointment.TabIndex = 18;
            this.btMakeAppointment.Text = "Afspraak maken";
            this.btMakeAppointment.UseVisualStyleBackColor = true;
            this.btMakeAppointment.Click += new System.EventHandler(this.btMakeAppointment_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(163, 119);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(69, 24);
            this.lbDate.TabIndex = 17;
            this.lbDate.Text = "Datum:";
            // 
            // tbCareRecipientName
            // 
            this.tbCareRecipientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCareRecipientName.Location = new System.Drawing.Point(242, 79);
            this.tbCareRecipientName.Name = "tbCareRecipientName";
            this.tbCareRecipientName.Size = new System.Drawing.Size(251, 29);
            this.tbCareRecipientName.TabIndex = 15;
            // 
            // lbNameCR
            // 
            this.lbNameCR.AutoSize = true;
            this.lbNameCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameCR.Location = new System.Drawing.Point(17, 79);
            this.lbNameCR.Name = "lbNameCR";
            this.lbNameCR.Size = new System.Drawing.Size(215, 24);
            this.lbNameCR.TabIndex = 14;
            this.lbNameCR.Text = "Naam hulpbehoevende:";
            // 
            // lblOpenRequests
            // 
            this.lblOpenRequests.AutoSize = true;
            this.lblOpenRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenRequests.Location = new System.Drawing.Point(11, 9);
            this.lblOpenRequests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpenRequests.Name = "lblOpenRequests";
            this.lblOpenRequests.Size = new System.Drawing.Size(434, 33);
            this.lblOpenRequests.TabIndex = 13;
            this.lblOpenRequests.Text = "Vrijwilliger - Afspraak aanmaken";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dtpAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointment.Location = new System.Drawing.Point(242, 119);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(251, 20);
            this.dtpAppointment.TabIndex = 19;
            // 
            // FormAppointmentVolunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 200);
            this.Controls.Add(this.dtpAppointment);
            this.Controls.Add(this.btMakeAppointment);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.tbCareRecipientName);
            this.Controls.Add(this.lbNameCR);
            this.Controls.Add(this.lblOpenRequests);
            this.Name = "FormAppointmentVolunteer";
            this.Text = "FormAppointmentVolunteer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMakeAppointment;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox tbCareRecipientName;
        private System.Windows.Forms.Label lbNameCR;
        private System.Windows.Forms.Label lblOpenRequests;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
    }
}