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
            this.components = new System.ComponentModel.Container();
            this.log = new System.Windows.Forms.TextBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.picRight = new System.Windows.Forms.PictureBox();
            this.boxLeft = new System.Windows.Forms.GroupBox();
            this.rbtnCameroonLeft = new System.Windows.Forms.RadioButton();
            this.rbtnGermanyLeft = new System.Windows.Forms.RadioButton();
            this.rbtnChileLeft = new System.Windows.Forms.RadioButton();
            this.boxRight = new System.Windows.Forms.GroupBox();
            this.rbtnCameroonRight = new System.Windows.Forms.RadioButton();
            this.rbtnChileRight = new System.Windows.Forms.RadioButton();
            this.rbtnGermanyRight = new System.Windows.Forms.RadioButton();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblScoreLeft = new System.Windows.Forms.Label();
            this.lblScoreRight = new System.Windows.Forms.Label();
            this.btnTryLeft = new System.Windows.Forms.Button();
            this.btnConversionLeft = new System.Windows.Forms.Button();
            this.btnPenaltyLeft = new System.Windows.Forms.Button();
            this.btnDropLeft = new System.Windows.Forms.Button();
            this.btnDropRight = new System.Windows.Forms.Button();
            this.btnPenaltyRight = new System.Windows.Forms.Button();
            this.btnConversionRight = new System.Windows.Forms.Button();
            this.btnTryRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            this.boxLeft.SuspendLayout();
            this.boxRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(191, 243);
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
            this.boxLeft.Location = new System.Drawing.Point(18, 100);
            this.boxLeft.Name = "boxLeft";
            this.boxLeft.Size = new System.Drawing.Size(148, 100);
            this.boxLeft.TabIndex = 3;
            this.boxLeft.TabStop = false;
            // 
            // rbtnCameroonLeft
            // 
            this.rbtnCameroonLeft.AutoSize = true;
            this.rbtnCameroonLeft.Location = new System.Drawing.Point(24, 63);
            this.rbtnCameroonLeft.Name = "rbtnCameroonLeft";
            this.rbtnCameroonLeft.Size = new System.Drawing.Size(71, 16);
            this.rbtnCameroonLeft.TabIndex = 2;
            this.rbtnCameroonLeft.Text = "Cameroon";
            this.rbtnCameroonLeft.UseVisualStyleBackColor = true;
            this.rbtnCameroonLeft.CheckedChanged += new System.EventHandler(this.rbtnCameroonLeft_CheckedChanged);
            // 
            // rbtnGermanyLeft
            // 
            this.rbtnGermanyLeft.AutoSize = true;
            this.rbtnGermanyLeft.Location = new System.Drawing.Point(24, 42);
            this.rbtnGermanyLeft.Name = "rbtnGermanyLeft";
            this.rbtnGermanyLeft.Size = new System.Drawing.Size(65, 16);
            this.rbtnGermanyLeft.TabIndex = 1;
            this.rbtnGermanyLeft.Text = "Germany";
            this.rbtnGermanyLeft.UseVisualStyleBackColor = true;
            this.rbtnGermanyLeft.CheckedChanged += new System.EventHandler(this.rbtnGermanyLeft_CheckedChanged);
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
            this.rbtnChileLeft.CheckedChanged += new System.EventHandler(this.rbtnChileLeft_CheckedChanged);
            // 
            // boxRight
            // 
            this.boxRight.Controls.Add(this.rbtnCameroonRight);
            this.boxRight.Controls.Add(this.rbtnChileRight);
            this.boxRight.Controls.Add(this.rbtnGermanyRight);
            this.boxRight.Location = new System.Drawing.Point(531, 100);
            this.boxRight.Name = "boxRight";
            this.boxRight.Size = new System.Drawing.Size(148, 100);
            this.boxRight.TabIndex = 4;
            this.boxRight.TabStop = false;
            // 
            // rbtnCameroonRight
            // 
            this.rbtnCameroonRight.AutoSize = true;
            this.rbtnCameroonRight.Location = new System.Drawing.Point(24, 70);
            this.rbtnCameroonRight.Name = "rbtnCameroonRight";
            this.rbtnCameroonRight.Size = new System.Drawing.Size(71, 16);
            this.rbtnCameroonRight.TabIndex = 7;
            this.rbtnCameroonRight.Text = "Cameroon";
            this.rbtnCameroonRight.UseVisualStyleBackColor = true;
            this.rbtnCameroonRight.CheckedChanged += new System.EventHandler(this.rbtnCameroonRight_CheckedChanged);
            // 
            // rbtnChileRight
            // 
            this.rbtnChileRight.AutoSize = true;
            this.rbtnChileRight.Location = new System.Drawing.Point(24, 28);
            this.rbtnChileRight.Name = "rbtnChileRight";
            this.rbtnChileRight.Size = new System.Drawing.Size(53, 16);
            this.rbtnChileRight.TabIndex = 5;
            this.rbtnChileRight.Text = "Chile";
            this.rbtnChileRight.UseVisualStyleBackColor = true;
            this.rbtnChileRight.CheckedChanged += new System.EventHandler(this.rbtnChileRight_CheckedChanged);
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
            this.rbtnGermanyRight.CheckedChanged += new System.EventHandler(this.rbtnGermanyRight_CheckedChanged);
            // 
            // lblElapsed
            // 
            this.lblElapsed.AutoSize = true;
            this.lblElapsed.Font = new System.Drawing.Font("SimSun", 24F);
            this.lblElapsed.Location = new System.Drawing.Point(286, 36);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(95, 33);
            this.lblElapsed.TabIndex = 5;
            this.lblElapsed.Text = "00:00";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(256, 81);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 22);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(337, 81);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 22);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.tick_eventHandler);
            // 
            // lblScoreLeft
            // 
            this.lblScoreLeft.AutoSize = true;
            this.lblScoreLeft.Font = new System.Drawing.Font("SimSun", 36F);
            this.lblScoreLeft.Location = new System.Drawing.Point(269, 153);
            this.lblScoreLeft.Name = "lblScoreLeft";
            this.lblScoreLeft.Size = new System.Drawing.Size(44, 48);
            this.lblScoreLeft.TabIndex = 8;
            this.lblScoreLeft.Text = "0";
            // 
            // lblScoreRight
            // 
            this.lblScoreRight.AutoSize = true;
            this.lblScoreRight.Font = new System.Drawing.Font("SimSun", 36F);
            this.lblScoreRight.Location = new System.Drawing.Point(360, 154);
            this.lblScoreRight.Name = "lblScoreRight";
            this.lblScoreRight.Size = new System.Drawing.Size(44, 48);
            this.lblScoreRight.TabIndex = 9;
            this.lblScoreRight.Text = "0";
            // 
            // btnTryLeft
            // 
            this.btnTryLeft.Location = new System.Drawing.Point(45, 226);
            this.btnTryLeft.Name = "btnTryLeft";
            this.btnTryLeft.Size = new System.Drawing.Size(75, 23);
            this.btnTryLeft.TabIndex = 10;
            this.btnTryLeft.Text = "Try";
            this.btnTryLeft.UseVisualStyleBackColor = true;
            this.btnTryLeft.Click += new System.EventHandler(this.btnTryLeft_Click);
            // 
            // btnConversionLeft
            // 
            this.btnConversionLeft.Location = new System.Drawing.Point(45, 255);
            this.btnConversionLeft.Name = "btnConversionLeft";
            this.btnConversionLeft.Size = new System.Drawing.Size(75, 23);
            this.btnConversionLeft.TabIndex = 11;
            this.btnConversionLeft.Text = "Conversion";
            this.btnConversionLeft.UseVisualStyleBackColor = true;
            this.btnConversionLeft.Click += new System.EventHandler(this.btnConversionLeft_Click);
            // 
            // btnPenaltyLeft
            // 
            this.btnPenaltyLeft.Location = new System.Drawing.Point(45, 284);
            this.btnPenaltyLeft.Name = "btnPenaltyLeft";
            this.btnPenaltyLeft.Size = new System.Drawing.Size(75, 23);
            this.btnPenaltyLeft.TabIndex = 12;
            this.btnPenaltyLeft.Text = "Penalty";
            this.btnPenaltyLeft.UseVisualStyleBackColor = true;
            this.btnPenaltyLeft.Click += new System.EventHandler(this.btnPenaltyLeft_Click);
            // 
            // btnDropLeft
            // 
            this.btnDropLeft.Location = new System.Drawing.Point(45, 313);
            this.btnDropLeft.Name = "btnDropLeft";
            this.btnDropLeft.Size = new System.Drawing.Size(75, 23);
            this.btnDropLeft.TabIndex = 13;
            this.btnDropLeft.Text = "Drop";
            this.btnDropLeft.UseVisualStyleBackColor = true;
            this.btnDropLeft.Click += new System.EventHandler(this.btnDropLeft_Click);
            // 
            // btnDropRight
            // 
            this.btnDropRight.Location = new System.Drawing.Point(565, 313);
            this.btnDropRight.Name = "btnDropRight";
            this.btnDropRight.Size = new System.Drawing.Size(75, 23);
            this.btnDropRight.TabIndex = 17;
            this.btnDropRight.Text = "Drop";
            this.btnDropRight.UseVisualStyleBackColor = true;
            this.btnDropRight.Click += new System.EventHandler(this.btnDropRight_Click);
            // 
            // btnPenaltyRight
            // 
            this.btnPenaltyRight.Location = new System.Drawing.Point(565, 284);
            this.btnPenaltyRight.Name = "btnPenaltyRight";
            this.btnPenaltyRight.Size = new System.Drawing.Size(75, 23);
            this.btnPenaltyRight.TabIndex = 16;
            this.btnPenaltyRight.Text = "Penalty";
            this.btnPenaltyRight.UseVisualStyleBackColor = true;
            this.btnPenaltyRight.Click += new System.EventHandler(this.btnPenaltyRight_Click);
            // 
            // btnConversionRight
            // 
            this.btnConversionRight.Location = new System.Drawing.Point(565, 255);
            this.btnConversionRight.Name = "btnConversionRight";
            this.btnConversionRight.Size = new System.Drawing.Size(75, 23);
            this.btnConversionRight.TabIndex = 15;
            this.btnConversionRight.Text = "Conversion";
            this.btnConversionRight.UseVisualStyleBackColor = true;
            this.btnConversionRight.Click += new System.EventHandler(this.btnConversionRight_Click);
            // 
            // btnTryRight
            // 
            this.btnTryRight.Location = new System.Drawing.Point(565, 226);
            this.btnTryRight.Name = "btnTryRight";
            this.btnTryRight.Size = new System.Drawing.Size(75, 23);
            this.btnTryRight.TabIndex = 14;
            this.btnTryRight.Text = "Try";
            this.btnTryRight.UseVisualStyleBackColor = true;
            this.btnTryRight.Click += new System.EventHandler(this.btnTryRight_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 392);
            this.Controls.Add(this.btnDropRight);
            this.Controls.Add(this.btnPenaltyRight);
            this.Controls.Add(this.btnConversionRight);
            this.Controls.Add(this.btnTryRight);
            this.Controls.Add(this.btnDropLeft);
            this.Controls.Add(this.btnPenaltyLeft);
            this.Controls.Add(this.btnConversionLeft);
            this.Controls.Add(this.btnTryLeft);
            this.Controls.Add(this.lblScoreRight);
            this.Controls.Add(this.lblScoreLeft);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblElapsed);
            this.Controls.Add(this.boxRight);
            this.Controls.Add(this.boxLeft);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.picLeft);
            this.Controls.Add(this.log);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblScoreLeft;
        private System.Windows.Forms.Label lblScoreRight;
        private System.Windows.Forms.Button btnTryLeft;
        private System.Windows.Forms.Button btnConversionLeft;
        private System.Windows.Forms.Button btnPenaltyLeft;
        private System.Windows.Forms.Button btnDropLeft;
        private System.Windows.Forms.Button btnDropRight;
        private System.Windows.Forms.Button btnPenaltyRight;
        private System.Windows.Forms.Button btnConversionRight;
        private System.Windows.Forms.Button btnTryRight;
    }
}

