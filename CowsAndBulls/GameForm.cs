using CowsAndBulls.Database;
using CowsAndBulls.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CowsAndBulls
{
    public partial class GameForm : Form
    {
        private string difficulty;

        private int generatedNumberLength;

        private string generatedNumber;
        private string guessedNumber;

        private int turnsPlayed;
        private int maxTurns;

        private Player player;
        private uint currentScore;

        public GameForm(string difficulty, string username)
        {
            InitializeComponent();

            player = new Player(username);

            currentScore = 0;

            this.difficulty = difficulty;
            switch (difficulty)
            {
                case "Normal":
                    maxTurns = 15;
                    break;
                case "Hard":
                    maxTurns = 10;
                    break;
                default:
                    break;
            }

            this.generatedNumberLength = 4;
            this.generatedNumber = GenerateNumber(this.difficulty, this.generatedNumberLength);
            turnsPlayed = 0;

            actionsLog.AppendText(String.Format("{0} started a new game. Difficulty: {1}.\r\n", player.Username, this.difficulty));
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guessBtn_Click(object sender, EventArgs e)
        {
            guessedNumber = digit1.Value.ToString() +
                digit2.Value.ToString() +
                digit3.Value.ToString() +
                digit4.Value.ToString();

            HandleTurn(guessedNumber);
        }

        private string GenerateNumber(string difficulty, int numberLength)
        {
            string number = "";

            Random random = new Random();

            if (difficulty == "Normal")
            {
                while (number.Length < numberLength)
                {
                    string temp = random.Next(0, 9).ToString();
                    if (number.Length == 0 && temp == "0")
                    {
                        continue;
                    }
                    else if (number.Contains(temp))
                    {
                        continue;
                    }
                    else
                    {
                        number += temp;
                    }
                }
            }
            else if (difficulty == "Hard")
            {
                for (int i = 0; i < numberLength; i++)
                {
                    number += random.Next(0, 9).ToString();
                }
            }

            //debug: show number
            //actionsLog.AppendText(number + "\n");
            return number;
        }

        private void HandleTurn(string guessedNumber)
        {
            if (guessedNumber == this.generatedNumber)
            {
                GameOver("Player");
            }
            else
            {
                int[] cowsAndBulls = CountCowsAndBulls();
                int cows = cowsAndBulls[0];
                int bulls = cowsAndBulls[1];

                // add points for each bull
                switch (difficulty)
                {
                    case "Normal":
                        // add 1 point on Normal mode
                        currentScore += (uint)bulls;
                        break;
                    case "Hard":
                        // add 2 points on Hard mode
                        currentScore += (uint)bulls * 2;
                        break;
                    default:
                        break;
                }

                LogResult(cows, bulls, guessedNumber);

                if (maxTurns == ++turnsPlayed)
                {
                    GameOver("Computer");
                }
            }
        }

        private int[] CountCowsAndBulls()
        {
            int bulls = 0;
            int cows = 0;

            bool[] isGuessVisted = new bool[generatedNumber.Length];
            bool[] isNumVisted = new bool[generatedNumber.Length];

            // count bulls and cows
            for (int i = 0; i < generatedNumber.Length; i++)
            {
                if (guessedNumber[i] == generatedNumber[i])
                {
                    bulls++;
                    isGuessVisted[i] = true; // set that we have visited this digit at index i
                    isNumVisted[i] = true; // set that we have visited this digit at index i
                }
            }

            for (int i = 0; i < guessedNumber.Length; i++)
            {
                for (int j = 0; j < generatedNumber.Length; j++)
                {
                    if (i != j &&
                        !isNumVisted[j] &&
                        !isGuessVisted[i] &&
                        guessedNumber[i] == generatedNumber[j]) // check if digits are the same
                    {
                        cows++;
                        isGuessVisted[i] = true; // set that we have visited this digit at index i
                        isNumVisted[j] = true; // set that we have visited this digit at index j
                    }
                }
            }

            return new int[] { cows, bulls };
        }

        private void GameOver(string winner)
        {
            if (winner == "Player")
            {
                winner = player.Username;

                // add points for winning
                switch (difficulty)
                {
                    case "Normal":
                        // add 50 points on Normal mode
                        currentScore += 50;
                        break;
                    case "Hard":
                        // add 100 points on Hard mode
                        currentScore += 100;
                        break;
                    default:
                        break;
                }
            }

            if (player.Username != "Guest")
            {
                if (!PlayerBase.ContainsPlayer(player.Username))
                {
                    PlayerBase.AddPlayer(player);
                }

                player = PlayerBase.GetPlayer(player.Username);
            }

            player.PlayGame();
            player.AddScore(currentScore);

            actionsLog.AppendText(String.Format("Game over! {0} won! The number was: {1}\r\n", winner, generatedNumber));
            actionsLog.AppendText(String.Format("Player: {0}. Games played: {1}. Highscore: {2}\r\n", player.Username, player.GamesPlayed, player.HighScore));

            guessBtn.Hide();
        }

        private void LogResult(int cows, int bulls, string guessedNumber)
        {
            actionsLog.AppendText(String.Format("Guess: {0}. Cows: {1}, Bulls: {2}\r\n", guessedNumber, cows, bulls));
        }
    }
}
