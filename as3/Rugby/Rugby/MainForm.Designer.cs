namespace Rugby
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
            this.log = new System.Windows.Forms.TextBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.picRight = new System.Windows.Forms.PictureBox();
            this.boxLeft = new System.Windows.Forms.GroupBox();
            this.boxRight = new System.Windows.Forms.GroupBox();
            this.rbtnChileLeft = new System.Windows.Forms.RadioButton();
            this.rbtnGermanyLeft = new System.Windows.Forms.RadioButton();
            this.rbtnCameroonLeft = new System.Windows.Forms.RadioButton();
            this.rbtnCameroonRight = new System.Windows.Forms.RadioButton();
            this.rbtnGermanyRight = new System.Windows.Forms.RadioButton();
            this.rbtnChileRight = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            this.boxLeft.SuspendLayout();
            this.boxRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(187, 144);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(312, 102);
            this.log.TabIndex = 0;
            // 
            // picLeft
            // 
            this.picLeft.Image = global::Rugby.Properties.Resources.Chile;
            this.picLeft.Location = new System.Drawing.Point(42, 36);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(100, 50);
            this.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeft.TabIndex = 1;
            this.picLeft.TabStop = false;
            // 
            // picRight
            // 
            this.picRight.Image = global::Rugby.Properties.Resources.Germany;
            this.picRight.Location = new System.Drawing.Point(555, 36);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(100, 50);
            this.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRight.TabIndex = 2;
            this.picRight.TabStop = false;
            // 
            // boxLeft
            // 
            this.boxLeft.Controls.Add(this.rbtnCameroonLeft);
            this.boxLeft.Controls.Add(this.rbtnGermanyLeft);
            this.boxLeft.Controls.Add(this.rbtnChileLeft);
            this.boxLeft.Location = new System.Drawing.Point(18, 117);
            this.boxLeft.Name = "boxLeft";
            this.boxLeft.Size = new System.Drawing.Size(148, 100);
            this.boxLeft.TabIndex = 3;
            this.boxLeft.TabStop = false;
            // 
            // boxRight
            // 
            this.boxRight.Controls.Add(this.rbtnCameroonRight);
            this.boxRight.Controls.Add(this.rbtnChileRight);
            this.boxRight.Controls.Add(this.rbtnGermanyRight);
            this.boxRight.Location = new System.Drawing.Point(531, 117);
            this.boxRight.Name = "boxRight";
            this.boxRight.Size = new System.Drawing.Size(148, 100);
            this.boxRight.TabIndex = 4;
            this.boxRight.TabStop = false;
            // 
            // rbtnChileLeft
            // 
            this.rbtnChileLeft.AutoSize = true;
            this.rbtnChileLeft.Checked = true;
            this.rbtnChileLeft.Location = new System.Drawing.Point(24, 21);
            this.rbtnChileLeft.Name = "rbtnChileLeft";
            this.rbtnChileLeft.Size = new System.Drawing.Size(53, 16);
            this.rbtnChileLeft.TabIndex = 0;
            this.rbtnChileLeft.TabStop = true;
            this.rbtnChileLeft.Text = "Chile";
            this.rbtnChileLeft.UseVisualStyleBackColor = true;
            // 
            // rbtnGermanyLeft
            // 
            this.rbtnGermanyLeft.AutoSize = true;
            this.rbtnGermanyLeft.Location = new System.Drawing.Point(24, 42);
            this.rbtnGermanyLeft.Name = "rbtnGermanyLeft";
            this.rbtnGermanyLeft.Size = new System.Drawing.Size(65, 16);
            this.rbtnGermanyLeft.TabIndex = 1;
            this.rbtnGermanyLeft.TabStop = true;
            this.rbtnGermanyLeft.Text = "Germany";
            this.rbtnGermanyLeft.UseVisualStyleBackColor = true;
            // 
            // rbtnCameroonLeft
            // 
            this.rbtnCameroonLeft.AutoSize = true;
            this.rbtnCameroonLeft.Location = new System.Drawing.Point(24, 63);
            this.rbtnCameroonLeft.Name = "rbtnCameroonLeft";
            this.rbtnCameroonLeft.Size = new System.Drawing.Size(71, 16);
            this.rbtnCameroonLeft.TabIndex = 2;
            this.rbtnCameroonLeft.TabStop = true;
            this.rbtnCameroonLeft.Text = "Cameroon";
            this.rbtnCameroonLeft.UseVisualStyleBackColor = true;
            // 
            // rbtnCameroonRight
            // 
            this.rbtnCameroonRight.AutoSize = true;
            this.rbtnCameroonRight.Location = new System.Drawing.Point(24, 70);
            this.rbtnCameroonRight.Name = "rbtnCameroonRight";
            this.rbtnCameroonRight.Size = new System.Drawing.Size(71, 16);
            this.rbtnCameroonRight.TabIndex = 7;
            this.rbtnCameroonRight.TabStop = true;
            this.rbtnCameroonRight.Text = "Cameroon";
            this.rbtnCameroonRight.UseVisualStyleBackColor = true;
            // 
            // rbtnGermanyRight
            // 
            this.rbtnGermanyRight.AutoSize = true;
            this.rbtnGermanyRight.Checked = true;
            this.rbtnGermanyRight.Location = new System.Drawing.Point(24, 49);
            this.rbtnGermanyRight.Name = "rbtnGermanyRight";
            this.rbtnGermanyRight.Size = new System.Drawing.Size(65, 16);
            this.rbtnGermanyRight.TabIndex = 6;
            this.rbtnGermanyRight.TabStop = true;
            this.rbtnGermanyRight.Text = "Germany";
            this.rbtnGermanyRight.UseVisualStyleBackColor = true;
            // 
            // rbtnChileRight
            // 
            this.rbtnChileRight.AutoSize = true;
            this.rbtnChileRight.Location = new System.Drawing.Point(24, 28);
            this.rbtnChileRight.Name = "rbtnChileRight";
            this.rbtnChileRight.Size = new System.Drawing.Size(53, 16);
            this.rbtnChileRight.TabIndex = 5;
            this.rbtnChileRight.TabStop = true;
            this.rbtnChileRight.Text = "Chile";
            this.rbtnChileRight.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 392);
            this.Controls.Add(this.boxRight);
            this.Controls.Add(this.boxLeft);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.picLeft);
            this.Controls.Add(this.log);
            this.Name = "MainForm";
            this.Text = "Rugby";
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            this.boxLeft.ResumeLayout(false);
            this.boxLeft.PerformLayout();
            this.boxRight.ResumeLayout(false);
            this.boxRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.PictureBox picLeft;
        private System.Windows.Forms.PictureBox picRight;
        private System.Windows.Forms.GroupBox boxLeft;
        private System.Windows.Forms.RadioButton rbtnCameroonLeft;
        private System.Windows.Forms.RadioButton rbtnGermanyLeft;
        private System.Windows.Forms.RadioButton rbtnChileLeft;
        private System.Windows.Forms.GroupBox boxRight;
        private System.Windows.Forms.RadioButton rbtnCameroonRight;
        private System.Windows.Forms.RadioButton rbtnChileRight;
        private System.Windows.Forms.RadioButton rbtnGermanyRight;
    }
}

