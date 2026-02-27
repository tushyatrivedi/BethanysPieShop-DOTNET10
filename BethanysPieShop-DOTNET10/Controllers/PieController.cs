using BethanysPieShop_DOTNET10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop_DOTNET10.Controllers
{
    public class PieController : Controller
    {
        public readonly AppDbContext _context;

        public PieController(AppDbContext context)
        {
            _context = context;
        }

        public ViewResult List()
        {
            var pies = _context.Pies.AsNoTracking().ToList();
            ViewBag.CurrentCategory = "All Pies";
            return View(pies);
        }

        public ActionResult Details(int id)
        {
            var pie = _context.Pies.AsNoTracking()
                .FirstOrDefault(p => p.PieId == id);
            if (pie == null)
            {
                return NotFound();
            }
            return View(pie);
        }
    }
}
