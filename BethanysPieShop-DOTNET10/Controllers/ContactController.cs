using BethanysPieShop_DOTNET10.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop_DOTNET10.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact item)
        {
            if (!ModelState.IsValid)
            {
                return View(item);
            }
            StaticContactData.AddContact(item);
            TempData["Message"] = "Message Recieved, we'll get back to you shortly!!";
            return RedirectToAction(nameof(Thanks));
        }

        [HttpGet]
        public IActionResult Thanks()
        {
            return View();
        }
    }
}
