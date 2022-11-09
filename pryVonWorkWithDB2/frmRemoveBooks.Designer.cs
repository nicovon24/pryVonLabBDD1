namespace pryVonWorkWithDB2
{
    partial class frmRemoveBooks
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblMSG = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.bntEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(113, 85);
            this.txtNumber.MaxLength = 8;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(133, 20);
            this.txtNumber.TabIndex = 69;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblMSG
            // 
            this.lblMSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMSG.Location = new System.Drawing.Point(24, 18);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(222, 42);
            this.lblMSG.TabIndex = 68;
            this.lblMSG.Text = "Type the CP or number of the book, example 1,2,4";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(183, 137);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 31);
            this.btnVolver.TabIndex = 66;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNum
            // 
            this.lblNum.Location = new System.Drawing.Point(21, 88);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(86, 19);
            this.lblNum.TabIndex = 67;
            this.lblNum.Text = "N° of the book";
            // 
            // bntEliminar
            // 
            this.bntEliminar.Location = new System.Drawing.Point(24, 137);
            this.bntEliminar.Name = "bntEliminar";
            this.bntEliminar.Size = new System.Drawing.Size(65, 32);
            this.bntEliminar.TabIndex = 65;
            this.bntEliminar.Text = "Eliminar";
            this.bntEliminar.UseVisualStyleBackColor = true;
            this.bntEliminar.Click += new System.EventHandler(this.bntEliminar_Click);
            // 
            // frmRemoveBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.bntEliminar);
            this.Name = "frmRemoveBooks";
            this.Text = "frmRemoveBooks";
            this.Load += new System.EventHandler(this.frmRemoveBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button bntEliminar;
    }
}