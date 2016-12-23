namespace SongGame
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
            this.answerLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.answerButton1 = new System.Windows.Forms.Button();
            this.answerButton2 = new System.Windows.Forms.Button();
            this.answerButton3 = new System.Windows.Forms.Button();
            this.answerButton4 = new System.Windows.Forms.Button();
            this.answerButton5 = new System.Windows.Forms.Button();
            this.answerButton6 = new System.Windows.Forms.Button();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.correctLabel = new System.Windows.Forms.Label();
            this.answerLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // answerLayoutPanel
            // 
            this.answerLayoutPanel.Controls.Add(this.answerButton1);
            this.answerLayoutPanel.Controls.Add(this.answerButton2);
            this.answerLayoutPanel.Controls.Add(this.answerButton3);
            this.answerLayoutPanel.Controls.Add(this.answerButton4);
            this.answerLayoutPanel.Controls.Add(this.answerButton5);
            this.answerLayoutPanel.Controls.Add(this.answerButton6);
            this.answerLayoutPanel.Location = new System.Drawing.Point(12, 130);
            this.answerLayoutPanel.Name = "answerLayoutPanel";
            this.answerLayoutPanel.Size = new System.Drawing.Size(526, 207);
            this.answerLayoutPanel.TabIndex = 0;
            // 
            // answerButton1
            // 
            this.answerButton1.Location = new System.Drawing.Point(3, 3);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(75, 23);
            this.answerButton1.TabIndex = 0;
            this.answerButton1.Text = "button1";
            this.answerButton1.UseVisualStyleBackColor = true;
            this.answerButton1.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // answerButton2
            // 
            this.answerButton2.Location = new System.Drawing.Point(84, 3);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(75, 23);
            this.answerButton2.TabIndex = 1;
            this.answerButton2.Text = "button2";
            this.answerButton2.UseVisualStyleBackColor = true;
            this.answerButton2.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // answerButton3
            // 
            this.answerButton3.Location = new System.Drawing.Point(165, 3);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(75, 23);
            this.answerButton3.TabIndex = 2;
            this.answerButton3.Text = "button3";
            this.answerButton3.UseVisualStyleBackColor = true;
            this.answerButton3.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // answerButton4
            // 
            this.answerButton4.Location = new System.Drawing.Point(246, 3);
            this.answerButton4.Name = "answerButton4";
            this.answerButton4.Size = new System.Drawing.Size(75, 23);
            this.answerButton4.TabIndex = 3;
            this.answerButton4.Text = "button4";
            this.answerButton4.UseVisualStyleBackColor = true;
            this.answerButton4.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // answerButton5
            // 
            this.answerButton5.Location = new System.Drawing.Point(327, 3);
            this.answerButton5.Name = "answerButton5";
            this.answerButton5.Size = new System.Drawing.Size(75, 23);
            this.answerButton5.TabIndex = 4;
            this.answerButton5.Text = "button5";
            this.answerButton5.UseVisualStyleBackColor = true;
            this.answerButton5.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // answerButton6
            // 
            this.answerButton6.Location = new System.Drawing.Point(408, 3);
            this.answerButton6.Name = "answerButton6";
            this.answerButton6.Size = new System.Drawing.Size(75, 23);
            this.answerButton6.TabIndex = 5;
            this.answerButton6.Text = "button6";
            this.answerButton6.UseVisualStyleBackColor = true;
            this.answerButton6.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songNameLabel.Location = new System.Drawing.Point(46, 39);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(89, 20);
            this.songNameLabel.TabIndex = 1;
            this.songNameLabel.Text = "SongName";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(367, 56);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(69, 26);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score";
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(12, 343);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(94, 27);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLabel.Location = new System.Drawing.Point(365, 13);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(79, 29);
            this.correctLabel.TabIndex = 4;
            this.correctLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 400);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.songNameLabel);
            this.Controls.Add(this.answerLayoutPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.answerLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel answerLayoutPanel;
        private System.Windows.Forms.Label songNameLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button answerButton1;
        private System.Windows.Forms.Button answerButton2;
        private System.Windows.Forms.Button answerButton3;
        private System.Windows.Forms.Button answerButton4;
        private System.Windows.Forms.Button answerButton5;
        private System.Windows.Forms.Button answerButton6;
        private System.Windows.Forms.Label correctLabel;
    }
}

