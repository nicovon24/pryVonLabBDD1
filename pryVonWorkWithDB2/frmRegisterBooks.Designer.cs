namespace pryVonWorkWithDB2
{
    partial class frmRegisterBooks
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumLibro = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.nudNumLibro = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(12, 61);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 99);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblNumLibro
            // 
            this.lblNumLibro.AutoSize = true;
            this.lblNumLibro.Location = new System.Drawing.Point(12, 145);
            this.lblNumLibro.Name = "lblNumLibro";
            this.lblNumLibro.Size = new System.Drawing.Size(70, 13);
            this.lblNumLibro.TabIndex = 3;
            this.lblNumLibro.Text = "Numero Libro";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(100, 19);
            this.txtTitulo.MaxLength = 45;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(198, 20);
            this.txtTitulo.TabIndex = 4;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(100, 58);
            this.txtAutor.MaxLength = 45;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(198, 20);
            this.txtAutor.TabIndex = 5;
            // 
            // nudNumLibro
            // 
            this.nudNumLibro.Location = new System.Drawing.Point(100, 143);
            this.nudNumLibro.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudNumLibro.Name = "nudNumLibro";
            this.nudNumLibro.Size = new System.Drawing.Size(70, 20);
            this.nudNumLibro.TabIndex = 6;
            this.nudNumLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(100, 92);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(198, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 192);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmRegisterBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 241);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.nudNumLibro);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblNumLibro);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmRegisterBooks";
            this.Text = "frmRegisterBooks";
            this.Load += new System.EventHandler(this.frmRegisterBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNumLibro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.NumericUpDown nudNumLibro;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCargar;
    }
}