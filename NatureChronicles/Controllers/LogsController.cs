using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NatureChronicles.Controllers
{
    public class LogsController : Controller
    {
        public IActionResult LogHome()
        {
            return View();
        }
    }
}
