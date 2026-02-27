using BethanysPieShop_DOTNET10.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop_DOTNET10.Controllers
{
    public class PieController : Controller
    {
        public IActionResult List()
        {
            ViewBag.CurrentCategory = "All Pies";
            return View(StaticPieData.GetAll());
        }
    }
}
