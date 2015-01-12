namespace TextAnalysis
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnMostCommon = new System.Windows.Forms.Button();
            this.btnLongest = new System.Windows.Forms.Button();
            this.btnShortest = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnByLength = new System.Windows.Forms.Button();
            this.boxForLength = new System.Windows.Forms.GroupBox();
            this.boxForWord = new System.Windows.Forms.GroupBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnByWord = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.boxForLength.SuspendLayout();
            this.boxForWord.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(820, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "test.txt";
            this.openFileDialog.Filter = "\"txt files (*.txt)|*.txt\"";
            this.openFileDialog.FilterIndex = 2;
            this.openFileDialog.InitialDirectory = "d:\\";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // btnMostCommon
            // 
            this.btnMostCommon.Location = new System.Drawing.Point(99, 331);
            this.btnMostCommon.Name = "btnMostCommon";
            this.btnMostCommon.Size = new System.Drawing.Size(106, 23);
            this.btnMostCommon.TabIndex = 1;
            this.btnMostCommon.Text = "Most Common";
            this.btnMostCommon.UseVisualStyleBackColor = true;
            this.btnMostCommon.Click += new System.EventHandler(this.btnMostCommon_Click);
            // 
            // btnLongest
            // 
            this.btnLongest.Location = new System.Drawing.Point(256, 331);
            this.btnLongest.Name = "btnLongest";
            this.btnLongest.Size = new System.Drawing.Size(106, 23);
            this.btnLongest.TabIndex = 2;
            this.btnLongest.Text = "Longest";
            this.btnLongest.UseVisualStyleBackColor = true;
            this.btnLongest.Click += new System.EventHandler(this.btnLongest_Click);
            // 
            // btnShortest
            // 
            this.btnShortest.Location = new System.Drawing.Point(416, 331);
            this.btnShortest.Name = "btnShortest";
            this.btnShortest.Size = new System.Drawing.Size(106, 23);
            this.btnShortest.TabIndex = 3;
            this.btnShortest.Text = "Shortest";
            this.btnShortest.UseVisualStyleBackColor = true;
            this.btnShortest.Click += new System.EventHandler(this.btnShortest_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(577, 331);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(106, 23);
            this.btnAverage.TabIndex = 4;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // display
            // 
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.Location = new System.Drawing.Point(99, 140);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.display.Size = new System.Drawing.Size(584, 171);
            this.display.TabIndex = 5;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(22, 20);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(214, 21);
            this.txtLength.TabIndex = 6;
            // 
            // btnByLength
            // 
            this.btnByLength.Location = new System.Drawing.Point(22, 60);
            this.btnByLength.Name = "btnByLength";
            this.btnByLength.Size = new System.Drawing.Size(214, 23);
            this.btnByLength.TabIndex = 11;
            this.btnByLength.Text = "Enter";
            this.btnByLength.UseVisualStyleBackColor = true;
            this.btnByLength.Click += new System.EventHandler(this.btnByLength_Click);
            // 
            // boxForLength
            // 
            this.boxForLength.Controls.Add(this.txtLength);
            this.boxForLength.Controls.Add(this.btnByLength);
            this.boxForLength.Location = new System.Drawing.Point(99, 28);
            this.boxForLength.Name = "boxForLength";
            this.boxForLength.Size = new System.Drawing.Size(263, 100);
            this.boxForLength.TabIndex = 12;
            this.boxForLength.TabStop = false;
            this.boxForLength.Text = "Look up by length";
            // 
            // boxForWord
            // 
            this.boxForWord.Controls.Add(this.txtWord);
            this.boxForWord.Controls.Add(this.btnByWord);
            this.boxForWord.Location = new System.Drawing.Point(420, 28);
            this.boxForWord.Name = "boxForWord";
            this.boxForWord.Size = new System.Drawing.Size(263, 100);
            this.boxForWord.TabIndex = 13;
            this.boxForWord.TabStop = false;
            this.boxForWord.Text = "Look up by word";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(22, 20);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(214, 21);
            this.txtWord.TabIndex = 6;
            // 
            // btnByWord
            // 
            this.btnByWord.Location = new System.Drawing.Point(22, 60);
            this.btnByWord.Name = "btnByWord";
            this.btnByWord.Size = new System.Drawing.Size(214, 23);
            this.btnByWord.TabIndex = 11;
            this.btnByWord.Text = "Enter";
            this.btnByWord.UseVisualStyleBackColor = true;
            this.btnByWord.Click += new System.EventHandler(this.btnByWord_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 371);
            this.Controls.Add(this.boxForWord);
            this.Controls.Add(this.boxForLength);
            this.Controls.Add(this.display);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnShortest);
            this.Controls.Add(this.btnLongest);
            this.Controls.Add(this.btnMostCommon);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Text Analysis";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.boxForLength.ResumeLayout(false);
            this.boxForLength.PerformLayout();
            this.boxForWord.ResumeLayout(false);
            this.boxForWord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnMostCommon;
        private System.Windows.Forms.Button btnLongest;
        private System.Windows.Forms.Button btnShortest;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnByLength;
        private System.Windows.Forms.GroupBox boxForLength;
        private System.Windows.Forms.GroupBox boxForWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnByWord;
    }
}

