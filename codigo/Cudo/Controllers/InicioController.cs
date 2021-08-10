using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cudo.Models;

namespace Cudo.Controllers
{
    public class InicioController : Controller
    {
        
        public IActionResult Login()
        {

            return View();
        }
        public IActionResult main()
        {
            return View();
        }
         public IActionResult registrar()
        {
            return View();
        }


        
    }
}