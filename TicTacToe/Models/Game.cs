using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Game
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        // public Dictionary<string, string> CurrentSquareValues { get; set; }
        public string[] CurrentSquareValues { get; set; }
        public string CurrentPlayer { get; set; }
        public bool IsGameOver { get; set; }
        public string GameResult { get; set; }

        public Game()
        {
            NewGame();
        }

        public void NewGame()
        {
            if (CurrentSquareValues != null)
            {
                //CurrentSquareValues..Clear();
            }
            CurrentSquareValues = new string[9]; //Dictionary<string, string>();

            for (int x = 0; x <= 8; x++)
            {
                CurrentSquareValues[x] = "";//.Add(x.ToString(), "");
            }

            CurrentPlayer = "X";
            IsGameOver = false;
            Player1 = "X";
            Player2 = "O";
        }

        public void SetValue(int id)
        {
            if (CurrentPlayer == "X")
            {
                CurrentSquareValues[id] = "X";
            }
            else
            {
                CurrentSquareValues[id] = "O";
            }

            CurrentPlayer = (CurrentPlayer == Player1) ? Player2 : Player1;
        }

        public void GameOver(Game game)
        {
            int SameValue = 0;
            for (int x = 0, y = 0; x <= 2; x++) // row 0, 1, 2
            {
                if (game.CurrentSquareValues[x] != "")
                {
                    if (game.CurrentSquareValues[x] == game.CurrentSquareValues[y])
                    {
                        SameValue++;
                    }
                }
            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues[0];
                game.IsGameOver = true;
            }
            SameValue = 0;
            for (int x = 3, y = 3; x <= 5; x++) // row 3, 4, 5
            {
                if (game.CurrentSquareValues[x] != "")
                {
                    if (game.CurrentSquareValues[x] == game.CurrentSquareValues[y])
                    {
                        SameValue++;
                    }
                }
            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues[3];
                game.IsGameOver = true;
            }
            SameValue = 0;
            for (int x = 6, y = 6; x <= 8; x++) // row 6, 7, 8
            {
                if (game.CurrentSquareValues[x] != "")
                {
                    if (game.CurrentSquareValues[x] == game.CurrentSquareValues[y])
                    {
                        SameValue++;
                    }
                }
            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues[6];
                game.IsGameOver = true;
            }
            SameValue = 0;
            for (int x = 0, y = 0; x <= 6; x += 3) // column 0, 3, 6
            {
                if (game.CurrentSquareValues[x] != "")
                {
                    if (game.CurrentSquareValues[x] == game.CurrentSquareValues[y])
                    {
                        SameValue++;
                    }
                }
            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues[0];
                game.IsGameOver = true;
            }
            SameValue = 0;
            for (int x = 1, y = 1; x <= 7; x += 3) // column 1, 4, 7
            {
                if (game.CurrentSquareValues[x] != "")
                {
                    if (game.CurrentSquareValues[x] == game.CurrentSquareValues[y])
                    {
                        SameValue++;
                    }
                }
            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues[1];
                game.IsGameOver = true;
            }
            SameValue = 0;
            for (int x = 2, y = 2; x <= 8; x += 3) // column 2, 5, 8
            {
                if (game.CurrentSquareValues[x] != "")
                {
                    if (game.CurrentSquareValues[x] == game.CurrentSquareValues[y])
                    {
                        SameValue++;
                    }
                }
            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues[2].ToString();
                game.IsGameOver = true;
            }
            SameValue = 0;
            for (int x = 0, y = 0; x <= 8; x += 4) // diagonal 0, 4, 8
            {
                if (game.CurrentSquareValues[x] != "")
                {
                    if (game.CurrentSquareValues[x] == game.CurrentSquareValues[y])
                    {
                        SameValue++;
                    }
                }
            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues[0];
                game.IsGameOver = true;
            }
            SameValue = 0;
            for (int x = 6, y = 6; x >= 2; x -= 2) // diagonal 6, 4, 2
            {
                if (game.CurrentSquareValues[x] != "")
                {
                    if (game.CurrentSquareValues[x] == game.CurrentSquareValues[y])
                    {
                        SameValue++;
                    }
                }
            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues[6];
                game.IsGameOver = true;
            }
            int XAndOCount = 0;
            for (int x = 0; x <= 8; x++) // tie
            {
                if (game.CurrentSquareValues[x] != "")
                {
                    XAndOCount++;
                }
            }
            if (IsGameOver == false && XAndOCount == 9)
            {
                game.GameResult = "It's a tie!";
                game.IsGameOver = true;
            }
        }
    }
}
