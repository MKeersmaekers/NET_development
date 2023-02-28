using Microsoft.AspNetCore.Mvc;
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
            ViewData["BannerNr"] = 3;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmOrder(Ticket ticket)
        {
            ticket.OrderDate= DateTime.Now;
            ticket.Paid = false;
            if (ModelState.IsValid)
            {
                _context.Add(ticket);
                _context.SaveChanges();
                return RedirectToAction("ConfirmOrder");
            }

            ViewData["BannerNr"] = 3;
            return View(ticket);
        }
    }
}
