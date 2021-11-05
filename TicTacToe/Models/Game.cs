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
        public Dictionary<int, string> CurrentSquareValues { get; set; }
        public string CurrentPlayer { get; set; }
        public bool IsGameOver { get; set; }

        public Game()
        {
            NewGame();
        }

        public void NewGame()
        {
            for (int x = 1; x < 10; x++)
            {
                CurrentSquareValues.Clear();
                CurrentSquareValues.Add(x, "");
            }
            
            CurrentPlayer = "X";
            IsGameOver = false;
            Player1 = "X";
            Player2 = "O";
        }
    }
}
