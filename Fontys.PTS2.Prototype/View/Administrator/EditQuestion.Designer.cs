namespace Fontys.PTS2.Prototype.View
{
    partial class EditQuestion
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
            this.lblSubjectOld = new System.Windows.Forms.Label();
            this.lblContentOld = new System.Windows.Forms.Label();
            this.lblCategoryOld = new System.Windows.Forms.Label();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.tbSubjectOld = new System.Windows.Forms.TextBox();
            this.tbContentOld = new System.Windows.Forms.TextBox();
            this.tbCategoryOld = new System.Windows.Forms.TextBox();
            this.lblSubjectNew = new System.Windows.Forms.Label();
            this.lblContentNew = new System.Windows.Forms.Label();
            this.lblCategoryNew = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.tbContentNew = new System.Windows.Forms.TextBox();
            this.tbSubjectNew = new System.Windows.Forms.TextBox();
            this.cbUrgent = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSubjectOld
            // 
            this.lblSubjectOld.AutoSize = true;
            this.lblSubjectOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectOld.Location = new System.Drawing.Point(15, 11);
            this.lblSubjectOld.Name = "lblSubjectOld";
            this.lblSubjectOld.Size = new System.Drawing.Size(185, 29);
            this.lblSubjectOld.TabIndex = 2;
            this.lblSubjectOld.Text = "Oud onderwerp";
            // 
            // lblContentOld
            // 
            this.lblContentOld.AutoSize = true;
            this.lblContentOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentOld.Location = new System.Drawing.Point(15, 54);
            this.lblContentOld.Name = "lblContentOld";
            this.lblContentOld.Size = new System.Drawing.Size(216, 29);
            this.lblContentOld.TabIndex = 3;
            this.lblContentOld.Text = "Oude beschrijving";
            // 
            // lblCategoryOld
            // 
            this.lblCategoryOld.AutoSize = true;
            this.lblCategoryOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryOld.Location = new System.Drawing.Point(15, 142);
            this.lblCategoryOld.Name = "lblCategoryOld";
            this.lblCategoryOld.Size = new System.Drawing.Size(185, 29);
            this.lblCategoryOld.TabIndex = 4;
            this.lblCategoryOld.Text = "Oude categorie";
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveQuestion.Location = new System.Drawing.Point(856, 494);
            this.btnSaveQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(195, 46);
            this.btnSaveQuestion.TabIndex = 5;
            this.btnSaveQuestion.Text = "Opslaan";
            this.btnSaveQuestion.UseVisualStyleBackColor = false;
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);
            // 
            // tbSubjectOld
            // 
            this.tbSubjectOld.Enabled = false;
            this.tbSubjectOld.Location = new System.Drawing.Point(261, 17);
            this.tbSubjectOld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSubjectOld.Name = "tbSubjectOld";
            this.tbSubjectOld.Size = new System.Drawing.Size(711, 22);
            this.tbSubjectOld.TabIndex = 6;
            // 
            // tbContentOld
            // 
            this.tbContentOld.Enabled = false;
            this.tbContentOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContentOld.Location = new System.Drawing.Point(261, 59);
            this.tbContentOld.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContentOld.Multiline = true;
            this.tbContentOld.Name = "tbContentOld";
            this.tbContentOld.Size = new System.Drawing.Size(711, 75);
            this.tbContentOld.TabIndex = 7;
            // 
            // tbCategoryOld
            // 
            this.tbCategoryOld.Enabled = false;
            this.tbCategoryOld.Location = new System.Drawing.Point(261, 148);
            this.tbCategoryOld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCategoryOld.Name = "tbCategoryOld";
            this.tbCategoryOld.Size = new System.Drawing.Size(711, 22);
            this.tbCategoryOld.TabIndex = 8;
            // 
            // lblSubjectNew
            // 
            this.lblSubjectNew.AutoSize = true;
            this.lblSubjectNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectNew.Location = new System.Drawing.Point(15, 250);
            this.lblSubjectNew.Name = "lblSubjectNew";
            this.lblSubjectNew.Size = new System.Drawing.Size(208, 29);
            this.lblSubjectNew.TabIndex = 9;
            this.lblSubjectNew.Text = "Nieuw onderwerp";
            // 
            // lblContentNew
            // 
            this.lblContentNew.AutoSize = true;
            this.lblContentNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentNew.Location = new System.Drawing.Point(15, 292);
            this.lblContentNew.Name = "lblContentNew";
            this.lblContentNew.Size = new System.Drawing.Size(225, 29);
            this.lblContentNew.TabIndex = 10;
            this.lblContentNew.Text = "Nieuw beschrijving";
            // 
            // lblCategoryNew
            // 
            this.lblCategoryNew.AutoSize = true;
            this.lblCategoryNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryNew.Location = new System.Drawing.Point(15, 379);
            this.lblCategoryNew.Name = "lblCategoryNew";
            this.lblCategoryNew.Size = new System.Drawing.Size(194, 29);
            this.lblCategoryNew.TabIndex = 11;
            this.lblCategoryNew.Text = "Nieuw categorie";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(261, 386);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(711, 24);
            this.cmbCategory.TabIndex = 12;
            // 
            // tbContentNew
            // 
            this.tbContentNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContentNew.Location = new System.Drawing.Point(261, 299);
            this.tbContentNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContentNew.Multiline = true;
            this.tbContentNew.Name = "tbContentNew";
            this.tbContentNew.Size = new System.Drawing.Size(711, 75);
            this.tbContentNew.TabIndex = 14;
            // 
            // tbSubjectNew
            // 
            this.tbSubjectNew.Location = new System.Drawing.Point(261, 257);
            this.tbSubjectNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSubjectNew.Name = "tbSubjectNew";
            this.tbSubjectNew.Size = new System.Drawing.Size(711, 22);
            this.tbSubjectNew.TabIndex = 13;
            // 
            // cbUrgent
            // 
            this.cbUrgent.AutoSize = true;
            this.cbUrgent.Location = new System.Drawing.Point(261, 420);
            this.cbUrgent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUrgent.Name = "cbUrgent";
            this.cbUrgent.Size = new System.Drawing.Size(73, 21);
            this.cbUrgent.TabIndex = 15;
            this.cbUrgent.Text = "Urgent";
            this.cbUrgent.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(691, 494);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 46);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbUrgent);
            this.Controls.Add(this.tbContentNew);
            this.Controls.Add(this.tbSubjectNew);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategoryNew);
            this.Controls.Add(this.lblContentNew);
            this.Controls.Add(this.lblSubjectNew);
            this.Controls.Add(this.tbCategoryOld);
            this.Controls.Add(this.tbContentOld);
            this.Controls.Add(this.tbSubjectOld);
            this.Controls.Add(this.btnSaveQuestion);
            this.Controls.Add(this.lblCategoryOld);
            this.Controls.Add(this.lblContentOld);
            this.Controls.Add(this.lblSubjectOld);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditQuestion";
            this.Text = "EditQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubjectOld;
        private System.Windows.Forms.Label lblContentOld;
        private System.Windows.Forms.Label lblCategoryOld;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.TextBox tbSubjectOld;
        private System.Windows.Forms.TextBox tbContentOld;
        private System.Windows.Forms.TextBox tbCategoryOld;
        private System.Windows.Forms.Label lblSubjectNew;
        private System.Windows.Forms.Label lblContentNew;
        private System.Windows.Forms.Label lblCategoryNew;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox tbContentNew;
        private System.Windows.Forms.TextBox tbSubjectNew;
        private System.Windows.Forms.CheckBox cbUrgent;
        private System.Windows.Forms.Button btnCancel;
    }
}