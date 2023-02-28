using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotoGP.Data;
using MotoGP.Models;
using System.ComponentModel.DataAnnotations;

namespace MotoGP.Controllers
{
    public class InfoController : Controller
    {
        private readonly GPContext _context;
        public InfoController(GPContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListRaces()
        {
            ViewData["BannerNr"] = 0;

            var races = _context.Races.OrderBy(m => m.Date);

            return View(races.ToList());
        }

        public IActionResult BuildMap()
        {
            List<Race> races = new List<Race>();

            races.Add(new Race() { RaceID = 1, X = 517, Y = 19, Name = "Assen" });
            races.Add(new Race() { RaceID = 2, X = 859, Y = 249, Name = "Losail Circuit" });
            races.Add(new Race() { RaceID = 3, X = 194, Y = 428, Name = "Autódromo Termas de Río Hondo" });

            ViewData["BannerNr"] = 0;

            return View(races);
        }

        public IActionResult ShowRace(int id)
        {
            ViewData["BannerNr"] = 0;

            var race = _context.Races
                .SingleOrDefault(m => m.RaceID== id);

            return View(race);
        }

        public IActionResult ListRiders()
        {
            ViewData["BannerNr"] = 1;

            var rider = _context.Riders
                .Include(m => m.Country);

            return View(rider);
        }
    }
}
