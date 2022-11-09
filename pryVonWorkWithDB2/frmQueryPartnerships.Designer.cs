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
            this.grdPartners = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartners)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPartners
            // 
            this.grdPartners.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPartners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colFecha,
            this.colNroLibro,
            this.colFInscripcion,
            this.colNSocio});
            this.grdPartners.Location = new System.Drawing.Point(12, 12);
            this.grdPartners.Name = "grdPartners";
            this.grdPartners.Size = new System.Drawing.Size(539, 347);
            this.grdPartners.TabIndex = 4;
            this.grdPartners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPartners_CellContentClick);
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Direccion";
            this.colFecha.Name = "colFecha";
            // 
            // colNroLibro
            // 
            this.colNroLibro.HeaderText = "Telefono";
            this.colNroLibro.Name = "colNroLibro";
            // 
            // colFInscripcion
            // 
            this.colFInscripcion.HeaderText = "Fecha inscripcion";
            this.colFInscripcion.Name = "colFInscripcion";
            // 
            // colNSocio
            // 
            this.colNSocio.HeaderText = "Nº SOCIO";
            this.colNSocio.Name = "colNSocio";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(448, 391);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 37);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmQueryPartnerships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.grdPartners);
            this.Controls.Add(this.btnBack);
            this.Name = "frmQueryPartnerships";
            this.Text = "Query Partnerships formulare";
            this.Load += new System.EventHandler(this.frmQueryPartnerships_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPartners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPartners;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNSocio;
    }
}