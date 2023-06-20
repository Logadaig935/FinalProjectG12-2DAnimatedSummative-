namespace _2DAnimatedGameSummitive
{
    partial class Level2
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
            this.components = new System.ComponentModel.Container();
            this.livesLabel = new System.Windows.Forms.Label();
            this.scoreOutputLabel = new System.Windows.Forms.Label();
            this.gameEngine = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // livesLabel
            // 
            this.livesLabel.BackColor = System.Drawing.Color.Transparent;
            this.livesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.livesLabel.Location = new System.Drawing.Point(1005, 5);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(177, 35);
            this.livesLabel.TabIndex = 2;
            this.livesLabel.Text = "Lives :";
            // 
            // scoreOutputLabel
            // 
            this.scoreOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreOutputLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.scoreOutputLabel.Location = new System.Drawing.Point(3, 5);
            this.scoreOutputLabel.Name = "scoreOutputLabel";
            this.scoreOutputLabel.Size = new System.Drawing.Size(150, 35);
            this.scoreOutputLabel.TabIndex = 3;
            this.scoreOutputLabel.Text = "Score:";
            // 
            // gameEngine
            // 
            this.gameEngine.Enabled = true;
            this.gameEngine.Interval = 20;
            this.gameEngine.Tick += new System.EventHandler(this.gameEngine_Tick);
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.scoreOutputLabel);
            this.Controls.Add(this.livesLabel);
            this.DoubleBuffered = true;
            this.Name = "Level2";
            this.Size = new System.Drawing.Size(1200, 600);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Level2_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Level2_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Label scoreOutputLabel;
        private System.Windows.Forms.Timer gameEngine;
    }
}
