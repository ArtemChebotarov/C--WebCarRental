using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium2_test.DAL;
using Kolokwium2_test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2_test.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IDBLayer _context;
        public PlayersController(IDBLayer context)
        {
            _context = context;
        }


        public IActionResult Index()
        {

            ViewBag.Players = _context.GetPlayers();
            ViewBag.Teams = _context.GetTeams();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Player newPlayer)
        {
            
           
            if (!ModelState.IsValid)
            {
                ViewBag.Players = _context.GetPlayers();

                return View("Index", newPlayer);
            }

            _context.AddNewPlayer(newPlayer);
            return RedirectToAction("Index");
        }
    }
} 