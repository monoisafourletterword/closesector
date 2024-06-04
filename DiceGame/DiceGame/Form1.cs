using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form1 : Form
    {
        private Game game;
        private int currentPlayerIndex = 0;
        private List<TextBox> playerNameTextBoxes = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();

            
            btnRollDice.Image = Image.FromFile("C:\\Users\\user\\Documents\\dice.png");
            btnRollDice.ImageAlign = ContentAlignment.MiddleLeft;
            btnRollDice.TextAlign = ContentAlignment.MiddleRight;

            btnRollDice.Size = new Size(120, 40);
            btnRollDice.Image = new Bitmap(btnRollDice.Image, new Size(32, 32));
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            int numberOfPlayers = (int)numericUpDownPlayers.Value;
            playerNameTextBoxes.Clear();

            Form nameInputForm = new Form
            {
                Text = "Введите имена игроков",
                Size = new Size(300, 90 + numberOfPlayers * 30)
            };

            for (int i = 0; i < numberOfPlayers; i++)
            {
                var textBox = new TextBox
                {
                    Location = new Point(10, 10 + i * 30),
                    Size = new Size(260, 20),
                    Text = "Игрок " + (i + 1)
                };
                nameInputForm.Controls.Add(textBox);
                playerNameTextBoxes.Add(textBox);
            }

            var btnConfirm = new Button
            {
                Text = "Подтвердить",
                Location = new Point(10, 10 + numberOfPlayers * 30),
                Size = new Size(260, 30)
            };
            btnConfirm.Click += (s, ev) =>
            {
                List<string> playerNames = playerNameTextBoxes.Select(tb => tb.Text).ToList();
                game = new Game(1, numberOfPlayers);
                game.StartNewGame(playerNames);
                MessageBox.Show("Игра началась с " + numberOfPlayers + " игроками.");
                currentPlayerIndex = 0;
                UpdateSectors();
                UpdateCurrentPlayer();
                lblRolledSum.Text = "Сумма броска: 0";
                UpdatePlayerPenalties();
                nameInputForm.Close();
            };
            nameInputForm.Controls.Add(btnConfirm);

            nameInputForm.ShowDialog();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            if (game != null)
            {
                Round currentRound = game.Rounds[game.Rounds.Count - 1];
                Turn newTurn = new Turn(currentRound.Turns.Count + 1);
                currentRound.AddTurn(newTurn);
                Roll roll;

                // Проверка на закрытие номеров 9, 8 и 7
                if (!game.AvailableSectors.Contains(7) && !game.AvailableSectors.Contains(8) && !game.AvailableSectors.Contains(9))
                {
                    roll = newTurn.RollDice(1); // Один кубик
                }
                else
                {
                    roll = newTurn.RollDice(2); // Два кубика
                }

                MessageBox.Show("Выпало: " + roll.Result);
                lblRolledSum.Text = "Сумма броска: " + roll.Result;
                UpdateSectors();

                if (!newTurn.CanCloseSectors(game, roll.Result))
                {
                    MessageBox.Show("Нет доступных секторов для закрытия. Конец хода.");
                    EndTurn();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, начните игру.");
            }
        }




        private void btnEndGame_Click(object sender, EventArgs e)
        {
            if (game != null)
            {
                foreach (var player in game.Players)
                {
                    player.CalculatePenalty();
                }
                UpdatePlayerPenalties(); // Обновление списка штрафов в конце игры
                game.ShowGameResults();
                MessageBox.Show("Игра завершена.");
            }
            else
            {
                MessageBox.Show("Нет активной игры для завершения.");
            }
        }

        private void btnCloseSectors_Click(object sender, EventArgs e)
        {
            if (game != null)
            {
                int sector1 = (int)numericUpDownSector1.Value;
                int sector2 = (int)numericUpDownSector2.Value;
                if (sector1 != sector2 && game.CloseSectors(sector1, sector2))
                {
                    game.Players[currentPlayerIndex].SaveAvailableSectorsAtEnd(new List<int>(game.AvailableSectors));
                    game.Players[currentPlayerIndex].CalculatePenalty();
                    UpdateSectors();
                    UpdatePlayerPenalties();
                    EndTurn();
                }
                else
                {
                    MessageBox.Show("Невозможно закрыть выбранные сектора.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, начните игру.");
            }
        }


        private void EndTurn()
        {
            game.Players[currentPlayerIndex].CalculatePenalty();
            currentPlayerIndex = (currentPlayerIndex + 1) % game.PlayerCount;
            UpdateCurrentPlayer();
            UpdatePlayerPenalties(); // Обновление списка штрафов после каждого хода
        }

        private void UpdateSectors()
        {
            listBoxSectors.Items.Clear();
            foreach (var sector in game.AvailableSectors)
            {
                listBoxSectors.Items.Add(sector);
            }
        }

        private void UpdateCurrentPlayer()
        {
            lblCurrentPlayer.Text = $"Текущий игрок: {game.Players[currentPlayerIndex].Name}";
        }

        private void UpdatePlayerPenalties()
        {
            listBoxPlayerPenalties.Items.Clear();
            foreach (var player in game.Players)
            {
                player.CalculatePenalty();
                listBoxPlayerPenalties.Items.Add($"{player.Name}: штраф {player.Penalty}");
            }
        }
    }
}
