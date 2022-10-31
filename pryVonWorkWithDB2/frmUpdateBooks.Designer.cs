namespace pryVonWorkWithDB2
{
    partial class frmUpdateBooks
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(111, 90);
            this.txtNumber.MaxLength = 8;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(133, 20);
            this.txtNumber.TabIndex = 74;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // lblMSG
            // 
            this.lblMSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMSG.Location = new System.Drawing.Point(22, 23);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(222, 42);
            this.lblMSG.TabIndex = 73;
            this.lblMSG.Text = "Type the CP or number of the book, example 3, 4, 24, 25, 26 or 27";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(22, 200);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 31);
            this.btnVolver.TabIndex = 71;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNum
            // 
            this.lblNum.Location = new System.Drawing.Point(19, 93);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(86, 19);
            this.lblNum.TabIndex = 72;
            this.lblNum.Text = "N° of the book";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(179, 199);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(65, 32);
            this.btnActualizar.TabIndex = 70;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.bntActualizar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(111, 149);
            this.txtTitulo.MaxLength = 30;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(133, 20);
            this.txtTitulo.TabIndex = 76;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(19, 152);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(86, 19);
            this.lblTitulo.TabIndex = 75;
            this.lblTitulo.Text = "Nuevo título";
            // 
            // frmUpdateBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 257);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnActualizar);
            this.Name = "frmUpdateBooks";
            this.Text = "Update Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}