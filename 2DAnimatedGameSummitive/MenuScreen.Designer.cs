namespace _2DAnimatedGameSummitive
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.robberManLabel = new System.Windows.Forms.Label();
            this.highScoreButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.Black;
            this.easyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easyButton.ForeColor = System.Drawing.Color.Lime;
            this.easyButton.Location = new System.Drawing.Point(534, 163);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(120, 50);
            this.easyButton.TabIndex = 0;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.Color.Black;
            this.mediumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mediumButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.mediumButton.Location = new System.Drawing.Point(534, 219);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(120, 50);
            this.mediumButton.TabIndex = 1;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.Color.Black;
            this.hardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hardButton.ForeColor = System.Drawing.Color.DarkViolet;
            this.hardButton.Location = new System.Drawing.Point(534, 275);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(120, 50);
            this.hardButton.TabIndex = 2;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.difficultyLabel.Location = new System.Drawing.Point(392, 117);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(413, 43);
            this.difficultyLabel.TabIndex = 3;
            this.difficultyLabel.Text = "Please select your difficulty";
            // 
            // robberManLabel
            // 
            this.robberManLabel.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robberManLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.robberManLabel.Location = new System.Drawing.Point(436, 65);
            this.robberManLabel.Name = "robberManLabel";
            this.robberManLabel.Size = new System.Drawing.Size(340, 52);
            this.robberManLabel.TabIndex = 4;
            this.robberManLabel.Text = "ROBBER MAN";
            // 
            // highScoreButton
            // 
            this.highScoreButton.BackColor = System.Drawing.Color.Black;
            this.highScoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highScoreButton.ForeColor = System.Drawing.Color.DeepPink;
            this.highScoreButton.Location = new System.Drawing.Point(1027, 447);
            this.highScoreButton.Name = "highScoreButton";
            this.highScoreButton.Size = new System.Drawing.Size(120, 50);
            this.highScoreButton.TabIndex = 5;
            this.highScoreButton.Text = "HighScores";
            this.highScoreButton.UseVisualStyleBackColor = false;
            this.highScoreButton.Click += new System.EventHandler(this.highScoreButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.ForeColor = System.Drawing.Color.Lime;
            this.exitButton.Location = new System.Drawing.Point(3, 447);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 50);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.highScoreButton);
            this.Controls.Add(this.robberManLabel);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1150, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label robberManLabel;
        private System.Windows.Forms.Button highScoreButton;
        private System.Windows.Forms.Button exitButton;
    }
}
