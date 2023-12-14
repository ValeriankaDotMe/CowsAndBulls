namespace CowsAndBulls
{
    partial class MainMenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.chosenDifficulty = new System.Windows.Forms.ComboBox();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.highScoresBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cows And Bulls";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.Location = new System.Drawing.Point(13, 121);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(138, 31);
            this.difficultyLabel.TabIndex = 1;
            this.difficultyLabel.Text = "Difficulty:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(13, 78);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(156, 31);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Username:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.Location = new System.Drawing.Point(175, 78);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(192, 38);
            this.usernameTextbox.TabIndex = 3;
            // 
            // chosenDifficulty
            // 
            this.chosenDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chosenDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenDifficulty.FormattingEnabled = true;
            this.chosenDifficulty.Items.AddRange(new object[] {
            "Normal",
            "Hard"});
            this.chosenDifficulty.Location = new System.Drawing.Point(157, 121);
            this.chosenDifficulty.Name = "chosenDifficulty";
            this.chosenDifficulty.Size = new System.Drawing.Size(210, 39);
            this.chosenDifficulty.TabIndex = 4;
            this.chosenDifficulty.SelectedIndexChanged += new System.EventHandler(this.chosenDifficulty_SelectedIndexChanged);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.Location = new System.Drawing.Point(19, 291);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(348, 45);
            this.PlayBtn.TabIndex = 5;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // highScoresBtn
            // 
            this.highScoresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoresBtn.Location = new System.Drawing.Point(19, 342);
            this.highScoresBtn.Name = "highScoresBtn";
            this.highScoresBtn.Size = new System.Drawing.Size(348, 45);
            this.highScoresBtn.TabIndex = 6;
            this.highScoresBtn.Text = "High Scores";
            this.highScoresBtn.UseVisualStyleBackColor = true;
            this.highScoresBtn.Click += new System.EventHandler(this.highScoresBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(19, 393);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(348, 45);
            this.quitBtn.TabIndex = 7;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(373, 12);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(415, 426);
            this.descriptionBox.TabIndex = 8;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.highScoresBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.chosenDifficulty);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cows And Bulls";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.ComboBox chosenDifficulty;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button highScoresBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.TextBox descriptionBox;
    }
}

