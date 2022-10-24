namespace pryVonWorkWithDB2
{
    partial class frmMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerLendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryLendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryPartnershipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.queryToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(190, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuMain_ItemClicked);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerLibraryToolStripMenuItem});
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.registerToolStripMenuItem.Text = "Register";
            // 
            // registerLibraryToolStripMenuItem
            // 
            this.registerLibraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerBooksToolStripMenuItem,
            this.registerLendsToolStripMenuItem});
            this.registerLibraryToolStripMenuItem.Name = "registerLibraryToolStripMenuItem";
            this.registerLibraryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerLibraryToolStripMenuItem.Text = "Register Library";
            // 
            // registerBooksToolStripMenuItem
            // 
            this.registerBooksToolStripMenuItem.Name = "registerBooksToolStripMenuItem";
            this.registerBooksToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.registerBooksToolStripMenuItem.Text = "register books";
            this.registerBooksToolStripMenuItem.Click += new System.EventHandler(this.registerBooksToolStripMenuItem_Click);
            // 
            // registerLendsToolStripMenuItem
            // 
            this.registerLendsToolStripMenuItem.Name = "registerLendsToolStripMenuItem";
            this.registerLendsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.registerLendsToolStripMenuItem.Text = "register lends";
            this.registerLendsToolStripMenuItem.Click += new System.EventHandler(this.registerLendsToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryLibraryToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.queryToolStripMenuItem.Text = "Query";
            // 
            // queryLibraryToolStripMenuItem
            // 
            this.queryLibraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryBooksToolStripMenuItem,
            this.queryLendsToolStripMenuItem,
            this.queryPartnershipsToolStripMenuItem});
            this.queryLibraryToolStripMenuItem.Name = "queryLibraryToolStripMenuItem";
            this.queryLibraryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.queryLibraryToolStripMenuItem.Text = "Query library";
            this.queryLibraryToolStripMenuItem.Click += new System.EventHandler(this.queryLibraryToolStripMenuItem_Click);
            // 
            // queryBooksToolStripMenuItem
            // 
            this.queryBooksToolStripMenuItem.Name = "queryBooksToolStripMenuItem";
            this.queryBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.queryBooksToolStripMenuItem.Text = "query books";
            this.queryBooksToolStripMenuItem.Click += new System.EventHandler(this.queryBooksToolStripMenuItem_Click);
            // 
            // queryLendsToolStripMenuItem
            // 
            this.queryLendsToolStripMenuItem.Name = "queryLendsToolStripMenuItem";
            this.queryLendsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.queryLendsToolStripMenuItem.Text = "query lends";
            this.queryLendsToolStripMenuItem.Click += new System.EventHandler(this.queryLendsToolStripMenuItem_Click);
            // 
            // queryPartnershipsToolStripMenuItem
            // 
            this.queryPartnershipsToolStripMenuItem.Name = "queryPartnershipsToolStripMenuItem";
            this.queryPartnershipsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.queryPartnershipsToolStripMenuItem.Text = "query partnerships";
            this.queryPartnershipsToolStripMenuItem.Click += new System.EventHandler(this.queryPartnershipsToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 71);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryLendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerLendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryPartnershipsToolStripMenuItem;
    }
}

