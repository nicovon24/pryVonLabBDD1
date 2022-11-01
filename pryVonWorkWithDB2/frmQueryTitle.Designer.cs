namespace pryVonWorkWithDB2
{
    partial class frmQueryTitle
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.lblAuthorRes = new System.Windows.Forms.Label();
            this.lblDateRes = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(18, 45);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.lblDateRes);
            this.gbData.Controls.Add(this.lblDate);
            this.gbData.Controls.Add(this.lblAuthorRes);
            this.gbData.Controls.Add(this.lblAuthor);
            this.gbData.Location = new System.Drawing.Point(15, 71);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(240, 191);
            this.gbData.TabIndex = 2;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data of the book";
            // 
            // lblAuthorRes
            // 
            this.lblAuthorRes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAuthorRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAuthorRes.Location = new System.Drawing.Point(94, 32);
            this.lblAuthorRes.Name = "lblAuthorRes";
            this.lblAuthorRes.Size = new System.Drawing.Size(140, 43);
            this.lblAuthorRes.TabIndex = 4;
            // 
            // lblDateRes
            // 
            this.lblDateRes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDateRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateRes.Location = new System.Drawing.Point(94, 104);
            this.lblDateRes.Name = "lblDateRes";
            this.lblDateRes.Size = new System.Drawing.Size(140, 35);
            this.lblDateRes.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(18, 116);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Edited data";
            // 
            // cbTitle
            // 
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(109, 31);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(140, 21);
            this.cbTitle.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 281);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(180, 281);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 30);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show data";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmQueryTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 333);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbTitle);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmQueryTitle";
            this.Text = "frmQueryTitle";
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label lblDateRes;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAuthorRes;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShow;
    }
}