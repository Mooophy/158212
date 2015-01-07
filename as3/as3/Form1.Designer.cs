namespace as3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonLeftCameroon = new System.Windows.Forms.RadioButton();
            this.radioButtonLeftGermany = new System.Windows.Forms.RadioButton();
            this.radioButtonLeftChile = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonRightCameroon = new System.Windows.Forms.RadioButton();
            this.radioButtonRightGermany = new System.Windows.Forms.RadioButton();
            this.radioButtonRightChile = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelLeftScore = new System.Windows.Forms.Label();
            this.labelRightScore = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonLeftTry = new System.Windows.Forms.Button();
            this.buttonLeftConversion = new System.Windows.Forms.Button();
            this.buttonLeftPenalty = new System.Windows.Forms.Button();
            this.buttonLeftDrop = new System.Windows.Forms.Button();
            this.buttonRightDrop = new System.Windows.Forms.Button();
            this.buttonRightPenalty = new System.Windows.Forms.Button();
            this.buttonRightConversion = new System.Windows.Forms.Button();
            this.buttonRightTry = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLeftCameroon);
            this.groupBox1.Controls.Add(this.radioButtonLeftGermany);
            this.groupBox1.Controls.Add(this.radioButtonLeftChile);
            this.groupBox1.Location = new System.Drawing.Point(48, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonLeftCameroon
            // 
            this.radioButtonLeftCameroon.AutoSize = true;
            this.radioButtonLeftCameroon.Location = new System.Drawing.Point(16, 64);
            this.radioButtonLeftCameroon.Name = "radioButtonLeftCameroon";
            this.radioButtonLeftCameroon.Size = new System.Drawing.Size(71, 16);
            this.radioButtonLeftCameroon.TabIndex = 2;
            this.radioButtonLeftCameroon.TabStop = true;
            this.radioButtonLeftCameroon.Text = "Cameroon";
            this.radioButtonLeftCameroon.UseVisualStyleBackColor = true;
            this.radioButtonLeftCameroon.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonLeftGermany
            // 
            this.radioButtonLeftGermany.AutoSize = true;
            this.radioButtonLeftGermany.Location = new System.Drawing.Point(16, 42);
            this.radioButtonLeftGermany.Name = "radioButtonLeftGermany";
            this.radioButtonLeftGermany.Size = new System.Drawing.Size(65, 16);
            this.radioButtonLeftGermany.TabIndex = 1;
            this.radioButtonLeftGermany.TabStop = true;
            this.radioButtonLeftGermany.Text = "Germany";
            this.radioButtonLeftGermany.UseVisualStyleBackColor = true;
            this.radioButtonLeftGermany.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonLeftChile
            // 
            this.radioButtonLeftChile.AutoSize = true;
            this.radioButtonLeftChile.Location = new System.Drawing.Point(16, 20);
            this.radioButtonLeftChile.Name = "radioButtonLeftChile";
            this.radioButtonLeftChile.Size = new System.Drawing.Size(53, 16);
            this.radioButtonLeftChile.TabIndex = 0;
            this.radioButtonLeftChile.TabStop = true;
            this.radioButtonLeftChile.Text = "Chile";
            this.radioButtonLeftChile.UseVisualStyleBackColor = true;
            this.radioButtonLeftChile.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonRightCameroon);
            this.groupBox2.Controls.Add(this.radioButtonRightGermany);
            this.groupBox2.Controls.Add(this.radioButtonRightChile);
            this.groupBox2.Location = new System.Drawing.Point(501, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioButtonRightCameroon
            // 
            this.radioButtonRightCameroon.AutoSize = true;
            this.radioButtonRightCameroon.Location = new System.Drawing.Point(23, 68);
            this.radioButtonRightCameroon.Name = "radioButtonRightCameroon";
            this.radioButtonRightCameroon.Size = new System.Drawing.Size(71, 16);
            this.radioButtonRightCameroon.TabIndex = 5;
            this.radioButtonRightCameroon.TabStop = true;
            this.radioButtonRightCameroon.Text = "Cameroon";
            this.radioButtonRightCameroon.UseVisualStyleBackColor = true;
            this.radioButtonRightCameroon.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButtonRightGermany
            // 
            this.radioButtonRightGermany.AutoSize = true;
            this.radioButtonRightGermany.Location = new System.Drawing.Point(23, 46);
            this.radioButtonRightGermany.Name = "radioButtonRightGermany";
            this.radioButtonRightGermany.Size = new System.Drawing.Size(65, 16);
            this.radioButtonRightGermany.TabIndex = 4;
            this.radioButtonRightGermany.TabStop = true;
            this.radioButtonRightGermany.Text = "Germany";
            this.radioButtonRightGermany.UseVisualStyleBackColor = true;
            this.radioButtonRightGermany.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButtonRightChile
            // 
            this.radioButtonRightChile.AutoSize = true;
            this.radioButtonRightChile.Location = new System.Drawing.Point(23, 24);
            this.radioButtonRightChile.Name = "radioButtonRightChile";
            this.radioButtonRightChile.Size = new System.Drawing.Size(53, 16);
            this.radioButtonRightChile.TabIndex = 3;
            this.radioButtonRightChile.TabStop = true;
            this.radioButtonRightChile.Text = "Chile";
            this.radioButtonRightChile.UseVisualStyleBackColor = true;
            this.radioButtonRightChile.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::as3.Properties.Resources.Germany;
            this.pictureBox2.Location = new System.Drawing.Point(517, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::as3.Properties.Resources.Cameroon;
            this.pictureBox1.Location = new System.Drawing.Point(48, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 36F);
            this.label1.Location = new System.Drawing.Point(266, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "00:00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.tick_EventHandler);
            // 
            // labelLeftScore
            // 
            this.labelLeftScore.AutoSize = true;
            this.labelLeftScore.Font = new System.Drawing.Font("SimSun", 48F);
            this.labelLeftScore.Location = new System.Drawing.Point(244, 170);
            this.labelLeftScore.Name = "labelLeftScore";
            this.labelLeftScore.Size = new System.Drawing.Size(60, 64);
            this.labelLeftScore.TabIndex = 7;
            this.labelLeftScore.Text = "0";
            // 
            // labelRightScore
            // 
            this.labelRightScore.AutoSize = true;
            this.labelRightScore.Font = new System.Drawing.Font("SimSun", 48F);
            this.labelRightScore.Location = new System.Drawing.Point(366, 170);
            this.labelRightScore.Name = "labelRightScore";
            this.labelRightScore.Size = new System.Drawing.Size(60, 64);
            this.labelRightScore.TabIndex = 8;
            this.labelRightScore.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 277);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(326, 96);
            this.textBox1.TabIndex = 9;
            // 
            // buttonLeftTry
            // 
            this.buttonLeftTry.Enabled = false;
            this.buttonLeftTry.Location = new System.Drawing.Point(64, 209);
            this.buttonLeftTry.Name = "buttonLeftTry";
            this.buttonLeftTry.Size = new System.Drawing.Size(75, 23);
            this.buttonLeftTry.TabIndex = 10;
            this.buttonLeftTry.Text = "Try";
            this.buttonLeftTry.UseVisualStyleBackColor = true;
            this.buttonLeftTry.Click += new System.EventHandler(this.buttonLeftTry_Click);
            // 
            // buttonLeftConversion
            // 
            this.buttonLeftConversion.Enabled = false;
            this.buttonLeftConversion.Location = new System.Drawing.Point(64, 240);
            this.buttonLeftConversion.Name = "buttonLeftConversion";
            this.buttonLeftConversion.Size = new System.Drawing.Size(75, 23);
            this.buttonLeftConversion.TabIndex = 11;
            this.buttonLeftConversion.Text = "Conversion";
            this.buttonLeftConversion.UseVisualStyleBackColor = true;
            this.buttonLeftConversion.Click += new System.EventHandler(this.buttonLeftConversion_Click);
            // 
            // buttonLeftPenalty
            // 
            this.buttonLeftPenalty.Enabled = false;
            this.buttonLeftPenalty.Location = new System.Drawing.Point(64, 270);
            this.buttonLeftPenalty.Name = "buttonLeftPenalty";
            this.buttonLeftPenalty.Size = new System.Drawing.Size(75, 23);
            this.buttonLeftPenalty.TabIndex = 12;
            this.buttonLeftPenalty.Text = "Penalty";
            this.buttonLeftPenalty.UseVisualStyleBackColor = true;
            // 
            // buttonLeftDrop
            // 
            this.buttonLeftDrop.Enabled = false;
            this.buttonLeftDrop.Location = new System.Drawing.Point(64, 300);
            this.buttonLeftDrop.Name = "buttonLeftDrop";
            this.buttonLeftDrop.Size = new System.Drawing.Size(75, 23);
            this.buttonLeftDrop.TabIndex = 13;
            this.buttonLeftDrop.Text = "Drop";
            this.buttonLeftDrop.UseVisualStyleBackColor = true;
            // 
            // buttonRightDrop
            // 
            this.buttonRightDrop.Enabled = false;
            this.buttonRightDrop.Location = new System.Drawing.Point(524, 302);
            this.buttonRightDrop.Name = "buttonRightDrop";
            this.buttonRightDrop.Size = new System.Drawing.Size(75, 23);
            this.buttonRightDrop.TabIndex = 17;
            this.buttonRightDrop.Text = "Drop";
            this.buttonRightDrop.UseVisualStyleBackColor = true;
            // 
            // buttonRightPenalty
            // 
            this.buttonRightPenalty.Enabled = false;
            this.buttonRightPenalty.Location = new System.Drawing.Point(524, 272);
            this.buttonRightPenalty.Name = "buttonRightPenalty";
            this.buttonRightPenalty.Size = new System.Drawing.Size(75, 23);
            this.buttonRightPenalty.TabIndex = 16;
            this.buttonRightPenalty.Text = "Penalty";
            this.buttonRightPenalty.UseVisualStyleBackColor = true;
            // 
            // buttonRightConversion
            // 
            this.buttonRightConversion.Enabled = false;
            this.buttonRightConversion.Location = new System.Drawing.Point(524, 242);
            this.buttonRightConversion.Name = "buttonRightConversion";
            this.buttonRightConversion.Size = new System.Drawing.Size(75, 23);
            this.buttonRightConversion.TabIndex = 15;
            this.buttonRightConversion.Text = "Conversion";
            this.buttonRightConversion.UseVisualStyleBackColor = true;
            // 
            // buttonRightTry
            // 
            this.buttonRightTry.Enabled = false;
            this.buttonRightTry.Location = new System.Drawing.Point(524, 211);
            this.buttonRightTry.Name = "buttonRightTry";
            this.buttonRightTry.Size = new System.Drawing.Size(75, 23);
            this.buttonRightTry.TabIndex = 14;
            this.buttonRightTry.Text = "Try";
            this.buttonRightTry.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 394);
            this.Controls.Add(this.buttonRightDrop);
            this.Controls.Add(this.buttonRightPenalty);
            this.Controls.Add(this.buttonRightConversion);
            this.Controls.Add(this.buttonRightTry);
            this.Controls.Add(this.buttonLeftDrop);
            this.Controls.Add(this.buttonLeftPenalty);
            this.Controls.Add(this.buttonLeftConversion);
            this.Controls.Add(this.buttonLeftTry);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelRightScore);
            this.Controls.Add(this.labelLeftScore);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonLeftCameroon;
        private System.Windows.Forms.RadioButton radioButtonLeftGermany;
        private System.Windows.Forms.RadioButton radioButtonLeftChile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonRightCameroon;
        private System.Windows.Forms.RadioButton radioButtonRightGermany;
        private System.Windows.Forms.RadioButton radioButtonRightChile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelLeftScore;
        private System.Windows.Forms.Label labelRightScore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonLeftTry;
        private System.Windows.Forms.Button buttonLeftConversion;
        private System.Windows.Forms.Button buttonLeftPenalty;
        private System.Windows.Forms.Button buttonLeftDrop;
        private System.Windows.Forms.Button buttonRightDrop;
        private System.Windows.Forms.Button buttonRightPenalty;
        private System.Windows.Forms.Button buttonRightConversion;
        private System.Windows.Forms.Button buttonRightTry;
    }
}

