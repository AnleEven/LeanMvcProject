using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LeanMvcProject.Controllers
{
    public class SystemController : Controller
    {
        public new IActionResult User()
        {
            return View();
        }

        public IActionResult Role()
        {
            return View();
        }

        public IActionResult Deptment()
        {
            return View();
        }

        public IActionResult Power()
        {
            return View();
        }

        public IActionResult logging()
        {
            return View();
        }
    }
}