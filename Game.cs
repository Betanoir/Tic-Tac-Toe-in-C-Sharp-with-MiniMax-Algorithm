using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Game : Form
    {
        bool playerTurn; // if true, its the player's turn, else it is the computer's turn
        int turn_count = 0;
        Button[] buttons;
        string[] board; // an array of all the different values in each button where each can either be "X", "O", or ""
        int winStreak = 0;
        int wins = 0;
        int losses = 0;
        int draws = 0;
        Random random = new();
        int starterBool;

        public Game()
        {
            InitializeComponent();
            buttons = new Button[] { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            board = new string[] { "", "", "", "", "", "", "", "", "" };
        }

        private void Game_Load(object sender, EventArgs e)
        {
            GameReset();
        }

        private void SetAllButtonsDisabled()
        {
            foreach (Button button in buttons) button.Enabled = false;
        }

        private void GameReset()
        {
            foreach (Button button in buttons) button.Text = "";
            for (int i = 0; i < board.Length; i++) board[i] = "";
            SetAllButtonsDisabled();

            turn_count = 0;

            starterBool = random.Next(0, 2);

            btnPlayAgain.Enabled = false;
            btnPlayAgain.BackColor = Color.FromArgb(71, 99, 74);
            lblWinLose.Text = "";

            if (starterBool == 1)
            {
                playerTurn = true;
                foreach (Button button in buttons) button.Enabled = true;
            }
            else
            {
                playerTurn = false;
                AIClick();
            }
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SetAllButtonsDisabled();

            Debug.WriteLine(button.ForeColor);

            button.Text = starterBool == 1 && playerTurn
                ? "X" : starterBool == 0 && !playerTurn
                ? "X" : "O";

            for (int i = 0; i < buttons.Length; i++) 
                if (buttons[i].Name == button.Name) board[i] = button.Text;

            turn_count++;
            playerTurn = !playerTurn;
            string? winner = checkWinner(button.Text);

            if (winner != null) endGame(winner);
            else
            {
                if (!playerTurn) AIClick();
                else foreach (Button buttonGame in buttons) if (buttonGame.Text == "") buttonGame.Enabled = true;
            }
        }

        private string? checkWinner(string XorO)
        {
            string? winner = null;
            // ---
            if ((board[0] == board[1] && board[1] == board[2] && board[1] != "") ||
                (board[3] == board[4] && board[4] == board[5] && board[4] != "") ||
                (board[6] == board[7] && board[7] == board[8] && board[7] != ""))
                winner = XorO;
            // |||
            else if ((board[0] == board[3] && board[3] == board[6] && board[3] != "") ||
                (board[1] == board[4] && board[4] == board[7] && board[4] != "") ||
                (board[2] == board[5] && board[5] == board[8] && board[5] != ""))
                winner = XorO;
            // X
            else if ((board[0] == board[4] && board[4] == board[8] && board[4] != "") ||
                (board[2] == board[4] && board[4] == board[6] && board[4] != ""))
                winner = XorO;

            if (winner == null && turn_count == 9) return "tie";

            int temp_turn_count = 0;
            foreach (string text in board) if (text != "") temp_turn_count++;
            if (winner == null && temp_turn_count == 9) return "tie";

            return winner;
        }

        private void endGame(string? winner)
        {
            SetAllButtonsDisabled();

            switch (starterBool)
            {
                case 1 when winner == "X":
                case 0 when winner == "O":
                    winStreak++;
                    wins++;
                    lblWins.Text = "Wins: " + wins;
                    lblWinStreak.Text = "Win Streak: " + winStreak;
                    lblWinLose.Text = "You Win!";
                    break;
                case 1 when winner == "O":
                case 0 when winner == "X":
                    losses++;
                    winStreak = 0;
                    lblLosses.Text = "Losses: " + losses;
                    lblWinStreak.Text = "Win Streak: " + winStreak;
                    lblWinLose.Text = "You Lose!";
                    break;
                default:
                    draws++;
                    winStreak = 0;
                    lblDraws.Text = "Draws: " + draws;
                    lblWinStreak.Text = "Win Streak: " + winStreak;
                    lblWinLose.Text = "Draw!";
                    break;
            }

            PlayButtonShow();
        }

        private void PlayButtonShow()
        {
            btnPlayAgain.Enabled = true;
            btnPlayAgain.BackColor = Color.FromArgb(192, 255, 192);
        }

        
        private void AIClick()
        {
            int bestScore = starterBool == 0 ? -10 : 10;
            Button bestNextMove = new();

            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == "")
                {
                    // if starterBool == 0 computer is X and therefore it is maximising
                    board[i] = starterBool == 0 ? "X" : "O";
                    int score = minimax(board, board[i], 0, starterBool == 1);
                    board[i] = "";

                    if (starterBool == 0 && score > bestScore)
                    {
                        bestScore = score;
                        bestNextMove = buttons[i];
                    }
                    else if (starterBool == 1 && score < bestScore)
                    {
                        bestScore = score;
                        bestNextMove = buttons[i];
                    }
                }
            }

            bestNextMove.Enabled = true;
            bestNextMove.PerformClick();
        }

        private Dictionary<string, int> scores = new()
        {
            { "X", 1 },
            { "O", -1 },
            { "tie", 0 },
        };
        private int minimax(string[] board, string latestXorO, int depth, bool isMaximising)
        {
            string? result = checkWinner(latestXorO);
            if (result != null)
            {
                return scores[result];
            }

            if (isMaximising)
            {
                int bestScore = -10; // Low number due to algorithm trying to find the highest possible number
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == "")
                    {
                        // if starterBool == 0 computer is X and therefore it is maximising
                        board[i] = latestXorO == "X" ? "O" : "X";
                        int score = minimax(board, board[i], depth + 1, false);
                        board[i] = "";

                        bestScore = Math.Max(score, bestScore);
                    }
                }
                return bestScore;
            } else
            {
                int bestScore = 10; // High number due to algorithm trying to find the lowest possible number
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == "")
                    {
                        // if starterBool == 0 computer is X and therefore it is maximising
                        board[i] = latestXorO == "X" ? "O" : "X";
                        int score = minimax(board, board[i], depth + 1, true);
                        board[i] = "";

                        bestScore = Math.Min(score, bestScore);
                    }
                }
                return bestScore;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            GameReset();
        }

    }
}
