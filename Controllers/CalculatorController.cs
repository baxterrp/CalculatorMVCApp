using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCALC.Models;

using Microsoft.AspNetCore.Mvc;

namespace ASPCALC.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View(new Calc());
        }
        [HttpPost]
        public ActionResult Index(Calc c, string calculate)
        {
            if (calculate == "add")
            {
                c.tot = c.no1 + c.no2;
            }
            else if (calculate == "min")
            {
                c.tot = c.no1 - c.no2;
            }
            else if (calculate == "sub")
            {
                c.tot = c.no1 * c.no2;
            }
            else
            {
                c.tot = c.no1 - c.no2;
            }
            return View(c);
        }
    }
}
