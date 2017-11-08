namespace TicTacToe
{
    partial class TicTacToe
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
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.textNext = new System.Windows.Forms.TextBox();
            this.nextPlayer = new System.Windows.Forms.Label();
            this.newGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(12, 12);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(60, 60);
            this.bt1.TabIndex = 0;
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.btClick);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(78, 12);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(60, 60);
            this.bt2.TabIndex = 1;
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.btClick);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(144, 12);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(60, 60);
            this.bt3.TabIndex = 2;
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.btClick);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(144, 78);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(60, 60);
            this.bt6.TabIndex = 5;
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.btClick);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(78, 78);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(60, 60);
            this.bt5.TabIndex = 4;
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.btClick);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(12, 78);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(60, 60);
            this.bt4.TabIndex = 3;
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.btClick);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(144, 144);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(60, 60);
            this.bt9.TabIndex = 8;
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.btClick);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(78, 144);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(60, 60);
            this.bt8.TabIndex = 7;
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.btClick);
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(12, 144);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(60, 60);
            this.bt7.TabIndex = 6;
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.btClick);
            // 
            // textNext
            // 
            this.textNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNext.Location = new System.Drawing.Point(221, 80);
            this.textNext.Name = "textNext";
            this.textNext.ReadOnly = true;
            this.textNext.Size = new System.Drawing.Size(70, 58);
            this.textNext.TabIndex = 10;
            this.textNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextPlayer
            // 
            this.nextPlayer.AutoSize = true;
            this.nextPlayer.Location = new System.Drawing.Point(218, 64);
            this.nextPlayer.Name = "nextPlayer";
            this.nextPlayer.Size = new System.Drawing.Size(73, 13);
            this.nextPlayer.TabIndex = 11;
            this.nextPlayer.Text = "Next player is:";
            // 
            // newGame
            // 
            this.newGame.AutoSize = true;
            this.newGame.Location = new System.Drawing.Point(167, 207);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(124, 13);
            this.newGame.TabIndex = 12;
            this.newGame.Text = "Press here for new game";
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 225);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.nextPlayer);
            this.Controls.Add(this.textNext);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.TextBox textNext;
        private System.Windows.Forms.Label nextPlayer;
        private System.Windows.Forms.Label newGame;
    }
}

