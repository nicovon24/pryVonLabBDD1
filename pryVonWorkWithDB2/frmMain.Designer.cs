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
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lendsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.partnersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.commandsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(268, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuMain_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryToolStripMenuItem1,
            this.registerToolStripMenuItem1,
            this.removeToolStripMenuItem1,
            this.updateToolStripMenuItem1});
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // queryToolStripMenuItem1
            // 
            this.queryToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.lendsToolStripMenuItem,
            this.partnersToolStripMenuItem});
            this.queryToolStripMenuItem1.Name = "queryToolStripMenuItem1";
            this.queryToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.queryToolStripMenuItem1.Text = "Query";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // lendsToolStripMenuItem
            // 
            this.lendsToolStripMenuItem.Name = "lendsToolStripMenuItem";
            this.lendsToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.lendsToolStripMenuItem.Text = "Lends";
            this.lendsToolStripMenuItem.Click += new System.EventHandler(this.lendsToolStripMenuItem_Click);
            // 
            // partnersToolStripMenuItem
            // 
            this.partnersToolStripMenuItem.Name = "partnersToolStripMenuItem";
            this.partnersToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.partnersToolStripMenuItem.Text = "Partners";
            this.partnersToolStripMenuItem.Click += new System.EventHandler(this.partnersToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem1
            // 
            this.registerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem3,
            this.lendsToolStripMenuItem1,
            this.partnersToolStripMenuItem1});
            this.registerToolStripMenuItem1.Name = "registerToolStripMenuItem1";
            this.registerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.registerToolStripMenuItem1.Text = "Register";
            // 
            // booksToolStripMenuItem3
            // 
            this.booksToolStripMenuItem3.Name = "booksToolStripMenuItem3";
            this.booksToolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.booksToolStripMenuItem3.Text = "Books";
            this.booksToolStripMenuItem3.Click += new System.EventHandler(this.booksToolStripMenuItem3_Click);
            // 
            // lendsToolStripMenuItem1
            // 
            this.lendsToolStripMenuItem1.Name = "lendsToolStripMenuItem1";
            this.lendsToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.lendsToolStripMenuItem1.Text = "Lends";
            this.lendsToolStripMenuItem1.Click += new System.EventHandler(this.lendsToolStripMenuItem1_Click);
            // 
            // partnersToolStripMenuItem1
            // 
            this.partnersToolStripMenuItem1.Name = "partnersToolStripMenuItem1";
            this.partnersToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.partnersToolStripMenuItem1.Text = "Partners";
            this.partnersToolStripMenuItem1.Click += new System.EventHandler(this.partnersToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem1});
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            // 
            // booksToolStripMenuItem1
            // 
            this.booksToolStripMenuItem1.Name = "booksToolStripMenuItem1";
            this.booksToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.booksToolStripMenuItem1.Text = "Books";
            this.booksToolStripMenuItem1.Click += new System.EventHandler(this.booksToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem2});
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
            // 
            // booksToolStripMenuItem2
            // 
            this.booksToolStripMenuItem2.Name = "booksToolStripMenuItem2";
            this.booksToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.booksToolStripMenuItem2.Text = "Books";
            this.booksToolStripMenuItem2.Click += new System.EventHandler(this.booksToolStripMenuItem2_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 144);
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
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem lendsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem partnersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

