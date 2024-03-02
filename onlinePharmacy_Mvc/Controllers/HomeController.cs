using Microsoft.AspNetCore.Mvc;
using onlinePharmacy_Mvc.Data;
using onlinePharmacy_Mvc.Models;
using System.Diagnostics;

namespace onlinePharmacy_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            List<Product> allProducts = _db.products.ToList();
            if (allProducts == null)
            {
                return NotFound();
            }

            return View(allProducts);
        }

    }
}
