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
                c.total = c.number1 + c.number2;
            }
            else if (calculate == "min")
            {
                c.total = c.number1 - c.number2;
            }
            else if (calculate == "sub")
            {
                c.total = c.number1 * c.number2;
            }
            else
            {
                c.total = c.number1 - c.number2;
            }
            return View(c);
        }
    }
}
