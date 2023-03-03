namespace PizzaTowerBankEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.bankTreeView = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unloadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractBankAsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFolderAsBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportSelectedChunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importChunkAsSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportAsVixenEngineSoundDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.blockContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(713, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bankTreeView
            // 
            this.bankTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bankTreeView.Location = new System.Drawing.Point(12, 27);
            this.bankTreeView.Name = "bankTreeView";
            this.bankTreeView.Size = new System.Drawing.Size(535, 411);
            this.bankTreeView.TabIndex = 1;
            this.bankTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.bankTreeView_NodeMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.unloadFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "Open File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // unloadFileToolStripMenuItem
            // 
            this.unloadFileToolStripMenuItem.Name = "unloadFileToolStripMenuItem";
            this.unloadFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unloadFileToolStripMenuItem.Text = "Unload File";
            this.unloadFileToolStripMenuItem.Click += new System.EventHandler(this.unloadFileToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractBankAsFolderToolStripMenuItem,
            this.importFolderAsBankToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportSelectedChunkToolStripMenuItem,
            this.importChunkAsSelectedToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportAsVixenEngineSoundDirectoriesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // extractBankAsFolderToolStripMenuItem
            // 
            this.extractBankAsFolderToolStripMenuItem.Name = "extractBankAsFolderToolStripMenuItem";
            this.extractBankAsFolderToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.extractBankAsFolderToolStripMenuItem.Text = "Extract Bank as Folder";
            this.extractBankAsFolderToolStripMenuItem.Click += new System.EventHandler(this.extractBankAsFolderToolStripMenuItem_Click);
            // 
            // importFolderAsBankToolStripMenuItem
            // 
            this.importFolderAsBankToolStripMenuItem.Name = "importFolderAsBankToolStripMenuItem";
            this.importFolderAsBankToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.importFolderAsBankToolStripMenuItem.Text = "Import Folder as Bank";
            this.importFolderAsBankToolStripMenuItem.Click += new System.EventHandler(this.importFolderAsBankToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(286, 6);
            // 
            // exportSelectedChunkToolStripMenuItem
            // 
            this.exportSelectedChunkToolStripMenuItem.Name = "exportSelectedChunkToolStripMenuItem";
            this.exportSelectedChunkToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.exportSelectedChunkToolStripMenuItem.Text = "Export Selected Chunk";
            this.exportSelectedChunkToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedChunkToolStripMenuItem_Click);
            // 
            // importChunkAsSelectedToolStripMenuItem
            // 
            this.importChunkAsSelectedToolStripMenuItem.Name = "importChunkAsSelectedToolStripMenuItem";
            this.importChunkAsSelectedToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.importChunkAsSelectedToolStripMenuItem.Text = "Import Chunk as Selected";
            this.importChunkAsSelectedToolStripMenuItem.Click += new System.EventHandler(this.importChunkAsSelectedToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(286, 6);
            // 
            // exportAsVixenEngineSoundDirectoriesToolStripMenuItem
            // 
            this.exportAsVixenEngineSoundDirectoriesToolStripMenuItem.Name = "exportAsVixenEngineSoundDirectoriesToolStripMenuItem";
            this.exportAsVixenEngineSoundDirectoriesToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.exportAsVixenEngineSoundDirectoriesToolStripMenuItem.Text = "Export as Vixen Engine Sound Directories";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // blockContextMenuStrip
            // 
            this.blockContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.blockContextMenuStrip.Name = "blockContextMenuStrip";
            this.blockContextMenuStrip.Size = new System.Drawing.Size(111, 48);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bankTreeView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Pizza Tower Bank Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.blockContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TreeView bankTreeView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem unloadFileToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem extractBankAsFolderToolStripMenuItem;
        private ToolStripMenuItem importFolderAsBankToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exportSelectedChunkToolStripMenuItem;
        private ToolStripMenuItem importChunkAsSelectedToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exportAsVixenEngineSoundDirectoriesToolStripMenuItem;
        private ContextMenuStrip blockContextMenuStrip;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
    }
}