using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
