using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string str0utput = "Xin Chao" + ps.PersonId + "-" + ps.Fullname + "-" + ps.Address;
            ViewBag.infoPerson = str0utput;
            return View();
    }

    }
 
}