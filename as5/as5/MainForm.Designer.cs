namespace as5
{
    partial class MainForm
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportPapers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportEnrollment = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportPapers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportEnrollment = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewPapers = new System.Windows.Forms.ToolStripMenuItem();
            this.grid = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(879, 25);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(96, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImportStudents,
            this.menuImportPapers,
            this.menuImportEnrollment});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // menuImportStudents
            // 
            this.menuImportStudents.Name = "menuImportStudents";
            this.menuImportStudents.Size = new System.Drawing.Size(165, 22);
            this.menuImportStudents.Text = "Students";
            this.menuImportStudents.Click += new System.EventHandler(this.menuImportStudents_Click);
            // 
            // menuImportPapers
            // 
            this.menuImportPapers.Name = "menuImportPapers";
            this.menuImportPapers.Size = new System.Drawing.Size(165, 22);
            this.menuImportPapers.Text = "Papers";
            this.menuImportPapers.Click += new System.EventHandler(this.menuImportPapers_Click);
            // 
            // menuImportEnrollment
            // 
            this.menuImportEnrollment.Name = "menuImportEnrollment";
            this.menuImportEnrollment.Size = new System.Drawing.Size(165, 22);
            this.menuImportEnrollment.Text = "Enrollment Info";
            this.menuImportEnrollment.Click += new System.EventHandler(this.menuImportEnrollment_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExportStudents,
            this.menuExportPapers,
            this.menuExportEnrollment});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // menuExportStudents
            // 
            this.menuExportStudents.Name = "menuExportStudents";
            this.menuExportStudents.Size = new System.Drawing.Size(165, 22);
            this.menuExportStudents.Text = "Students";
            // 
            // menuExportPapers
            // 
            this.menuExportPapers.Name = "menuExportPapers";
            this.menuExportPapers.Size = new System.Drawing.Size(165, 22);
            this.menuExportPapers.Text = "Papers";
            // 
            // menuExportEnrollment
            // 
            this.menuExportEnrollment.Name = "menuExportEnrollment";
            this.menuExportEnrollment.Size = new System.Drawing.Size(165, 22);
            this.menuExportEnrollment.Text = "Enrollemnt Info";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewStudents,
            this.menuViewPapers});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // menuViewStudents
            // 
            this.menuViewStudents.Name = "menuViewStudents";
            this.menuViewStudents.Size = new System.Drawing.Size(126, 22);
            this.menuViewStudents.Text = "Students";
            this.menuViewStudents.Click += new System.EventHandler(this.menuViewStudents_Click);
            // 
            // menuViewPapers
            // 
            this.menuViewPapers.Name = "menuViewPapers";
            this.menuViewPapers.Size = new System.Drawing.Size(126, 22);
            this.menuViewPapers.Text = "Papers";
            this.menuViewPapers.Click += new System.EventHandler(this.menuViewPapers_Click);
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 25);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 23;
            this.grid.Size = new System.Drawing.Size(879, 308);
            this.grid.TabIndex = 1;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCell_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 333);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Enrollment System";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuImportStudents;
        private System.Windows.Forms.ToolStripMenuItem menuImportPapers;
        private System.Windows.Forms.ToolStripMenuItem menuImportEnrollment;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExportStudents;
        private System.Windows.Forms.ToolStripMenuItem menuExportPapers;
        private System.Windows.Forms.ToolStripMenuItem menuExportEnrollment;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuViewStudents;
        private System.Windows.Forms.ToolStripMenuItem menuViewPapers;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.OpenFileDialog openFileDialog;


    }
}

