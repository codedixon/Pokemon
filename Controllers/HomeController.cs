using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Poke.Models;

namespace Poke.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Pokemon> pokeList = new List<Pokemon>();
            for (int i = 1; i < 152; i++)
            {
                pokeList.Add(Pokemon.GetPokemon(i));
            }
            ViewData["pokemon"] = pokeList;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PokeView()
        {
            Pokemon pokemon = Pokemon.GetPokemon(1);

            ViewData["pokemon"] = pokemon;
       
            return View();
        }


    }
}
