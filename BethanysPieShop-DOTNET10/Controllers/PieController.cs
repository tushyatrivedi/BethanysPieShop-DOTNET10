using BethanysPieShop_DOTNET10.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop_DOTNET10.Controllers
{
    public class PieController : Controller
    {
        public IActionResult List()
        {
            return View(StaticPieData.GetAll());
        }
    }
}
