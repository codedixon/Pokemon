using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Poke.Controllers
{
    public class PokeController : Controller
    {
        // GET: PokeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PokeController/Details/5
        public ActionResult Details(int id)
        {
            Models.Pokemon pokemon = Models.Pokemon.GetPokemon(id);
            ViewData["details"] = pokemon;
            return View();
        }

        // GET: PokeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PokeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PokeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PokeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PokeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PokeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
