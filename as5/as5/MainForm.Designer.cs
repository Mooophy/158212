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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.papersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollmentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.papersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollemntInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.papersToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.grid = new System.Windows.Forms.DataGridView();
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
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.papersToolStripMenuItem,
            this.enrollmentInfoToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // papersToolStripMenuItem
            // 
            this.papersToolStripMenuItem.Name = "papersToolStripMenuItem";
            this.papersToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.papersToolStripMenuItem.Text = "Papers";
            // 
            // enrollmentInfoToolStripMenuItem
            // 
            this.enrollmentInfoToolStripMenuItem.Name = "enrollmentInfoToolStripMenuItem";
            this.enrollmentInfoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.enrollmentInfoToolStripMenuItem.Text = "Enrollment Info";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem1,
            this.papersToolStripMenuItem1,
            this.enrollemntInfoToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // studentsToolStripMenuItem1
            // 
            this.studentsToolStripMenuItem1.Name = "studentsToolStripMenuItem1";
            this.studentsToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.studentsToolStripMenuItem1.Text = "Students";
            // 
            // papersToolStripMenuItem1
            // 
            this.papersToolStripMenuItem1.Name = "papersToolStripMenuItem1";
            this.papersToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.papersToolStripMenuItem1.Text = "Papers";
            // 
            // enrollemntInfoToolStripMenuItem
            // 
            this.enrollemntInfoToolStripMenuItem.Name = "enrollemntInfoToolStripMenuItem";
            this.enrollemntInfoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.enrollemntInfoToolStripMenuItem.Text = "Enrollemnt Info";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem2,
            this.papersToolStripMenuItem2});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // studentsToolStripMenuItem2
            // 
            this.studentsToolStripMenuItem2.Name = "studentsToolStripMenuItem2";
            this.studentsToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.studentsToolStripMenuItem2.Text = "Students";
            // 
            // papersToolStripMenuItem2
            // 
            this.papersToolStripMenuItem2.Name = "papersToolStripMenuItem2";
            this.papersToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.papersToolStripMenuItem2.Text = "Papers";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 25);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 23;
            this.grid.Size = new System.Drawing.Size(879, 308);
            this.grid.TabIndex = 1;
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
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem papersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollmentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem papersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enrollemntInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem papersToolStripMenuItem2;
        private System.Windows.Forms.DataGridView grid;


    }
}

