﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace MotoGP.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult OrderTicket()
        {
            ViewData["BannerNr"] = 3;
            return View();
        }

        public IActionResult ConfirmOrder()
        {
            ViewData["BannerNr"] = 3;
            return View();
        }
    }
}
