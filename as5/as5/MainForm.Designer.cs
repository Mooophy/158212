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
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportPapers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportEnrollment = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportPapers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportEnrollment = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tab = new System.Windows.Forms.TabControl();
            this.pageStudents = new System.Windows.Forms.TabPage();
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.pagePapers = new System.Windows.Forms.TabPage();
            this.gridPapers = new System.Windows.Forms.DataGridView();
            this.menu.SuspendLayout();
            this.tab.SuspendLayout();
            this.pageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            this.pagePapers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPapers)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(879, 25);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEdit,
            this.menuSave,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuEdit
            // 
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(103, 22);
            this.menuEdit.Text = "Edit";
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(103, 22);
            this.menuSave.Text = "Save";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(103, 22);
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
            // tab
            // 
            this.tab.Controls.Add(this.pageStudents);
            this.tab.Controls.Add(this.pagePapers);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 25);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(879, 308);
            this.tab.TabIndex = 1;
            // 
            // pageStudents
            // 
            this.pageStudents.Controls.Add(this.gridStudents);
            this.pageStudents.Location = new System.Drawing.Point(4, 22);
            this.pageStudents.Name = "pageStudents";
            this.pageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.pageStudents.Size = new System.Drawing.Size(871, 282);
            this.pageStudents.TabIndex = 0;
            this.pageStudents.Text = "Students";
            this.pageStudents.UseVisualStyleBackColor = true;
            // 
            // gridStudents
            // 
            this.gridStudents.AllowUserToDeleteRows = false;
            this.gridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.gridStudents.Location = new System.Drawing.Point(3, 3);
            this.gridStudents.MultiSelect = false;
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.RowTemplate.Height = 23;
            this.gridStudents.Size = new System.Drawing.Size(865, 276);
            this.gridStudents.TabIndex = 0;
            this.gridStudents.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gridStudentsOnRowValidating);
            this.gridStudents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridStudentsOnControlWPressed);
            // 
            // pagePapers
            // 
            this.pagePapers.Controls.Add(this.gridPapers);
            this.pagePapers.Location = new System.Drawing.Point(4, 22);
            this.pagePapers.Name = "pagePapers";
            this.pagePapers.Padding = new System.Windows.Forms.Padding(3);
            this.pagePapers.Size = new System.Drawing.Size(871, 282);
            this.pagePapers.TabIndex = 1;
            this.pagePapers.Text = "Papers";
            this.pagePapers.UseVisualStyleBackColor = true;
            // 
            // gridPapers
            // 
            this.gridPapers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPapers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPapers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPapers.Location = new System.Drawing.Point(3, 3);
            this.gridPapers.Name = "gridPapers";
            this.gridPapers.RowTemplate.Height = 23;
            this.gridPapers.Size = new System.Drawing.Size(865, 276);
            this.gridPapers.TabIndex = 0;
            this.gridPapers.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gridPapersOnRowValidating);
            this.gridPapers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridPapersOnControlWPressed);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 333);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Enrollment System";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tab.ResumeLayout(false);
            this.pageStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            this.pagePapers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPapers)).EndInit();
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
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage pageStudents;
        private System.Windows.Forms.TabPage pagePapers;
        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.DataGridView gridPapers;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;


    }
}

