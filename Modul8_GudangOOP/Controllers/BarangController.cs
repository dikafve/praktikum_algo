using Microsoft.AspNetCore.Mvc;

namespace GudangWebApp.Controllers
{
    public class BarangController : Controller
    {
        // Bab 8: Index statis (belum konek database)
        public IActionResult Index()
        {
            return View();
        }
    }
}
