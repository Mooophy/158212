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
            this._StudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._PapersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._EnrollmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._GridLeft = new System.Windows.Forms.DataGridView();
            this._GridRight = new System.Windows.Forms.DataGridView();
            this._ContextMenuStrip.SuspendLayout();
            this._TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._GridLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GridRight)).BeginInit();
            this.SuspendLayout();
            // 
            // _ContextMenuStrip
            // 
            this._ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ImportToolStripMenuItem,
            this.exportToolStripMenuItem,
            this._DetailToolStripMenuItem,
            this._EnrollToolStripMenuItem});
            this._ContextMenuStrip.Name = "_ContextMenuStrip";
            this._ContextMenuStrip.Size = new System.Drawing.Size(117, 92);
            // 
            // _DetailToolStripMenuItem
            // 
            this._DetailToolStripMenuItem.Name = "_DetailToolStripMenuItem";
            this._DetailToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this._DetailToolStripMenuItem.Text = "Detail";
            // 
            // _EnrollToolStripMenuItem
            // 
            this._EnrollToolStripMenuItem.Name = "_EnrollToolStripMenuItem";
            this._EnrollToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this._EnrollToolStripMenuItem.Text = "Enroll";
            // 
            // _ImportToolStripMenuItem
            // 
            this._ImportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._StudentsToolStripMenuItem,
            this._PapersToolStripMenuItem,
            this._EnrollmentsToolStripMenuItem});
            this._ImportToolStripMenuItem.Name = "_ImportToolStripMenuItem";
            this._ImportToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this._ImportToolStripMenuItem.Text = "Import";
            // 
            // _StudentsToolStripMenuItem
            // 
            this._StudentsToolStripMenuItem.Name = "_StudentsToolStripMenuItem";
            this._StudentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this._StudentsToolStripMenuItem.Text = "Students";
            // 
            // _PapersToolStripMenuItem
            // 
            this._PapersToolStripMenuItem.Name = "_PapersToolStripMenuItem";
            this._PapersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this._PapersToolStripMenuItem.Text = "Papers";
            // 
            // _EnrollmentsToolStripMenuItem
            // 
            this._EnrollmentsToolStripMenuItem.Name = "_EnrollmentsToolStripMenuItem";
            this._EnrollmentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this._EnrollmentsToolStripMenuItem.Text = "Enrollments";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // _TableLayoutPanel
            // 
            this._TableLayoutPanel.ColumnCount = 2;
            this._TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._TableLayoutPanel.Controls.Add(this._GridLeft, 0, 0);
            this._TableLayoutPanel.Controls.Add(this._GridRight, 1, 0);
            this._TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._TableLayoutPanel.Name = "_TableLayoutPanel";
            this._TableLayoutPanel.RowCount = 1;
            this._TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._TableLayoutPanel.Size = new System.Drawing.Size(939, 288);
            this._TableLayoutPanel.TabIndex = 1;
            // 
            // _GridLeft
            // 
            this._GridLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._GridLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GridLeft.Location = new System.Drawing.Point(3, 3);
            this._GridLeft.Name = "_GridLeft";
            this._GridLeft.RowTemplate.Height = 23;
            this._GridLeft.Size = new System.Drawing.Size(463, 282);
            this._GridLeft.TabIndex = 0;
            // 
            // _GridRight
            // 
            this._GridRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._GridRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._GridRight.Location = new System.Drawing.Point(472, 3);
            this._GridRight.Name = "_GridRight";
            this._GridRight.RowTemplate.Height = 23;
            this._GridRight.Size = new System.Drawing.Size(464, 282);
            this._GridRight.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this._GridLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GridRight)).EndInit();
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
        private System.Windows.Forms.DataGridView _GridLeft;
        private System.Windows.Forms.DataGridView _GridRight;
    }
}

