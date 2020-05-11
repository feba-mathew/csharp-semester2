using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Homework5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private enum BoardPieceType 
        {
            EMPTY = 0,
            KNOT,
            CROSS
        };

        private string[,] winningCombinations = {   { "0,0", "0,1", "0,2" },
                                                    { "1,0", "1,1", "1,2" },
                                                    { "2,0", "2,1", "2,2" },
                                                    { "0,0", "1,0", "2,0" },
                                                    { "0,1", "1,1", "2,1" },
                                                    { "0,2", "1,2", "2,2" },
                                                    { "0,0", "1,1", "2,2" },
                                                    { "0,2", "1,1", "2,0" } };

        private Dictionary<string, Button> ButtonValueDictionary = new Dictionary<string, Button>();
        private BoardPieceType lastPlayedPiece = BoardPieceType.EMPTY;
        private bool gameOver = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button != null && button.Content == null && !gameOver)
            {
                string tag = button.Tag.ToString();

                if (lastPlayedPiece == BoardPieceType.EMPTY || lastPlayedPiece == BoardPieceType.KNOT)
                {
                    button.Content = "X";
                    lastPlayedPiece = BoardPieceType.CROSS;
                }
                else
                {
                    button.Content = "O";
                    lastPlayedPiece = BoardPieceType.KNOT;
                }

                ButtonValueDictionary[tag] = button;

                checkForGameWinner();
            }

            if(gameOver)
            {
                startNewGame();
            }
        }

        private void checkForGameWinner()
        {
            for (int x = 0; x <= winningCombinations.GetUpperBound(0); x++)
            {
                bool isWinner = false;
                string boardPiece = "";
                
                for (int y = 0; y <= winningCombinations.GetUpperBound(1); y++)
                {
                    if(ButtonValueDictionary.ContainsKey(winningCombinations[x,y]))
                    {
                        string currentBoardPiece = ButtonValueDictionary[winningCombinations[x, y]].Content.ToString();
                        if(boardPiece.Length == 0 || currentBoardPiece == boardPiece)
                        {
                            if (boardPiece.Length == 0)
                                boardPiece = currentBoardPiece;

                            if (y == winningCombinations.GetUpperBound(1))
                            {
                                // All positions have the same board piece
                                isWinner = true;
                            }
                            else
                            {
                                // Continue to see if all positions have the same board piece
                                continue;
                            }
                        }
                    }

                    if(isWinner)
                    {
                        MessageBox.Show(boardPiece + " wins. Game over!");
                        gameOver = true;
                    }

                    break;
                }
            }
        }

        private void startNewGame()
        {
            foreach (var entry in ButtonValueDictionary)
            {
                entry.Value.Content = null;
            }

            ButtonValueDictionary.Clear();
            lastPlayedPiece = BoardPieceType.EMPTY;
            gameOver = false;
        }

        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            startNewGame();
        }

        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            uxWindow.Close();
        }
    }
}
