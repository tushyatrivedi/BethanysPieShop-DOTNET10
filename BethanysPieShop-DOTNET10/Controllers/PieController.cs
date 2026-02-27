using BethanysPieShop_DOTNET10.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop_DOTNET10.Controllers
{
    public class PieController : Controller
    {
        public ViewResult List()
        {
            ViewBag.CurrentCategory = "All Pies";
            return View(StaticPieData.GetAll());
        }

        public ActionResult Details(int id)
        {
            var pie = StaticPieData.GetById(id);
            if (pie == null)
            {
                return NotFound();
            }
            return View(pie);
        }
    }
}
