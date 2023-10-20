using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Game : Form
    {
        private bool PlayerTurn { get; set; } // if true, its the player's turn, else it is the computer's turn
        private int Turn_count { get; set; }
        private Button[] Buttons { get; set; }
        private string[] Board { get; set; } // an array of all the different values in each button where each can either be "X", "O", or ""
        private int WinStreak { get; set; }
        private int Wins { get; set; }
        private int Losses { get; set; }
        private int Draws { get; set; }
        private readonly Random random = new();
        private int StarterBool { get; set; }

        public Game()
        {
            InitializeComponent();
            Buttons = new Button[] { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            Board = new string[] { "", "", "", "", "", "", "", "", "" };
        }

        private void Game_Load(object sender, EventArgs e)
        {
            GameReset();
        }

        private void SetAllButtonsDisabled()
        {
            foreach (Button button in Buttons) button.Enabled = false;
        }

        private void GameReset()
        {
            foreach (Button button in Buttons) button.Text = "";
            for (int i = 0; i < Board.Length; i++) Board[i] = "";
            SetAllButtonsDisabled();

            Turn_count = 0;

            StarterBool = random.Next(0, 2);

            btnPlayAgain.Enabled = false;
            btnPlayAgain.BackColor = Color.FromArgb(71, 99, 74);
            lblWinLose.Text = "";

            if (StarterBool == 1)
            {
                PlayerTurn = true;
                foreach (Button button in Buttons) button.Enabled = true;
            }
            else
            {
                PlayerTurn = false;
                AIClick();
            }
        }

        private void BtnGame_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SetAllButtonsDisabled();

            button.Text = StarterBool == 1 && PlayerTurn
                ? "X" : StarterBool == 0 && !PlayerTurn
                ? "X" : "O";

            for (int i = 0; i < Buttons.Length; i++)
                if (Buttons[i].Name == button.Name) Board[i] = button.Text;

            Turn_count++;
            PlayerTurn = !PlayerTurn;
            string? winner = CheckWinner(button.Text);

            if (winner != null) EndGame(winner);
            else
            {
                if (!PlayerTurn) AIClick();
                else foreach (Button buttonGame in Buttons) if (buttonGame.Text == "") buttonGame.Enabled = true;
            }
        }

        private string? CheckWinner(string XorO)
        {
            string? winner = null;
            // ---
            if ((Board[0] == Board[1] && Board[1] == Board[2] && Board[1] != "") ||
                (Board[3] == Board[4] && Board[4] == Board[5] && Board[4] != "") ||
                (Board[6] == Board[7] && Board[7] == Board[8] && Board[7] != ""))
                winner = XorO;
            // |||
            else if ((Board[0] == Board[3] && Board[3] == Board[6] && Board[3] != "") ||
                (Board[1] == Board[4] && Board[4] == Board[7] && Board[4] != "") ||
                (Board[2] == Board[5] && Board[5] == Board[8] && Board[5] != ""))
                winner = XorO;
            // X
            else if ((Board[0] == Board[4] && Board[4] == Board[8] && Board[4] != "") ||
                (Board[2] == Board[4] && Board[4] == Board[6] && Board[4] != ""))
                winner = XorO;

            if (winner == null && Turn_count == 9) return "tie";

            int temp_turn_count = 0;
            foreach (string text in Board) if (text != "") temp_turn_count++;
            if (winner == null && temp_turn_count == 9) return "tie";

            return winner;
        }

        private void EndGame(string? winner)
        {
            SetAllButtonsDisabled();

            switch (StarterBool)
            {
                case 1 when winner == "X":
                case 0 when winner == "O":
                    WinStreak++;
                    Wins++;
                    lblWins.Text = "Wins: " + Wins;
                    lblWinStreak.Text = "Win Streak: " + WinStreak;
                    lblWinLose.Text = "You Win!";
                    break;
                case 1 when winner == "O":
                case 0 when winner == "X":
                    Losses++;
                    WinStreak = 0;
                    lblLosses.Text = "Losses: " + Losses;
                    lblWinStreak.Text = "Win Streak: " + WinStreak;
                    lblWinLose.Text = "You Lose!";
                    break;
                default:
                    Draws++;
                    WinStreak = 0;
                    lblDraws.Text = "Draws: " + Draws;
                    lblWinStreak.Text = "Win Streak: " + WinStreak;
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

        int nodeIndex = 0; // The number of nodes being traversed in the algorithm
        private void AIClick()
        {
            nodeIndex = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();
            int bestScore = StarterBool == 0 ? -1000 : 1000;
            int MIN = -1000;
            int MAX = 1000;   
            Button bestNextMove = new();

            for (int i = 0; i < Board.Length; i++)
            {
                if (Board[i] == "")
                {
                    nodeIndex++;
                    Board[i] = StarterBool == 0 ? "X" : "O";
                    int score = Minimax(Board, Board[i], 0, StarterBool == 1, MIN, MAX);
                    Board[i] = "";

                    if (StarterBool == 0 && score > bestScore)
                    {
                        bestScore = score;
                        bestNextMove = Buttons[i];
                    }
                    else if (StarterBool == 1 && score < bestScore)
                    {
                        bestScore = score;
                        bestNextMove = Buttons[i];
                    }
                }
            }

            stopwatch.Stop();
            Debug.WriteLine($"Number of nodes that have been traversed: {nodeIndex}, taking {stopwatch.ElapsedMilliseconds}ms to complete");
            bestNextMove.Enabled = true;
            bestNextMove.PerformClick();
        }

        private readonly Dictionary<string, int> scores = new()
        {
            { "X", 1 },
            { "O", -1 },
            { "tie", 0 },
        };
        private int Minimax(string[] board, string latestXorO, int depth, bool isMaximising, int alpha, int beta)
        {
            string? result = CheckWinner(latestXorO);
            if (result != null)
            {
                return scores[result];
            }

            if (isMaximising)
            {
                int bestScore = -1000; // Low number due to algorithm trying to find the highest possible number
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == "")
                    {
                        nodeIndex++;
                        board[i] = latestXorO == "X" ? "O" : "X";
                        int score = Minimax(board, board[i], depth + 1, false, alpha, beta);
                        board[i] = "";

                        bestScore = Math.Max(score, bestScore);
                        alpha = Math.Max(bestScore, alpha);

                        if (beta <= alpha) break;
                    }
                }
                return bestScore;
            }
            else
            {
                int bestScore = 1000; // High number due to algorithm trying to find the lowest possible number
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == "")
                    {
                        nodeIndex++;
                        board[i] = latestXorO == "X" ? "O" : "X";
                        int score = Minimax(board, board[i], depth + 1, true, alpha, beta);
                        board[i] = "";

                        bestScore = Math.Min(score, bestScore);
                        beta = Math.Min(bestScore, beta);

                        if (beta <= alpha) break;
                    }
                }
                return bestScore;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            GameReset();
        }
    }
}
