using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidateNationalCode.Models;

namespace ValidateNationalCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string NationalCode)
        {
            var result = new RouteSegments()
            {
                Controller = nameof(HomeController),
                Action = nameof(Index)
            };
            result.Parameters["NationalCode"] = NationalCode;
            return View(result);
        }
    }
}