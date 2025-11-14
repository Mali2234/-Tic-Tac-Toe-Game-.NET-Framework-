namespace tictactoe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Main container split into two columns: Game Grid & Controls.
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel gameGridPanel;
        private System.Windows.Forms.TableLayoutPanel controlPanel;
        private System.Windows.Forms.TableLayoutPanel scorePanel;
        private System.Windows.Forms.TableLayoutPanel buttonPanel;

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox turnIndicator;
        private System.Windows.Forms.TextBox scorePlayer;
        private System.Windows.Forms.TextBox scoreComputer;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button pauseGameBtn;
        private System.Windows.Forms.TextBox winDisplay;

        private System.Windows.Forms.Button r1c1;
        private System.Windows.Forms.Button r1c2;
        private System.Windows.Forms.Button r1c3;
        private System.Windows.Forms.Button r2c1;
        private System.Windows.Forms.Button r2c2;
        private System.Windows.Forms.Button r2c3;
        private System.Windows.Forms.Button r3c1;
        private System.Windows.Forms.Button r3c2;
        private System.Windows.Forms.Button r3c3;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gameGridPanel = new System.Windows.Forms.TableLayoutPanel();
            this.r1c1 = new System.Windows.Forms.Button();
            this.r1c2 = new System.Windows.Forms.Button();
            this.r1c3 = new System.Windows.Forms.Button();
            this.r2c1 = new System.Windows.Forms.Button();
            this.r2c2 = new System.Windows.Forms.Button();
            this.r2c3 = new System.Windows.Forms.Button();
            this.r3c1 = new System.Windows.Forms.Button();
            this.r3c2 = new System.Windows.Forms.Button();
            this.r3c3 = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.turnIndicator = new System.Windows.Forms.TextBox();
            this.scorePanel = new System.Windows.Forms.TableLayoutPanel();
            this.scorePlayer = new System.Windows.Forms.TextBox();
            this.scoreComputer = new System.Windows.Forms.TextBox();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.pauseGameBtn = new System.Windows.Forms.Button();
            this.winDisplay = new System.Windows.Forms.TextBox();
            this.mainTableLayoutPanel.SuspendLayout();
            this.gameGridPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.scorePanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTableLayoutPanel.Controls.Add(this.gameGridPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.controlPanel, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(930, 620);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // gameGridPanel
            // 
            this.gameGridPanel.ColumnCount = 3;
            this.gameGridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.gameGridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.gameGridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.gameGridPanel.Controls.Add(this.r1c1, 0, 0);
            this.gameGridPanel.Controls.Add(this.r1c2, 1, 0);
            this.gameGridPanel.Controls.Add(this.r1c3, 2, 0);
            this.gameGridPanel.Controls.Add(this.r2c1, 0, 1);
            this.gameGridPanel.Controls.Add(this.r2c2, 1, 1);
            this.gameGridPanel.Controls.Add(this.r2c3, 2, 1);
            this.gameGridPanel.Controls.Add(this.r3c1, 0, 2);
            this.gameGridPanel.Controls.Add(this.r3c2, 1, 2);
            this.gameGridPanel.Controls.Add(this.r3c3, 2, 2);
            this.gameGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameGridPanel.Location = new System.Drawing.Point(3, 3);
            this.gameGridPanel.Name = "gameGridPanel";
            this.gameGridPanel.RowCount = 3;
            this.gameGridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.gameGridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.gameGridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.gameGridPanel.Size = new System.Drawing.Size(645, 614);
            this.gameGridPanel.TabIndex = 0;
            // 
            // r1c1
            // 
            this.r1c1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r1c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.r1c1.Location = new System.Drawing.Point(3, 3);
            this.r1c1.Name = "r1c1";
            this.r1c1.Size = new System.Drawing.Size(209, 198);
            this.r1c1.TabIndex = 0;
            this.r1c1.UseVisualStyleBackColor = true;
            // 
            // r1c2
            // 
            this.r1c2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r1c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.r1c2.Location = new System.Drawing.Point(218, 3);
            this.r1c2.Name = "r1c2";
            this.r1c2.Size = new System.Drawing.Size(209, 198);
            this.r1c2.TabIndex = 1;
            this.r1c2.UseVisualStyleBackColor = true;
            // 
            // r1c3
            // 
            this.r1c3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r1c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.r1c3.Location = new System.Drawing.Point(433, 3);
            this.r1c3.Name = "r1c3";
            this.r1c3.Size = new System.Drawing.Size(209, 198);
            this.r1c3.TabIndex = 2;
            this.r1c3.UseVisualStyleBackColor = true;
            // 
            // r2c1
            // 
            this.r2c1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r2c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.r2c1.Location = new System.Drawing.Point(3, 207);
            this.r2c1.Name = "r2c1";
            this.r2c1.Size = new System.Drawing.Size(209, 198);
            this.r2c1.TabIndex = 3;
            this.r2c1.UseVisualStyleBackColor = true;
            // 
            // r2c2
            // 
            this.r2c2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r2c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.r2c2.Location = new System.Drawing.Point(218, 207);
            this.r2c2.Name = "r2c2";
            this.r2c2.Size = new System.Drawing.Size(209, 198);
            this.r2c2.TabIndex = 4;
            this.r2c2.UseVisualStyleBackColor = true;
            // 
            // r2c3
            // 
            this.r2c3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r2c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.r2c3.Location = new System.Drawing.Point(433, 207);
            this.r2c3.Name = "r2c3";
            this.r2c3.Size = new System.Drawing.Size(209, 198);
            this.r2c3.TabIndex = 5;
            this.r2c3.UseVisualStyleBackColor = true;
            // 
            // r3c1
            // 
            this.r3c1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r3c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.r3c1.Location = new System.Drawing.Point(3, 411);
            this.r3c1.Name = "r3c1";
            this.r3c1.Size = new System.Drawing.Size(209, 200);
            this.r3c1.TabIndex = 6;
            this.r3c1.UseVisualStyleBackColor = true;
            // 
            // r3c2
            // 
            this.r3c2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r3c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.r3c2.Location = new System.Drawing.Point(218, 411);
            this.r3c2.Name = "r3c2";
            this.r3c2.Size = new System.Drawing.Size(209, 200);
            this.r3c2.TabIndex = 7;
            this.r3c2.UseVisualStyleBackColor = true;
            // 
            // r3c3
            // 
            this.r3c3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r3c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.r3c3.Location = new System.Drawing.Point(433, 411);
            this.r3c3.Name = "r3c3";
            this.r3c3.Size = new System.Drawing.Size(209, 200);
            this.r3c3.TabIndex = 8;
            this.r3c3.UseVisualStyleBackColor = true;
            // 
            // controlPanel
            // 
            this.controlPanel.ColumnCount = 1;
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel.Controls.Add(this.titleLabel, 0, 0);
            this.controlPanel.Controls.Add(this.turnIndicator, 0, 1);
            this.controlPanel.Controls.Add(this.scorePanel, 0, 2);
            this.controlPanel.Controls.Add(this.buttonPanel, 0, 3);
            this.controlPanel.Controls.Add(this.winDisplay, 0, 4);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(654, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.RowCount = 5;
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel.Size = new System.Drawing.Size(273, 614);
            this.controlPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(267, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Tic Tac Toe";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turnIndicator
            // 
            this.turnIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.turnIndicator.Location = new System.Drawing.Point(3, 40);
            this.turnIndicator.Name = "turnIndicator";
            this.turnIndicator.ReadOnly = true;
            this.turnIndicator.Size = new System.Drawing.Size(267, 26);
            this.turnIndicator.TabIndex = 1;
            this.turnIndicator.Text = "Turn:";
            // 
            // scorePanel
            // 
            this.scorePanel.ColumnCount = 2;
            this.scorePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scorePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scorePanel.Controls.Add(this.scorePlayer, 0, 0);
            this.scorePanel.Controls.Add(this.scoreComputer, 1, 0);
            this.scorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scorePanel.Location = new System.Drawing.Point(3, 77);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.RowCount = 1;
            this.scorePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.scorePanel.Size = new System.Drawing.Size(267, 50);
            this.scorePanel.TabIndex = 2;
            // 
            // scorePlayer
            // 
            this.scorePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scorePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorePlayer.Location = new System.Drawing.Point(3, 3);
            this.scorePlayer.Name = "scorePlayer";
            this.scorePlayer.ReadOnly = true;
            this.scorePlayer.Size = new System.Drawing.Size(127, 20);
            this.scorePlayer.TabIndex = 0;
            this.scorePlayer.Text = "Player: 0";
            // 
            // scoreComputer
            // 
            this.scoreComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreComputer.Location = new System.Drawing.Point(136, 3);
            this.scoreComputer.Name = "scoreComputer";
            this.scoreComputer.ReadOnly = true;
            this.scoreComputer.Size = new System.Drawing.Size(128, 20);
            this.scoreComputer.TabIndex = 1;
            this.scoreComputer.Text = "Computer: 0";
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 2;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.Controls.Add(this.newGameBtn, 0, 0);
            this.buttonPanel.Controls.Add(this.pauseGameBtn, 1, 0);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(3, 133);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 1;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonPanel.Size = new System.Drawing.Size(267, 50);
            this.buttonPanel.TabIndex = 3;
            // 
            // newGameBtn
            // 
            this.newGameBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.newGameBtn.Location = new System.Drawing.Point(3, 3);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(127, 44);
            this.newGameBtn.TabIndex = 0;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // pauseGameBtn
            // 
            this.pauseGameBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pauseGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.pauseGameBtn.Location = new System.Drawing.Point(136, 3);
            this.pauseGameBtn.Name = "pauseGameBtn";
            this.pauseGameBtn.Size = new System.Drawing.Size(128, 44);
            this.pauseGameBtn.TabIndex = 1;
            this.pauseGameBtn.Text = "Stop Game";
            this.pauseGameBtn.UseVisualStyleBackColor = true;
            this.pauseGameBtn.Click += new System.EventHandler(this.PauseGame_Click);
            // 
            // winDisplay
            // 
            this.winDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.winDisplay.Location = new System.Drawing.Point(3, 189);
            this.winDisplay.Name = "winDisplay";
            this.winDisplay.ReadOnly = true;
            this.winDisplay.Size = new System.Drawing.Size(267, 29);
            this.winDisplay.TabIndex = 4;
            this.winDisplay.Text = "Winner:";
            this.winDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 620);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(688, 467);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.gameGridPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
