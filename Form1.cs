//////////////////////////////////////////
/// Name              Date        Description
/// Mahamed Ali       2/16/25     Setup initial framework for Tic-Tac-Toe game, set up basic UI.
/// anawar kimo       2/16/25     Added button functionality for Tic-Tac-Toe grid.
/// Mahamed Ali       2/17/25     Implemented user input handling and basic game state management.
/// anawar kimo       2/17/25     Making the event handling for button click to checked for winner conditions.
/// Mahamed Ali       2/20/25     Added functionality for computer moves with random selections and who goes first.
/// anawar kimo       2/20/25     Increased table size to include additional buttons and text boxes (Turn, Winner, New Game, Stop Game).
/// Mahamed Ali       2/21/25     Created a score tracking system to monitor user and computer scores.
/// anawar kimo       2/21/25     Updated the game UI to show dynamic scores.
/// Mahamed Ali       2/22/25     Full Tic-Tac-Toe logic game, user & computer moves, score tracking, and game reset.
/// anawar kimo       2/22/25     Changed rest game method and Fixed the Tictactoe game
//////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        // Who starts first
        private bool isComputerTurn, isPlayerTurn;

        // make X/O sign
        private char playerMark, computerMark;

        // All 9 buttons for the game grid.
        private List<Button> gameButtons;

        // Computer selction random
        private Random randomizer = new Random();

        // Score counters for game
        private int computerScore = 0;
        private int playerScore = 0;

        // Lets you know hether the game is paused/stopped.
        private bool isGamePaused = false;

        public Form1()
        {
            InitializeComponent();

            // Build the list of game buttons right after InitializeComponent().
            gameButtons = new List<Button>
            {
                r1c1, r1c2, r1c3,
                r2c1, r2c2, r2c3,
                r3c1, r3c2, r3c3
            };

            // Attach click handlers to each board button.
            AttachButtonClickHandlers();

            // Initialize the score display.
            UpdateScoreDisplay();

            // Decide who goes first, etc.
            StartNewTurn();
        }

        // Attach a common click event handler to each game button.
        private void AttachButtonClickHandlers()
        {
            foreach (Button btn in gameButtons)
            {
                btn.Click += OnBoardButtonClick;
            }
        }

        // Called when a user clicks one of the 9 board buttons.
        private void OnBoardButtonClick(object sender, EventArgs e)
        {
            if (isGamePaused) return;

            Button clickedButton = sender as Button;
            if (clickedButton != null && string.IsNullOrEmpty(clickedButton.Text))
            {
                if (isPlayerTurn && GetAvailableButtons().Count > 0)
                {
                    // Place the player's mark (X or O)
                    clickedButton.Text = playerMark.ToString();

                    // Check if that move wins the game
                    if (DetermineWinner())
                    {
                        winDisplay.Text = "Winner:\r\nPlayer Wins!";
                        playerScore++;
                        UpdateScoreDisplay();
                        EndGame();
                        return;
                    }
                    // If board is full but no winner => Draw
                    else if (GetAvailableButtons().Count == 0)
                    {
                        winDisplay.Text = "It's a Draw!";
                        EndGame();
                        return;
                    }

                    // Switch to the computer's turn
                    ToggleTurn();
                }
            }
        }

        // Switch turns between player and computer.
        private void ToggleTurn()
        {
            isComputerTurn = !isComputerTurn;
            isPlayerTurn = !isPlayerTurn;

            if (isComputerTurn)
            {
                ProcessComputerMove();
            }
        }

        // Let the computer choose a random empty button and place its mark.
        private void ProcessComputerMove()
        {
            List<Button> freeButtons = GetAvailableButtons();
            if (freeButtons.Count > 0)
            {
                // Pick a random button from available ones
                Button chosenButton = freeButtons[randomizer.Next(freeButtons.Count)];
                chosenButton.Text = computerMark.ToString();

                // Check for a computer win
                if (DetermineWinner())
                {
                    winDisplay.Text = "Winner:\r\nComputer Wins!";
                    computerScore++;
                    UpdateScoreDisplay();
                    EndGame();
                    return;
                }
                // If board is full => Draw
                else if (GetAvailableButtons().Count == 0)
                {
                    winDisplay.Text = "It's a Draw!";
                    EndGame();
                    return;
                }
            }
            
            ToggleTurn();
        }

        // Shown when "Stop Game" is clicked (toggles pause).
        private void PauseGame_Click(object sender, EventArgs e)
        {
            isGamePaused = !isGamePaused;
            pauseGameBtn.Text = isGamePaused ? "Resume Game" : "Stop Game";
        }

        // Shown when "New Game" is clicked.
        private void NewGame_Click(object sender, EventArgs e)
        {
            ResetBoard();
            winDisplay.Text = "Winner:";
        }

        // Disable moves when game end
        private void EndGame()
        {
            isComputerTurn = false;
            isPlayerTurn = false;
        }

        // Return a list of all buttons still empty (no mark).
        private List<Button> GetAvailableButtons()
        {
            List<Button> freeButtons = new List<Button>();
            foreach (Button btn in gameButtons)
            {
                if (string.IsNullOrEmpty(btn.Text))
                {
                    freeButtons.Add(btn);
                }
            }
            return freeButtons;
        }

        // Clear for new round
        private void ResetBoard()
        {
            // If the board isn't brand new and there's no winner, computer gets a point
            // (This is optional logic you had in your code).
            if (GetAvailableButtons().Count < 8 && GetAvailableButtons().Count > 0 && !DetermineWinner())
            {
                computerScore++;
            }

            // Clear each button's text
            foreach (Button btn in gameButtons)
            {
                btn.Text = "";
            }
            UpdateScoreDisplay();
            StartNewTurn();
        }

        // Randomize who goes fisrt X/O.
        private void StartNewTurn()
        {
            bool playerStarts = randomizer.Next(2) == 0;

            if (playerStarts)
            {
                turnIndicator.Text = "Turn: Player (X)";
                isPlayerTurn = true;
                isComputerTurn = false;
                playerMark = 'X';
                computerMark = 'O';
            }
            else
            {
                turnIndicator.Text = "Turn: Computer (X)";
                isComputerTurn = true;
                isPlayerTurn = false;
                playerMark = 'O';
                computerMark = 'X';
                
                ProcessComputerMove();
            }
        }

        // Check for winner (rows, columns, diagonals).
        private bool DetermineWinner()
        {
            Button[,] grid = new Button[,]
            {
                { r1c1, r1c2, r1c3 },
                { r2c1, r2c2, r2c3 },
                { r3c1, r3c2, r3c3 }
            };

            for (int i = 0; i < 3; i++)
            {
                if (!string.IsNullOrEmpty(grid[i, 0].Text) &&
                    grid[i, 0].Text == grid[i, 1].Text &&
                    grid[i, 1].Text == grid[i, 2].Text)
                {
                    return true;
                }
            }

            for (int j = 0; j < 3; j++)
            {
                if (!string.IsNullOrEmpty(grid[0, j].Text) &&
                    grid[0, j].Text == grid[1, j].Text &&
                    grid[1, j].Text == grid[2, j].Text)
                {
                    return true;
                }
            }

            if (!string.IsNullOrEmpty(grid[0, 0].Text) &&
                grid[0, 0].Text == grid[1, 1].Text &&
                grid[1, 1].Text == grid[2, 2].Text)
            {
                return true;
            }

            
            if (!string.IsNullOrEmpty(grid[0, 2].Text) &&
                grid[0, 2].Text == grid[1, 1].Text &&
                grid[1, 1].Text == grid[2, 0].Text)
            {
                return true;
            }

            return false;
        }

        // Update the Player/Computer score labels.
        private void UpdateScoreDisplay()
        {
            scorePlayer.Text = $"Player Score: {playerScore}";
            scoreComputer.Text = $"Computer Score: {computerScore}";
        }

        // Leave this empty, if TextChanged event on winDisplay
        private void WinDisplay_TextChanged(object sender, EventArgs e)
        {
            // No action
        }
    }
}
