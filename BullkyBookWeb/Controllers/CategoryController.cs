using BullkyBookWeb.Data;
using BullkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BullkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoriesList = _db.Categories;
            return View(objCategoriesList);
        }

        
    }
}
