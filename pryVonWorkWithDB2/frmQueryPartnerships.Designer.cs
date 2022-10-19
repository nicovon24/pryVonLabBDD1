namespace pryVonWorkWithDB2
{
    partial class frmQueryPartnerships
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
            this.grdPartenerships = new System.Windows.Forms.DataGridView();
            this.colNroSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaInscrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartenerships)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(460, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 37);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grdPartenerships
            // 
            this.grdPartenerships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPartenerships.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroSocio,
            this.colNombre,
            this.colDireccion,
            this.colTelefono,
            this.colFechaInscrip});
            this.grdPartenerships.Location = new System.Drawing.Point(24, 22);
            this.grdPartenerships.Name = "grdPartenerships";
            this.grdPartenerships.Size = new System.Drawing.Size(539, 347);
            this.grdPartenerships.TabIndex = 3;
            this.grdPartenerships.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPartenerships_CellContentClick);
            // 
            // colNroSocio
            // 
            this.colNroSocio.HeaderText = "Nro Socio";
            this.colNroSocio.Name = "colNroSocio";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colDireccion
            // 
            this.colDireccion.HeaderText = "Direccion";
            this.colDireccion.Name = "colDireccion";
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            // 
            // colFechaInscrip
            // 
            this.colFechaInscrip.HeaderText = "Fecha Inscripcion";
            this.colFechaInscrip.Name = "colFechaInscrip";
            // 
            // frmQueryPartnerships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.grdPartenerships);
            this.Controls.Add(this.btnBack);
            this.Name = "frmQueryPartnerships";
            this.Text = "Query Partnerships formulare";
            this.Load += new System.EventHandler(this.frmQueryPartnerships_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPartenerships)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdPartenerships;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaInscrip;
    }
}