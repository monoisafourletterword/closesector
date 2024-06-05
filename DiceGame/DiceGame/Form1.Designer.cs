using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace DiceGame
{
    partial class DiceGameForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnStartGame;
        private Button btnRollDice;
        private Button btnEndGame;
        private Button btnCloseSectors;
        private NumericUpDown numericUpDownPlayers;
        private NumericUpDown numericUpDownSector1;
        private NumericUpDown numericUpDownSector2;
        private ListBox listBoxSectors;
        private ListBox listBoxPlayerPenalties;
        private Label lblPlayers;
        private Label lblSector1;
        private Label lblSector2;
        private Label lblCurrentPlayer;
        private Label lblRolledSum;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.btnCloseSectors = new System.Windows.Forms.Button();
            this.numericUpDownPlayers = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSector1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSector2 = new System.Windows.Forms.NumericUpDown();
            this.listBoxSectors = new System.Windows.Forms.ListBox();
            this.listBoxPlayerPenalties = new System.Windows.Forms.ListBox();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lblSector1 = new System.Windows.Forms.Label();
            this.lblSector2 = new System.Windows.Forms.Label();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.lblRolledSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSector1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSector2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(15, 37);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Начать игру";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(15, 76);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(156, 50);
            this.btnRollDice.TabIndex = 1;
            this.btnRollDice.Text = "Бросить кости";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.Location = new System.Drawing.Point(96, 37);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(75, 23);
            this.btnEndGame.TabIndex = 2;
            this.btnEndGame.Text = "Завершить игру";
            this.btnEndGame.UseVisualStyleBackColor = true;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // btnCloseSectors
            // 
            this.btnCloseSectors.Location = new System.Drawing.Point(15, 181);
            this.btnCloseSectors.Name = "btnCloseSectors";
            this.btnCloseSectors.Size = new System.Drawing.Size(156, 23);
            this.btnCloseSectors.TabIndex = 3;
            this.btnCloseSectors.Text = "Закрыть сектора";
            this.btnCloseSectors.UseVisualStyleBackColor = true;
            this.btnCloseSectors.Click += new System.EventHandler(this.btnCloseSectors_Click);
            // 
            // numericUpDownPlayers
            // 
            this.numericUpDownPlayers.Location = new System.Drawing.Point(131, 10);
            this.numericUpDownPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownPlayers.Name = "numericUpDownPlayers";
            this.numericUpDownPlayers.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownPlayers.TabIndex = 4;
            this.numericUpDownPlayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownSector1
            // 
            this.numericUpDownSector1.Location = new System.Drawing.Point(15, 155);
            this.numericUpDownSector1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSector1.Name = "numericUpDownSector1";
            this.numericUpDownSector1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownSector1.TabIndex = 5;
            this.numericUpDownSector1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownSector2
            // 
            this.numericUpDownSector2.Location = new System.Drawing.Point(96, 155);
            this.numericUpDownSector2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSector2.Name = "numericUpDownSector2";
            this.numericUpDownSector2.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownSector2.TabIndex = 6;
            // 
            // listBoxSectors
            // 
            this.listBoxSectors.FormattingEnabled = true;
            this.listBoxSectors.Location = new System.Drawing.Point(192, 12);
            this.listBoxSectors.Name = "listBoxSectors";
            this.listBoxSectors.Size = new System.Drawing.Size(120, 160);
            this.listBoxSectors.TabIndex = 7;
            // 
            // listBoxPlayerPenalties
            // 
            this.listBoxPlayerPenalties.FormattingEnabled = true;
            this.listBoxPlayerPenalties.Location = new System.Drawing.Point(192, 181);
            this.listBoxPlayerPenalties.Name = "listBoxPlayerPenalties";
            this.listBoxPlayerPenalties.Size = new System.Drawing.Size(120, 82);
            this.listBoxPlayerPenalties.TabIndex = 13;
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Location = new System.Drawing.Point(12, 12);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(113, 13);
            this.lblPlayers.TabIndex = 8;
            this.lblPlayers.Text = "Количество игроков:";
            // 
            // lblSector1
            // 
            this.lblSector1.AutoSize = true;
            this.lblSector1.Location = new System.Drawing.Point(12, 139);
            this.lblSector1.Name = "lblSector1";
            this.lblSector1.Size = new System.Drawing.Size(55, 13);
            this.lblSector1.TabIndex = 9;
            this.lblSector1.Text = "Сектор 1:";
            // 
            // lblSector2
            // 
            this.lblSector2.AutoSize = true;
            this.lblSector2.Location = new System.Drawing.Point(93, 139);
            this.lblSector2.Name = "lblSector2";
            this.lblSector2.Size = new System.Drawing.Size(55, 13);
            this.lblSector2.TabIndex = 10;
            this.lblSector2.Text = "Сектор 2:";
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(12, 217);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(87, 13);
            this.lblCurrentPlayer.TabIndex = 11;
            this.lblCurrentPlayer.Text = "Текущий игрок:";
            // 
            // lblRolledSum
            // 
            this.lblRolledSum.AutoSize = true;
            this.lblRolledSum.Location = new System.Drawing.Point(12, 240);
            this.lblRolledSum.Name = "lblRolledSum";
            this.lblRolledSum.Size = new System.Drawing.Size(83, 13);
            this.lblRolledSum.TabIndex = 12;
            this.lblRolledSum.Text = "Сумма броска:";
            // 
            // DiceGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 330);
            this.Controls.Add(this.listBoxPlayerPenalties);
            this.Controls.Add(this.lblRolledSum);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.lblSector2);
            this.Controls.Add(this.lblSector1);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.listBoxSectors);
            this.Controls.Add(this.numericUpDownSector2);
            this.Controls.Add(this.numericUpDownSector1);
            this.Controls.Add(this.numericUpDownPlayers);
            this.Controls.Add(this.btnCloseSectors);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.btnStartGame);
            this.Name = "DiceGameForm";
            this.Text = "Игра в кости";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSector1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSector2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
