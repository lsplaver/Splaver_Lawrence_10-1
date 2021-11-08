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
        public Dictionary<string, string> CurrentSquareValues { get; set; }
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
                CurrentSquareValues.Clear();
            }
            CurrentSquareValues = new Dictionary<string, string>();

            for (int x = 1; x < 10; x++)
            {
                CurrentSquareValues.Add(x.ToString(), "");
            }

            CurrentPlayer = "X";
            IsGameOver = false;
            Player1 = "X";
            Player2 = "O";
        }

        public void SetValue(string id)
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
            for (int x = 1, y = 1; x <= 3; x++)
            {
                if (game.CurrentSquareValues[x.ToString()].ToString() != "")
                {
                    if (game.CurrentSquareValues[x.ToString()].ToString() == game.CurrentSquareValues[y.ToString()].ToString())
                    {
                        SameValue++;
                    }
                }
            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues["1"].ToString();
                game.IsGameOver = true;
            }
            SameValue = 0;
            for (int x = 4, y = 4; x <= 6; x++)
            {
                if (game.CurrentSquareValues[x.ToString()].ToString() != "")
                {
                    if (game.CurrentSquareValues[x.ToString()].ToString() == game.CurrentSquareValues[y.ToString()].ToString())
                    {
                        SameValue++;
                    }
                }
            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues["4"].ToString();
                game.IsGameOver = true;
            }
            SameValue = 0;
            for (int x = 7, y = 7; x <= 9; x++)
            {
                if (game.CurrentSquareValues[x.ToString()].ToString() != "")
                {
                    if (game.CurrentSquareValues[x.ToString()].ToString() == game.CurrentSquareValues[y.ToString()].ToString())
                    {
                        SameValue++;
                    }
                }
            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues["7"].ToString();
                game.IsGameOver = true;
            }
            SameValue = 0;
            for (int x = 1, y = 1; x <= 7; x += 3)
            {
                if (game.CurrentSquareValues[x.ToString()].ToString() != "")
                {
                    if (game.CurrentSquareValues[x.ToString()].ToString() == game.CurrentSquareValues[y.ToString()].ToString())
                    {
                        SameValue++;
                    }
                }

            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues["1"].ToString();
                game.IsGameOver = true;
            }
            SameValue = 0;
            for (int x = 2, y = 2; x <= 8; x += 3)
            {
                if (game.CurrentSquareValues[x.ToString()].ToString() != "")
                {
                    if (game.CurrentSquareValues[x.ToString()].ToString() == game.CurrentSquareValues[y.ToString()].ToString())
                    {
                        SameValue++;
                    }
                }

            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues["2"].ToString();
                game.IsGameOver = true;
            }
            SameValue = 0;
            for (int x = 3, y = 3; x <= 9; x += 3)
            {
                if (game.CurrentSquareValues[x.ToString()].ToString() != "")
                {
                    if (game.CurrentSquareValues[x.ToString()].ToString() == game.CurrentSquareValues[y.ToString()].ToString())
                    {
                        SameValue++;
                    }
                }

            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues["3"].ToString();
                game.IsGameOver = true;
            }
            SameValue = 0;
            for (int x = 1, y = 1; x <= 9; x += 4)
            {
                if (game.CurrentSquareValues[x.ToString()].ToString() != "")
                {
                    if (game.CurrentSquareValues[x.ToString()].ToString() == game.CurrentSquareValues[y.ToString()].ToString())
                    {
                        SameValue++;
                    }
                }
            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues["1"].ToString();
                game.IsGameOver = true;
            }
            SameValue = 0;
            for (int x = 7, y = 7; x >= 3; x -= 2)
            {
                if (game.CurrentSquareValues[x.ToString()].ToString() != "")
                {
                    if (game.CurrentSquareValues[x.ToString()].ToString() == game.CurrentSquareValues[y.ToString()].ToString())
                    {
                        SameValue++;
                    }
                }
            }
            if (SameValue == 3)
            {
                game.GameResult = game.CurrentSquareValues["7"].ToString();
                game.IsGameOver = true;
            }

            int XAndOCount = 0;
            for (int x = 1; x <= 9; x++)
            {
                if (game.CurrentSquareValues[x.ToString()].ToString() != "")
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
