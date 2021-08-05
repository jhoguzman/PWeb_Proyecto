using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class LoginController : Controller
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