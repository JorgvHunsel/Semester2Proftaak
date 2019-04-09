namespace Fontys.PTS2.Prototype
{
    partial class FormCareAskQuestion
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
            this.lblAddRequest = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.cbUrgent = new System.Windows.Forms.CheckBox();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddRequest
            // 
            this.lblAddRequest.AutoSize = true;
            this.lblAddRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRequest.Location = new System.Drawing.Point(43, 42);
            this.lblAddRequest.Name = "lblAddRequest";
            this.lblAddRequest.Size = new System.Drawing.Size(317, 58);
            this.lblAddRequest.TabIndex = 0;
            this.lblAddRequest.Text = "Vraag stellen";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(48, 148);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(136, 29);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Onderwerp";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(47, 201);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(151, 29);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Beschrijving";
            // 
            // tbSubject
            // 
            this.tbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubject.Location = new System.Drawing.Point(236, 148);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(711, 36);
            this.tbSubject.TabIndex = 3;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(236, 201);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(711, 75);
            this.tbDescription.TabIndex = 4;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(417, 472);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(315, 69);
            this.btnRequest.TabIndex = 5;
            this.btnRequest.Text = "Aanvragen";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // cbUrgent
            // 
            this.cbUrgent.AutoSize = true;
            this.cbUrgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUrgent.Location = new System.Drawing.Point(236, 335);
            this.cbUrgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUrgent.Name = "cbUrgent";
            this.cbUrgent.Size = new System.Drawing.Size(137, 33);
            this.cbUrgent.TabIndex = 7;
            this.cbUrgent.Text = "Dringend";
            this.cbUrgent.UseVisualStyleBackColor = true;
            // 
            // cboxCategory
            // 
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Location = new System.Drawing.Point(236, 284);
            this.cboxCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(160, 24);
            this.cboxCategory.TabIndex = 8;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(48, 279);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(122, 29);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Categorie";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(739, 472);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(315, 69);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnQuestionOverview_Click);
            // 
            // FormCareAskQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboxCategory);
            this.Controls.Add(this.cbUrgent);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblAddRequest);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCareAskQuestion";
            this.Text = "Hulpvraag aanmaken";
            this.Load += new System.EventHandler(this.FormCareAskQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddRequest;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.CheckBox cbUrgent;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnBack;
    }
}

