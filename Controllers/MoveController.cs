using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Poke.Controllers
{
    public class MoveController : Controller
    {
        public IActionResult Details(int id)
        {
            Models.Moves move = Models.Moves.GetMoves(id);
            ViewData["move"] = move;
            return View();
        }
    }
}
