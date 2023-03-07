using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MotoGP.Data;
using MotoGP.Models;
using System;

namespace MotoGP.Controllers
{
    public class ShopController : Controller
    {
        private readonly GPContext _context;

        public ShopController(GPContext context)
        {
            _context = context;
        }

        public IActionResult OrderTicket()
        {
            ViewData["Countries"] =
                new SelectList(_context.Countries.OrderBy(c => c.Name),
                "CountryID",
                "Name");

            var races = _context.Races.OrderBy(c => c.Name);

            ViewData["Races"] = races.ToList();

            ViewData["BannerNr"] = 3;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmOrder(Ticket ticket, int TicketID)
        {
            ticket.OrderDate= DateTime.Now;
            ticket.Paid = false;

            if (ModelState.IsValid)
            {
                _context.Add(ticket);
                _context.SaveChanges();
                return RedirectToAction("ConfirmOrder", new { id = ticket.TicketID});
            }

            ViewData["BannerNr"] = 3;
            return View(ticket);
        }
    }
}
