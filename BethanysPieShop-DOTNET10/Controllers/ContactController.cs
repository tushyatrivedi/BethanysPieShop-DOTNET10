using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop_DOTNET10.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
