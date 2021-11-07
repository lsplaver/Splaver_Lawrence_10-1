using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;
using Microsoft.AspNetCore.Http;

namespace TicTacToe.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            GameSession session = new GameSession(HttpContext.Session);
            Game game = session.GetGame();

            if (game.IsGameOver)
            {
                if (game.GameResult == "X" || game.GameResult == "O")
                {
                    TempData["message"] = $"{game.GameResult} wins";
                }
                else
                {
                    TempData["message"] = "It's a tie!";
                }
            }
            return View(game);
        }

        //[HttpPost]
        public RedirectToActionResult NewGame()
        {
            GameSession session = new GameSession(HttpContext.Session);
            Game game = session.GetGame();

            game.NewGame();

            session.SetGame(game);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult SetValue([FromRoute]string id)
        {
            GameSession session = new GameSession(HttpContext.Session);
            Game game = session.GetGame();

            game.SetValue(id);

            game.GameOver(game);

            session.SetGame(game);

            return RedirectToAction("Index");
        }
    }
}
