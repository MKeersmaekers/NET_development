using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MotoGP.Data;
using MotoGP.Models;
using MotoGP.Models.ViewModels;
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
            var races = _context.Races;

            ViewData["BannerNr"] = 0;

            return View(races.ToList());
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
                .Include(m => m.Country)
                .OrderBy(m => m.RiderID);

            return View(rider);
        }
        public IActionResult SelectRace(int raceID = 0) 
        {
            var listRacesVM = new SelectRaceViewModel();

            if (raceID != 0)
            {
                listRacesVM.showraces = _context.Races.Where(m => m.RaceID == raceID).OrderBy(m => m.RaceID).ToList();
            } else
            {
                listRacesVM.showraces = _context.Races.OrderBy(m => m.RaceID).ToList();
            }

            listRacesVM.Races = 
                new SelectList(_context.Races.OrderBy(n => n.Name), "RaceID", "Name");

            listRacesVM.raceID = raceID;

            ViewData["BannerNr"] = 1;

            return View(listRacesVM); 
        }
    }
}
