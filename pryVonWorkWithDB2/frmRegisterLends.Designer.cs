namespace pryVonWorkWithDB2
{
    partial class pryRegisterLends
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.dtpFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRetiro = new System.Windows.Forms.Label();
            this.lblNumLibro = new System.Windows.Forms.Label();
            this.lblNumSocio = new System.Windows.Forms.Label();
            this.nudNumLibro = new System.Windows.Forms.NumericUpDown();
            this.nudNumSocio = new System.Windows.Forms.NumericUpDown();
            this.lblMSJ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumSocio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(240, 261);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(15, 261);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 16;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(123, 71);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(198, 20);
            this.dtpFechaEntrega.TabIndex = 15;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(12, 78);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(77, 13);
            this.lblFechaEntrega.TabIndex = 12;
            this.lblFechaEntrega.Text = "Fecha Entrega";
            // 
            // dtpFechaRetiro
            // 
            this.dtpFechaRetiro.Location = new System.Drawing.Point(123, 121);
            this.dtpFechaRetiro.Name = "dtpFechaRetiro";
            this.dtpFechaRetiro.Size = new System.Drawing.Size(198, 20);
            this.dtpFechaRetiro.TabIndex = 19;
            // 
            // lblFechaRetiro
            // 
            this.lblFechaRetiro.AutoSize = true;
            this.lblFechaRetiro.Location = new System.Drawing.Point(13, 127);
            this.lblFechaRetiro.Name = "lblFechaRetiro";
            this.lblFechaRetiro.Size = new System.Drawing.Size(68, 13);
            this.lblFechaRetiro.TabIndex = 18;
            this.lblFechaRetiro.Text = "Fecha Retiro";
            // 
            // lblNumLibro
            // 
            this.lblNumLibro.AutoSize = true;
            this.lblNumLibro.Location = new System.Drawing.Point(13, 216);
            this.lblNumLibro.Name = "lblNumLibro";
            this.lblNumLibro.Size = new System.Drawing.Size(70, 13);
            this.lblNumLibro.TabIndex = 21;
            this.lblNumLibro.Text = "Numero Libro";
            // 
            // lblNumSocio
            // 
            this.lblNumSocio.AutoSize = true;
            this.lblNumSocio.Location = new System.Drawing.Point(13, 171);
            this.lblNumSocio.Name = "lblNumSocio";
            this.lblNumSocio.Size = new System.Drawing.Size(74, 13);
            this.lblNumSocio.TabIndex = 20;
            this.lblNumSocio.Text = "Numero Socio";
            // 
            // nudNumLibro
            // 
            this.nudNumLibro.Location = new System.Drawing.Point(123, 214);
            this.nudNumLibro.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.nudNumLibro.Name = "nudNumLibro";
            this.nudNumLibro.Size = new System.Drawing.Size(72, 20);
            this.nudNumLibro.TabIndex = 22;
            this.nudNumLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudNumSocio
            // 
            this.nudNumSocio.Location = new System.Drawing.Point(123, 169);
            this.nudNumSocio.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.nudNumSocio.Name = "nudNumSocio";
            this.nudNumSocio.Size = new System.Drawing.Size(72, 20);
            this.nudNumSocio.TabIndex = 23;
            this.nudNumSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMSJ
            // 
            this.lblMSJ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMSJ.Location = new System.Drawing.Point(12, 19);
            this.lblMSJ.Name = "lblMSJ";
            this.lblMSJ.Size = new System.Drawing.Size(308, 30);
            this.lblMSJ.TabIndex = 24;
            this.lblMSJ.Text = "Cabe destacar, que el ID del prestamos la BDD la realiza automáticamente";
            this.lblMSJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pryRegisterLends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 304);
            this.Controls.Add(this.lblMSJ);
            this.Controls.Add(this.nudNumSocio);
            this.Controls.Add(this.nudNumLibro);
            this.Controls.Add(this.lblNumLibro);
            this.Controls.Add(this.lblNumSocio);
            this.Controls.Add(this.dtpFechaRetiro);
            this.Controls.Add(this.lblFechaRetiro);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.lblFechaEntrega);
            this.Name = "pryRegisterLends";
            this.Text = "Register Lends formulare";
            this.Load += new System.EventHandler(this.pryRegisterLends_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumSocio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaRetiro;
        private System.Windows.Forms.Label lblFechaRetiro;
        private System.Windows.Forms.Label lblNumLibro;
        private System.Windows.Forms.Label lblNumSocio;
        private System.Windows.Forms.NumericUpDown nudNumLibro;
        private System.Windows.Forms.NumericUpDown nudNumSocio;
        private System.Windows.Forms.Label lblMSJ;
    }
}