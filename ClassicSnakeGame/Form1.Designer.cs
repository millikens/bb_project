namespace ClassicSnakeGame
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.startButton = new System.Windows.Forms.Button();
            this.screenshotButton = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.firstPage = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.firstPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.startButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(408, 18);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(140, 48);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartGame);
            // 
            // screenshotButton
            // 
            this.screenshotButton.BackColor = System.Drawing.Color.Thistle;
            this.screenshotButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenshotButton.Location = new System.Drawing.Point(408, 70);
            this.screenshotButton.Margin = new System.Windows.Forms.Padding(2);
            this.screenshotButton.Name = "screenshotButton";
            this.screenshotButton.Size = new System.Drawing.Size(140, 48);
            this.screenshotButton.TabIndex = 1;
            this.screenshotButton.Text = "Screenshot";
            this.screenshotButton.UseVisualStyleBackColor = false;
            this.screenshotButton.Click += new System.EventHandler(this.TakeScreenshot);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.picCanvas.Location = new System.Drawing.Point(10, 8);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(394, 456);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(408, 141);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(92, 25);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "Score: 0";
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.Location = new System.Drawing.Point(408, 166);
            this.txtHighScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(135, 25);
            this.txtHighScore.TabIndex = 4;
            this.txtHighScore.Text = "High Score:";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // firstPage
            // 
            this.firstPage.BackColor = System.Drawing.Color.Olive;
            this.firstPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstPage.BackgroundImage")));
            this.firstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.firstPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstPage.Controls.Add(this.author);
            this.firstPage.Controls.Add(this.title);
            this.firstPage.Location = new System.Drawing.Point(10, 8);
            this.firstPage.Name = "firstPage";
            this.firstPage.Size = new System.Drawing.Size(393, 456);
            this.firstPage.TabIndex = 5;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Stencil", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(13, 94);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(364, 39);
            this.title.TabIndex = 0;
            this.title.Text = "Classic Snake Game";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Perpetua", 12.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(46, 133);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(290, 35);
            this.author.TabIndex = 1;
            this.author.Text = "by PowerPlay Studios";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 471);
            this.Controls.Add(this.firstPage);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.screenshotButton);
            this.Controls.Add(this.startButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.Text = "Classic Snake Game by PowerPlay Studios";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.firstPage.ResumeLayout(false);
            this.firstPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button screenshotButton;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel firstPage;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label title;
    }
}

