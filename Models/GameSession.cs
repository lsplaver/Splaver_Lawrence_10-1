using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TicTacToe.Models
{
    public class GameSession
    {
        private ISession session;

        private const string GameKey = "ticTacToeGame";

        public GameSession(ISession session) => this.session = session;

        public void SetGame(Game game) => session.SetObject(GameKey, game);

        public Game GetGame() => session.GetObject<Game>(GameKey) ?? new Game();
    }
}
