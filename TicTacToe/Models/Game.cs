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
    }
}
