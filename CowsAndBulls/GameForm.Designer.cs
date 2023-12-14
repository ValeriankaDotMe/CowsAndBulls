namespace CowsAndBulls
{
    partial class GameForm
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
            this.actionsLogPanel = new System.Windows.Forms.GroupBox();
            this.actionsLog = new System.Windows.Forms.TextBox();
            this.quitBtn = new System.Windows.Forms.Button();
            this.guessBtn = new System.Windows.Forms.Button();
            this.digit1 = new System.Windows.Forms.NumericUpDown();
            this.digit2 = new System.Windows.Forms.NumericUpDown();
            this.digit3 = new System.Windows.Forms.NumericUpDown();
            this.digit4 = new System.Windows.Forms.NumericUpDown();
            this.actionsLogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit4)).BeginInit();
            this.SuspendLayout();
            // 
            // actionsLogPanel
            // 
            this.actionsLogPanel.Controls.Add(this.actionsLog);
            this.actionsLogPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionsLogPanel.Location = new System.Drawing.Point(12, 12);
            this.actionsLogPanel.Name = "actionsLogPanel";
            this.actionsLogPanel.Size = new System.Drawing.Size(776, 314);
            this.actionsLogPanel.TabIndex = 0;
            this.actionsLogPanel.TabStop = false;
            this.actionsLogPanel.Text = "Actions Log";
            // 
            // actionsLog
            // 
            this.actionsLog.Location = new System.Drawing.Point(7, 31);
            this.actionsLog.Multiline = true;
            this.actionsLog.Name = "actionsLog";
            this.actionsLog.ReadOnly = true;
            this.actionsLog.Size = new System.Drawing.Size(763, 277);
            this.actionsLog.TabIndex = 0;
            // 
            // quitBtn
            // 
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(609, 397);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(179, 41);
            this.quitBtn.TabIndex = 1;
            this.quitBtn.Text = "Main Menu";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // guessBtn
            // 
            this.guessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBtn.Location = new System.Drawing.Point(259, 350);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(179, 41);
            this.guessBtn.TabIndex = 2;
            this.guessBtn.Text = "Guess!";
            this.guessBtn.UseVisualStyleBackColor = true;
            this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
            // 
            // digit1
            // 
            this.digit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit1.Location = new System.Drawing.Point(19, 347);
            this.digit1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(54, 44);
            this.digit1.TabIndex = 3;
            // 
            // digit2
            // 
            this.digit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit2.Location = new System.Drawing.Point(79, 347);
            this.digit2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(54, 44);
            this.digit2.TabIndex = 4;
            // 
            // digit3
            // 
            this.digit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit3.Location = new System.Drawing.Point(139, 347);
            this.digit3.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(54, 44);
            this.digit3.TabIndex = 5;
            // 
            // digit4
            // 
            this.digit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit4.Location = new System.Drawing.Point(199, 347);
            this.digit4.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(54, 44);
            this.digit4.TabIndex = 6;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit1);
            this.Controls.Add(this.guessBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.actionsLogPanel);
            this.Name = "GameForm";
            this.Text = "Cows and Bulls";
            this.actionsLogPanel.ResumeLayout(false);
            this.actionsLogPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox actionsLogPanel;
        private System.Windows.Forms.TextBox actionsLog;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.NumericUpDown digit1;
        private System.Windows.Forms.NumericUpDown digit2;
        private System.Windows.Forms.NumericUpDown digit3;
        private System.Windows.Forms.NumericUpDown digit4;
    }
}