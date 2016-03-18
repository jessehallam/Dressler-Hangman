namespace dresslerAssign2
{
    partial class hangmanForm
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
            this.hangmanPictureBox = new System.Windows.Forms.PictureBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.targetTB = new System.Windows.Forms.TextBox();
            this.guessesLabel = new System.Windows.Forms.Label();
            this.guessesTB = new System.Windows.Forms.TextBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.wonLabel = new System.Windows.Forms.Label();
            this.wonTB = new System.Windows.Forms.TextBox();
            this.lossesLabel = new System.Windows.Forms.Label();
            this.lossesTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // hangmanPictureBox
            // 
            this.hangmanPictureBox.Image = global::dresslerAssign2.Properties.Resources.hangman0;
            this.hangmanPictureBox.Location = new System.Drawing.Point(52, 26);
            this.hangmanPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.hangmanPictureBox.Name = "hangmanPictureBox";
            this.hangmanPictureBox.Size = new System.Drawing.Size(267, 256);
            this.hangmanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangmanPictureBox.TabIndex = 0;
            this.hangmanPictureBox.TabStop = false;
            this.hangmanPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.targetLabel.Location = new System.Drawing.Point(367, 72);
            this.targetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(69, 25);
            this.targetLabel.TabIndex = 1;
            this.targetLabel.Text = "Target";
            // 
            // targetTB
            // 
            this.targetTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.targetTB.Location = new System.Drawing.Point(524, 70);
            this.targetTB.Margin = new System.Windows.Forms.Padding(2);
            this.targetTB.Name = "targetTB";
            this.targetTB.ReadOnly = true;
            this.targetTB.Size = new System.Drawing.Size(209, 30);
            this.targetTB.TabIndex = 2;
            this.targetTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guessesLabel
            // 
            this.guessesLabel.AutoSize = true;
            this.guessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.guessesLabel.Location = new System.Drawing.Point(367, 162);
            this.guessesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.guessesLabel.Name = "guessesLabel";
            this.guessesLabel.Size = new System.Drawing.Size(90, 25);
            this.guessesLabel.TabIndex = 3;
            this.guessesLabel.Text = "Guesses";
            // 
            // guessesTB
            // 
            this.guessesTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.guessesTB.Location = new System.Drawing.Point(524, 159);
            this.guessesTB.Margin = new System.Windows.Forms.Padding(2);
            this.guessesTB.Name = "guessesTB";
            this.guessesTB.ReadOnly = true;
            this.guessesTB.Size = new System.Drawing.Size(209, 30);
            this.guessesTB.TabIndex = 4;
            this.guessesTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guessesTB_KeyPress);
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.newGameButton.Location = new System.Drawing.Point(148, 320);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(87, 60);
            this.newGameButton.TabIndex = 5;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // wonLabel
            // 
            this.wonLabel.AutoSize = true;
            this.wonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.wonLabel.Location = new System.Drawing.Point(367, 330);
            this.wonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wonLabel.Name = "wonLabel";
            this.wonLabel.Size = new System.Drawing.Size(60, 25);
            this.wonLabel.TabIndex = 6;
            this.wonLabel.Text = "Won:";
            // 
            // wonTB
            // 
            this.wonTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.wonTB.Location = new System.Drawing.Point(434, 327);
            this.wonTB.Margin = new System.Windows.Forms.Padding(2);
            this.wonTB.Name = "wonTB";
            this.wonTB.ReadOnly = true;
            this.wonTB.Size = new System.Drawing.Size(49, 30);
            this.wonTB.TabIndex = 7;
            // 
            // lossesLabel
            // 
            this.lossesLabel.AutoSize = true;
            this.lossesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lossesLabel.Location = new System.Drawing.Point(520, 330);
            this.lossesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lossesLabel.Name = "lossesLabel";
            this.lossesLabel.Size = new System.Drawing.Size(81, 25);
            this.lossesLabel.TabIndex = 8;
            this.lossesLabel.Text = "Losses:";
            // 
            // lossesTB
            // 
            this.lossesTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lossesTB.Location = new System.Drawing.Point(608, 327);
            this.lossesTB.Margin = new System.Windows.Forms.Padding(2);
            this.lossesTB.Name = "lossesTB";
            this.lossesTB.ReadOnly = true;
            this.lossesTB.Size = new System.Drawing.Size(49, 30);
            this.lossesTB.TabIndex = 9;
            // 
            // hangmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 418);
            this.Controls.Add(this.lossesTB);
            this.Controls.Add(this.lossesLabel);
            this.Controls.Add(this.wonTB);
            this.Controls.Add(this.wonLabel);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.guessesTB);
            this.Controls.Add(this.guessesLabel);
            this.Controls.Add(this.targetTB);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.hangmanPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "hangmanForm";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.hangmanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hangmanPictureBox;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.TextBox targetTB;
        private System.Windows.Forms.Label guessesLabel;
        private System.Windows.Forms.TextBox guessesTB;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label wonLabel;
        private System.Windows.Forms.TextBox wonTB;
        private System.Windows.Forms.Label lossesLabel;
        private System.Windows.Forms.TextBox lossesTB;
    }
}

