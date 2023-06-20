namespace _2DAnimatedGameSummitive
{
    partial class HighScoreScreen
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
            this.menuButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.robberiesLabel = new System.Windows.Forms.Label();
            this.devLabel = new System.Windows.Forms.Label();
            this.goldLabel = new System.Windows.Forms.Label();
            this.silverLabel = new System.Windows.Forms.Label();
            this.bronzeLabel = new System.Windows.Forms.Label();
            this.bronzeMedalPicture = new System.Windows.Forms.PictureBox();
            this.silverMedalPicture = new System.Windows.Forms.PictureBox();
            this.goldMedalPicture = new System.Windows.Forms.PictureBox();
            this.redMedalPicture = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bronzeMedalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverMedalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldMedalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redMedalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Black;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.ForeColor = System.Drawing.Color.Lime;
            this.menuButton.Location = new System.Drawing.Point(471, 579);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(120, 50);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.ForeColor = System.Drawing.Color.Lime;
            this.exitButton.Location = new System.Drawing.Point(3, 579);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // robberiesLabel
            // 
            this.robberiesLabel.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robberiesLabel.ForeColor = System.Drawing.Color.Lime;
            this.robberiesLabel.Location = new System.Drawing.Point(120, 41);
            this.robberiesLabel.Name = "robberiesLabel";
            this.robberiesLabel.Size = new System.Drawing.Size(357, 52);
            this.robberiesLabel.TabIndex = 5;
            this.robberiesLabel.Text = "Fastest Robberies";
            // 
            // devLabel
            // 
            this.devLabel.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devLabel.ForeColor = System.Drawing.Color.Crimson;
            this.devLabel.Location = new System.Drawing.Point(106, 114);
            this.devLabel.Name = "devLabel";
            this.devLabel.Size = new System.Drawing.Size(426, 70);
            this.devLabel.TabIndex = 6;
            this.devLabel.Text = "DEV TIME: my time";
            // 
            // goldLabel
            // 
            this.goldLabel.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldLabel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.goldLabel.Location = new System.Drawing.Point(106, 221);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(463, 56);
            this.goldLabel.TabIndex = 11;
            this.goldLabel.Text = "Gold TIME: hard";
            // 
            // silverLabel
            // 
            this.silverLabel.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silverLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.silverLabel.Location = new System.Drawing.Point(106, 327);
            this.silverLabel.Name = "silverLabel";
            this.silverLabel.Size = new System.Drawing.Size(463, 56);
            this.silverLabel.TabIndex = 12;
            this.silverLabel.Text = "Silver Time: medium";
            // 
            // bronzeLabel
            // 
            this.bronzeLabel.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bronzeLabel.ForeColor = System.Drawing.Color.Lime;
            this.bronzeLabel.Location = new System.Drawing.Point(106, 430);
            this.bronzeLabel.Name = "bronzeLabel";
            this.bronzeLabel.Size = new System.Drawing.Size(463, 55);
            this.bronzeLabel.TabIndex = 13;
            this.bronzeLabel.Text = "Bronze Time: easy";
            // 
            // bronzeMedalPicture
            // 
            this.bronzeMedalPicture.Image = global::_2DAnimatedGameSummitive.Properties.Resources.bromze_Medal;
            this.bronzeMedalPicture.Location = new System.Drawing.Point(29, 417);
            this.bronzeMedalPicture.Name = "bronzeMedalPicture";
            this.bronzeMedalPicture.Size = new System.Drawing.Size(71, 80);
            this.bronzeMedalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bronzeMedalPicture.TabIndex = 10;
            this.bronzeMedalPicture.TabStop = false;
            // 
            // silverMedalPicture
            // 
            this.silverMedalPicture.Image = global::_2DAnimatedGameSummitive.Properties.Resources.SilverMedal;
            this.silverMedalPicture.Location = new System.Drawing.Point(29, 317);
            this.silverMedalPicture.Name = "silverMedalPicture";
            this.silverMedalPicture.Size = new System.Drawing.Size(71, 80);
            this.silverMedalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.silverMedalPicture.TabIndex = 9;
            this.silverMedalPicture.TabStop = false;
            // 
            // goldMedalPicture
            // 
            this.goldMedalPicture.Image = global::_2DAnimatedGameSummitive.Properties.Resources.Gold_Medal1;
            this.goldMedalPicture.Location = new System.Drawing.Point(29, 208);
            this.goldMedalPicture.Name = "goldMedalPicture";
            this.goldMedalPicture.Size = new System.Drawing.Size(71, 80);
            this.goldMedalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goldMedalPicture.TabIndex = 8;
            this.goldMedalPicture.TabStop = false;
            // 
            // redMedalPicture
            // 
            this.redMedalPicture.Image = global::_2DAnimatedGameSummitive.Properties.Resources.Red_Medal;
            this.redMedalPicture.Location = new System.Drawing.Point(29, 104);
            this.redMedalPicture.Name = "redMedalPicture";
            this.redMedalPicture.Size = new System.Drawing.Size(71, 80);
            this.redMedalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redMedalPicture.TabIndex = 7;
            this.redMedalPicture.TabStop = false;
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Lime;
            this.timeLabel.Location = new System.Drawing.Point(161, 569);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(277, 52);
            this.timeLabel.TabIndex = 14;
            this.timeLabel.Text = "1000 = 1 sec";
            // 
            // HighScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.bronzeLabel);
            this.Controls.Add(this.silverLabel);
            this.Controls.Add(this.goldLabel);
            this.Controls.Add(this.bronzeMedalPicture);
            this.Controls.Add(this.silverMedalPicture);
            this.Controls.Add(this.goldMedalPicture);
            this.Controls.Add(this.redMedalPicture);
            this.Controls.Add(this.devLabel);
            this.Controls.Add(this.robberiesLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuButton);
            this.Name = "HighScoreScreen";
            this.Size = new System.Drawing.Size(594, 632);
            ((System.ComponentModel.ISupportInitialize)(this.bronzeMedalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverMedalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldMedalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redMedalPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label robberiesLabel;
        private System.Windows.Forms.Label devLabel;
        private System.Windows.Forms.PictureBox redMedalPicture;
        private System.Windows.Forms.PictureBox goldMedalPicture;
        private System.Windows.Forms.PictureBox silverMedalPicture;
        private System.Windows.Forms.PictureBox bronzeMedalPicture;
        private System.Windows.Forms.Label goldLabel;
        private System.Windows.Forms.Label silverLabel;
        private System.Windows.Forms.Label bronzeLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}
