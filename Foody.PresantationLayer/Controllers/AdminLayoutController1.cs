﻿using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.Controllers
{
    public class AdminLayoutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}