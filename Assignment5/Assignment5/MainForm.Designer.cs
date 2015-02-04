namespace Assignment5
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
            this.components = new System.ComponentModel.Container();
            this._ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._DetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._EnrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._PapersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._StudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._EnrollmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._GridPapers = new System.Windows.Forms.DataGridView();
            this._GridStudents = new System.Windows.Forms.DataGridView();
            this._OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._ContextMenuStrip.SuspendLayout();
            this._TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._GridPapers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // _ContextMenuStrip
            // 
            this._ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._DetailToolStripMenuItem,
            this._EnrollToolStripMenuItem,
            this._ImportToolStripMenuItem,
            this.exportToolStripMenuItem});
            this._ContextMenuStrip.Name = "_ContextMenuStrip";
            this._ContextMenuStrip.Size = new System.Drawing.Size(153, 114);
            // 
            // _DetailToolStripMenuItem
            // 
            this._DetailToolStripMenuItem.Name = "_DetailToolStripMenuItem";
            this._DetailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this._DetailToolStripMenuItem.Text = "Detail";
            this._DetailToolStripMenuItem.Click += new System.EventHandler(this._DetailToolStripMenuItemClick);
            // 
            // _EnrollToolStripMenuItem
            // 
            this._EnrollToolStripMenuItem.Name = "_EnrollToolStripMenuItem";
            this._EnrollToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this._EnrollToolStripMenuItem.Text = "Enroll";
            this._EnrollToolStripMenuItem.Click += new System.EventHandler(this._EnrollToolStripMenuItemClick);
            // 
            // _ImportToolStripMenuItem
            // 
            this._ImportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._PapersToolStripMenuItem,
            this._StudentsToolStripMenuItem,
            this._EnrollmentsToolStripMenuItem});
            this._ImportToolStripMenuItem.Name = "_ImportToolStripMenuItem";
            this._ImportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this._ImportToolStripMenuItem.Text = "Import";
            // 
            // _PapersToolStripMenuItem
            // 
            this._PapersToolStripMenuItem.Name = "_PapersToolStripMenuItem";
            this._PapersToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this._PapersToolStripMenuItem.Text = "Papers";
            this._PapersToolStripMenuItem.Click += new System.EventHandler(this._PapersToolStripMenuItemClick);
            // 
            // _StudentsToolStripMenuItem
            // 
            this._StudentsToolStripMenuItem.Name = "_StudentsToolStripMenuItem";
            this._StudentsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this._StudentsToolStripMenuItem.Text = "Students";
            this._StudentsToolStripMenuItem.Click += new System.EventHandler(this._StudentsToolStripMenuItemClick);
            // 
            // _EnrollmentsToolStripMenuItem
            // 
            this._EnrollmentsToolStripMenuItem.Name = "_EnrollmentsToolStripMenuItem";
            this._EnrollmentsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this._EnrollmentsToolStripMenuItem.Text = "Enrollments";
            this._EnrollmentsToolStripMenuItem.Click += new System.EventHandler(this._EnrollmentsToolStripMenuItemClick);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItemClick);
            // 
            // _TableLayoutPanel
            // 
            this._TableLayoutPanel.ColumnCount = 2;
            this._TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._TableLayoutPanel.Controls.Add(this._GridPapers, 0, 0);
            this._TableLayoutPanel.Controls.Add(this._GridStudents, 1, 0);
            this._TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._TableLayoutPanel.Name = "_TableLayoutPanel";
            this._TableLayoutPanel.RowCount = 1;
            this._TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._TableLayoutPanel.Size = new System.Drawing.Size(939, 288);
            this._TableLayoutPanel.TabIndex = 1;
            // 
            // _GridPapers
            // 
            this._GridPapers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._GridPapers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._GridPapers.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GridPapers.Location = new System.Drawing.Point(3, 3);
            this._GridPapers.Name = "_GridPapers";
            this._GridPapers.RowTemplate.Height = 23;
            this._GridPapers.Size = new System.Drawing.Size(463, 282);
            this._GridPapers.TabIndex = 0;
            this._GridPapers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RightClickOnGrid);
            this._GridPapers.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.CheckAndSaveOnRowValidating);
            // 
            // _GridStudents
            // 
            this._GridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._GridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._GridStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GridStudents.Location = new System.Drawing.Point(472, 3);
            this._GridStudents.Name = "_GridStudents";
            this._GridStudents.RowTemplate.Height = 23;
            this._GridStudents.Size = new System.Drawing.Size(464, 282);
            this._GridStudents.TabIndex = 1;
            this._GridStudents.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RightClickOnGrid);
            this._GridStudents.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.CheckAndSaveOnRowValidating);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 288);
            this.Controls.Add(this._TableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Welcome";
            this._ContextMenuStrip.ResumeLayout(false);
            this._TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._GridPapers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GridStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip _ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _DetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _EnrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _ImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _StudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _PapersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _EnrollmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel _TableLayoutPanel;
        private System.Windows.Forms.DataGridView _GridPapers;
        private System.Windows.Forms.DataGridView _GridStudents;
        private System.Windows.Forms.OpenFileDialog _OpenFileDialog;
    }
}

