namespace pryVonWorkWithDB2
{
    partial class frmQueryLends
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
            this.grdLends = new System.Windows.Forms.DataGridView();
            this.colFechaRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdLends)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(457, 385);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 37);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grdLends
            // 
            this.grdLends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLends.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFechaRetiro,
            this.colFechaEntrega,
            this.colSocio,
            this.colLibro,
            this.colIDPrestamo});
            this.grdLends.Location = new System.Drawing.Point(21, 12);
            this.grdLends.Name = "grdLends";
            this.grdLends.Size = new System.Drawing.Size(539, 347);
            this.grdLends.TabIndex = 3;
            this.grdLends.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colFechaRetiro
            // 
            this.colFechaRetiro.HeaderText = "Fecha Retiro";
            this.colFechaRetiro.Name = "colFechaRetiro";
            // 
            // colFechaEntrega
            // 
            this.colFechaEntrega.HeaderText = "Fecha Entrega";
            this.colFechaEntrega.Name = "colFechaEntrega";
            // 
            // colSocio
            // 
            this.colSocio.HeaderText = "Socio";
            this.colSocio.Name = "colSocio";
            // 
            // colLibro
            // 
            this.colLibro.HeaderText = "Libro";
            this.colLibro.Name = "colLibro";
            // 
            // colIDPrestamo
            // 
            this.colIDPrestamo.HeaderText = "ID Prestamo";
            this.colIDPrestamo.Name = "colIDPrestamo";
            // 
            // frmQueryLends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.grdLends);
            this.Controls.Add(this.btnBack);
            this.Name = "frmQueryLends";
            this.Text = "Query Lends formulare";
            this.Load += new System.EventHandler(this.frmQueryLends_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLends)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdLends;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaRetiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPrestamo;
    }
}